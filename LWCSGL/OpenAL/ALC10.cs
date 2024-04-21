using System.Runtime.InteropServices;

// TODO: Add documentation
#pragma warning disable 1591

namespace LWCSGL.OpenAL
{
    /// <summary>
    /// OpenALC 1.0 APIs
    /// </summary>
    public unsafe class ALC10
    {
        private const string DLL_NAME = "openal.dll";

        #region Methods
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcCreateContext(nint device, uint[] attrlist);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcMakeContextCurrent(nint context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcProcessContext(nint context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcSuspendContext(nint context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcDestroyContext(nint context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetCurrentContext();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetContextsDevice(nint context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcOpenDevice([In()][MarshalAs(UnmanagedType.LPStr)] string devicename);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcCloseDevice(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alcGetError(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcIsExtensionPresent(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetProcAddress(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string funcname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alcGetEnumValue(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string enumname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetString(nint device, uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcGetIntegerv(nint device, uint param, uint size, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcCaptureOpenDevice([In()][MarshalAs(UnmanagedType.LPStr)] string devicename, uint frequency, uint format, uint buffersize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcCaptureCloseDevice(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStart(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStop(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureSamples(nint device, nint buffer, uint samples);
        #endregion

        #region Methods (pointers)
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcCreateContext(void* device, uint* attrlist);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcMakeContextCurrent(void* context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcProcessContext(void* context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcSuspendContext(void* context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcDestroyContext(void* context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetCurrentContext2();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetContextsDevice(void* context);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcOpenDevice2([In()][MarshalAs(UnmanagedType.LPStr)] string devicename);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcCloseDevice(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alcGetError(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcIsExtensionPresent(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetProcAddress(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string funcname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alcGetEnumValue(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string enumname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetString(void* device, uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcGetIntegerv(void* device, uint param, uint size, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcCaptureOpenDevice2([In()][MarshalAs(UnmanagedType.LPStr)] string devicename, uint frequency, uint format, uint buffersize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool alcCaptureCloseDevice(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStart(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStop(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureSamples(void* device, void* buffer, uint samples);
        #endregion
    }
}
