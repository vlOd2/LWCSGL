using LWCSGL.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static LWCSGL.OpenGL.WGL;

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// Interface for creating a window and a GL viewport
    /// </summary>
    public class Display
    {
        private const int DEFAULT_WIDTH = 640;
        private const int DEFAULT_HEIGHT = 480;
        internal static Display instance = new Display();
        internal Form form;
        internal GLViewport viewport;
        private int prevWidth;
        private int prevHeight;
        private DisplayMode displayMode = new DisplayMode(DEFAULT_WIDTH, DEFAULT_HEIGHT);
        private string initTitle = "Game";
        private Icon initIcon;
        private bool closeRequested;
        private bool wasResized;
        private bool doNotCancelCloseEvent;
        private static readonly HashSet<string> supportedExt = new HashSet<string>();

        internal static void CheckForDisplay()
        {
            if (IsCreated()) return;
            throw new InvalidOperationException("Display not created!");
        }

        private static Form GetFormSafely()
        {
            CheckForDisplay();
            return instance.form;
        }

        private static void AssertNullArg(object arg)
        {
            if (arg != null) return;
            throw new ArgumentNullException();
        }

        private void ChangeDisplayMode__GoFullscreen(DisplayMode displayMode)
        {
            DEVMODE devMode = new DEVMODE();
            DisplayModeUtils.MG2UMG(displayMode, ref devMode);
            if (ChangeDisplaySettingsA(ref devMode, CDS_FULLSCREEN) != 0)
                throw new OpenGLException("Couldn't apply the display mode!");
            form.FormBorderStyle = FormBorderStyle.None;
            form.ClientSize = new Size(displayMode.width, displayMode.height);
            form.Location = new Point(0, 0);
            form.BringToFront();
            form.Activate();
            this.displayMode = displayMode;
        }

        private void ChangeDisplayMode__LeaveFullscreen()
        {
            ChangeDisplaySettingsA(IntPtr.Zero, CDS_RESET);
            // Janky way to restore resizability
            form.FormBorderStyle = form.MaximizeBox ?
                FormBorderStyle.Sizable : FormBorderStyle.FixedDialog;
        }

        private void ChangeDisplayMode(DisplayMode displayMode)
        {
            if (displayMode.fullscreen)
                ChangeDisplayMode__GoFullscreen(displayMode);
            else
            {
                if (this.displayMode.fullscreen)
                    ChangeDisplayMode__LeaveFullscreen();
                int dw = displayMode.GetWidth();
                int dh = displayMode.GetHeight();
                int w = dw > 0 ? dw : viewport.Width;
                int h = dh > 0 ? dh : viewport.Height;
                form.ClientSize = new Size(w, h);
                this.displayMode = new DisplayMode(w, h);
                CenterWindow();
            }
        }

        /// <summary>
        /// Initialises a window and a GL viewport
        /// </summary>
        public static void Create() => instance._Create();
        /// <summary>
        /// Gets the X of the window relative to the top corner
        /// </summary>
        /// <returns>the x</returns>
        public static int GetX() => GetFormSafely().Location.X;
        /// <summary>
        /// Gets the Y of the window relative to the top corner
        /// </summary>
        /// <returns>the y</returns>
        public static int GetY() => GetFormSafely().Location.Y;
        /// <summary>
        /// Gets the width of the viewport
        /// </summary>
        /// <returns>the width</returns>
        public static int GetWidth() => instance.displayMode.width;
        /// <summary>
        /// Gets the height of the viewport
        /// </summary>
        /// <returns>the height</returns>
        public static int GetHeight() => instance.displayMode.height;
        /// <summary>
        /// Indicates if the viewport was requested to be closed
        /// </summary>
        /// <returns>true if closing is requested, false if not</returns>
        public static bool IsCloseRequested() => instance.closeRequested;
        /// <summary>
        /// Indicates if the window is active
        /// </summary>
        /// <returns>true if the window is active, false if not</returns>
        public static bool IsActive() => GetFormSafely().ContainsFocus;
        /// <summary>
        /// Indicates if the window is visible
        /// </summary>
        /// <returns>true if the window is visible, false if not</returns>
        public static bool IsVisible() => GetFormSafely().Visible;
        /// <summary>
        /// Gets the current display mode
        /// </summary>
        /// <returns>the current display mode</returns>
        public static DisplayMode GetDisplayMode() => instance.displayMode;
        /// <summary>
        /// Gets the current desktop display mode
        /// </summary>
        /// <returns>the current desktop display mode</returns>
        public static DisplayMode GetDesktopDisplayMode() => DisplayModeUtils.GetCurrent();
        /// <summary>
        /// Gets all available desktop display modes
        /// </summary>
        /// <returns>the desktop display modes</returns>
        public static DisplayMode[] GetAvailableDisplayModes() => DisplayModeUtils.GetAll();
        /// <summary>
        /// Indicates if the window is resizable
        /// </summary>
        /// <returns>true if the window is resizable, false if not</returns>
        public static bool IsResizable() => GetFormSafely().FormBorderStyle == FormBorderStyle.Sizable;
        /// <summary>
        /// Indicates if the window was resized since last calling Update()
        /// </summary>
        /// <returns>true if the window was resized, false if not or in fullscreen</returns>
        public static bool WasResized() => instance.wasResized;
        /// <summary>
        /// Indicates if a Display was created
        /// </summary>
        /// <returns>true if a Display was created, false if not</returns>
        public static bool IsCreated() => instance.form != null;
        /// <summary>
        /// Indicates if the Display is fullscreen
        /// </summary>
        /// <returns>true if the Display is fullscreen, false if not</returns>
        public static bool IsFullscreen() => instance.displayMode.fullscreen;
        /// <summary>
        /// Gets the title of the window
        /// </summary>
        /// <returns>the title of the window</returns>
        public static string GetTitle() => GetFormSafely().Text;
        /// <summary>
        /// Stub method, doesn't do anything
        /// </summary>
        public static void SwapBuffers() { }

        /// <summary>
        /// Sets the size of the viewport<para></para>
        /// This method strips the fullscreen property of the mode
        /// </summary>
        /// <param name="displayMode">the size</param>
        public static void SetDisplayMode(DisplayMode displayMode)
        {
            AssertNullArg(displayMode);
            displayMode.fullscreen = false;
            if (!IsCreated())
            {
                instance.displayMode = displayMode;
                return;
            }
            instance.ChangeDisplayMode(displayMode);
        }

        /// <summary>
        /// Sets the size of the viewport<para></para>
        /// This method respects the display mode's fullscreen capability
        /// </summary>
        /// <param name="displayMode">the size</param>
        public static void SetDisplayModeAndFullscreen(DisplayMode displayMode)
        {
            AssertNullArg(displayMode);
            if (!IsCreated())
            {
                instance.displayMode = displayMode;
                return;
            }
            instance.ChangeDisplayMode(displayMode);
        }

        /// <summary>
        /// Sets the title of the window
        /// </summary>
        /// <param name="title">the title</param>
        public static void SetTitle(string title)
        {
            AssertNullArg(title);
            if (!IsCreated())
                instance.initTitle = title;
            else
                GetFormSafely().Text = title;
        }

        /// <summary>
        /// Sets the resizable status of the window<para></para>
        /// Does nothing when in fullscreen mode
        /// </summary>
        /// <remarks>Can only be called after Create()</remarks>
        /// <param name="val">the status</param>
        public static void SetResizable(bool val)
        {
            if (!IsCreated() || IsFullscreen()) return;
            GetFormSafely().FormBorderStyle = val ?
                FormBorderStyle.Sizable : FormBorderStyle.FixedDialog;
            GetFormSafely().MaximizeBox = val;
        }

        /// <summary>
        /// Sets the icon of the window
        /// </summary>
        /// <remarks>Pass null to reset to the default icon</remarks>
        /// <param name="icon">the icon</param>
        public static void SetIcon(Icon icon)
        {
            if (!IsCreated())
                instance.initIcon = icon;
            else
                GetFormSafely().Icon = icon;
        }

        private void _Create()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form();
            form.Text = initTitle;
            form.Icon = initIcon;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                if (doNotCancelCloseEvent) return;
                e.Cancel = true;
                closeRequested = true;
            };

            viewport = new GLViewport();
            viewport.Parent = form;
            viewport.Location = new Point(0, 0);
            viewport.Dock = DockStyle.Fill;
            form.Controls.Add(viewport);

            ChangeDisplayMode(displayMode);
            form.Resize += (object sender, EventArgs e) =>
            {
                displayMode.width = viewport.Width;
                displayMode.height = viewport.Height;
            };
            form.Show();

            string[] extensions = GLU.GetGLString(GL11C.GL_EXTENSIONS).Split(
                new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            supportedExt.Clear();
            foreach (string ext in extensions) supportedExt.Add(ext.Trim());
        }

        /// <summary>
        /// Checks if a GL extension is supported
        /// </summary>
        /// <param name="ext">The GL extension to check for</param>
        /// <returns>true if the extension is supported, false if otherwise</returns>
        public static bool CheckGLExtension(string ext)
        {
            return supportedExt.Contains(ext);
        }

        /// <summary>
        /// Destroys the window and the GL viewport
        /// </summary>
        public static void Destroy()
        {
            CheckForDisplay();
            instance.viewport.Dispose();
            instance.form.Close();
            instance.form.Dispose();
            instance.viewport = null;
            instance.form = null;
            instance = new Display();
        }

        /// <summary>
        /// Updates the window and the GL viewport
        /// </summary>
        public static void Update() => instance._Update(true);

        /// <summary>
        /// Updates the GL viewport, and optionally, the window
        /// </summary>
        /// <remarks>You can still manually update the window with ProcessMessages()</remarks>
        /// <param name="updateWin">Whether to only update the GL viewport</param>
        public static void Update(bool updateWin) => instance._Update(updateWin);

        /// <summary>
        /// Updates only the window
        /// </summary>
        public static void ProcessMessages() => Application.DoEvents();

        private void _Update(bool updateWin)
        {
            CheckForDisplay();
            viewport.Invalidate();
            if (updateWin) ProcessMessages();

            int nw = displayMode.width;
            int nh = displayMode.height;
            if (nw != prevWidth || nh != prevHeight)
            {
                prevWidth = nw;
                prevHeight = nh;
                wasResized = true;
            }
            else
                wasResized = false;

            // Poll the mouse, to update the cursor position
            if (Mouse.instance != null)
                Mouse.instance.Poll();
        }

        /// <summary>
        /// Sets fullscreen status<para></para>
        /// </summary>
        /// <param name="state">The fullscreen state</param>
        public static void SetFullscreen(bool state) => instance._SetFullscreen(state);

        private void _SetFullscreen(bool state)
        {
            if (state)
                SetDisplayModeAndFullscreen(GetDesktopDisplayMode());
            else
                SetDisplayModeAndFullscreen(new DisplayMode(DEFAULT_WIDTH, DEFAULT_HEIGHT));
        }

        private void CenterWindow()
        {
            Form form = GetFormSafely();
            Screen screen = Screen.FromControl(form);
            Rectangle workingArea = screen.WorkingArea;
            form.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - form.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - form.Height) / 2)
            };
        }

        /// <summary>
        /// Set the location of the window<para></para>
        /// This function doesn't do anything when in fullscreen
        /// </summary>
        /// <remarks>If nx or ny == -1 then the window will be centered</remarks>
        public static void SetLocation(int nx, int ny) => instance._SetLocation(nx, ny);

        private void _SetLocation(int nx, int ny)
        {
            if (IsFullscreen()) return;

            if (nx > -1 && ny > -1)
                GetFormSafely().Location = new Point(nx, ny);
            else
                CenterWindow();
        }

        /// <summary>
        /// Prints to the console the status
        /// </summary>
        public static void PrintStatusReport()
        {
            Console.WriteLine("------------- DISPLAY STATUS ------------");
            Console.WriteLine($"DisplayMode: {GetDisplayMode()}");
            Console.WriteLine($"Width: {GetWidth()}");
            Console.WriteLine($"Height: {GetHeight()}");
            Console.WriteLine($"X: {GetX()}");
            Console.WriteLine($"Y: {GetY()}");
            Console.WriteLine($"Title: {GetTitle()}");
            Console.WriteLine($"IsActive: {IsActive()}");
            Console.WriteLine($"IsCloseRequested: {IsCloseRequested()}");
            Console.WriteLine($"IsCreated: {IsCreated()}");
            Console.WriteLine($"IsFullscreen: {IsFullscreen()}");
            Console.WriteLine($"IsResizable: {IsResizable()}");
            Console.WriteLine($"IsVisible: {IsVisible()}");
            Console.WriteLine($"WasResized: {WasResized()}");
            Console.WriteLine("------------- DISPLAY STATUS ------------");
        }
    }
}
