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
        private int deltaWheel;
        private bool grabbed;
        private MouseEventData mEvent = new MouseEventData();
        private MouseEventData mWheelRestoreEvent = new MouseEventData();

        private struct MouseEventData
        {
            public int Button;
            public bool State;
            public float X;
            public float Y;
            public float DeltaX;
            public float DeltaY;
            public int DeltaWheel;
            public bool DeltaWheelChanged;
            public bool IsRestore;
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
            Display.instance.viewport.MouseWheel += instance.Viewport_MouseWheel;
        }

        /// <summary>
        /// Destroys the mouse instance, must be called before Display.Destroy()
        /// </summary>
        public static void Destroy()
        {
            Display.CheckForDisplay();
            Display.instance.viewport.MouseWheel -= instance.Viewport_MouseWheel;
            instance = null;
        }

        private void Viewport_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / SystemInformation.MouseWheelScrollDelta;
            deltaWheel = delta;
            mEvent.DeltaWheel = delta;
            mEvent.DeltaWheelChanged = true;
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
                // Make the coords relative to the center
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

            if (mWheelRestoreEvent.IsRestore) 
            {
                mEvent = mWheelRestoreEvent;
                mEvent.IsRestore = false;
                mWheelRestoreEvent = new MouseEventData();
            }

            if (mEvent.Button != BUTTON_NONE && !mEvent.State)
                mEvent.Button = BUTTON_NONE;
            else if (mEvent.Button == BUTTON_NONE)
            {
                if (rightButton) mEvent.Button = BUTTON_RIGHT;
                if (leftButton) mEvent.Button = BUTTON_LEFT;
                mEvent.State = leftButton || rightButton;
                hasEvent = mEvent.Button != BUTTON_NONE;
            }
            else if (mEvent.Button != BUTTON_NONE && mEvent.State)
            {
                switch (mEvent.Button)
                {
                    case BUTTON_LEFT:
                        if (!leftButton)
                        {
                            hasEvent = true;
                            mEvent.State = false;
                        }
                        break;
                    case BUTTON_RIGHT:
                        if (!rightButton)
                        {
                            hasEvent = true;
                            mEvent.State = false;
                        }
                        break;
                }
            }

            if (hasEvent) 
            {
                mEvent.X = GetX();
                mEvent.Y = GetY();
                mEvent.DeltaX = GetDX();
                mEvent.DeltaY = GetDY();
            }

            if (!hasEvent && mEvent.DeltaWheelChanged)
            {
                mEvent.DeltaWheelChanged = false;
                mWheelRestoreEvent = mEvent;
                mWheelRestoreEvent.DeltaWheel = 0;
                mWheelRestoreEvent.IsRestore = true;
                mEvent.Button = BUTTON_NONE;
                mEvent.X = 0;
                mEvent.Y = 0;
                mEvent.DeltaX = 0;
                mEvent.DeltaY = 0;
                hasEvent = true;
            }

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
        /// <returns>the event button, undefined when Next() returned false</returns>
        public static int GetEventButton() => instance.mEvent.Button;
        /// <summary>
        /// Checks if the specified button was the current event button
        /// </summary>
        /// <returns>the check result, undefined when Next() returned false</returns>
        public static bool GetEventButton(int button) => button == instance.mEvent.Button;
        /// <summary>
        /// Gets the state of the event button
        /// </summary>
        /// <returns>the state of the event button, undefined when Next() returned false</returns>
        public static bool GetEventButtonState() => instance.mEvent.State;
        /// <summary>
        /// Gets the absoulute X position of the mouse of the current event
        /// </summary>
        /// <returns>the X position of the mouse</returns>
        public static float GetEventX() => instance.mEvent.X;
        /// <summary>
        /// Gets the absoulute Y position of the mouse of the current event
        /// </summary>
        /// <returns>the Y position of the mouse</returns>
        public static float GetEventY() => instance.mEvent.Y;
        /// <summary>
        /// Gets the X delta of the current event
        /// </summary>
        /// <returns>the X delta</returns>
        public static float GetEventDX() => instance.mEvent.DeltaX;
        /// <summary>
        /// Gets the Y delta of the current event
        /// </summary>
        /// <returns>the Y delta</returns>
        public static float GetEventDY() => instance.mEvent.DeltaY;
        /// <summary>
        /// Gets the wheel delta of the current event
        /// </summary>
        /// <returns>the wheel delta</returns>
        public static int GetEventDWheel() 
        {
            int delta = instance.mEvent.DeltaWheel;
            instance.mEvent.DeltaWheel = 0;
            instance.mEvent.DeltaWheelChanged = false;
            return delta;
        }
        /// <summary>
        /// Gets the absoulute X position of the mouse
        /// </summary>
        /// <returns>the X position of the mouse</returns>
        public static float GetX() => Math.Max(Math.Min(instance.x, instance.form.Width - 1), 0);
        /// <summary>
        /// Gets the absoulute Y position of the mouse
        /// </summary>
        /// <returns>The Y position of the mouse</returns>
        public static float GetY() => Math.Max(Math.Min(instance.y, instance.form.Height - 1), 0);
        /// <summary>
        /// Gets the X delta of the mouse since the last poll
        /// </summary>
        /// <returns>the X delta</returns>
        public static float GetDX() => instance.deltaX;
        /// <summary>
        /// Gets the Y delta of the mouse since the last poll
        /// </summary>
        /// <returns>the Y delta</returns>
        public static float GetDY() => instance.deltaY;
        /// <summary>
        /// Gets the delta of the mouse wheel since the last call
        /// </summary>
        /// <returns>the wheel delta</returns>
        public static int GetDWheel() 
        {
            int delta = instance.deltaWheel;
            instance.deltaWheel = 0;
            return delta;
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
