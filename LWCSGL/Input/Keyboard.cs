using System.Collections.Generic;
using System.Windows.Forms;
using LWCSGL.OpenGL;

namespace LWCSGL.Input
{
    /// <summary>
    /// API for interfacing with the keyboard
    /// </summary>
    public class Keyboard
    {
        private static Keyboard instance;
        private Dictionary<VirtualKey, bool> pressedKeys;
        private Queue<KeyboardEvent> eventQueue;
        private KeyboardEvent currentEvent;
        private bool repeatEvents;

        private struct KeyboardEvent
        {
            public VirtualKey Key;
            public char Character;
            public bool State;
            public bool Repeat;
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
            Display.instance.viewport.KeyDown += instance.Viewport_KeyDown;
            Display.instance.viewport.KeyUp += instance.Viewport_KeyUp;
        }

        /// <summary>
        /// Destroys the keyboard instance, must be called before Display.Destroy()
        /// </summary>
        public static void Destroy()
        {
            Display.CheckForDisplay();
            Display.instance.viewport.KeyDown -= instance.Viewport_KeyDown;
            Display.instance.viewport.KeyUp -= instance.Viewport_KeyUp;
            instance = null;
        }

        private void QueueEvent(VirtualKey key, char character, bool state, bool repeat)
        {
            eventQueue.Enqueue(new KeyboardEvent
            {
                Key = key,
                Character = character,
                State = state,
                Repeat = repeat
            });
        }

        private void Viewport_KeyUp(object sender, KeyEventArgs e)
        {
            VirtualKey key = (VirtualKey)e.KeyCode;

            if (pressedKeys.ContainsKey(key))
            {
                pressedKeys[key] = false;
                QueueEvent(key, VKMapper.GetChar(key), false, false);
            }
        }

        private void Viewport_KeyDown(object sender, KeyEventArgs e)
        {
            VirtualKey key = (VirtualKey)e.KeyCode;

            if (pressedKeys.ContainsKey(key))
            {
                bool alreadyPressed = pressedKeys[key];

                if (!alreadyPressed || repeatEvents)
                {
                    pressedKeys[key] = true;
                    QueueEvent(key, VKMapper.GetChar(key), true, alreadyPressed);
                }
            }
            else
            {
                pressedKeys.Add(key, true);
                QueueEvent(key, VKMapper.GetChar(key), true, false);
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
        /// Checks if a keyboard has been created
        /// </summary>
        /// <returns>true if a keyboard has been created, false if not</returns>
        public static bool IsCreated() => instance != null;
        /// <summary>
        /// Gets the current event key
        /// </summary>
        /// <returns>the event key, undefined when Next() returned false</returns>
        public static VirtualKey GetEventKey() => instance.currentEvent.Key;
        /// <summary>
        /// Gets the current event key as a character
        /// </summary>
        /// <returns>the event key as a character, undefined when Next() returned false</returns>
        public static char GetEventCharacter() => instance.currentEvent.Character;
        /// <summary>
        /// Gets the state of the event key
        /// </summary>
        /// <returns>the state of the event key, undefined when Next() returned false</returns>
        public static bool GetEventKeyState() => instance.currentEvent.State;
        /// <summary>
        /// Checks if the current event is a repeating event
        /// </summary>
        /// <returns>true if the current event has been repeated, false if not</returns>
        public static bool IsRepeatEvent() => instance.currentEvent.Repeat;
        /// <summary>
        /// Checks if the specified key is being held down
        /// </summary>
        /// <returns>the state of the key</returns>
        public static bool IsKeyDown(VirtualKey key) => instance._IsKeyDown(key);
        /// <summary>
        /// Checks if repeat events are enabled
        /// </summary>
        /// <returns>true if repeat events are enabled, false if not</returns>
        public static bool AreRepeatEventsEnabled() => instance.repeatEvents;

        private bool _IsKeyDown(VirtualKey key)
        {
            if (!pressedKeys.ContainsKey(key)) return false;
            return pressedKeys[key];
        }

        /// <summary>
        /// Gets the friendly name of a virtual key
        /// </summary>
        /// <param name="vk">The VK</param>
        /// <returns>the friendly name</returns>
        public static string GetKeyName(VirtualKey vk)
        {
            return VKMapper.GetFriendlyName(vk);
        }

        /// <summary>
        /// Sets the status of repeat events, i.e whether to repeat the same event or not
        /// </summary>
        /// <param name="state">the status of repeat events</param>
        public static void EnableRepeatEvents(bool state) => instance.repeatEvents = state;
    }
}
