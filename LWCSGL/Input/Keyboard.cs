using LWCSGL.OpenGL;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LWCSGL.Input
{
    /// <summary>
    /// API for interfacing with the keyboard
    /// </summary>
    public class Keyboard
    {
        [DllImport("user32.dll")]
        private static extern int MapVirtualKeyA(int uCode, int uMapType);
        private const int MAPVK_VK_TO_CHAR = 2;
        private static Keyboard instance;
        private Dictionary<VirtualKey, bool> pressedKeys;
        private Queue<KeyboardEvent> eventQueue;
        private KeyboardEvent currentEvent;

        private struct KeyboardEvent
        {
            public VirtualKey Key;
            public char Character;
            public bool State;
        }

        private Keyboard()
        {
            pressedKeys = new Dictionary<VirtualKey, bool>();
            eventQueue = new Queue<KeyboardEvent>();
        }

        /// <summary>
        /// Creates a keyboard instance, must be called after Display.Create()
        /// </summary>
        public static void Create()
        {
            Display.CheckForDisplay();
            instance = new Keyboard();
            Display.instance.viewport.KeyDown += instance.Form_KeyDown;
            Display.instance.viewport.KeyUp += instance.Form_KeyUp;
        }

        /// <summary>
        /// Destroys the keyboard instance, must be called before Display.Destroy()
        /// </summary>
        public static void Destroy()
        {
            Display.CheckForDisplay();
            Display.instance.viewport.KeyDown -= instance.Form_KeyDown;
            Display.instance.viewport.KeyUp -= instance.Form_KeyUp;
            instance = null;
        }

        private void QueueEvent(VirtualKey key, char character, bool state)
        {
            eventQueue.Enqueue(new KeyboardEvent
            {
                Key = key,
                Character = character,
                State = state
            });
        }

        private char Key2Char(int key)
        {
            return (char)MapVirtualKeyA(key, MAPVK_VK_TO_CHAR);
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            VirtualKey key = (VirtualKey)e.KeyCode;

            if (pressedKeys.ContainsKey(key))
            {
                pressedKeys[key] = false;
                QueueEvent(key, Key2Char(e.KeyValue), false);
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            VirtualKey key = (VirtualKey)e.KeyCode;

            if (pressedKeys.ContainsKey(key))
            {
                if (!pressedKeys[key])
                {
                    pressedKeys[key] = true;
                    QueueEvent(key, Key2Char(e.KeyValue), true);
                }
            }
            else
            {
                pressedKeys.Add(key, true);
                QueueEvent(key, Key2Char(e.KeyValue), true);
            }
        }

        /// <summary>
        /// Polls the next keyboard event
        /// </summary>
        /// <returns>true if there was a keyboard event, false if not</returns>
        public static bool Next() => instance._Next();

        private bool _Next()
        {
            if (eventQueue.Count == 0) return false;
            currentEvent = eventQueue.Dequeue();
            return true;
        }

        /// <summary>
        /// Gets the current event key
        /// </summary>
        /// <returns>The event key, undefined when Next() returned false</returns>
        public static VirtualKey GetEventKey() => instance.currentEvent.Key;

        /// <summary>
        /// Gets the current event key as a character
        /// </summary>
        /// <returns>The event key as a character, undefined when Next() returned false</returns>
        public static char GetEventCharacter() => instance.currentEvent.Character;

        /// <summary>
        /// Gets the state of the event key
        /// </summary>
        /// <returns>The state of the event key, undefined when Next() returned false</returns>
        public static bool GetEventKeyState() => instance.currentEvent.State;

        /// <summary>
        /// Checks if the specified key is being held down
        /// </summary>
        /// <returns>The state of the key</returns>
        public static bool IsKeyDown(VirtualKey key) => instance._IsKeyDown(key);

        private bool _IsKeyDown(VirtualKey key)
        {
            if (!pressedKeys.ContainsKey(key)) return false;
            return pressedKeys[key];
        }

        /// <summary>
        /// Gets the friendly name of a virtual key
        /// </summary>
        /// <param name="keyCode">The key code of the VK</param>
        /// <returns>The friendly name</returns>
        public static string GetVKFriendlyName(int keyCode)
        {
            return ((VirtualKey)keyCode).ToString();
        }
    }
}
