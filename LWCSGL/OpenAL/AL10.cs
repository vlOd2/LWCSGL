using System.Runtime.InteropServices;

// TODO: Add documentation
#pragma warning disable 1591

namespace LWCSGL.OpenAL
{
    /// <summary>
    /// OpenAL 1.0 APIs
    /// </summary>
    public unsafe class AL10
    {
        private const string DLL_NAME = "openal.dll";

        #region Methods
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alEnable(uint capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDisable(uint capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsEnabled(uint capability);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerFactor(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerVelocity(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSpeedOfSound(float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDistanceModel(uint distanceModel);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alGetString(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBooleanv(uint param, nint values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetIntegerv(uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetFloatv(uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetDoublev(uint param, double[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alGetBoolean(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alGetInteger(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern float alGetFloat(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double alGetDouble(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alGetError();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsExtensionPresent([In()][MarshalAs(UnmanagedType.LPStr)] string extname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern nint alGetProcAddress([In()][MarshalAs(UnmanagedType.LPStr)] string fname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint alGetEnumValue([In()][MarshalAs(UnmanagedType.LPStr)] string ename);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerf(uint param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3f(uint param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerfv(uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneri(uint param, uint value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3i(uint param, uint value1, uint value2, uint value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneriv(uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerf(uint param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3f(uint param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerfv(uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneri(uint param, uint[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3i(uint param, uint[] value1, uint[] value2, uint[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneriv(uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenSources(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteSources(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsSource(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcef(uint source, uint param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3f(uint source, uint param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcefv(uint source, uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcei(uint source, uint param, uint value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3i(uint source, uint param, uint value1, uint value2, uint value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceiv(uint source, uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcef(uint source, uint param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3f(uint source, uint param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcefv(uint source, uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcei(uint source, uint param, uint[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3i(uint source, uint param, uint[] value1, uint[] value2, uint[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourceiv(uint source, uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlay(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStop(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewind(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePause(uint source);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlayv(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStopv(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewindv(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePausev(uint n, uint[] sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceQueueBuffers(uint source, uint nb, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceUnqueueBuffers(uint source, uint nb, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenBuffers(uint n, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteBuffers(uint n, uint[] buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte alIsBuffer(uint buffer);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferData(uint buffer, uint format, nint data, uint size, uint samplerate);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferf(uint buffer, uint param, float value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3f(uint buffer, uint param, float value1, float value2, float value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferfv(uint buffer, uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferi(uint buffer, uint param, uint value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3i(uint buffer, uint param, uint value1, uint value2, uint value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferiv(uint buffer, uint param, uint[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferf(uint buffer, uint param, float[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3f(uint buffer, uint param, float[] value1, float[] value2, float[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferfv(uint buffer, uint param, float[] values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferi(uint buffer, uint param, uint[] value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3i(uint buffer, uint param, uint[] value1, uint[] value2, uint[] value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferiv(uint buffer, uint param, uint[] values);
        #endregion

        #region Methods (pointers)
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alGetString2(uint param);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBooleanv(uint param, void* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alGetProcAddress2([In()][MarshalAs(UnmanagedType.LPStr)] string fname);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferData(uint buffer, uint format, void* data, uint size, uint samplerate);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetIntegerv(uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetFloatv(uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetDoublev(uint param, double* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerfv(uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneriv(uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerf(uint param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3f(uint param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerfv(uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneri(uint param, uint* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3i(uint param, uint* value1, uint* value2, uint* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneriv(uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenSources(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteSources(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcefv(uint source, uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceiv(uint source, uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcef(uint source, uint param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3f(uint source, uint param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcefv(uint source, uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcei(uint source, uint param, uint* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3i(uint source, uint param, uint* value1, uint* value2, uint* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourceiv(uint source, uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlayv(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStopv(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewindv(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePausev(uint n, uint* sources);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceQueueBuffers(uint source, uint nb, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceUnqueueBuffers(uint source, uint nb, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenBuffers(uint n, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteBuffers(uint n, uint* buffers);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferfv(uint buffer, uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferiv(uint buffer, uint param, uint* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferf(uint buffer, uint param, float* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3f(uint buffer, uint param, float* value1, float* value2, float* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferfv(uint buffer, uint param, float* values);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferi(uint buffer, uint param, uint* value);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3i(uint buffer, uint param, uint* value1, uint* value2, uint* value3);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferiv(uint buffer, uint param, uint* values);
        #endregion
    }
}
