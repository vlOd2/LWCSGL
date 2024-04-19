using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LWCSGL.OpenGL
{
    // Wiggle shit
    internal class WGL
    {
        public const int PFD_NEED_SYSTEM_PALETTE = 256;
        public const int PFD_GENERIC_ACCELERATED = 4096;
        public const int PFD_SWAP_LAYER_BUFFERS = 2048;
        public const int PFD_SUPPORT_DIRECTDRAW = 8192;
        public const int PFD_TYPE_COLORINDEX = 1;
        public const int PFD_STEREO_DONTCARE = -2147483648;
        public const int PFD_UNDERLAY_PLANE = -1;
        public const int PFD_SUPPORT_OPENGL = 32;
        public const int PFD_GENERIC_FORMAT = 64;
        public const int PFD_DRAW_TO_WINDOW = 4;
        public const int PFD_DRAW_TO_BITMAP = 8;
        public const int PFD_DEPTH_DONTCARE = 536870912;
        public const int PFD_SWAP_EXCHANGE = 512;
        public const int PFD_OVERLAY_PLANE = 1;
        public const int PFD_NEED_PALETTE = 128;
        public const int PFD_DOUBLEBUFFER = 1;
        public const int PFD_SUPPORT_GDI = 16;
        public const int PFD_MAIN_PLANE = 0;
        public const int PFD_TYPE_RGBA = 0;
        public const int PFD_SWAP_COPY = 1024;
        public const int PFD_STEREO = 2;
        public const int PFD_DOUBLEBUFFER_DONTCARE = 1073741824;
        public const int WM_PAINT = 15;
        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_RESET = 1073741824;
        public const int CDS_FULLSCREEN = 4;
        public const int DM_PELSHEIGHT = 1048576;
        public const int DM_PELSWIDTH = 524288;
        public const int DM_BITSPERPEL = 262144;
        public const int DM_DISPLAYFREQUENCY = 4194304;

        [DllImport("user32.dll")]
        public static extern nint BeginPaint(nint hWnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint(nint hWnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        public static extern nint GetDC(nint hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(nint hWnd, nint hDC);

        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(nint hdc, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll")]
        public static extern bool SetPixelFormat(nint hdc, int format, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettingsA(ref DEVMODE lpDevMode, int dwFlags);

        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettingsA(nint lpDevMode, int dwFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsA(
            [In()][MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName,
            int iModeNum, ref DEVMODE lpDevMode);

        [DllImport("opengl32.dll")]
        public static extern nint wglCreateContext(nint param0);

        [DllImport("opengl32.dll")]
        public static extern bool wglMakeCurrent(nint param0, nint param1);

        [DllImport("opengl32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglDeleteContext(nint param0);

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public nint hdc;
            public bool fErase;
            public Rectangle rcPaint;
            public bool fRestore;
            public bool fIncUpdate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PIXELFORMATDESCRIPTOR
        {
            public short nSize;
            public short nVersion;
            public int dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public int dwLayerMask;
            public int dwVisibleMask;
            public int dwDamageMask;
        }

        #region DEVMODE
        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE__DUMMYSTRUCTNAME
        {
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE__DUMMYSTRUCTNAME2
        {
            public Point dmPosition;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct DEVMODE__UNION1
        {
            [FieldOffset(0)]
            public DEVMODE__DUMMYSTRUCTNAME Struct1;
            [FieldOffset(0)]
            public DEVMODE__DUMMYSTRUCTNAME2 Struct2;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct DEVMODE__UNION2
        {
            [FieldOffset(0)]
            public int dmDisplayFlags;
            [FieldOffset(0)]
            public int dmNup;
        }

        // WHY THE FUCK IS THE PRINTER CRAP FUCKED WITH THIS???
        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public DEVMODE__UNION1 Union1;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public DEVMODE__UNION2 Union2;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
        #endregion
    }
}
