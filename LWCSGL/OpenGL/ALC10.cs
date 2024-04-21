using System.Runtime.InteropServices;

// TODO: Add documentation
#pragma warning disable 15911

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenALC 1.0 APIs
    /// </summary>
    public unsafe class ALC10
    {
        private const string DLL_NAME = "al.dll";

        #region Methods
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcCreateContext(nint device, int[] attrlist);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcMakeContextCurrent(nint context);

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
        public static extern byte alcCloseDevice(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetError(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcIsExtensionPresent(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetProcAddress(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string funcname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetEnumValue(nint device, [In()][MarshalAs(UnmanagedType.LPStr)] string enumname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcGetString(nint device, int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcGetIntegerv(nint device, int param, int size, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alcCaptureOpenDevice([In()][MarshalAs(UnmanagedType.LPStr)] string devicename, uint frequency, int format, int buffersize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcCaptureCloseDevice(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStart(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStop(nint device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureSamples(nint device, nint buffer, int samples);
        #endregion

        #region Methods (pointers)
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcCreateContext(void* device, int* attrlist);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcMakeContextCurrent(void* context);

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
        public static extern byte alcCloseDevice(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetError(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcIsExtensionPresent(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetProcAddress(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string funcname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetEnumValue(void* device, [In()][MarshalAs(UnmanagedType.LPStr)] string enumname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetString(void* device, int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcGetIntegerv(void* device, int param, int size, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcCaptureOpenDevice2([In()][MarshalAs(UnmanagedType.LPStr)] string devicename, uint frequency, int format, int buffersize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alcCaptureCloseDevice(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStart(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStop(void* device);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureSamples(void* device, void* buffer, int samples);
        #endregion
    }
}
