using System.Threading;
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
            float fr = 0.5F;
            float fg = 0.8F;
            float fb = 1.0F;
            glClearColor(fr, fg, fb, 0.0F);
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
            glOrtho(0.0F, 1.0F, 1.0F, 0.0F, 0.1F, 1000F);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslatef(0, 0, -1000F);
        }

        private static void DrawTriangle() 
        {
            glBegin(GL_TRIANGLES);
            glColor3f(1.0F, 1.0F, 1.0F);
            glVertex2f(0, 0);
            glVertex2f(0, 0.25F);
            glVertex2f(0.25F, 0.25F);
            glEnd();
        }

        static void Main(string[] args)
        {
            GLViewport.DebugMode = true;
            Display.Create();
            Keyboard.Create();
            Display.SetTitle("LWCSGL Test");
            Display.SetResizable(true);
            SetupGL();

            while (!Display.IsCloseRequested())
            {
                while (Keyboard.Next()) 
                {
                    if (!Keyboard.GetEventKeyState()) continue;

                    if (Keyboard.GetEventKey() == VirtualKey.Enter)
                        Display.SetFullscreen(!Display.IsFullscreen());
                }

                if (Display.WasResized())
                    glViewport(0, 0, Display.GetWidth(), Display.GetHeight());

                Display.PrintStatusReport();
                SetupCamera();
                DrawTriangle();

                Display.Update();
                Thread.Sleep(100);
            }

            Display.Destroy();
        }
    }
}
