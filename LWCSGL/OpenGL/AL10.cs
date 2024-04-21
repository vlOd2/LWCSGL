using System.Runtime.InteropServices;

// TODO: Add documentation
#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenAL 1.0 APIs
    /// </summary>
    public unsafe class AL10
    {
        private const string DLL_NAME = "al.dll";

        #region Methods
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alEnable(int capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDisable(int capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsEnabled(int capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerFactor(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerVelocity(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSpeedOfSound(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDistanceModel(int distanceModel);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alGetString(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBooleanv(int param, nint values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetIntegerv(int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetFloatv(int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetDoublev(int param, double[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alGetBoolean(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetInteger(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern float alGetFloat(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double alGetDouble(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetError();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsExtensionPresent([In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alGetProcAddress([In()][MarshalAs(UnmanagedType.LPStr)] string fname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetEnumValue([In()][MarshalAs(UnmanagedType.LPStr)] string ename);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerf(int param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3f(int param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerfv(int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneri(int param, int value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3i(int param, int value1, int value2, int value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneriv(int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerf(int param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3f(int param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerfv(int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneri(int param, int[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3i(int param, int[] value1, int[] value2, int[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneriv(int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenSources(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteSources(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsSource(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcef(uint source, int param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3f(uint source, int param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcefv(uint source, int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcei(uint source, int param, int value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3i(uint source, int param, int value1, int value2, int value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceiv(uint source, int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcef(uint source, int param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3f(uint source, int param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcefv(uint source, int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcei(uint source, int param, int[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3i(uint source, int param, int[] value1, int[] value2, int[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourceiv(uint source, int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlay(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStop(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewind(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePause(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlayv(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStopv(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewindv(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePausev(int n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceQueueBuffers(uint source, int nb, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceUnqueueBuffers(uint source, int nb, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenBuffers(int n, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteBuffers(int n, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsBuffer(uint buffer);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferData(uint buffer, int format, nint data, int size, int samplerate);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferf(uint buffer, int param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3f(uint buffer, int param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferfv(uint buffer, int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferi(uint buffer, int param, int value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3i(uint buffer, int param, int value1, int value2, int value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferiv(uint buffer, int param, int[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferf(uint buffer, int param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3f(uint buffer, int param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferfv(uint buffer, int param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferi(uint buffer, int param, int[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3i(uint buffer, int param, int[] value1, int[] value2, int[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferiv(uint buffer, int param, int[] values);
        #endregion

        #region Methods (pointers)
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alGetString2(int param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBooleanv(int param, void* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alGetProcAddress2([In()][MarshalAs(UnmanagedType.LPStr)] string fname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferData(uint buffer, int format, void* data, int size, int samplerate);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetIntegerv(int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetFloatv(int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetDoublev(int param, double* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerfv(int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneriv(int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerf(int param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3f(int param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerfv(int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneri(int param, int* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3i(int param, int* value1, int* value2, int* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneriv(int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenSources(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteSources(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcefv(uint source, int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceiv(uint source, int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcef(uint source, int param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3f(uint source, int param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcefv(uint source, int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcei(uint source, int param, int* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3i(uint source, int param, int* value1, int* value2, int* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourceiv(uint source, int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlayv(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStopv(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewindv(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePausev(int n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceQueueBuffers(uint source, int nb, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceUnqueueBuffers(uint source, int nb, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenBuffers(int n, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteBuffers(int n, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferfv(uint buffer, int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferiv(uint buffer, int param, int* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferf(uint buffer, int param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3f(uint buffer, int param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferfv(uint buffer, int param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferi(uint buffer, int param, int* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3i(uint buffer, int param, int* value1, int* value2, int* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferiv(uint buffer, int param, int* values);
        #endregion
    }
}
