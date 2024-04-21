// TODO: Add documentation
#pragma warning disable 1591

/*
 * Code originally written by Dart (https://github.com/dart25)
 * Modified to meet the needs of the library
*/

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL ARB extensions APIs<para></para>
    /// !!! Really incomplete
    /// </summary>
    public static unsafe class GLARB
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBeginQueryARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBindBufferARB;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, uint, void> _glBufferDataARB;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, nint, void> _glBufferSubDataARB;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteBuffersARB;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteQueriesARB;
        private static delegate* unmanaged[Stdcall]<uint, void> _glEndQueryARB;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenBuffersARB;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenQueriesARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetBufferParameterivARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetBufferPointervARB;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, nint, void> _glGetBufferSubDataARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetQueryObjectivARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetQueryObjectuivARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetQueryivARB;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsBufferARB;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsQueryARB;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint> _glMapBufferARB;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glUnmapBufferARB;

        public static void glBeginQueryARB(uint target, uint id) { _glBeginQueryARB(target, id); }
        public static void glBindBufferARB(uint target, uint buffer) { _glBindBufferARB(target, buffer); }
        public static void glBufferDataARB(uint target, nint size, nint data, uint usage) { _glBufferDataARB(target, size, data, usage); }
        public static void glBufferSubDataARB(uint target, nint offset, nint size, nint data) { _glBufferSubDataARB(target, offset, size, data); }
        public static void glDeleteBuffersARB(int n, nint buffers) { _glDeleteBuffersARB(n, buffers); }
        public static void glDeleteQueriesARB(int n, nint ids) { _glDeleteQueriesARB(n, ids); }
        public static void glEndQueryARB(uint target) { _glEndQueryARB(target); }
        public static void glGenBuffersARB(int n, nint buffers) { _glGenBuffersARB(n, buffers); }
        public static void glGenQueriesARB(int n, nint ids) { _glGenQueriesARB(n, ids); }
        public static void glGetBufferParameterivARB(uint target, uint pname, nint @params) { _glGetBufferParameterivARB(target, pname, @params); }
        public static void glGetBufferPointervARB(uint target, uint pname, nint @params) { _glGetBufferPointervARB(target, pname, @params); }
        public static void glGetBufferSubDataARB(uint target, nint offset, nint size, nint data) { _glGetBufferSubDataARB(target, offset, size, data); }
        public static void glGetQueryObjectivARB(uint id, uint pname, nint @params) { _glGetQueryObjectivARB(id, pname, @params); }
        public static void glGetQueryObjectuivARB(uint id, uint pname, nint @params) { _glGetQueryObjectuivARB(id, pname, @params); }
        public static void glGetQueryivARB(uint target, uint pname, nint @params) { _glGetQueryivARB(target, pname, @params); }
        public static bool glIsBufferARB(uint buffer) { return _glIsBufferARB(buffer); }
        public static bool glIsQueryARB(uint id) { return _glIsQueryARB(id); }
        public static nint glMapBufferARB(uint target, uint access) { return _glMapBufferARB(target, access); }
        public static bool glUnmapBufferARB(uint target) { return _glUnmapBufferARB(target); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBeginQueryARB = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBeginQueryARB");
            _glBindBufferARB = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBindBufferARB");
            _glBufferDataARB = (delegate* unmanaged[Stdcall]<uint, nint, nint, uint, void>)src.GetFuncPtr("glBufferDataARB");
            _glBufferSubDataARB = (delegate* unmanaged[Stdcall]<uint, nint, nint, nint, void>)src.GetFuncPtr("glBufferSubDataARB");
            _glDeleteBuffersARB = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteBuffersARB");
            _glDeleteQueriesARB = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteQueriesARB");
            _glEndQueryARB = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glEndQueryARB");
            _glGenBuffersARB = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenBuffersARB");
            _glGenQueriesARB = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenQueriesARB");
            _glGetBufferParameterivARB = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetBufferParameterivARB");
            _glGetBufferPointervARB = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetBufferPointervARB");
            _glGetBufferSubDataARB = (delegate* unmanaged[Stdcall]<uint, nint, nint, nint, void>)src.GetFuncPtr("glGetBufferSubDataARB");
            _glGetQueryObjectivARB = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetQueryObjectivARB");
            _glGetQueryObjectuivARB = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetQueryObjectuivARB");
            _glGetQueryivARB = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetQueryivARB");
            _glIsBufferARB = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsBufferARB");
            _glIsQueryARB = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsQueryARB");
            _glMapBufferARB = (delegate* unmanaged[Stdcall]<uint, uint, nint>)src.GetFuncPtr("glMapBufferARB");
            _glUnmapBufferARB = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glUnmapBufferARB");
        }

        internal static void Unload()
        {
            _glBeginQueryARB = null;
            _glBindBufferARB = null;
            _glBufferDataARB = null;
            _glBufferSubDataARB = null;
            _glDeleteBuffersARB = null;
            _glDeleteQueriesARB = null;
            _glEndQueryARB = null;
            _glGenBuffersARB = null;
            _glGenQueriesARB = null;
            _glGetBufferParameterivARB = null;
            _glGetBufferPointervARB = null;
            _glGetBufferSubDataARB = null;
            _glGetQueryObjectivARB = null;
            _glGetQueryObjectuivARB = null;
            _glGetQueryivARB = null;
            _glIsBufferARB = null;
            _glIsQueryARB = null;
            _glMapBufferARB = null;
            _glUnmapBufferARB = null;
        }
    }
}
