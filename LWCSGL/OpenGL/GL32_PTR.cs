#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 3.2_PTR APIs
    /// </summary>
    public unsafe static class GL32_PTR
    {
        private static delegate* unmanaged[Stdcall]<nint, uint, ulong, uint> _glClientWaitSync;
        private static delegate* unmanaged[Stdcall]<nint, void> _glDeleteSync;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, void*, int, void> _glDrawElementsBaseVertex;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, void*, int, int, void> _glDrawElementsInstancedBaseVertex;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, int, uint, void*, int, void> _glDrawRangeElementsBaseVertex;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint> _glFenceSync;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, int, void> _glFramebufferTexture;
        private static delegate* unmanaged[Stdcall]<uint, uint, long*, void> _glGetBufferParameteri64v;
        private static delegate* unmanaged[Stdcall]<uint, uint, long*, void> _glGetInteger64i_v;
        private static delegate* unmanaged[Stdcall]<uint, long*, void> _glGetInteger64v;
        private static delegate* unmanaged[Stdcall]<uint, uint, float*, void> _glGetMultisamplefv;
        private static delegate* unmanaged[Stdcall]<nint, uint, int, int*, int*, void> _glGetSynciv;
        private static delegate* unmanaged[Stdcall]<nint, bool> _glIsSync;
        private static delegate* unmanaged[Stdcall]<uint, int*, uint, void**, int, int*, void> _glMultiDrawElementsBaseVertex;
        private static delegate* unmanaged[Stdcall]<uint, void> _glProvokingVertex;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glSampleMaski;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, bool, void> _glTexImage2DMultisample;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, bool, void> _glTexImage3DMultisample;
        private static delegate* unmanaged[Stdcall]<nint, uint, ulong, void> _glWaitSync;

        public static uint glClientWaitSync(nint sync, uint flags, ulong timeout) { return _glClientWaitSync(sync, flags, timeout); }
        public static void glDeleteSync(nint sync) { _glDeleteSync(sync); }
        public static void glDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex) { _glDrawElementsBaseVertex(mode, count, type, indices, basevertex); }
        public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex) { _glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex); }
        public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex) { _glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex); }
        public static nint glFenceSync(uint condition, uint flags) { return _glFenceSync(condition, flags); }
        public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level) { _glFramebufferTexture(target, attachment, texture, level); }
        public static void glGetBufferParameteri64v(uint target, uint pname, long* @params) { _glGetBufferParameteri64v(target, pname, @params); }
        public static void glGetInteger64i_v(uint target, uint index, long* data) { _glGetInteger64i_v(target, index, data); }
        public static void glGetInteger64v(uint pname, long* data) { _glGetInteger64v(pname, data); }
        public static void glGetMultisamplefv(uint pname, uint index, float* val) { _glGetMultisamplefv(pname, index, val); }
        public static void glGetSynciv(nint sync, uint pname, int count, int* length, int* values) { _glGetSynciv(sync, pname, count, length, values); }
        public static bool glIsSync(nint sync) { return _glIsSync(sync); }
        public static void glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex) { _glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex); }
        public static void glProvokingVertex(uint mode) { _glProvokingVertex(mode); }
        public static void glSampleMaski(uint maskNumber, uint mask) { _glSampleMaski(maskNumber, mask); }
        public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) { _glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations); }
        public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) { _glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations); }
        public static void glWaitSync(nint sync, uint flags, ulong timeout) { _glWaitSync(sync, flags, timeout); }

        internal static void Load(DelegatePtrSource src)
        {
            _glClientWaitSync = (delegate* unmanaged[Stdcall]<nint, uint, ulong, uint>)src.GetFuncPtr("glClientWaitSync");
            _glDeleteSync = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glDeleteSync");
            _glDrawElementsBaseVertex = (delegate* unmanaged[Stdcall]<uint, int, uint, void*, int, void>)src.GetFuncPtr("glDrawElementsBaseVertex");
            _glDrawElementsInstancedBaseVertex = (delegate* unmanaged[Stdcall]<uint, int, uint, void*, int, int, void>)src.GetFuncPtr("glDrawElementsInstancedBaseVertex");
            _glDrawRangeElementsBaseVertex = (delegate* unmanaged[Stdcall]<uint, uint, uint, int, uint, void*, int, void>)src.GetFuncPtr("glDrawRangeElementsBaseVertex");
            _glFenceSync = (delegate* unmanaged[Stdcall]<uint, uint, nint>)src.GetFuncPtr("glFenceSync");
            _glFramebufferTexture = (delegate* unmanaged[Stdcall]<uint, uint, uint, int, void>)src.GetFuncPtr("glFramebufferTexture");
            _glGetBufferParameteri64v = (delegate* unmanaged[Stdcall]<uint, uint, long*, void>)src.GetFuncPtr("glGetBufferParameteri64v");
            _glGetInteger64i_v = (delegate* unmanaged[Stdcall]<uint, uint, long*, void>)src.GetFuncPtr("glGetInteger64i_v");
            _glGetInteger64v = (delegate* unmanaged[Stdcall]<uint, long*, void>)src.GetFuncPtr("glGetInteger64v");
            _glGetMultisamplefv = (delegate* unmanaged[Stdcall]<uint, uint, float*, void>)src.GetFuncPtr("glGetMultisamplefv");
            _glGetSynciv = (delegate* unmanaged[Stdcall]<nint, uint, int, int*, int*, void>)src.GetFuncPtr("glGetSynciv");
            _glIsSync = (delegate* unmanaged[Stdcall]<nint, bool>)src.GetFuncPtr("glIsSync");
            _glMultiDrawElementsBaseVertex = (delegate* unmanaged[Stdcall]<uint, int*, uint, void**, int, int*, void>)src.GetFuncPtr("glMultiDrawElementsBaseVertex");
            _glProvokingVertex = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glProvokingVertex");
            _glSampleMaski = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glSampleMaski");
            _glTexImage2DMultisample = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, bool, void>)src.GetFuncPtr("glTexImage2DMultisample");
            _glTexImage3DMultisample = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, bool, void>)src.GetFuncPtr("glTexImage3DMultisample");
            _glWaitSync = (delegate* unmanaged[Stdcall]<nint, uint, ulong, void>)src.GetFuncPtr("glWaitSync");
        }

        internal static void Unload()
        {
            _glClientWaitSync = null;
            _glDeleteSync = null;
            _glDrawElementsBaseVertex = null;
            _glDrawElementsInstancedBaseVertex = null;
            _glDrawRangeElementsBaseVertex = null;
            _glFenceSync = null;
            _glFramebufferTexture = null;
            _glGetBufferParameteri64v = null;
            _glGetInteger64i_v = null;
            _glGetInteger64v = null;
            _glGetMultisamplefv = null;
            _glGetSynciv = null;
            _glIsSync = null;
            _glMultiDrawElementsBaseVertex = null;
            _glProvokingVertex = null;
            _glSampleMaski = null;
            _glTexImage2DMultisample = null;
            _glTexImage3DMultisample = null;
            _glWaitSync = null;
        }
    }
}
