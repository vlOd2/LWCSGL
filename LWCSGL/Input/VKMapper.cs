using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LWCSGL.Input
{
    internal class VKMapper
    {
        private const int MAPVK_VK_TO_VSC = 0;

        [DllImport("user32.dll")]
        private static extern int ToUnicode(uint wVirtKey, uint wScanCode, byte[] lpKeyState,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKeyW(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetKeyboardState(byte[] lpKeyState);

        private static KeysConverter converter = new KeysConverter();

        public static char GetChar(VirtualKey vk)
        {
            byte[] keyboardState = new byte[255];
            if (!GetKeyboardState(keyboardState)) return default;

            uint code = (uint)vk;
            uint scanCode = MapVirtualKeyW(code, MAPVK_VK_TO_VSC);
            StringBuilder builder = new StringBuilder();

            int result = ToUnicode(code, scanCode, keyboardState, builder, 1, 0);
            string builderRes = builder.ToString();

            if (result <= 0 || builderRes.Length == 0)
                return default;

            return builderRes[0];
        }

        public static string GetFriendlyName(VirtualKey vk)
        {
            return converter.ConvertToString((Keys)vk);
        }
    }
}
