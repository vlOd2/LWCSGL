using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using LWCSGL.Input;
using LWCSGL.OpenGL;
using static LWCSGL.OpenGL.GL11;
using static LWCSGL.OpenGL.GL11C;

namespace LWCSGL
{
    public class LWCSGLTest
    {
        private static void SetupGL() 
        {
            glEnable(GL_TEXTURE_2D);
            glShadeModel(GL_SMOOTH);
            glClearColor(0.5F, 0.8F, 1.0F, 0.0F);
            glClearDepth(1.0);
            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LEQUAL);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            glMatrixMode(GL_MODELVIEW);
            glViewport(0, 0, (uint)Display.GetWidth(), (uint)Display.GetHeight());
        }

        private static void SetupCamera() 
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            GLU.gluPerspective(70, Display.GetWidth() / (float)Display.GetHeight(), 0.01F, 1000F);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslatef(0, 0, -0.3F);
        }

        private static void SetupTexture() 
        {
            byte[] pixels = new byte[128 * 128 * 4];
            GCHandle pixelsHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            for (int y = 0; y < 128; y++)
            {
                for (int x = 0; x < 128; x++)
                {
                    int i = y + x * 128;
                    byte xorValue = (byte)(x ^ y & 255);
                    pixels[i * 4] = xorValue;
                    pixels[(i * 4) + 1] = xorValue;
                    pixels[(i * 4) + 2] = xorValue;
                    pixels[(i * 4) + 3] = 255;
                }
            }

            uint[] textureID = new uint[1];
            glGenTextures(1, textureID);
            glBindTexture(GL_TEXTURE_2D, textureID[0]);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_NEAREST);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_NEAREST);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, 128, 128, 0, 
                GL_RGBA, GL_UNSIGNED_BYTE, pixelsHandle.AddrOfPinnedObject());
            pixelsHandle.Free();
        }

        private static void DrawTriangle() 
        {
            glRotatef(TimeUtil.MilliTime / 10 % 360, 0, 1, 0);
            glColor3f(1.0F, 1.0F, 1.0F);
            glBegin(GL_QUADS);
            glVertex2f(-0.1F, -0.1F);
            glTexCoord2f(0, 0);
            glVertex2f(-0.1F, 0.1F);
            glTexCoord2f(0, 1);
            glVertex2f(0.1F, 0.1F);
            glTexCoord2f(1, 1);
            glVertex2f(0.1F, -0.1F);
            glTexCoord2f(1, 0);
            glEnd();
        }

        static void Main(string[] args)
        {
            GLViewport.DebugMode = true;
            Display.Create();
            Keyboard.Create();
            Mouse.Create();
            Display.SetTitle("LWCSGL Test");
            Display.SetResizable(true);
            SetupGL();
            SetupTexture();

            int frames = 0;
            long frameTime = TimeUtil.MilliTime;

            while (!Display.IsCloseRequested())
            {
                while (Keyboard.Next()) 
                {
                    if (Keyboard.GetEventKeyState() && !Keyboard.IsRepeatEvent() && 
                        Keyboard.GetEventKey() == VirtualKey.Enter)
                        Display.SetFullscreen(!Display.IsFullscreen());

                    if (Keyboard.GetEventKeyState() && !Keyboard.IsRepeatEvent() &&
                        Keyboard.GetEventKey() == VirtualKey.R)
                        Keyboard.EnableRepeatEvents(!Keyboard.AreRepeatEventsEnabled());

                    if (Keyboard.GetEventKeyState() && !Keyboard.IsRepeatEvent() &&
                        Keyboard.GetEventKey() == VirtualKey.S)
                        Display.PrintStatusReport();

                    string state = Keyboard.IsRepeatEvent() ? "Holding" : 
                        Keyboard.GetEventKeyState() ? "Pressed" : "Released";
                    Console.WriteLine($"{state} key {Keyboard.GetEventKey()} ({Keyboard.GetEventCharacter()})");
                }

                while (Mouse.Next()) 
                {
                    string state = Mouse.GetEventButtonState() ? "Pressed" : "Released";
                    Console.WriteLine($"{state} mouse button {Mouse.GetEventButton()} @ " +
                        $"{Mouse.GetEventX()}, {Mouse.GetEventY()} with delta " +
                        $"{Mouse.GetEventDX()}, {Mouse.GetEventDY()} with wheel {Mouse.GetEventDWheel()}");
                }

                if (Display.WasResized())
                    glViewport(0, 0, Display.GetWidth(), Display.GetHeight());

                SetupCamera();
                DrawTriangle();

                Display.Update();
                frames++;

                if (TimeUtil.MilliTime - frameTime >= 1000) 
                {
                    Console.WriteLine($"Framerate: {frames}");
                    frames = 0;
                    frameTime = TimeUtil.MilliTime;
                }
            }

            Display.Destroy();
        }
    }
}
