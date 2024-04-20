using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LWCSGL.OpenGL;

namespace LWCSGL.Input
{
    /// <summary>
    /// API for interfacing with the Mouse
    /// </summary>
    public class Mouse
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
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
            public float X;
            public float Y;
            public float DeltaX;
            public float DeltaY;

            public override bool Equals(object obj)
            {
                return obj is MouseEventData data &&
                       Button == data.Button &&
                       State == data.State &&
                       X == data.X &&
                       Y == data.Y &&
                       DeltaX == data.DeltaX &&
                       DeltaY == data.DeltaY;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Button, State, X, Y, DeltaX, DeltaY);
            }

            public static bool operator ==(MouseEventData left, MouseEventData right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(MouseEventData left, MouseEventData right)
            {
                return !(left == right);
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

        private void GetCursorPos(out int x, out int y)
        {
            Point pos = Cursor.Position;
            x = pos.X - form.Location.X;
            y = pos.Y - form.Location.Y;
            y = form.Height - y - 1;

            if (grabbed) 
            {
                int origX = form.Width / 2;
                int origY = form.Height / 2;
                // Even heights need to be adjusted
                if (form.Height % 2 == 0) origY -= 1;
                x -= origX;
                y -= origY;
            }
        }

        private void CenterCursor()
        {
            int centerX = form.Location.X + form.Width / 2;
            int centerY = form.Location.Y + form.Height / 2;
            Cursor.Position = new Point(centerX, centerY);
        }

        private void _Poll()
        {
            if (form == null || !form.ContainsFocus) return;
            GetCursorPos(out int x, out int y);

            if (grabbed)
            {
                deltaX = x;
                deltaY = y;
                this.x = x;
                this.y = y;
                CenterCursor();
            }
            else
            {
                deltaX = x - this.x;
                deltaY = y - this.y;
                this.x = x;
                this.y = y;
            }
        }

        /// <summary>
        /// Polls the mouse position
        /// </summary>
        /// <remarks>You usually don't need to call this method manually</remarks>
        public static void Poll() => instance._Poll();

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

            currentEvent.X = GetX();
            currentEvent.Y = GetY();
            currentEvent.DeltaX = GetDX();
            currentEvent.DeltaY = GetDY();

            return hasEvent;
        }

        /// <summary>
        /// Checks if a mouse has been created
        /// </summary>
        /// <returns>true if a mouse has been created, false if not</returns>
        public static bool IsCreated() => instance != null;
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
        /// Gets the absoulute X position of the mouse of the current event
        /// </summary>
        /// <returns>The X position of the mouse</returns>
        public static float GetEventX() => instance.currentEvent.X;
        /// <summary>
        /// Gets the absoulute Y position of the mouse of the current event
        /// </summary>
        /// <returns>The Y position of the mouse</returns>
        public static float GetEventY() => instance.currentEvent.Y;
        /// <summary>
        /// Gets the X delta of the current event
        /// </summary>
        /// <returns>The X delta</returns>
        public static float GetEventDX() => instance.currentEvent.DeltaX;
        /// <summary>
        /// Gets the Y delta of the current event
        /// </summary>
        /// <returns>The Y delta</returns>
        public static float GetEventDY() => instance.currentEvent.DeltaY;
        /// <summary>
        /// Gets the absoulute X position of the mouse
        /// </summary>
        /// <returns>The X position of the mouse</returns>
        public static float GetX() => Math.Max(Math.Min(instance.x, instance.form.Width - 1), 0);
        /// <summary>
        /// Gets the absoulute Y position of the mouse
        /// </summary>
        /// <returns>The Y position of the mouse</returns>
        public static float GetY() => Math.Max(Math.Min(instance.y, instance.form.Height - 1), 0);
        /// <summary>
        /// Gets the X delta of the mouse since the last poll
        /// </summary>
        /// <returns>The X delta</returns>
        public static float GetDX() => instance.deltaX;
        /// <summary>
        /// Gets the Y delta of the mouse since the last poll
        /// </summary>
        /// <returns>The Y delta</returns>
        public static float GetDY() => instance.deltaY;
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

        /// <summary>
        /// Checks if the specified mouse button is down
        /// </summary>
        /// <param name="btn">The button to check</param>
        /// <returns>true if the button is down, false if not</returns>
        public static bool IsButtonDown(int btn)
        {
            int vk;

            switch (btn) 
            {
                case BUTTON_LEFT:
                    vk = (int)Keys.LButton;
                    break;
                case BUTTON_RIGHT:
                    vk = (int)Keys.RButton;
                    break;
                default:
                    throw new ArgumentException("Invalid button!");
            }

            return GetAsyncKeyState(vk) != 0;
        }

        /// <summary>
        /// Sets the cursor position relative to the window origin
        /// </summary>
        /// <param name="x">the new x position of the cursor</param>
        /// <param name="y">the new y position of the cursor</param>
        public static void SetCursorPosition(int x, int y) 
            => Cursor.Position = instance.form.PointToScreen(new Point(x, y));
    }
}
