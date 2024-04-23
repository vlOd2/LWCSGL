#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 3.3_NINT APIs
    /// </summary>
    public unsafe static class GL33_NINT
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void> _glBindFragDataLocationIndexed;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBindSampler;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glColorP3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glColorP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glColorP4ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glColorP4uiv;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteSamplers;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenSamplers;
        private static delegate* unmanaged[Stdcall]<uint, nint, int> _glGetFragDataIndex;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetQueryObjecti64v;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetQueryObjectui64v;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetSamplerParameterIiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetSamplerParameterIuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetSamplerParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetSamplerParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsSampler;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glMultiTexCoordP1ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glMultiTexCoordP1uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glMultiTexCoordP2ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glMultiTexCoordP2uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glMultiTexCoordP3ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glMultiTexCoordP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glMultiTexCoordP4ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glMultiTexCoordP4uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glNormalP3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glNormalP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glQueryCounter;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glSamplerParameterIiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glSamplerParameterIuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glSamplerParameterf;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glSamplerParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glSamplerParameteri;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glSamplerParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glSecondaryColorP3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glSecondaryColorP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glTexCoordP1ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glTexCoordP1uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glTexCoordP2ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glTexCoordP2uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glTexCoordP3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glTexCoordP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glTexCoordP4ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glTexCoordP4uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glVertexAttribDivisor;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void> _glVertexAttribP1ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void> _glVertexAttribP1uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void> _glVertexAttribP2ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void> _glVertexAttribP2uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void> _glVertexAttribP3ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void> _glVertexAttribP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void> _glVertexAttribP4ui;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void> _glVertexAttribP4uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glVertexP2ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexP2uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glVertexP3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexP3uiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glVertexP4ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexP4uiv;

        public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, nint name) { _glBindFragDataLocationIndexed(program, colorNumber, index, name); }
        public static void glBindSampler(uint unit, uint sampler) { _glBindSampler(unit, sampler); }
        public static void glColorP3ui(uint type, uint color) { _glColorP3ui(type, color); }
        public static void glColorP3uiv(uint type, nint color) { _glColorP3uiv(type, color); }
        public static void glColorP4ui(uint type, uint color) { _glColorP4ui(type, color); }
        public static void glColorP4uiv(uint type, nint color) { _glColorP4uiv(type, color); }
        public static void glDeleteSamplers(int count, nint samplers) { _glDeleteSamplers(count, samplers); }
        public static void glGenSamplers(int count, nint samplers) { _glGenSamplers(count, samplers); }
        public static int glGetFragDataIndex(uint program, nint name) { return _glGetFragDataIndex(program, name); }
        public static void glGetQueryObjecti64v(uint id, uint pname, nint @params) { _glGetQueryObjecti64v(id, pname, @params); }
        public static void glGetQueryObjectui64v(uint id, uint pname, nint @params) { _glGetQueryObjectui64v(id, pname, @params); }
        public static void glGetSamplerParameterIiv(uint sampler, uint pname, nint @params) { _glGetSamplerParameterIiv(sampler, pname, @params); }
        public static void glGetSamplerParameterIuiv(uint sampler, uint pname, nint @params) { _glGetSamplerParameterIuiv(sampler, pname, @params); }
        public static void glGetSamplerParameterfv(uint sampler, uint pname, nint @params) { _glGetSamplerParameterfv(sampler, pname, @params); }
        public static void glGetSamplerParameteriv(uint sampler, uint pname, nint @params) { _glGetSamplerParameteriv(sampler, pname, @params); }
        public static bool glIsSampler(uint sampler) { return _glIsSampler(sampler); }
        public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords) { _glMultiTexCoordP1ui(texture, type, coords); }
        public static void glMultiTexCoordP1uiv(uint texture, uint type, nint coords) { _glMultiTexCoordP1uiv(texture, type, coords); }
        public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords) { _glMultiTexCoordP2ui(texture, type, coords); }
        public static void glMultiTexCoordP2uiv(uint texture, uint type, nint coords) { _glMultiTexCoordP2uiv(texture, type, coords); }
        public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords) { _glMultiTexCoordP3ui(texture, type, coords); }
        public static void glMultiTexCoordP3uiv(uint texture, uint type, nint coords) { _glMultiTexCoordP3uiv(texture, type, coords); }
        public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords) { _glMultiTexCoordP4ui(texture, type, coords); }
        public static void glMultiTexCoordP4uiv(uint texture, uint type, nint coords) { _glMultiTexCoordP4uiv(texture, type, coords); }
        public static void glNormalP3ui(uint type, uint coords) { _glNormalP3ui(type, coords); }
        public static void glNormalP3uiv(uint type, nint coords) { _glNormalP3uiv(type, coords); }
        public static void glQueryCounter(uint id, uint target) { _glQueryCounter(id, target); }
        public static void glSamplerParameterIiv(uint sampler, uint pname, nint param) { _glSamplerParameterIiv(sampler, pname, param); }
        public static void glSamplerParameterIuiv(uint sampler, uint pname, nint param) { _glSamplerParameterIuiv(sampler, pname, param); }
        public static void glSamplerParameterf(uint sampler, uint pname, float param) { _glSamplerParameterf(sampler, pname, param); }
        public static void glSamplerParameterfv(uint sampler, uint pname, nint param) { _glSamplerParameterfv(sampler, pname, param); }
        public static void glSamplerParameteri(uint sampler, uint pname, int param) { _glSamplerParameteri(sampler, pname, param); }
        public static void glSamplerParameteriv(uint sampler, uint pname, nint param) { _glSamplerParameteriv(sampler, pname, param); }
        public static void glSecondaryColorP3ui(uint type, uint color) { _glSecondaryColorP3ui(type, color); }
        public static void glSecondaryColorP3uiv(uint type, nint color) { _glSecondaryColorP3uiv(type, color); }
        public static void glTexCoordP1ui(uint type, uint coords) { _glTexCoordP1ui(type, coords); }
        public static void glTexCoordP1uiv(uint type, nint coords) { _glTexCoordP1uiv(type, coords); }
        public static void glTexCoordP2ui(uint type, uint coords) { _glTexCoordP2ui(type, coords); }
        public static void glTexCoordP2uiv(uint type, nint coords) { _glTexCoordP2uiv(type, coords); }
        public static void glTexCoordP3ui(uint type, uint coords) { _glTexCoordP3ui(type, coords); }
        public static void glTexCoordP3uiv(uint type, nint coords) { _glTexCoordP3uiv(type, coords); }
        public static void glTexCoordP4ui(uint type, uint coords) { _glTexCoordP4ui(type, coords); }
        public static void glTexCoordP4uiv(uint type, nint coords) { _glTexCoordP4uiv(type, coords); }
        public static void glVertexAttribDivisor(uint index, uint divisor) { _glVertexAttribDivisor(index, divisor); }
        public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) { _glVertexAttribP1ui(index, type, normalized, value); }
        public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, nint value) { _glVertexAttribP1uiv(index, type, normalized, value); }
        public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) { _glVertexAttribP2ui(index, type, normalized, value); }
        public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, nint value) { _glVertexAttribP2uiv(index, type, normalized, value); }
        public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) { _glVertexAttribP3ui(index, type, normalized, value); }
        public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, nint value) { _glVertexAttribP3uiv(index, type, normalized, value); }
        public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) { _glVertexAttribP4ui(index, type, normalized, value); }
        public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, nint value) { _glVertexAttribP4uiv(index, type, normalized, value); }
        public static void glVertexP2ui(uint type, uint value) { _glVertexP2ui(type, value); }
        public static void glVertexP2uiv(uint type, nint value) { _glVertexP2uiv(type, value); }
        public static void glVertexP3ui(uint type, uint value) { _glVertexP3ui(type, value); }
        public static void glVertexP3uiv(uint type, nint value) { _glVertexP3uiv(type, value); }
        public static void glVertexP4ui(uint type, uint value) { _glVertexP4ui(type, value); }
        public static void glVertexP4uiv(uint type, nint value) { _glVertexP4uiv(type, value); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBindFragDataLocationIndexed = (delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void>)src.GetFuncPtr("glBindFragDataLocationIndexed");
            _glBindSampler = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBindSampler");
            _glColorP3ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glColorP3ui");
            _glColorP3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glColorP3uiv");
            _glColorP4ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glColorP4ui");
            _glColorP4uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glColorP4uiv");
            _glDeleteSamplers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteSamplers");
            _glGenSamplers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenSamplers");
            _glGetFragDataIndex = (delegate* unmanaged[Stdcall]<uint, nint, int>)src.GetFuncPtr("glGetFragDataIndex");
            _glGetQueryObjecti64v = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetQueryObjecti64v");
            _glGetQueryObjectui64v = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetQueryObjectui64v");
            _glGetSamplerParameterIiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetSamplerParameterIiv");
            _glGetSamplerParameterIuiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetSamplerParameterIuiv");
            _glGetSamplerParameterfv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetSamplerParameterfv");
            _glGetSamplerParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetSamplerParameteriv");
            _glIsSampler = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsSampler");
            _glMultiTexCoordP1ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glMultiTexCoordP1ui");
            _glMultiTexCoordP1uiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glMultiTexCoordP1uiv");
            _glMultiTexCoordP2ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glMultiTexCoordP2ui");
            _glMultiTexCoordP2uiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glMultiTexCoordP2uiv");
            _glMultiTexCoordP3ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glMultiTexCoordP3ui");
            _glMultiTexCoordP3uiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glMultiTexCoordP3uiv");
            _glMultiTexCoordP4ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glMultiTexCoordP4ui");
            _glMultiTexCoordP4uiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glMultiTexCoordP4uiv");
            _glNormalP3ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glNormalP3ui");
            _glNormalP3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glNormalP3uiv");
            _glQueryCounter = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glQueryCounter");
            _glSamplerParameterIiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glSamplerParameterIiv");
            _glSamplerParameterIuiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glSamplerParameterIuiv");
            _glSamplerParameterf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glSamplerParameterf");
            _glSamplerParameterfv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glSamplerParameterfv");
            _glSamplerParameteri = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glSamplerParameteri");
            _glSamplerParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glSamplerParameteriv");
            _glSecondaryColorP3ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glSecondaryColorP3ui");
            _glSecondaryColorP3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glSecondaryColorP3uiv");
            _glTexCoordP1ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glTexCoordP1ui");
            _glTexCoordP1uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glTexCoordP1uiv");
            _glTexCoordP2ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glTexCoordP2ui");
            _glTexCoordP2uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glTexCoordP2uiv");
            _glTexCoordP3ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glTexCoordP3ui");
            _glTexCoordP3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glTexCoordP3uiv");
            _glTexCoordP4ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glTexCoordP4ui");
            _glTexCoordP4uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glTexCoordP4uiv");
            _glVertexAttribDivisor = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glVertexAttribDivisor");
            _glVertexAttribP1ui = (delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void>)src.GetFuncPtr("glVertexAttribP1ui");
            _glVertexAttribP1uiv = (delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void>)src.GetFuncPtr("glVertexAttribP1uiv");
            _glVertexAttribP2ui = (delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void>)src.GetFuncPtr("glVertexAttribP2ui");
            _glVertexAttribP2uiv = (delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void>)src.GetFuncPtr("glVertexAttribP2uiv");
            _glVertexAttribP3ui = (delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void>)src.GetFuncPtr("glVertexAttribP3ui");
            _glVertexAttribP3uiv = (delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void>)src.GetFuncPtr("glVertexAttribP3uiv");
            _glVertexAttribP4ui = (delegate* unmanaged[Stdcall]<uint, uint, bool, uint, void>)src.GetFuncPtr("glVertexAttribP4ui");
            _glVertexAttribP4uiv = (delegate* unmanaged[Stdcall]<uint, uint, bool, nint, void>)src.GetFuncPtr("glVertexAttribP4uiv");
            _glVertexP2ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glVertexP2ui");
            _glVertexP2uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexP2uiv");
            _glVertexP3ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glVertexP3ui");
            _glVertexP3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexP3uiv");
            _glVertexP4ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glVertexP4ui");
            _glVertexP4uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexP4uiv");
        }

        internal static void Unload()
        {
            _glBindFragDataLocationIndexed = null;
            _glBindSampler = null;
            _glColorP3ui = null;
            _glColorP3uiv = null;
            _glColorP4ui = null;
            _glColorP4uiv = null;
            _glDeleteSamplers = null;
            _glGenSamplers = null;
            _glGetFragDataIndex = null;
            _glGetQueryObjecti64v = null;
            _glGetQueryObjectui64v = null;
            _glGetSamplerParameterIiv = null;
            _glGetSamplerParameterIuiv = null;
            _glGetSamplerParameterfv = null;
            _glGetSamplerParameteriv = null;
            _glIsSampler = null;
            _glMultiTexCoordP1ui = null;
            _glMultiTexCoordP1uiv = null;
            _glMultiTexCoordP2ui = null;
            _glMultiTexCoordP2uiv = null;
            _glMultiTexCoordP3ui = null;
            _glMultiTexCoordP3uiv = null;
            _glMultiTexCoordP4ui = null;
            _glMultiTexCoordP4uiv = null;
            _glNormalP3ui = null;
            _glNormalP3uiv = null;
            _glQueryCounter = null;
            _glSamplerParameterIiv = null;
            _glSamplerParameterIuiv = null;
            _glSamplerParameterf = null;
            _glSamplerParameterfv = null;
            _glSamplerParameteri = null;
            _glSamplerParameteriv = null;
            _glSecondaryColorP3ui = null;
            _glSecondaryColorP3uiv = null;
            _glTexCoordP1ui = null;
            _glTexCoordP1uiv = null;
            _glTexCoordP2ui = null;
            _glTexCoordP2uiv = null;
            _glTexCoordP3ui = null;
            _glTexCoordP3uiv = null;
            _glTexCoordP4ui = null;
            _glTexCoordP4uiv = null;
            _glVertexAttribDivisor = null;
            _glVertexAttribP1ui = null;
            _glVertexAttribP1uiv = null;
            _glVertexAttribP2ui = null;
            _glVertexAttribP2uiv = null;
            _glVertexAttribP3ui = null;
            _glVertexAttribP3uiv = null;
            _glVertexAttribP4ui = null;
            _glVertexAttribP4uiv = null;
            _glVertexP2ui = null;
            _glVertexP2uiv = null;
            _glVertexP3ui = null;
            _glVertexP3uiv = null;
            _glVertexP4ui = null;
            _glVertexP4uiv = null;
        }
    }
}
