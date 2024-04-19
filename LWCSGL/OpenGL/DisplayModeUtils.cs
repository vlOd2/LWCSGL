using System.Collections.Generic;
using System.Runtime.InteropServices;
using static LWCSGL.OpenGL.WGL;

namespace LWCSGL.OpenGL
{
    internal class DisplayModeUtils
    {
        // Unmanaged2Managed
        public static void UMG2MG(DEVMODE devMode, out DisplayMode mode)
        {
            int w = devMode.dmPelsWidth;
            int h = devMode.dmPelsHeight;
            int bps = devMode.dmBitsPerPel;
            int freq = devMode.dmDisplayFrequency;
            mode = new DisplayMode(w, h, true, bps, freq);
        }

        // Managed2Unmanaged
        public static void MG2UMG(DisplayMode mode, ref DEVMODE devMode)
        {
            devMode.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            devMode.dmPelsWidth = mode.width;
            devMode.dmPelsHeight = mode.height;
            devMode.dmBitsPerPel = mode.bitsPerPixel;
            devMode.dmDisplayFrequency = mode.frequency;
            devMode.dmFields = DM_PELSWIDTH | DM_PELSHEIGHT | DM_BITSPERPEL | DM_DISPLAYFREQUENCY;
        }

        public static DisplayMode GetCurrent()
        {
            DEVMODE devMode = new DEVMODE();

            if (!EnumDisplaySettingsA(null, ENUM_CURRENT_SETTINGS, ref devMode))
                throw new OpenGLException("Failed to retreive current display mode!");

            UMG2MG(devMode, out DisplayMode mode);
            return mode;
        }

        public static DisplayMode[] GetAll()
        {
            List<DisplayMode> modes = new List<DisplayMode>();
            DEVMODE devMode = new DEVMODE();
            int i = 0;

            while (EnumDisplaySettingsA(null, i, ref devMode))
            {
                i++;
                UMG2MG(devMode, out DisplayMode mode);
                // Filter out duplicates
                if (modes.Contains(mode)) continue;
                modes.Add(mode);
            }

            return modes.ToArray();
        }
    }
}
