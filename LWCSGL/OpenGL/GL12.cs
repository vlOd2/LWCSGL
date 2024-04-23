#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 1.2 APIs
    /// </summary>
    public unsafe static class GL12
    {
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, int, void> _glCopyTexSubImage3D;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, int, uint, nint, void> _glDrawRangeElements;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, uint, uint, nint, void> _glTexImage3D;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, uint, uint, nint, void> _glTexSubImage3D;

        public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) { _glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height); }
        public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, nint indices) { _glDrawRangeElements(mode, start, end, count, type, indices); }
        public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels) { _glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels); }
        public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels) { _glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels); }

        internal static void Load(DelegatePtrSource src)
        {
            _glCopyTexSubImage3D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, int, void>)src.GetFuncPtr("glCopyTexSubImage3D");
            _glDrawRangeElements = (delegate* unmanaged[Stdcall]<uint, uint, uint, int, uint, nint, void>)src.GetFuncPtr("glDrawRangeElements");
            _glTexImage3D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, uint, uint, nint, void>)src.GetFuncPtr("glTexImage3D");
            _glTexSubImage3D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, uint, uint, nint, void>)src.GetFuncPtr("glTexSubImage3D");
        }

        internal static void Unload()
        {
            _glCopyTexSubImage3D = null;
            _glDrawRangeElements = null;
            _glTexImage3D = null;
            _glTexSubImage3D = null;
        }
    }
}
