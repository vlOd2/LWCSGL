#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 2.1_PTR APIs
    /// </summary>
    public unsafe static class GL21_PTR
    {
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix2x3fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix2x4fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix3x2fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix3x4fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix4x2fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix4x3fv;

        public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value) { _glUniformMatrix2x3fv(location, count, transpose, value); }
        public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value) { _glUniformMatrix2x4fv(location, count, transpose, value); }
        public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value) { _glUniformMatrix3x2fv(location, count, transpose, value); }
        public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value) { _glUniformMatrix3x4fv(location, count, transpose, value); }
        public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value) { _glUniformMatrix4x2fv(location, count, transpose, value); }
        public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value) { _glUniformMatrix4x3fv(location, count, transpose, value); }

        internal static void Load(DelegatePtrSource src)
        {
            _glUniformMatrix2x3fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix2x3fv");
            _glUniformMatrix2x4fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix2x4fv");
            _glUniformMatrix3x2fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix3x2fv");
            _glUniformMatrix3x4fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix3x4fv");
            _glUniformMatrix4x2fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix4x2fv");
            _glUniformMatrix4x3fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix4x3fv");
        }

        internal static void Unload()
        {
            _glUniformMatrix2x3fv = null;
            _glUniformMatrix2x4fv = null;
            _glUniformMatrix3x2fv = null;
            _glUniformMatrix3x4fv = null;
            _glUniformMatrix4x2fv = null;
            _glUniformMatrix4x3fv = null;
        }
    }
}
