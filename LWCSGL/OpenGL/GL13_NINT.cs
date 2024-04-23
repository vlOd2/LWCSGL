#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 1.3_NINT APIs
    /// </summary>
    public unsafe static class GL13_NINT
    {
        private static delegate* unmanaged[Stdcall]<uint, void> _glActiveTexture;
        private static delegate* unmanaged[Stdcall]<uint, void> _glClientActiveTexture;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, nint, void> _glCompressedTexImage1D;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, int, nint, void> _glCompressedTexImage2D;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, int, int, nint, void> _glCompressedTexImage3D;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, uint, int, nint, void> _glCompressedTexSubImage1D;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, uint, int, nint, void> _glCompressedTexSubImage2D;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, uint, int, nint, void> _glCompressedTexSubImage3D;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glGetCompressedTexImage;
        private static delegate* unmanaged[Stdcall]<nint, void> _glLoadTransposeMatrixd;
        private static delegate* unmanaged[Stdcall]<nint, void> _glLoadTransposeMatrixf;
        private static delegate* unmanaged[Stdcall]<nint, void> _glMultTransposeMatrixd;
        private static delegate* unmanaged[Stdcall]<nint, void> _glMultTransposeMatrixf;
        private static delegate* unmanaged[Stdcall]<uint, double, void> _glMultiTexCoord1d;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord1dv;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glMultiTexCoord1f;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord1fv;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glMultiTexCoord1i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord1iv;
        private static delegate* unmanaged[Stdcall]<uint, short, void> _glMultiTexCoord1s;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord1sv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, void> _glMultiTexCoord2d;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord2dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, void> _glMultiTexCoord2f;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord2fv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, void> _glMultiTexCoord2i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord2iv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, void> _glMultiTexCoord2s;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord2sv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, double, void> _glMultiTexCoord3d;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord3dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, float, void> _glMultiTexCoord3f;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord3fv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, void> _glMultiTexCoord3i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord3iv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, short, void> _glMultiTexCoord3s;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord3sv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, double, double, void> _glMultiTexCoord4d;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord4dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, float, float, void> _glMultiTexCoord4f;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord4fv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, void> _glMultiTexCoord4i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord4iv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, short, short, void> _glMultiTexCoord4s;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glMultiTexCoord4sv;
        private static delegate* unmanaged[Stdcall]<float, bool, void> _glSampleCoverage;

        public static void glActiveTexture(uint texture) { _glActiveTexture(texture); }
        public static void glClientActiveTexture(uint texture) { _glClientActiveTexture(texture); }
        public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, nint data) { _glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data); }
        public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint data) { _glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data); }
        public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data) { _glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data); }
        public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, nint data) { _glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data); }
        public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data) { _glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data); }
        public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data) { _glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data); }
        public static void glGetCompressedTexImage(uint target, int level, nint img) { _glGetCompressedTexImage(target, level, img); }
        public static void glLoadTransposeMatrixd(nint m) { _glLoadTransposeMatrixd(m); }
        public static void glLoadTransposeMatrixf(nint m) { _glLoadTransposeMatrixf(m); }
        public static void glMultTransposeMatrixd(nint m) { _glMultTransposeMatrixd(m); }
        public static void glMultTransposeMatrixf(nint m) { _glMultTransposeMatrixf(m); }
        public static void glMultiTexCoord1d(uint target, double s) { _glMultiTexCoord1d(target, s); }
        public static void glMultiTexCoord1dv(uint target, nint v) { _glMultiTexCoord1dv(target, v); }
        public static void glMultiTexCoord1f(uint target, float s) { _glMultiTexCoord1f(target, s); }
        public static void glMultiTexCoord1fv(uint target, nint v) { _glMultiTexCoord1fv(target, v); }
        public static void glMultiTexCoord1i(uint target, int s) { _glMultiTexCoord1i(target, s); }
        public static void glMultiTexCoord1iv(uint target, nint v) { _glMultiTexCoord1iv(target, v); }
        public static void glMultiTexCoord1s(uint target, short s) { _glMultiTexCoord1s(target, s); }
        public static void glMultiTexCoord1sv(uint target, nint v) { _glMultiTexCoord1sv(target, v); }
        public static void glMultiTexCoord2d(uint target, double s, double t) { _glMultiTexCoord2d(target, s, t); }
        public static void glMultiTexCoord2dv(uint target, nint v) { _glMultiTexCoord2dv(target, v); }
        public static void glMultiTexCoord2f(uint target, float s, float t) { _glMultiTexCoord2f(target, s, t); }
        public static void glMultiTexCoord2fv(uint target, nint v) { _glMultiTexCoord2fv(target, v); }
        public static void glMultiTexCoord2i(uint target, int s, int t) { _glMultiTexCoord2i(target, s, t); }
        public static void glMultiTexCoord2iv(uint target, nint v) { _glMultiTexCoord2iv(target, v); }
        public static void glMultiTexCoord2s(uint target, short s, short t) { _glMultiTexCoord2s(target, s, t); }
        public static void glMultiTexCoord2sv(uint target, nint v) { _glMultiTexCoord2sv(target, v); }
        public static void glMultiTexCoord3d(uint target, double s, double t, double r) { _glMultiTexCoord3d(target, s, t, r); }
        public static void glMultiTexCoord3dv(uint target, nint v) { _glMultiTexCoord3dv(target, v); }
        public static void glMultiTexCoord3f(uint target, float s, float t, float r) { _glMultiTexCoord3f(target, s, t, r); }
        public static void glMultiTexCoord3fv(uint target, nint v) { _glMultiTexCoord3fv(target, v); }
        public static void glMultiTexCoord3i(uint target, int s, int t, int r) { _glMultiTexCoord3i(target, s, t, r); }
        public static void glMultiTexCoord3iv(uint target, nint v) { _glMultiTexCoord3iv(target, v); }
        public static void glMultiTexCoord3s(uint target, short s, short t, short r) { _glMultiTexCoord3s(target, s, t, r); }
        public static void glMultiTexCoord3sv(uint target, nint v) { _glMultiTexCoord3sv(target, v); }
        public static void glMultiTexCoord4d(uint target, double s, double t, double r, double q) { _glMultiTexCoord4d(target, s, t, r, q); }
        public static void glMultiTexCoord4dv(uint target, nint v) { _glMultiTexCoord4dv(target, v); }
        public static void glMultiTexCoord4f(uint target, float s, float t, float r, float q) { _glMultiTexCoord4f(target, s, t, r, q); }
        public static void glMultiTexCoord4fv(uint target, nint v) { _glMultiTexCoord4fv(target, v); }
        public static void glMultiTexCoord4i(uint target, int s, int t, int r, int q) { _glMultiTexCoord4i(target, s, t, r, q); }
        public static void glMultiTexCoord4iv(uint target, nint v) { _glMultiTexCoord4iv(target, v); }
        public static void glMultiTexCoord4s(uint target, short s, short t, short r, short q) { _glMultiTexCoord4s(target, s, t, r, q); }
        public static void glMultiTexCoord4sv(uint target, nint v) { _glMultiTexCoord4sv(target, v); }
        public static void glSampleCoverage(float value, bool invert) { _glSampleCoverage(value, invert); }

        internal static void Load(DelegatePtrSource src)
        {
            _glActiveTexture = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glActiveTexture");
            _glClientActiveTexture = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glClientActiveTexture");
            _glCompressedTexImage1D = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, nint, void>)src.GetFuncPtr("glCompressedTexImage1D");
            _glCompressedTexImage2D = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, int, nint, void>)src.GetFuncPtr("glCompressedTexImage2D");
            _glCompressedTexImage3D = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, int, int, int, nint, void>)src.GetFuncPtr("glCompressedTexImage3D");
            _glCompressedTexSubImage1D = (delegate* unmanaged[Stdcall]<uint, int, int, int, uint, int, nint, void>)src.GetFuncPtr("glCompressedTexSubImage1D");
            _glCompressedTexSubImage2D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, uint, int, nint, void>)src.GetFuncPtr("glCompressedTexSubImage2D");
            _glCompressedTexSubImage3D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, int, int, uint, int, nint, void>)src.GetFuncPtr("glCompressedTexSubImage3D");
            _glGetCompressedTexImage = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glGetCompressedTexImage");
            _glLoadTransposeMatrixd = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glLoadTransposeMatrixd");
            _glLoadTransposeMatrixf = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glLoadTransposeMatrixf");
            _glMultTransposeMatrixd = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glMultTransposeMatrixd");
            _glMultTransposeMatrixf = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glMultTransposeMatrixf");
            _glMultiTexCoord1d = (delegate* unmanaged[Stdcall]<uint, double, void>)src.GetFuncPtr("glMultiTexCoord1d");
            _glMultiTexCoord1dv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord1dv");
            _glMultiTexCoord1f = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glMultiTexCoord1f");
            _glMultiTexCoord1fv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord1fv");
            _glMultiTexCoord1i = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glMultiTexCoord1i");
            _glMultiTexCoord1iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord1iv");
            _glMultiTexCoord1s = (delegate* unmanaged[Stdcall]<uint, short, void>)src.GetFuncPtr("glMultiTexCoord1s");
            _glMultiTexCoord1sv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord1sv");
            _glMultiTexCoord2d = (delegate* unmanaged[Stdcall]<uint, double, double, void>)src.GetFuncPtr("glMultiTexCoord2d");
            _glMultiTexCoord2dv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord2dv");
            _glMultiTexCoord2f = (delegate* unmanaged[Stdcall]<uint, float, float, void>)src.GetFuncPtr("glMultiTexCoord2f");
            _glMultiTexCoord2fv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord2fv");
            _glMultiTexCoord2i = (delegate* unmanaged[Stdcall]<uint, int, int, void>)src.GetFuncPtr("glMultiTexCoord2i");
            _glMultiTexCoord2iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord2iv");
            _glMultiTexCoord2s = (delegate* unmanaged[Stdcall]<uint, short, short, void>)src.GetFuncPtr("glMultiTexCoord2s");
            _glMultiTexCoord2sv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord2sv");
            _glMultiTexCoord3d = (delegate* unmanaged[Stdcall]<uint, double, double, double, void>)src.GetFuncPtr("glMultiTexCoord3d");
            _glMultiTexCoord3dv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord3dv");
            _glMultiTexCoord3f = (delegate* unmanaged[Stdcall]<uint, float, float, float, void>)src.GetFuncPtr("glMultiTexCoord3f");
            _glMultiTexCoord3fv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord3fv");
            _glMultiTexCoord3i = (delegate* unmanaged[Stdcall]<uint, int, int, int, void>)src.GetFuncPtr("glMultiTexCoord3i");
            _glMultiTexCoord3iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord3iv");
            _glMultiTexCoord3s = (delegate* unmanaged[Stdcall]<uint, short, short, short, void>)src.GetFuncPtr("glMultiTexCoord3s");
            _glMultiTexCoord3sv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord3sv");
            _glMultiTexCoord4d = (delegate* unmanaged[Stdcall]<uint, double, double, double, double, void>)src.GetFuncPtr("glMultiTexCoord4d");
            _glMultiTexCoord4dv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord4dv");
            _glMultiTexCoord4f = (delegate* unmanaged[Stdcall]<uint, float, float, float, float, void>)src.GetFuncPtr("glMultiTexCoord4f");
            _glMultiTexCoord4fv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord4fv");
            _glMultiTexCoord4i = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, void>)src.GetFuncPtr("glMultiTexCoord4i");
            _glMultiTexCoord4iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord4iv");
            _glMultiTexCoord4s = (delegate* unmanaged[Stdcall]<uint, short, short, short, short, void>)src.GetFuncPtr("glMultiTexCoord4s");
            _glMultiTexCoord4sv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glMultiTexCoord4sv");
            _glSampleCoverage = (delegate* unmanaged[Stdcall]<float, bool, void>)src.GetFuncPtr("glSampleCoverage");
        }

        internal static void Unload()
        {
            _glActiveTexture = null;
            _glClientActiveTexture = null;
            _glCompressedTexImage1D = null;
            _glCompressedTexImage2D = null;
            _glCompressedTexImage3D = null;
            _glCompressedTexSubImage1D = null;
            _glCompressedTexSubImage2D = null;
            _glCompressedTexSubImage3D = null;
            _glGetCompressedTexImage = null;
            _glLoadTransposeMatrixd = null;
            _glLoadTransposeMatrixf = null;
            _glMultTransposeMatrixd = null;
            _glMultTransposeMatrixf = null;
            _glMultiTexCoord1d = null;
            _glMultiTexCoord1dv = null;
            _glMultiTexCoord1f = null;
            _glMultiTexCoord1fv = null;
            _glMultiTexCoord1i = null;
            _glMultiTexCoord1iv = null;
            _glMultiTexCoord1s = null;
            _glMultiTexCoord1sv = null;
            _glMultiTexCoord2d = null;
            _glMultiTexCoord2dv = null;
            _glMultiTexCoord2f = null;
            _glMultiTexCoord2fv = null;
            _glMultiTexCoord2i = null;
            _glMultiTexCoord2iv = null;
            _glMultiTexCoord2s = null;
            _glMultiTexCoord2sv = null;
            _glMultiTexCoord3d = null;
            _glMultiTexCoord3dv = null;
            _glMultiTexCoord3f = null;
            _glMultiTexCoord3fv = null;
            _glMultiTexCoord3i = null;
            _glMultiTexCoord3iv = null;
            _glMultiTexCoord3s = null;
            _glMultiTexCoord3sv = null;
            _glMultiTexCoord4d = null;
            _glMultiTexCoord4dv = null;
            _glMultiTexCoord4f = null;
            _glMultiTexCoord4fv = null;
            _glMultiTexCoord4i = null;
            _glMultiTexCoord4iv = null;
            _glMultiTexCoord4s = null;
            _glMultiTexCoord4sv = null;
            _glSampleCoverage = null;
        }
    }
}
