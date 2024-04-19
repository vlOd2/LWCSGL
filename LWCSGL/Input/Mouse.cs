using LWCSGL.OpenGL;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LWCSGL.Input
{
    /// <summary>
    /// API for interfacing with the Mouse
    /// </summary>
    public class Mouse
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        private const int BUTTON_LEFT = 0;
        private const int BUTTON_RIGHT = 1;
        private const int BUTTON_NONE = -1;
        internal static Mouse instance;
        private Form form;
        private float x;
        private float y;
        private float deltaX;
        private float deltaY;
        private bool grabbed;
        private MouseEventData currentEvent;

        private struct MouseEventData
        {
            public int Button;
            public bool State;

            public MouseEventData(int button, bool state)
            {
                Button = button;
                State = state;
            }

            public override bool Equals(object obj)
            {
                return obj is MouseEventData data &&
                       Button == data.Button &&
                       State == data.State;
            }

            public override int GetHashCode()
            {
                int hashCode = -693105969;
                hashCode = hashCode * -1521134295 + Button.GetHashCode();
                hashCode = hashCode * -1521134295 + State.GetHashCode();
                return hashCode;
            }

            public static bool operator ==(MouseEventData event0, MouseEventData event1)
            {
                return EqualityComparer<MouseEventData>.Default.Equals(event0, event1);
            }

            public static bool operator !=(MouseEventData event0, MouseEventData event1)
            {
                return !(event0 == event1);
            }
        }

        private Mouse() { }

        /// <summary>
        /// Creates a mouse instance, must be called after Display.Create()
        /// </summary>
        public static void Create()
        {
            Display.CheckForDisplay();
            instance = new Mouse();
            instance.form = Display.instance.form;
        }

        /// <summary>
        /// Destroys the mouse instance, must be called before Display.Destroy()
        /// </summary>
        public static void Destroy()
        {
            instance = null;
        }

        private void CenterCursor()
        {
            int centerX = form.Location.X + form.Width / 2;
            int centerY = form.Location.Y + form.Height / 2;
            Cursor.Position = new Point(centerX, centerY);
        }

        internal bool Poll()
        {
            if (form == null || !form.ContainsFocus) return false;

            Point pos = form.PointToClient(Cursor.Position);
            if (grabbed) CenterCursor();
            if (!form.ClientRectangle.Contains(pos)) return false;

            float newX = pos.X * (grabbed ? -1 : 1);
            float newY = pos.Y * (grabbed ? -1 : 1);
            newY = form.Height - newY - 1;
            bool changed = newX != x || newY != y;

            if (changed)
            {
                deltaX = newX - x;
                deltaY = newY - y;
                x = newX;
                y = newY;
            }

            return changed;
        }

        private bool _Next()
        {
            if (!form.ContainsFocus) return false;
            bool hasEvent = false;
            bool leftButton = GetAsyncKeyState((int)Keys.LButton) != 0;
            bool rightButton = GetAsyncKeyState((int)Keys.RButton) != 0;

            if (currentEvent.Button != BUTTON_NONE && !currentEvent.State)
                currentEvent.Button = BUTTON_NONE;
            else if (currentEvent.Button == BUTTON_NONE)
            {
                if (rightButton) currentEvent.Button = BUTTON_RIGHT;
                if (leftButton) currentEvent.Button = BUTTON_LEFT;
                currentEvent.State = leftButton || rightButton;
                hasEvent = currentEvent.Button != BUTTON_NONE;
            }
            else if (currentEvent.Button != BUTTON_NONE && currentEvent.State)
            {
                switch (currentEvent.Button)
                {
                    case BUTTON_LEFT:
                        if (!leftButton)
                        {
                            hasEvent = true;
                            currentEvent.State = false;
                        }
                        break;
                    case BUTTON_RIGHT:
                        if (!rightButton)
                        {
                            hasEvent = true;
                            currentEvent.State = false;
                        }
                        break;
                }
            }

            return hasEvent;
        }

        /// <summary>
        /// Polls the next mouse event
        /// </summary>
        /// <returns>true if there was a mouse event, false if not</returns>
        public static bool Next() => instance._Next();

        /// <summary>
        /// Gets the current event button
        /// </summary>
        /// <returns>The event button, undefined when Next() returned false</returns>
        public static int GetEventButton() => instance.currentEvent.Button;

        /// <summary>
        /// Checks if the specified button was the current event button
        /// </summary>
        /// <returns>The check result, undefined when Next() returned false</returns>
        public static bool GetEventButton(int button) => button == instance.currentEvent.Button;

        /// <summary>
        /// Gets the state of the event button
        /// </summary>
        /// <returns>The state of the event button, undefined when Next() returned false</returns>
        public static bool GetEventButtonState() => instance.currentEvent.State;

        /// <summary>
        /// Gets the X position of the mouse
        /// </summary>
        /// <returns>The X position of the mouse</returns>
        public static float GetX() => instance.x;

        /// <summary>
        /// Gets the Y position of the mouse
        /// </summary>
        /// <returns>The Y position of the mouse</returns>
        public static float GetY() => instance.y;

        /// <summary>
        /// Gets the X delta of the mouse since last calling this function
        /// </summary>
        /// <returns>The X delta</returns>
        public static float GetDeltaX()
        {
            float value = instance.deltaX;
            instance.deltaX = 0;
            return value;
        }

        /// <summary>
        /// Gets the Y delta of the mouse since last calling this function
        /// </summary>
        /// <returns>The Y delta</returns>
        public static float GetDeltaY()
        {
            float value = instance.deltaY;
            instance.deltaY = 0;
            return value;
        }

        /// <summary>
        /// Retreives the grab state
        /// </summary>
        /// <returns>The grab state</returns>
        public static bool IsGrabbed() => instance.grabbed;

        /// <summary>
        /// Sets the grab state
        /// </summary>
        /// <param name="grabbed">The new grab state</param>
        public static void SetGrabbed(bool grabbed)
        {
            instance.grabbed = grabbed;
            if (grabbed)
                Cursor.Hide();
            else
                Cursor.Show();
        }
    }
}
