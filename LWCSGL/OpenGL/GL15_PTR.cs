#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 1.5_PTR APIs
    /// </summary>
    public unsafe static class GL15_PTR
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBeginQuery;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBindBuffer;
        private static delegate* unmanaged[Stdcall]<uint, nint, void*, uint, void> _glBufferData;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, void*, void> _glBufferSubData;
        private static delegate* unmanaged[Stdcall]<int, uint*, void> _glDeleteBuffers;
        private static delegate* unmanaged[Stdcall]<int, uint*, void> _glDeleteQueries;
        private static delegate* unmanaged[Stdcall]<uint, void> _glEndQuery;
        private static delegate* unmanaged[Stdcall]<int, uint*, void> _glGenBuffers;
        private static delegate* unmanaged[Stdcall]<int, uint*, void> _glGenQueries;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetBufferParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void**, void> _glGetBufferPointerv;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, void*, void> _glGetBufferSubData;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetQueryObjectiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint*, void> _glGetQueryObjectuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetQueryiv;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsBuffer;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsQuery;
        private static delegate* unmanaged[Stdcall]<uint, uint, void*> _glMapBuffer;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glUnmapBuffer;

        public static void glBeginQuery(uint target, uint id) { _glBeginQuery(target, id); }
        public static void glBindBuffer(uint target, uint buffer) { _glBindBuffer(target, buffer); }
        public static void glBufferData(uint target, nint size, void* data, uint usage) { _glBufferData(target, size, data, usage); }
        public static void glBufferSubData(uint target, nint offset, nint size, void* data) { _glBufferSubData(target, offset, size, data); }
        public static void glDeleteBuffers(int n, uint* buffers) { _glDeleteBuffers(n, buffers); }
        public static void glDeleteQueries(int n, uint* ids) { _glDeleteQueries(n, ids); }
        public static void glEndQuery(uint target) { _glEndQuery(target); }
        public static void glGenBuffers(int n, uint* buffers) { _glGenBuffers(n, buffers); }
        public static void glGenQueries(int n, uint* ids) { _glGenQueries(n, ids); }
        public static void glGetBufferParameteriv(uint target, uint pname, int* @params) { _glGetBufferParameteriv(target, pname, @params); }
        public static void glGetBufferPointerv(uint target, uint pname, void** @params) { _glGetBufferPointerv(target, pname, @params); }
        public static void glGetBufferSubData(uint target, nint offset, nint size, void* data) { _glGetBufferSubData(target, offset, size, data); }
        public static void glGetQueryObjectiv(uint id, uint pname, int* @params) { _glGetQueryObjectiv(id, pname, @params); }
        public static void glGetQueryObjectuiv(uint id, uint pname, uint* @params) { _glGetQueryObjectuiv(id, pname, @params); }
        public static void glGetQueryiv(uint target, uint pname, int* @params) { _glGetQueryiv(target, pname, @params); }
        public static bool glIsBuffer(uint buffer) { return _glIsBuffer(buffer); }
        public static bool glIsQuery(uint id) { return _glIsQuery(id); }
        public static void* glMapBuffer(uint target, uint access) { return _glMapBuffer(target, access); }
        public static bool glUnmapBuffer(uint target) { return _glUnmapBuffer(target); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBeginQuery = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBeginQuery");
            _glBindBuffer = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBindBuffer");
            _glBufferData = (delegate* unmanaged[Stdcall]<uint, nint, void*, uint, void>)src.GetFuncPtr("glBufferData");
            _glBufferSubData = (delegate* unmanaged[Stdcall]<uint, nint, nint, void*, void>)src.GetFuncPtr("glBufferSubData");
            _glDeleteBuffers = (delegate* unmanaged[Stdcall]<int, uint*, void>)src.GetFuncPtr("glDeleteBuffers");
            _glDeleteQueries = (delegate* unmanaged[Stdcall]<int, uint*, void>)src.GetFuncPtr("glDeleteQueries");
            _glEndQuery = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glEndQuery");
            _glGenBuffers = (delegate* unmanaged[Stdcall]<int, uint*, void>)src.GetFuncPtr("glGenBuffers");
            _glGenQueries = (delegate* unmanaged[Stdcall]<int, uint*, void>)src.GetFuncPtr("glGenQueries");
            _glGetBufferParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetBufferParameteriv");
            _glGetBufferPointerv = (delegate* unmanaged[Stdcall]<uint, uint, void**, void>)src.GetFuncPtr("glGetBufferPointerv");
            _glGetBufferSubData = (delegate* unmanaged[Stdcall]<uint, nint, nint, void*, void>)src.GetFuncPtr("glGetBufferSubData");
            _glGetQueryObjectiv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetQueryObjectiv");
            _glGetQueryObjectuiv = (delegate* unmanaged[Stdcall]<uint, uint, uint*, void>)src.GetFuncPtr("glGetQueryObjectuiv");
            _glGetQueryiv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetQueryiv");
            _glIsBuffer = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsBuffer");
            _glIsQuery = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsQuery");
            _glMapBuffer = (delegate* unmanaged[Stdcall]<uint, uint, void*>)src.GetFuncPtr("glMapBuffer");
            _glUnmapBuffer = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glUnmapBuffer");
        }

        internal static void Unload()
        {
            _glBeginQuery = null;
            _glBindBuffer = null;
            _glBufferData = null;
            _glBufferSubData = null;
            _glDeleteBuffers = null;
            _glDeleteQueries = null;
            _glEndQuery = null;
            _glGenBuffers = null;
            _glGenQueries = null;
            _glGetBufferParameteriv = null;
            _glGetBufferPointerv = null;
            _glGetBufferSubData = null;
            _glGetQueryObjectiv = null;
            _glGetQueryObjectuiv = null;
            _glGetQueryiv = null;
            _glIsBuffer = null;
            _glIsQuery = null;
            _glMapBuffer = null;
            _glUnmapBuffer = null;
        }
    }
}
