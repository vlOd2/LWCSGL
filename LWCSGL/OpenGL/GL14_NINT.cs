#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 1.4_NINT APIs
    /// </summary>
    public unsafe static class GL14_NINT
    {
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glBlendColor;
        private static delegate* unmanaged[Stdcall]<uint, void> _glBlendEquation;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void> _glBlendFuncSeparate;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glFogCoordPointer;
        private static delegate* unmanaged[Stdcall]<double, void> _glFogCoordd;
        private static delegate* unmanaged[Stdcall]<nint, void> _glFogCoorddv;
        private static delegate* unmanaged[Stdcall]<float, void> _glFogCoordf;
        private static delegate* unmanaged[Stdcall]<nint, void> _glFogCoordfv;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, int, void> _glMultiDrawArrays;
        private static delegate* unmanaged[Stdcall]<uint, nint, uint, nint, int, void> _glMultiDrawElements;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glPointParameterf;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glPointParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glPointParameteri;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glPointParameteriv;
        private static delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void> _glSecondaryColor3b;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3bv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glSecondaryColor3d;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glSecondaryColor3f;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glSecondaryColor3i;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glSecondaryColor3s;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3sv;
        private static delegate* unmanaged[Stdcall]<byte, byte, byte, void> _glSecondaryColor3ub;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3ubv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glSecondaryColor3ui;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3uiv;
        private static delegate* unmanaged[Stdcall]<ushort, ushort, ushort, void> _glSecondaryColor3us;
        private static delegate* unmanaged[Stdcall]<nint, void> _glSecondaryColor3usv;
        private static delegate* unmanaged[Stdcall]<int, uint, int, nint, void> _glSecondaryColorPointer;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glWindowPos2d;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos2dv;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glWindowPos2f;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos2fv;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glWindowPos2i;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos2iv;
        private static delegate* unmanaged[Stdcall]<short, short, void> _glWindowPos2s;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos2sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glWindowPos3d;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glWindowPos3f;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glWindowPos3i;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glWindowPos3s;
        private static delegate* unmanaged[Stdcall]<nint, void> _glWindowPos3sv;

        public static void glBlendColor(float red, float green, float blue, float alpha) { _glBlendColor(red, green, blue, alpha); }
        public static void glBlendEquation(uint mode) { _glBlendEquation(mode); }
        public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) { _glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha); }
        public static void glFogCoordPointer(uint type, int stride, nint pointer) { _glFogCoordPointer(type, stride, pointer); }
        public static void glFogCoordd(double coord) { _glFogCoordd(coord); }
        public static void glFogCoorddv(nint coord) { _glFogCoorddv(coord); }
        public static void glFogCoordf(float coord) { _glFogCoordf(coord); }
        public static void glFogCoordfv(nint coord) { _glFogCoordfv(coord); }
        public static void glMultiDrawArrays(uint mode, nint first, nint count, int drawcount) { _glMultiDrawArrays(mode, first, count, drawcount); }
        public static void glMultiDrawElements(uint mode, nint count, uint type, nint indices, int drawcount) { _glMultiDrawElements(mode, count, type, indices, drawcount); }
        public static void glPointParameterf(uint pname, float param) { _glPointParameterf(pname, param); }
        public static void glPointParameterfv(uint pname, nint @params) { _glPointParameterfv(pname, @params); }
        public static void glPointParameteri(uint pname, int param) { _glPointParameteri(pname, param); }
        public static void glPointParameteriv(uint pname, nint @params) { _glPointParameteriv(pname, @params); }
        public static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) { _glSecondaryColor3b(red, green, blue); }
        public static void glSecondaryColor3bv(nint v) { _glSecondaryColor3bv(v); }
        public static void glSecondaryColor3d(double red, double green, double blue) { _glSecondaryColor3d(red, green, blue); }
        public static void glSecondaryColor3dv(nint v) { _glSecondaryColor3dv(v); }
        public static void glSecondaryColor3f(float red, float green, float blue) { _glSecondaryColor3f(red, green, blue); }
        public static void glSecondaryColor3fv(nint v) { _glSecondaryColor3fv(v); }
        public static void glSecondaryColor3i(int red, int green, int blue) { _glSecondaryColor3i(red, green, blue); }
        public static void glSecondaryColor3iv(nint v) { _glSecondaryColor3iv(v); }
        public static void glSecondaryColor3s(short red, short green, short blue) { _glSecondaryColor3s(red, green, blue); }
        public static void glSecondaryColor3sv(nint v) { _glSecondaryColor3sv(v); }
        public static void glSecondaryColor3ub(byte red, byte green, byte blue) { _glSecondaryColor3ub(red, green, blue); }
        public static void glSecondaryColor3ubv(nint v) { _glSecondaryColor3ubv(v); }
        public static void glSecondaryColor3ui(uint red, uint green, uint blue) { _glSecondaryColor3ui(red, green, blue); }
        public static void glSecondaryColor3uiv(nint v) { _glSecondaryColor3uiv(v); }
        public static void glSecondaryColor3us(ushort red, ushort green, ushort blue) { _glSecondaryColor3us(red, green, blue); }
        public static void glSecondaryColor3usv(nint v) { _glSecondaryColor3usv(v); }
        public static void glSecondaryColorPointer(int size, uint type, int stride, nint pointer) { _glSecondaryColorPointer(size, type, stride, pointer); }
        public static void glWindowPos2d(double x, double y) { _glWindowPos2d(x, y); }
        public static void glWindowPos2dv(nint v) { _glWindowPos2dv(v); }
        public static void glWindowPos2f(float x, float y) { _glWindowPos2f(x, y); }
        public static void glWindowPos2fv(nint v) { _glWindowPos2fv(v); }
        public static void glWindowPos2i(int x, int y) { _glWindowPos2i(x, y); }
        public static void glWindowPos2iv(nint v) { _glWindowPos2iv(v); }
        public static void glWindowPos2s(short x, short y) { _glWindowPos2s(x, y); }
        public static void glWindowPos2sv(nint v) { _glWindowPos2sv(v); }
        public static void glWindowPos3d(double x, double y, double z) { _glWindowPos3d(x, y, z); }
        public static void glWindowPos3dv(nint v) { _glWindowPos3dv(v); }
        public static void glWindowPos3f(float x, float y, float z) { _glWindowPos3f(x, y, z); }
        public static void glWindowPos3fv(nint v) { _glWindowPos3fv(v); }
        public static void glWindowPos3i(int x, int y, int z) { _glWindowPos3i(x, y, z); }
        public static void glWindowPos3iv(nint v) { _glWindowPos3iv(v); }
        public static void glWindowPos3s(short x, short y, short z) { _glWindowPos3s(x, y, z); }
        public static void glWindowPos3sv(nint v) { _glWindowPos3sv(v); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBlendColor = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glBlendColor");
            _glBlendEquation = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glBlendEquation");
            _glBlendFuncSeparate = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void>)src.GetFuncPtr("glBlendFuncSeparate");
            _glFogCoordPointer = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glFogCoordPointer");
            _glFogCoordd = (delegate* unmanaged[Stdcall]<double, void>)src.GetFuncPtr("glFogCoordd");
            _glFogCoorddv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glFogCoorddv");
            _glFogCoordf = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glFogCoordf");
            _glFogCoordfv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glFogCoordfv");
            _glMultiDrawArrays = (delegate* unmanaged[Stdcall]<uint, nint, nint, int, void>)src.GetFuncPtr("glMultiDrawArrays");
            _glMultiDrawElements = (delegate* unmanaged[Stdcall]<uint, nint, uint, nint, int, void>)src.GetFuncPtr("glMultiDrawElements");
            _glPointParameterf = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glPointParameterf");
            _glPointParameterfv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glPointParameterfv");
            _glPointParameteri = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glPointParameteri");
            _glPointParameteriv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glPointParameteriv");
            _glSecondaryColor3b = (delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void>)src.GetFuncPtr("glSecondaryColor3b");
            _glSecondaryColor3bv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3bv");
            _glSecondaryColor3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glSecondaryColor3d");
            _glSecondaryColor3dv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3dv");
            _glSecondaryColor3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glSecondaryColor3f");
            _glSecondaryColor3fv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3fv");
            _glSecondaryColor3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glSecondaryColor3i");
            _glSecondaryColor3iv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3iv");
            _glSecondaryColor3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glSecondaryColor3s");
            _glSecondaryColor3sv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3sv");
            _glSecondaryColor3ub = (delegate* unmanaged[Stdcall]<byte, byte, byte, void>)src.GetFuncPtr("glSecondaryColor3ub");
            _glSecondaryColor3ubv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3ubv");
            _glSecondaryColor3ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glSecondaryColor3ui");
            _glSecondaryColor3uiv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3uiv");
            _glSecondaryColor3us = (delegate* unmanaged[Stdcall]<ushort, ushort, ushort, void>)src.GetFuncPtr("glSecondaryColor3us");
            _glSecondaryColor3usv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glSecondaryColor3usv");
            _glSecondaryColorPointer = (delegate* unmanaged[Stdcall]<int, uint, int, nint, void>)src.GetFuncPtr("glSecondaryColorPointer");
            _glWindowPos2d = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glWindowPos2d");
            _glWindowPos2dv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos2dv");
            _glWindowPos2f = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glWindowPos2f");
            _glWindowPos2fv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos2fv");
            _glWindowPos2i = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glWindowPos2i");
            _glWindowPos2iv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos2iv");
            _glWindowPos2s = (delegate* unmanaged[Stdcall]<short, short, void>)src.GetFuncPtr("glWindowPos2s");
            _glWindowPos2sv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos2sv");
            _glWindowPos3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glWindowPos3d");
            _glWindowPos3dv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos3dv");
            _glWindowPos3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glWindowPos3f");
            _glWindowPos3fv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos3fv");
            _glWindowPos3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glWindowPos3i");
            _glWindowPos3iv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos3iv");
            _glWindowPos3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glWindowPos3s");
            _glWindowPos3sv = (delegate* unmanaged[Stdcall]<nint, void>)src.GetFuncPtr("glWindowPos3sv");
        }

        internal static void Unload()
        {
            _glBlendColor = null;
            _glBlendEquation = null;
            _glBlendFuncSeparate = null;
            _glFogCoordPointer = null;
            _glFogCoordd = null;
            _glFogCoorddv = null;
            _glFogCoordf = null;
            _glFogCoordfv = null;
            _glMultiDrawArrays = null;
            _glMultiDrawElements = null;
            _glPointParameterf = null;
            _glPointParameterfv = null;
            _glPointParameteri = null;
            _glPointParameteriv = null;
            _glSecondaryColor3b = null;
            _glSecondaryColor3bv = null;
            _glSecondaryColor3d = null;
            _glSecondaryColor3dv = null;
            _glSecondaryColor3f = null;
            _glSecondaryColor3fv = null;
            _glSecondaryColor3i = null;
            _glSecondaryColor3iv = null;
            _glSecondaryColor3s = null;
            _glSecondaryColor3sv = null;
            _glSecondaryColor3ub = null;
            _glSecondaryColor3ubv = null;
            _glSecondaryColor3ui = null;
            _glSecondaryColor3uiv = null;
            _glSecondaryColor3us = null;
            _glSecondaryColor3usv = null;
            _glSecondaryColorPointer = null;
            _glWindowPos2d = null;
            _glWindowPos2dv = null;
            _glWindowPos2f = null;
            _glWindowPos2fv = null;
            _glWindowPos2i = null;
            _glWindowPos2iv = null;
            _glWindowPos2s = null;
            _glWindowPos2sv = null;
            _glWindowPos3d = null;
            _glWindowPos3dv = null;
            _glWindowPos3f = null;
            _glWindowPos3fv = null;
            _glWindowPos3i = null;
            _glWindowPos3iv = null;
            _glWindowPos3s = null;
            _glWindowPos3sv = null;
        }
    }
}
