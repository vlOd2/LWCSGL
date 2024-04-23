#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 3.0_NINT APIs
    /// </summary>
    public unsafe static class GL30_NINT
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBeginConditionalRender;
        private static delegate* unmanaged[Stdcall]<uint, void> _glBeginTransformFeedback;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glBindBufferBase;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, nint, nint, void> _glBindBufferRange;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glBindFragDataLocation;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBindFramebuffer;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBindRenderbuffer;
        private static delegate* unmanaged[Stdcall]<uint, void> _glBindVertexArray;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, int, int, int, int, uint, uint, void> _glBlitFramebuffer;
        private static delegate* unmanaged[Stdcall]<uint, uint> _glCheckFramebufferStatus;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glClampColor;
        private static delegate* unmanaged[Stdcall]<uint, int, float, int, void> _glClearBufferfi;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glClearBufferfv;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glClearBufferiv;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glClearBufferuiv;
        private static delegate* unmanaged[Stdcall]<uint, bool, bool, bool, bool, void> _glColorMaski;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteFramebuffers;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteRenderbuffers;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glDeleteVertexArrays;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glDisablei;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glEnablei;
        private static delegate* unmanaged[Stdcall]<void> _glEndConditionalRender;
        private static delegate* unmanaged[Stdcall]<void> _glEndTransformFeedback;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, void> _glFlushMappedBufferRange;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void> _glFramebufferRenderbuffer;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, void> _glFramebufferTexture1D;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, void> _glFramebufferTexture2D;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, int, void> _glFramebufferTexture3D;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, int, int, void> _glFramebufferTextureLayer;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenFramebuffers;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenRenderbuffers;
        private static delegate* unmanaged[Stdcall]<int, nint, void> _glGenVertexArrays;
        private static delegate* unmanaged[Stdcall]<uint, void> _glGenerateMipmap;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetBooleani_v;
        private static delegate* unmanaged[Stdcall]<uint, nint, int> _glGetFragDataLocation;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void> _glGetFramebufferAttachmentParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetIntegeri_v;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetRenderbufferParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint> _glGetStringi;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetTexParameterIiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetTexParameterIuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, nint, nint, void> _glGetTransformFeedbackVarying;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, void> _glGetUniformuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetVertexAttribIiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetVertexAttribIuiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, bool> _glIsEnabledi;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsFramebuffer;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsRenderbuffer;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsVertexArray;
        private static delegate* unmanaged[Stdcall]<uint, nint, nint, uint, nint> _glMapBufferRange;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, int, void> _glRenderbufferStorage;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, int, void> _glRenderbufferStorageMultisample;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glTexParameterIiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glTexParameterIuiv;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, uint, void> _glTransformFeedbackVaryings;
        private static delegate* unmanaged[Stdcall]<int, uint, void> _glUniform1ui;
        private static delegate* unmanaged[Stdcall]<int, int, nint, void> _glUniform1uiv;
        private static delegate* unmanaged[Stdcall]<int, uint, uint, void> _glUniform2ui;
        private static delegate* unmanaged[Stdcall]<int, int, nint, void> _glUniform2uiv;
        private static delegate* unmanaged[Stdcall]<int, uint, uint, uint, void> _glUniform3ui;
        private static delegate* unmanaged[Stdcall]<int, int, nint, void> _glUniform3uiv;
        private static delegate* unmanaged[Stdcall]<int, uint, uint, uint, uint, void> _glUniform4ui;
        private static delegate* unmanaged[Stdcall]<int, int, nint, void> _glUniform4uiv;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glVertexAttribI1i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI1iv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glVertexAttribI1ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI1uiv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, void> _glVertexAttribI2i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI2iv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glVertexAttribI2ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI2uiv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, void> _glVertexAttribI3i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI3iv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void> _glVertexAttribI3ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI3uiv;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4bv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, void> _glVertexAttribI4i;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4iv;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4sv;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4ubv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, uint, void> _glVertexAttribI4ui;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4uiv;
        private static delegate* unmanaged[Stdcall]<uint, nint, void> _glVertexAttribI4usv;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int, nint, void> _glVertexAttribIPointer;

        public static void glBeginConditionalRender(uint id, uint mode) { _glBeginConditionalRender(id, mode); }
        public static void glBeginTransformFeedback(uint primitiveMode) { _glBeginTransformFeedback(primitiveMode); }
        public static void glBindBufferBase(uint target, uint index, uint buffer) { _glBindBufferBase(target, index, buffer); }
        public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size) { _glBindBufferRange(target, index, buffer, offset, size); }
        public static void glBindFragDataLocation(uint program, uint color, nint name) { _glBindFragDataLocation(program, color, name); }
        public static void glBindFramebuffer(uint target, uint framebuffer) { _glBindFramebuffer(target, framebuffer); }
        public static void glBindRenderbuffer(uint target, uint renderbuffer) { _glBindRenderbuffer(target, renderbuffer); }
        public static void glBindVertexArray(uint array) { _glBindVertexArray(array); }
        public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) { _glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
        public static uint glCheckFramebufferStatus(uint target) { return _glCheckFramebufferStatus(target); }
        public static void glClampColor(uint target, uint clamp) { _glClampColor(target, clamp); }
        public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) { _glClearBufferfi(buffer, drawbuffer, depth, stencil); }
        public static void glClearBufferfv(uint buffer, int drawbuffer, nint value) { _glClearBufferfv(buffer, drawbuffer, value); }
        public static void glClearBufferiv(uint buffer, int drawbuffer, nint value) { _glClearBufferiv(buffer, drawbuffer, value); }
        public static void glClearBufferuiv(uint buffer, int drawbuffer, nint value) { _glClearBufferuiv(buffer, drawbuffer, value); }
        public static void glColorMaski(uint index, bool r, bool g, bool b, bool a) { _glColorMaski(index, r, g, b, a); }
        public static void glDeleteFramebuffers(int n, nint framebuffers) { _glDeleteFramebuffers(n, framebuffers); }
        public static void glDeleteRenderbuffers(int n, nint renderbuffers) { _glDeleteRenderbuffers(n, renderbuffers); }
        public static void glDeleteVertexArrays(int n, nint arrays) { _glDeleteVertexArrays(n, arrays); }
        public static void glDisablei(uint target, uint index) { _glDisablei(target, index); }
        public static void glEnablei(uint target, uint index) { _glEnablei(target, index); }
        public static void glEndConditionalRender() { _glEndConditionalRender(); }
        public static void glEndTransformFeedback() { _glEndTransformFeedback(); }
        public static void glFlushMappedBufferRange(uint target, nint offset, nint length) { _glFlushMappedBufferRange(target, offset, length); }
        public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) { _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer); }
        public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) { _glFramebufferTexture1D(target, attachment, textarget, texture, level); }
        public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) { _glFramebufferTexture2D(target, attachment, textarget, texture, level); }
        public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) { _glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset); }
        public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) { _glFramebufferTextureLayer(target, attachment, texture, level, layer); }
        public static void glGenFramebuffers(int n, nint framebuffers) { _glGenFramebuffers(n, framebuffers); }
        public static void glGenRenderbuffers(int n, nint renderbuffers) { _glGenRenderbuffers(n, renderbuffers); }
        public static void glGenVertexArrays(int n, nint arrays) { _glGenVertexArrays(n, arrays); }
        public static void glGenerateMipmap(uint target) { _glGenerateMipmap(target); }
        public static void glGetBooleani_v(uint target, uint index, nint data) { _glGetBooleani_v(target, index, data); }
        public static int glGetFragDataLocation(uint program, nint name) { return _glGetFragDataLocation(program, name); }
        public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, nint @params) { _glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params); }
        public static void glGetIntegeri_v(uint target, uint index, nint data) { _glGetIntegeri_v(target, index, data); }
        public static void glGetRenderbufferParameteriv(uint target, uint pname, nint @params) { _glGetRenderbufferParameteriv(target, pname, @params); }
        public static nint glGetStringi(uint name, uint index) { return _glGetStringi(name, index); }
        public static void glGetTexParameterIiv(uint target, uint pname, nint @params) { _glGetTexParameterIiv(target, pname, @params); }
        public static void glGetTexParameterIuiv(uint target, uint pname, nint @params) { _glGetTexParameterIuiv(target, pname, @params); }
        public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, nint length, nint size, nint type, nint name) { _glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name); }
        public static void glGetUniformuiv(uint program, int location, nint @params) { _glGetUniformuiv(program, location, @params); }
        public static void glGetVertexAttribIiv(uint index, uint pname, nint @params) { _glGetVertexAttribIiv(index, pname, @params); }
        public static void glGetVertexAttribIuiv(uint index, uint pname, nint @params) { _glGetVertexAttribIuiv(index, pname, @params); }
        public static bool glIsEnabledi(uint target, uint index) { return _glIsEnabledi(target, index); }
        public static bool glIsFramebuffer(uint framebuffer) { return _glIsFramebuffer(framebuffer); }
        public static bool glIsRenderbuffer(uint renderbuffer) { return _glIsRenderbuffer(renderbuffer); }
        public static bool glIsVertexArray(uint array) { return _glIsVertexArray(array); }
        public static nint glMapBufferRange(uint target, nint offset, nint length, uint access) { return _glMapBufferRange(target, offset, length, access); }
        public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) { _glRenderbufferStorage(target, internalformat, width, height); }
        public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) { _glRenderbufferStorageMultisample(target, samples, internalformat, width, height); }
        public static void glTexParameterIiv(uint target, uint pname, nint @params) { _glTexParameterIiv(target, pname, @params); }
        public static void glTexParameterIuiv(uint target, uint pname, nint @params) { _glTexParameterIuiv(target, pname, @params); }
        public static void glTransformFeedbackVaryings(uint program, int count, nint varyings, uint bufferMode) { _glTransformFeedbackVaryings(program, count, varyings, bufferMode); }
        public static void glUniform1ui(int location, uint v0) { _glUniform1ui(location, v0); }
        public static void glUniform1uiv(int location, int count, nint value) { _glUniform1uiv(location, count, value); }
        public static void glUniform2ui(int location, uint v0, uint v1) { _glUniform2ui(location, v0, v1); }
        public static void glUniform2uiv(int location, int count, nint value) { _glUniform2uiv(location, count, value); }
        public static void glUniform3ui(int location, uint v0, uint v1, uint v2) { _glUniform3ui(location, v0, v1, v2); }
        public static void glUniform3uiv(int location, int count, nint value) { _glUniform3uiv(location, count, value); }
        public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) { _glUniform4ui(location, v0, v1, v2, v3); }
        public static void glUniform4uiv(int location, int count, nint value) { _glUniform4uiv(location, count, value); }
        public static void glVertexAttribI1i(uint index, int x) { _glVertexAttribI1i(index, x); }
        public static void glVertexAttribI1iv(uint index, nint v) { _glVertexAttribI1iv(index, v); }
        public static void glVertexAttribI1ui(uint index, uint x) { _glVertexAttribI1ui(index, x); }
        public static void glVertexAttribI1uiv(uint index, nint v) { _glVertexAttribI1uiv(index, v); }
        public static void glVertexAttribI2i(uint index, int x, int y) { _glVertexAttribI2i(index, x, y); }
        public static void glVertexAttribI2iv(uint index, nint v) { _glVertexAttribI2iv(index, v); }
        public static void glVertexAttribI2ui(uint index, uint x, uint y) { _glVertexAttribI2ui(index, x, y); }
        public static void glVertexAttribI2uiv(uint index, nint v) { _glVertexAttribI2uiv(index, v); }
        public static void glVertexAttribI3i(uint index, int x, int y, int z) { _glVertexAttribI3i(index, x, y, z); }
        public static void glVertexAttribI3iv(uint index, nint v) { _glVertexAttribI3iv(index, v); }
        public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z) { _glVertexAttribI3ui(index, x, y, z); }
        public static void glVertexAttribI3uiv(uint index, nint v) { _glVertexAttribI3uiv(index, v); }
        public static void glVertexAttribI4bv(uint index, nint v) { _glVertexAttribI4bv(index, v); }
        public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) { _glVertexAttribI4i(index, x, y, z, w); }
        public static void glVertexAttribI4iv(uint index, nint v) { _glVertexAttribI4iv(index, v); }
        public static void glVertexAttribI4sv(uint index, nint v) { _glVertexAttribI4sv(index, v); }
        public static void glVertexAttribI4ubv(uint index, nint v) { _glVertexAttribI4ubv(index, v); }
        public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) { _glVertexAttribI4ui(index, x, y, z, w); }
        public static void glVertexAttribI4uiv(uint index, nint v) { _glVertexAttribI4uiv(index, v); }
        public static void glVertexAttribI4usv(uint index, nint v) { _glVertexAttribI4usv(index, v); }
        public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, nint pointer) { _glVertexAttribIPointer(index, size, type, stride, pointer); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBeginConditionalRender = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBeginConditionalRender");
            _glBeginTransformFeedback = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glBeginTransformFeedback");
            _glBindBufferBase = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glBindBufferBase");
            _glBindBufferRange = (delegate* unmanaged[Stdcall]<uint, uint, uint, nint, nint, void>)src.GetFuncPtr("glBindBufferRange");
            _glBindFragDataLocation = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glBindFragDataLocation");
            _glBindFramebuffer = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBindFramebuffer");
            _glBindRenderbuffer = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBindRenderbuffer");
            _glBindVertexArray = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glBindVertexArray");
            _glBlitFramebuffer = (delegate* unmanaged[Stdcall]<int, int, int, int, int, int, int, int, uint, uint, void>)src.GetFuncPtr("glBlitFramebuffer");
            _glCheckFramebufferStatus = (delegate* unmanaged[Stdcall]<uint, uint>)src.GetFuncPtr("glCheckFramebufferStatus");
            _glClampColor = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glClampColor");
            _glClearBufferfi = (delegate* unmanaged[Stdcall]<uint, int, float, int, void>)src.GetFuncPtr("glClearBufferfi");
            _glClearBufferfv = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glClearBufferfv");
            _glClearBufferiv = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glClearBufferiv");
            _glClearBufferuiv = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glClearBufferuiv");
            _glColorMaski = (delegate* unmanaged[Stdcall]<uint, bool, bool, bool, bool, void>)src.GetFuncPtr("glColorMaski");
            _glDeleteFramebuffers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteFramebuffers");
            _glDeleteRenderbuffers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteRenderbuffers");
            _glDeleteVertexArrays = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glDeleteVertexArrays");
            _glDisablei = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glDisablei");
            _glEnablei = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glEnablei");
            _glEndConditionalRender = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glEndConditionalRender");
            _glEndTransformFeedback = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glEndTransformFeedback");
            _glFlushMappedBufferRange = (delegate* unmanaged[Stdcall]<uint, nint, nint, void>)src.GetFuncPtr("glFlushMappedBufferRange");
            _glFramebufferRenderbuffer = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void>)src.GetFuncPtr("glFramebufferRenderbuffer");
            _glFramebufferTexture1D = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, void>)src.GetFuncPtr("glFramebufferTexture1D");
            _glFramebufferTexture2D = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, void>)src.GetFuncPtr("glFramebufferTexture2D");
            _glFramebufferTexture3D = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, int, int, void>)src.GetFuncPtr("glFramebufferTexture3D");
            _glFramebufferTextureLayer = (delegate* unmanaged[Stdcall]<uint, uint, uint, int, int, void>)src.GetFuncPtr("glFramebufferTextureLayer");
            _glGenFramebuffers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenFramebuffers");
            _glGenRenderbuffers = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenRenderbuffers");
            _glGenVertexArrays = (delegate* unmanaged[Stdcall]<int, nint, void>)src.GetFuncPtr("glGenVertexArrays");
            _glGenerateMipmap = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glGenerateMipmap");
            _glGetBooleani_v = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetBooleani_v");
            _glGetFragDataLocation = (delegate* unmanaged[Stdcall]<uint, nint, int>)src.GetFuncPtr("glGetFragDataLocation");
            _glGetFramebufferAttachmentParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void>)src.GetFuncPtr("glGetFramebufferAttachmentParameteriv");
            _glGetIntegeri_v = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetIntegeri_v");
            _glGetRenderbufferParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetRenderbufferParameteriv");
            _glGetStringi = (delegate* unmanaged[Stdcall]<uint, uint, nint>)src.GetFuncPtr("glGetStringi");
            _glGetTexParameterIiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetTexParameterIiv");
            _glGetTexParameterIuiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetTexParameterIuiv");
            _glGetTransformFeedbackVarying = (delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, nint, nint, void>)src.GetFuncPtr("glGetTransformFeedbackVarying");
            _glGetUniformuiv = (delegate* unmanaged[Stdcall]<uint, int, nint, void>)src.GetFuncPtr("glGetUniformuiv");
            _glGetVertexAttribIiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetVertexAttribIiv");
            _glGetVertexAttribIuiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetVertexAttribIuiv");
            _glIsEnabledi = (delegate* unmanaged[Stdcall]<uint, uint, bool>)src.GetFuncPtr("glIsEnabledi");
            _glIsFramebuffer = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsFramebuffer");
            _glIsRenderbuffer = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsRenderbuffer");
            _glIsVertexArray = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsVertexArray");
            _glMapBufferRange = (delegate* unmanaged[Stdcall]<uint, nint, nint, uint, nint>)src.GetFuncPtr("glMapBufferRange");
            _glRenderbufferStorage = (delegate* unmanaged[Stdcall]<uint, uint, int, int, void>)src.GetFuncPtr("glRenderbufferStorage");
            _glRenderbufferStorageMultisample = (delegate* unmanaged[Stdcall]<uint, int, uint, int, int, void>)src.GetFuncPtr("glRenderbufferStorageMultisample");
            _glTexParameterIiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glTexParameterIiv");
            _glTexParameterIuiv = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glTexParameterIuiv");
            _glTransformFeedbackVaryings = (delegate* unmanaged[Stdcall]<uint, int, nint, uint, void>)src.GetFuncPtr("glTransformFeedbackVaryings");
            _glUniform1ui = (delegate* unmanaged[Stdcall]<int, uint, void>)src.GetFuncPtr("glUniform1ui");
            _glUniform1uiv = (delegate* unmanaged[Stdcall]<int, int, nint, void>)src.GetFuncPtr("glUniform1uiv");
            _glUniform2ui = (delegate* unmanaged[Stdcall]<int, uint, uint, void>)src.GetFuncPtr("glUniform2ui");
            _glUniform2uiv = (delegate* unmanaged[Stdcall]<int, int, nint, void>)src.GetFuncPtr("glUniform2uiv");
            _glUniform3ui = (delegate* unmanaged[Stdcall]<int, uint, uint, uint, void>)src.GetFuncPtr("glUniform3ui");
            _glUniform3uiv = (delegate* unmanaged[Stdcall]<int, int, nint, void>)src.GetFuncPtr("glUniform3uiv");
            _glUniform4ui = (delegate* unmanaged[Stdcall]<int, uint, uint, uint, uint, void>)src.GetFuncPtr("glUniform4ui");
            _glUniform4uiv = (delegate* unmanaged[Stdcall]<int, int, nint, void>)src.GetFuncPtr("glUniform4uiv");
            _glVertexAttribI1i = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glVertexAttribI1i");
            _glVertexAttribI1iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI1iv");
            _glVertexAttribI1ui = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glVertexAttribI1ui");
            _glVertexAttribI1uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI1uiv");
            _glVertexAttribI2i = (delegate* unmanaged[Stdcall]<uint, int, int, void>)src.GetFuncPtr("glVertexAttribI2i");
            _glVertexAttribI2iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI2iv");
            _glVertexAttribI2ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glVertexAttribI2ui");
            _glVertexAttribI2uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI2uiv");
            _glVertexAttribI3i = (delegate* unmanaged[Stdcall]<uint, int, int, int, void>)src.GetFuncPtr("glVertexAttribI3i");
            _glVertexAttribI3iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI3iv");
            _glVertexAttribI3ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void>)src.GetFuncPtr("glVertexAttribI3ui");
            _glVertexAttribI3uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI3uiv");
            _glVertexAttribI4bv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4bv");
            _glVertexAttribI4i = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, void>)src.GetFuncPtr("glVertexAttribI4i");
            _glVertexAttribI4iv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4iv");
            _glVertexAttribI4sv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4sv");
            _glVertexAttribI4ubv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4ubv");
            _glVertexAttribI4ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, uint, void>)src.GetFuncPtr("glVertexAttribI4ui");
            _glVertexAttribI4uiv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4uiv");
            _glVertexAttribI4usv = (delegate* unmanaged[Stdcall]<uint, nint, void>)src.GetFuncPtr("glVertexAttribI4usv");
            _glVertexAttribIPointer = (delegate* unmanaged[Stdcall]<uint, int, uint, int, nint, void>)src.GetFuncPtr("glVertexAttribIPointer");
        }

        internal static void Unload()
        {
            _glBeginConditionalRender = null;
            _glBeginTransformFeedback = null;
            _glBindBufferBase = null;
            _glBindBufferRange = null;
            _glBindFragDataLocation = null;
            _glBindFramebuffer = null;
            _glBindRenderbuffer = null;
            _glBindVertexArray = null;
            _glBlitFramebuffer = null;
            _glCheckFramebufferStatus = null;
            _glClampColor = null;
            _glClearBufferfi = null;
            _glClearBufferfv = null;
            _glClearBufferiv = null;
            _glClearBufferuiv = null;
            _glColorMaski = null;
            _glDeleteFramebuffers = null;
            _glDeleteRenderbuffers = null;
            _glDeleteVertexArrays = null;
            _glDisablei = null;
            _glEnablei = null;
            _glEndConditionalRender = null;
            _glEndTransformFeedback = null;
            _glFlushMappedBufferRange = null;
            _glFramebufferRenderbuffer = null;
            _glFramebufferTexture1D = null;
            _glFramebufferTexture2D = null;
            _glFramebufferTexture3D = null;
            _glFramebufferTextureLayer = null;
            _glGenFramebuffers = null;
            _glGenRenderbuffers = null;
            _glGenVertexArrays = null;
            _glGenerateMipmap = null;
            _glGetBooleani_v = null;
            _glGetFragDataLocation = null;
            _glGetFramebufferAttachmentParameteriv = null;
            _glGetIntegeri_v = null;
            _glGetRenderbufferParameteriv = null;
            _glGetStringi = null;
            _glGetTexParameterIiv = null;
            _glGetTexParameterIuiv = null;
            _glGetTransformFeedbackVarying = null;
            _glGetUniformuiv = null;
            _glGetVertexAttribIiv = null;
            _glGetVertexAttribIuiv = null;
            _glIsEnabledi = null;
            _glIsFramebuffer = null;
            _glIsRenderbuffer = null;
            _glIsVertexArray = null;
            _glMapBufferRange = null;
            _glRenderbufferStorage = null;
            _glRenderbufferStorageMultisample = null;
            _glTexParameterIiv = null;
            _glTexParameterIuiv = null;
            _glTransformFeedbackVaryings = null;
            _glUniform1ui = null;
            _glUniform1uiv = null;
            _glUniform2ui = null;
            _glUniform2uiv = null;
            _glUniform3ui = null;
            _glUniform3uiv = null;
            _glUniform4ui = null;
            _glUniform4uiv = null;
            _glVertexAttribI1i = null;
            _glVertexAttribI1iv = null;
            _glVertexAttribI1ui = null;
            _glVertexAttribI1uiv = null;
            _glVertexAttribI2i = null;
            _glVertexAttribI2iv = null;
            _glVertexAttribI2ui = null;
            _glVertexAttribI2uiv = null;
            _glVertexAttribI3i = null;
            _glVertexAttribI3iv = null;
            _glVertexAttribI3ui = null;
            _glVertexAttribI3uiv = null;
            _glVertexAttribI4bv = null;
            _glVertexAttribI4i = null;
            _glVertexAttribI4iv = null;
            _glVertexAttribI4sv = null;
            _glVertexAttribI4ubv = null;
            _glVertexAttribI4ui = null;
            _glVertexAttribI4uiv = null;
            _glVertexAttribI4usv = null;
            _glVertexAttribIPointer = null;
        }
    }
}
