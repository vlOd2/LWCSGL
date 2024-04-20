using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static LWCSGL.OpenGL.WGL;

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// A control that draws an OpenGL viewport
    /// </summary>
    public partial class GLViewport : Control
    {
        /// <summary>
        /// Whether to log to the console debug messages
        /// </summary>
        public static bool DebugMode;
        private nint deviceContext;
        private nint renderContext;

        internal GLViewport()
        {
            InitWGL();
        }

        internal void SwapBuffers() => WGL.SwapBuffers(deviceContext);

        private static void HandleStartupError(string msg)
        {
            if (DebugMode)
                Console.Error.WriteLine($"!!! START-UP ERROR: {msg} ({Marshal.GetLastWin32Error()})");
            throw new OpenGLException(msg);
        }

        private void Log(string msg)
        {
            if (!DebugMode) return;
            Console.WriteLine(msg);
        }

        private void InitWGL()
        {
            Log($"Initialising WGL...");

            deviceContext = GetDC(Handle);
            if (deviceContext == nint.Zero)
            {
                HandleStartupError("Couldn't create a WIN32 context!");
                return;
            }
            Log($"Device context: {deviceContext}");

            PIXELFORMATDESCRIPTOR pixelFormatDesc = new PIXELFORMATDESCRIPTOR();
            pixelFormatDesc.nSize = (short)Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR));
            pixelFormatDesc.nVersion = 1;
            pixelFormatDesc.dwFlags = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER;
            pixelFormatDesc.iPixelType = PFD_TYPE_RGBA;
            pixelFormatDesc.cColorBits = 32;
            pixelFormatDesc.cAlphaBits = 8;
            pixelFormatDesc.cDepthBits = 24;

            int pixelFormat = ChoosePixelFormat(deviceContext, ref pixelFormatDesc);
            if (pixelFormat == 0)
            {
                HandleStartupError("Pixel format not accelerated!");
                return;
            }

            if (!SetPixelFormat(deviceContext, pixelFormat, ref pixelFormatDesc))
            {
                HandleStartupError("Couldn't set the pixel format!");
                return;
            }

            renderContext = wglCreateContext(deviceContext);
            if (renderContext == nint.Zero)
            {
                HandleStartupError("Couldn't create a render context!");
                return;
            }
            Log($"Render context: {renderContext}");

            wglMakeCurrent(deviceContext, renderContext);
            Log("Initialised WGL");
            Log($"OpenGL: {GLU.GetGLString(GL11C.GL_VERSION)}");
        }

        private void DestroyWGL()
        {
            Log($"Destroying WGL...");
            wglMakeCurrent(deviceContext, nint.Zero);
            wglDeleteContext(renderContext);
            ReleaseDC(Handle, deviceContext);
            deviceContext = nint.Zero;
            renderContext = nint.Zero;
            Log($"Destroyed WGL");
        }

        /// <summary>
        /// Raises the System.Windows.Forms.Control.HandleDestroyed event.
        /// </summary>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            DestroyWGL();
            base.OnHandleDestroyed(e);
        }

        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">The Windows System.Windows.Forms.Message to process.</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PAINT)
            {
                PAINTSTRUCT paintStruct = new PAINTSTRUCT();
                BeginPaint(Handle, ref paintStruct);
                EndPaint(Handle, ref paintStruct);
                return;
            }
            base.WndProc(ref m);
        }
    }
}
