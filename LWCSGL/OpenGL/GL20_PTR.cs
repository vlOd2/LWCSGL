#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 2.0_PTR APIs
    /// </summary>
    public unsafe static class GL20_PTR
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glAttachShader;
        private static delegate* unmanaged[Stdcall]<uint, uint, char*, void> _glBindAttribLocation;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBlendEquationSeparate;
        private static delegate* unmanaged[Stdcall]<uint, void> _glCompileShader;
        private static delegate* unmanaged[Stdcall]<uint> _glCreateProgram;
        private static delegate* unmanaged[Stdcall]<uint, uint> _glCreateShader;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDeleteProgram;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDeleteShader;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glDetachShader;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDisableVertexAttribArray;
        private static delegate* unmanaged[Stdcall]<int, uint*, void> _glDrawBuffers;
        private static delegate* unmanaged[Stdcall]<uint, void> _glEnableVertexAttribArray;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, int*, int*, uint*, char*, void> _glGetActiveAttrib;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, int*, int*, uint*, char*, void> _glGetActiveUniform;
        private static delegate* unmanaged[Stdcall]<uint, int, int*, uint*, void> _glGetAttachedShaders;
        private static delegate* unmanaged[Stdcall]<uint, char*, int> _glGetAttribLocation;
        private static delegate* unmanaged[Stdcall]<uint, int, int*, char*, void> _glGetProgramInfoLog;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetProgramiv;
        private static delegate* unmanaged[Stdcall]<uint, int, int*, char*, void> _glGetShaderInfoLog;
        private static delegate* unmanaged[Stdcall]<uint, int, int*, char*, void> _glGetShaderSource;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetShaderiv;
        private static delegate* unmanaged[Stdcall]<uint, char*, int> _glGetUniformLocation;
        private static delegate* unmanaged[Stdcall]<uint, int, float*, void> _glGetUniformfv;
        private static delegate* unmanaged[Stdcall]<uint, int, int*, void> _glGetUniformiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void**, void> _glGetVertexAttribPointerv;
        private static delegate* unmanaged[Stdcall]<uint, uint, double*, void> _glGetVertexAttribdv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float*, void> _glGetVertexAttribfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int*, void> _glGetVertexAttribiv;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsProgram;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsShader;
        private static delegate* unmanaged[Stdcall]<uint, void> _glLinkProgram;
        private static delegate* unmanaged[Stdcall]<uint, int, char**, int*, void> _glShaderSource;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, uint, void> _glStencilFuncSeparate;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glStencilMaskSeparate;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void> _glStencilOpSeparate;
        private static delegate* unmanaged[Stdcall]<int, float, void> _glUniform1f;
        private static delegate* unmanaged[Stdcall]<int, int, float*, void> _glUniform1fv;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glUniform1i;
        private static delegate* unmanaged[Stdcall]<int, int, int*, void> _glUniform1iv;
        private static delegate* unmanaged[Stdcall]<int, float, float, void> _glUniform2f;
        private static delegate* unmanaged[Stdcall]<int, int, float*, void> _glUniform2fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glUniform2i;
        private static delegate* unmanaged[Stdcall]<int, int, int*, void> _glUniform2iv;
        private static delegate* unmanaged[Stdcall]<int, float, float, float, void> _glUniform3f;
        private static delegate* unmanaged[Stdcall]<int, int, float*, void> _glUniform3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glUniform3i;
        private static delegate* unmanaged[Stdcall]<int, int, int*, void> _glUniform3iv;
        private static delegate* unmanaged[Stdcall]<int, float, float, float, float, void> _glUniform4f;
        private static delegate* unmanaged[Stdcall]<int, int, float*, void> _glUniform4fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, int, void> _glUniform4i;
        private static delegate* unmanaged[Stdcall]<int, int, int*, void> _glUniform4iv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix2fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix3fv;
        private static delegate* unmanaged[Stdcall]<int, int, bool, float*, void> _glUniformMatrix4fv;
        private static delegate* unmanaged[Stdcall]<uint, void> _glUseProgram;
        private static delegate* unmanaged[Stdcall]<uint, void> _glValidateProgram;
        private static delegate* unmanaged[Stdcall]<uint, double, void> _glVertexAttrib1d;
        private static delegate* unmanaged[Stdcall]<uint, double*, void> _glVertexAttrib1dv;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glVertexAttrib1f;
        private static delegate* unmanaged[Stdcall]<uint, float*, void> _glVertexAttrib1fv;
        private static delegate* unmanaged[Stdcall]<uint, short, void> _glVertexAttrib1s;
        private static delegate* unmanaged[Stdcall]<uint, short*, void> _glVertexAttrib1sv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, void> _glVertexAttrib2d;
        private static delegate* unmanaged[Stdcall]<uint, double*, void> _glVertexAttrib2dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, void> _glVertexAttrib2f;
        private static delegate* unmanaged[Stdcall]<uint, float*, void> _glVertexAttrib2fv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, void> _glVertexAttrib2s;
        private static delegate* unmanaged[Stdcall]<uint, short*, void> _glVertexAttrib2sv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, double, void> _glVertexAttrib3d;
        private static delegate* unmanaged[Stdcall]<uint, double*, void> _glVertexAttrib3dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, float, void> _glVertexAttrib3f;
        private static delegate* unmanaged[Stdcall]<uint, float*, void> _glVertexAttrib3fv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, short, void> _glVertexAttrib3s;
        private static delegate* unmanaged[Stdcall]<uint, short*, void> _glVertexAttrib3sv;
        private static delegate* unmanaged[Stdcall]<uint, sbyte*, void> _glVertexAttrib4Nbv;
        private static delegate* unmanaged[Stdcall]<uint, int*, void> _glVertexAttrib4Niv;
        private static delegate* unmanaged[Stdcall]<uint, short*, void> _glVertexAttrib4Nsv;
        private static delegate* unmanaged[Stdcall]<uint, byte, byte, byte, byte, void> _glVertexAttrib4Nub;
        private static delegate* unmanaged[Stdcall]<uint, byte*, void> _glVertexAttrib4Nubv;
        private static delegate* unmanaged[Stdcall]<uint, uint*, void> _glVertexAttrib4Nuiv;
        private static delegate* unmanaged[Stdcall]<uint, ushort*, void> _glVertexAttrib4Nusv;
        private static delegate* unmanaged[Stdcall]<uint, sbyte*, void> _glVertexAttrib4bv;
        private static delegate* unmanaged[Stdcall]<uint, double, double, double, double, void> _glVertexAttrib4d;
        private static delegate* unmanaged[Stdcall]<uint, double*, void> _glVertexAttrib4dv;
        private static delegate* unmanaged[Stdcall]<uint, float, float, float, float, void> _glVertexAttrib4f;
        private static delegate* unmanaged[Stdcall]<uint, float*, void> _glVertexAttrib4fv;
        private static delegate* unmanaged[Stdcall]<uint, int*, void> _glVertexAttrib4iv;
        private static delegate* unmanaged[Stdcall]<uint, short, short, short, short, void> _glVertexAttrib4s;
        private static delegate* unmanaged[Stdcall]<uint, short*, void> _glVertexAttrib4sv;
        private static delegate* unmanaged[Stdcall]<uint, byte*, void> _glVertexAttrib4ubv;
        private static delegate* unmanaged[Stdcall]<uint, uint*, void> _glVertexAttrib4uiv;
        private static delegate* unmanaged[Stdcall]<uint, ushort*, void> _glVertexAttrib4usv;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, bool, int, void*, void> _glVertexAttribPointer;

        public static void glAttachShader(uint program, uint shader) { _glAttachShader(program, shader); }
        public static void glBindAttribLocation(uint program, uint index, char* name) { _glBindAttribLocation(program, index, name); }
        public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) { _glBlendEquationSeparate(modeRGB, modeAlpha); }
        public static void glCompileShader(uint shader) { _glCompileShader(shader); }
        public static uint glCreateProgram() { return _glCreateProgram(); }
        public static uint glCreateShader(uint type) { return _glCreateShader(type); }
        public static void glDeleteProgram(uint program) { _glDeleteProgram(program); }
        public static void glDeleteShader(uint shader) { _glDeleteShader(shader); }
        public static void glDetachShader(uint program, uint shader) { _glDetachShader(program, shader); }
        public static void glDisableVertexAttribArray(uint index) { _glDisableVertexAttribArray(index); }
        public static void glDrawBuffers(int n, uint* bufs) { _glDrawBuffers(n, bufs); }
        public static void glEnableVertexAttribArray(uint index) { _glEnableVertexAttribArray(index); }
        public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) { _glGetActiveAttrib(program, index, bufSize, length, size, type, name); }
        public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) { _glGetActiveUniform(program, index, bufSize, length, size, type, name); }
        public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) { _glGetAttachedShaders(program, maxCount, count, shaders); }
        public static int glGetAttribLocation(uint program, char* name) { return _glGetAttribLocation(program, name); }
        public static void glGetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) { _glGetProgramInfoLog(program, bufSize, length, infoLog); }
        public static void glGetProgramiv(uint program, uint pname, int* @params) { _glGetProgramiv(program, pname, @params); }
        public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) { _glGetShaderInfoLog(shader, bufSize, length, infoLog); }
        public static void glGetShaderSource(uint shader, int bufSize, int* length, char* source) { _glGetShaderSource(shader, bufSize, length, source); }
        public static void glGetShaderiv(uint shader, uint pname, int* @params) { _glGetShaderiv(shader, pname, @params); }
        public static int glGetUniformLocation(uint program, char* name) { return _glGetUniformLocation(program, name); }
        public static void glGetUniformfv(uint program, int location, float* @params) { _glGetUniformfv(program, location, @params); }
        public static void glGetUniformiv(uint program, int location, int* @params) { _glGetUniformiv(program, location, @params); }
        public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer) { _glGetVertexAttribPointerv(index, pname, pointer); }
        public static void glGetVertexAttribdv(uint index, uint pname, double* @params) { _glGetVertexAttribdv(index, pname, @params); }
        public static void glGetVertexAttribfv(uint index, uint pname, float* @params) { _glGetVertexAttribfv(index, pname, @params); }
        public static void glGetVertexAttribiv(uint index, uint pname, int* @params) { _glGetVertexAttribiv(index, pname, @params); }
        public static bool glIsProgram(uint program) { return _glIsProgram(program); }
        public static bool glIsShader(uint shader) { return _glIsShader(shader); }
        public static void glLinkProgram(uint program) { _glLinkProgram(program); }
        public static void glShaderSource(uint shader, int count, char** @string, int* length) { _glShaderSource(shader, count, @string, length); }
        public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask) { _glStencilFuncSeparate(face, func, @ref, mask); }
        public static void glStencilMaskSeparate(uint face, uint mask) { _glStencilMaskSeparate(face, mask); }
        public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) { _glStencilOpSeparate(face, sfail, dpfail, dppass); }
        public static void glUniform1f(int location, float v0) { _glUniform1f(location, v0); }
        public static void glUniform1fv(int location, int count, float* value) { _glUniform1fv(location, count, value); }
        public static void glUniform1i(int location, int v0) { _glUniform1i(location, v0); }
        public static void glUniform1iv(int location, int count, int* value) { _glUniform1iv(location, count, value); }
        public static void glUniform2f(int location, float v0, float v1) { _glUniform2f(location, v0, v1); }
        public static void glUniform2fv(int location, int count, float* value) { _glUniform2fv(location, count, value); }
        public static void glUniform2i(int location, int v0, int v1) { _glUniform2i(location, v0, v1); }
        public static void glUniform2iv(int location, int count, int* value) { _glUniform2iv(location, count, value); }
        public static void glUniform3f(int location, float v0, float v1, float v2) { _glUniform3f(location, v0, v1, v2); }
        public static void glUniform3fv(int location, int count, float* value) { _glUniform3fv(location, count, value); }
        public static void glUniform3i(int location, int v0, int v1, int v2) { _glUniform3i(location, v0, v1, v2); }
        public static void glUniform3iv(int location, int count, int* value) { _glUniform3iv(location, count, value); }
        public static void glUniform4f(int location, float v0, float v1, float v2, float v3) { _glUniform4f(location, v0, v1, v2, v3); }
        public static void glUniform4fv(int location, int count, float* value) { _glUniform4fv(location, count, value); }
        public static void glUniform4i(int location, int v0, int v1, int v2, int v3) { _glUniform4i(location, v0, v1, v2, v3); }
        public static void glUniform4iv(int location, int count, int* value) { _glUniform4iv(location, count, value); }
        public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value) { _glUniformMatrix2fv(location, count, transpose, value); }
        public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value) { _glUniformMatrix3fv(location, count, transpose, value); }
        public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value) { _glUniformMatrix4fv(location, count, transpose, value); }
        public static void glUseProgram(uint program) { _glUseProgram(program); }
        public static void glValidateProgram(uint program) { _glValidateProgram(program); }
        public static void glVertexAttrib1d(uint index, double x) { _glVertexAttrib1d(index, x); }
        public static void glVertexAttrib1dv(uint index, double* v) { _glVertexAttrib1dv(index, v); }
        public static void glVertexAttrib1f(uint index, float x) { _glVertexAttrib1f(index, x); }
        public static void glVertexAttrib1fv(uint index, float* v) { _glVertexAttrib1fv(index, v); }
        public static void glVertexAttrib1s(uint index, short x) { _glVertexAttrib1s(index, x); }
        public static void glVertexAttrib1sv(uint index, short* v) { _glVertexAttrib1sv(index, v); }
        public static void glVertexAttrib2d(uint index, double x, double y) { _glVertexAttrib2d(index, x, y); }
        public static void glVertexAttrib2dv(uint index, double* v) { _glVertexAttrib2dv(index, v); }
        public static void glVertexAttrib2f(uint index, float x, float y) { _glVertexAttrib2f(index, x, y); }
        public static void glVertexAttrib2fv(uint index, float* v) { _glVertexAttrib2fv(index, v); }
        public static void glVertexAttrib2s(uint index, short x, short y) { _glVertexAttrib2s(index, x, y); }
        public static void glVertexAttrib2sv(uint index, short* v) { _glVertexAttrib2sv(index, v); }
        public static void glVertexAttrib3d(uint index, double x, double y, double z) { _glVertexAttrib3d(index, x, y, z); }
        public static void glVertexAttrib3dv(uint index, double* v) { _glVertexAttrib3dv(index, v); }
        public static void glVertexAttrib3f(uint index, float x, float y, float z) { _glVertexAttrib3f(index, x, y, z); }
        public static void glVertexAttrib3fv(uint index, float* v) { _glVertexAttrib3fv(index, v); }
        public static void glVertexAttrib3s(uint index, short x, short y, short z) { _glVertexAttrib3s(index, x, y, z); }
        public static void glVertexAttrib3sv(uint index, short* v) { _glVertexAttrib3sv(index, v); }
        public static void glVertexAttrib4Nbv(uint index, sbyte* v) { _glVertexAttrib4Nbv(index, v); }
        public static void glVertexAttrib4Niv(uint index, int* v) { _glVertexAttrib4Niv(index, v); }
        public static void glVertexAttrib4Nsv(uint index, short* v) { _glVertexAttrib4Nsv(index, v); }
        public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) { _glVertexAttrib4Nub(index, x, y, z, w); }
        public static void glVertexAttrib4Nubv(uint index, byte* v) { _glVertexAttrib4Nubv(index, v); }
        public static void glVertexAttrib4Nuiv(uint index, uint* v) { _glVertexAttrib4Nuiv(index, v); }
        public static void glVertexAttrib4Nusv(uint index, ushort* v) { _glVertexAttrib4Nusv(index, v); }
        public static void glVertexAttrib4bv(uint index, sbyte* v) { _glVertexAttrib4bv(index, v); }
        public static void glVertexAttrib4d(uint index, double x, double y, double z, double w) { _glVertexAttrib4d(index, x, y, z, w); }
        public static void glVertexAttrib4dv(uint index, double* v) { _glVertexAttrib4dv(index, v); }
        public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) { _glVertexAttrib4f(index, x, y, z, w); }
        public static void glVertexAttrib4fv(uint index, float* v) { _glVertexAttrib4fv(index, v); }
        public static void glVertexAttrib4iv(uint index, int* v) { _glVertexAttrib4iv(index, v); }
        public static void glVertexAttrib4s(uint index, short x, short y, short z, short w) { _glVertexAttrib4s(index, x, y, z, w); }
        public static void glVertexAttrib4sv(uint index, short* v) { _glVertexAttrib4sv(index, v); }
        public static void glVertexAttrib4ubv(uint index, byte* v) { _glVertexAttrib4ubv(index, v); }
        public static void glVertexAttrib4uiv(uint index, uint* v) { _glVertexAttrib4uiv(index, v); }
        public static void glVertexAttrib4usv(uint index, ushort* v) { _glVertexAttrib4usv(index, v); }
        public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer) { _glVertexAttribPointer(index, size, type, normalized, stride, pointer); }

        internal static void Load(DelegatePtrSource src)
        {
            _glAttachShader = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glAttachShader");
            _glBindAttribLocation = (delegate* unmanaged[Stdcall]<uint, uint, char*, void>)src.GetFuncPtr("glBindAttribLocation");
            _glBlendEquationSeparate = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBlendEquationSeparate");
            _glCompileShader = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glCompileShader");
            _glCreateProgram = (delegate* unmanaged[Stdcall]<uint>)src.GetFuncPtr("glCreateProgram");
            _glCreateShader = (delegate* unmanaged[Stdcall]<uint, uint>)src.GetFuncPtr("glCreateShader");
            _glDeleteProgram = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDeleteProgram");
            _glDeleteShader = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDeleteShader");
            _glDetachShader = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glDetachShader");
            _glDisableVertexAttribArray = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDisableVertexAttribArray");
            _glDrawBuffers = (delegate* unmanaged[Stdcall]<int, uint*, void>)src.GetFuncPtr("glDrawBuffers");
            _glEnableVertexAttribArray = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glEnableVertexAttribArray");
            _glGetActiveAttrib = (delegate* unmanaged[Stdcall]<uint, uint, int, int*, int*, uint*, char*, void>)src.GetFuncPtr("glGetActiveAttrib");
            _glGetActiveUniform = (delegate* unmanaged[Stdcall]<uint, uint, int, int*, int*, uint*, char*, void>)src.GetFuncPtr("glGetActiveUniform");
            _glGetAttachedShaders = (delegate* unmanaged[Stdcall]<uint, int, int*, uint*, void>)src.GetFuncPtr("glGetAttachedShaders");
            _glGetAttribLocation = (delegate* unmanaged[Stdcall]<uint, char*, int>)src.GetFuncPtr("glGetAttribLocation");
            _glGetProgramInfoLog = (delegate* unmanaged[Stdcall]<uint, int, int*, char*, void>)src.GetFuncPtr("glGetProgramInfoLog");
            _glGetProgramiv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetProgramiv");
            _glGetShaderInfoLog = (delegate* unmanaged[Stdcall]<uint, int, int*, char*, void>)src.GetFuncPtr("glGetShaderInfoLog");
            _glGetShaderSource = (delegate* unmanaged[Stdcall]<uint, int, int*, char*, void>)src.GetFuncPtr("glGetShaderSource");
            _glGetShaderiv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetShaderiv");
            _glGetUniformLocation = (delegate* unmanaged[Stdcall]<uint, char*, int>)src.GetFuncPtr("glGetUniformLocation");
            _glGetUniformfv = (delegate* unmanaged[Stdcall]<uint, int, float*, void>)src.GetFuncPtr("glGetUniformfv");
            _glGetUniformiv = (delegate* unmanaged[Stdcall]<uint, int, int*, void>)src.GetFuncPtr("glGetUniformiv");
            _glGetVertexAttribPointerv = (delegate* unmanaged[Stdcall]<uint, uint, void**, void>)src.GetFuncPtr("glGetVertexAttribPointerv");
            _glGetVertexAttribdv = (delegate* unmanaged[Stdcall]<uint, uint, double*, void>)src.GetFuncPtr("glGetVertexAttribdv");
            _glGetVertexAttribfv = (delegate* unmanaged[Stdcall]<uint, uint, float*, void>)src.GetFuncPtr("glGetVertexAttribfv");
            _glGetVertexAttribiv = (delegate* unmanaged[Stdcall]<uint, uint, int*, void>)src.GetFuncPtr("glGetVertexAttribiv");
            _glIsProgram = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsProgram");
            _glIsShader = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsShader");
            _glLinkProgram = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glLinkProgram");
            _glShaderSource = (delegate* unmanaged[Stdcall]<uint, int, char**, int*, void>)src.GetFuncPtr("glShaderSource");
            _glStencilFuncSeparate = (delegate* unmanaged[Stdcall]<uint, uint, int, uint, void>)src.GetFuncPtr("glStencilFuncSeparate");
            _glStencilMaskSeparate = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glStencilMaskSeparate");
            _glStencilOpSeparate = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void>)src.GetFuncPtr("glStencilOpSeparate");
            _glUniform1f = (delegate* unmanaged[Stdcall]<int, float, void>)src.GetFuncPtr("glUniform1f");
            _glUniform1fv = (delegate* unmanaged[Stdcall]<int, int, float*, void>)src.GetFuncPtr("glUniform1fv");
            _glUniform1i = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glUniform1i");
            _glUniform1iv = (delegate* unmanaged[Stdcall]<int, int, int*, void>)src.GetFuncPtr("glUniform1iv");
            _glUniform2f = (delegate* unmanaged[Stdcall]<int, float, float, void>)src.GetFuncPtr("glUniform2f");
            _glUniform2fv = (delegate* unmanaged[Stdcall]<int, int, float*, void>)src.GetFuncPtr("glUniform2fv");
            _glUniform2i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glUniform2i");
            _glUniform2iv = (delegate* unmanaged[Stdcall]<int, int, int*, void>)src.GetFuncPtr("glUniform2iv");
            _glUniform3f = (delegate* unmanaged[Stdcall]<int, float, float, float, void>)src.GetFuncPtr("glUniform3f");
            _glUniform3fv = (delegate* unmanaged[Stdcall]<int, int, float*, void>)src.GetFuncPtr("glUniform3fv");
            _glUniform3i = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glUniform3i");
            _glUniform3iv = (delegate* unmanaged[Stdcall]<int, int, int*, void>)src.GetFuncPtr("glUniform3iv");
            _glUniform4f = (delegate* unmanaged[Stdcall]<int, float, float, float, float, void>)src.GetFuncPtr("glUniform4f");
            _glUniform4fv = (delegate* unmanaged[Stdcall]<int, int, float*, void>)src.GetFuncPtr("glUniform4fv");
            _glUniform4i = (delegate* unmanaged[Stdcall]<int, int, int, int, int, void>)src.GetFuncPtr("glUniform4i");
            _glUniform4iv = (delegate* unmanaged[Stdcall]<int, int, int*, void>)src.GetFuncPtr("glUniform4iv");
            _glUniformMatrix2fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix2fv");
            _glUniformMatrix3fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix3fv");
            _glUniformMatrix4fv = (delegate* unmanaged[Stdcall]<int, int, bool, float*, void>)src.GetFuncPtr("glUniformMatrix4fv");
            _glUseProgram = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glUseProgram");
            _glValidateProgram = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glValidateProgram");
            _glVertexAttrib1d = (delegate* unmanaged[Stdcall]<uint, double, void>)src.GetFuncPtr("glVertexAttrib1d");
            _glVertexAttrib1dv = (delegate* unmanaged[Stdcall]<uint, double*, void>)src.GetFuncPtr("glVertexAttrib1dv");
            _glVertexAttrib1f = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glVertexAttrib1f");
            _glVertexAttrib1fv = (delegate* unmanaged[Stdcall]<uint, float*, void>)src.GetFuncPtr("glVertexAttrib1fv");
            _glVertexAttrib1s = (delegate* unmanaged[Stdcall]<uint, short, void>)src.GetFuncPtr("glVertexAttrib1s");
            _glVertexAttrib1sv = (delegate* unmanaged[Stdcall]<uint, short*, void>)src.GetFuncPtr("glVertexAttrib1sv");
            _glVertexAttrib2d = (delegate* unmanaged[Stdcall]<uint, double, double, void>)src.GetFuncPtr("glVertexAttrib2d");
            _glVertexAttrib2dv = (delegate* unmanaged[Stdcall]<uint, double*, void>)src.GetFuncPtr("glVertexAttrib2dv");
            _glVertexAttrib2f = (delegate* unmanaged[Stdcall]<uint, float, float, void>)src.GetFuncPtr("glVertexAttrib2f");
            _glVertexAttrib2fv = (delegate* unmanaged[Stdcall]<uint, float*, void>)src.GetFuncPtr("glVertexAttrib2fv");
            _glVertexAttrib2s = (delegate* unmanaged[Stdcall]<uint, short, short, void>)src.GetFuncPtr("glVertexAttrib2s");
            _glVertexAttrib2sv = (delegate* unmanaged[Stdcall]<uint, short*, void>)src.GetFuncPtr("glVertexAttrib2sv");
            _glVertexAttrib3d = (delegate* unmanaged[Stdcall]<uint, double, double, double, void>)src.GetFuncPtr("glVertexAttrib3d");
            _glVertexAttrib3dv = (delegate* unmanaged[Stdcall]<uint, double*, void>)src.GetFuncPtr("glVertexAttrib3dv");
            _glVertexAttrib3f = (delegate* unmanaged[Stdcall]<uint, float, float, float, void>)src.GetFuncPtr("glVertexAttrib3f");
            _glVertexAttrib3fv = (delegate* unmanaged[Stdcall]<uint, float*, void>)src.GetFuncPtr("glVertexAttrib3fv");
            _glVertexAttrib3s = (delegate* unmanaged[Stdcall]<uint, short, short, short, void>)src.GetFuncPtr("glVertexAttrib3s");
            _glVertexAttrib3sv = (delegate* unmanaged[Stdcall]<uint, short*, void>)src.GetFuncPtr("glVertexAttrib3sv");
            _glVertexAttrib4Nbv = (delegate* unmanaged[Stdcall]<uint, sbyte*, void>)src.GetFuncPtr("glVertexAttrib4Nbv");
            _glVertexAttrib4Niv = (delegate* unmanaged[Stdcall]<uint, int*, void>)src.GetFuncPtr("glVertexAttrib4Niv");
            _glVertexAttrib4Nsv = (delegate* unmanaged[Stdcall]<uint, short*, void>)src.GetFuncPtr("glVertexAttrib4Nsv");
            _glVertexAttrib4Nub = (delegate* unmanaged[Stdcall]<uint, byte, byte, byte, byte, void>)src.GetFuncPtr("glVertexAttrib4Nub");
            _glVertexAttrib4Nubv = (delegate* unmanaged[Stdcall]<uint, byte*, void>)src.GetFuncPtr("glVertexAttrib4Nubv");
            _glVertexAttrib4Nuiv = (delegate* unmanaged[Stdcall]<uint, uint*, void>)src.GetFuncPtr("glVertexAttrib4Nuiv");
            _glVertexAttrib4Nusv = (delegate* unmanaged[Stdcall]<uint, ushort*, void>)src.GetFuncPtr("glVertexAttrib4Nusv");
            _glVertexAttrib4bv = (delegate* unmanaged[Stdcall]<uint, sbyte*, void>)src.GetFuncPtr("glVertexAttrib4bv");
            _glVertexAttrib4d = (delegate* unmanaged[Stdcall]<uint, double, double, double, double, void>)src.GetFuncPtr("glVertexAttrib4d");
            _glVertexAttrib4dv = (delegate* unmanaged[Stdcall]<uint, double*, void>)src.GetFuncPtr("glVertexAttrib4dv");
            _glVertexAttrib4f = (delegate* unmanaged[Stdcall]<uint, float, float, float, float, void>)src.GetFuncPtr("glVertexAttrib4f");
            _glVertexAttrib4fv = (delegate* unmanaged[Stdcall]<uint, float*, void>)src.GetFuncPtr("glVertexAttrib4fv");
            _glVertexAttrib4iv = (delegate* unmanaged[Stdcall]<uint, int*, void>)src.GetFuncPtr("glVertexAttrib4iv");
            _glVertexAttrib4s = (delegate* unmanaged[Stdcall]<uint, short, short, short, short, void>)src.GetFuncPtr("glVertexAttrib4s");
            _glVertexAttrib4sv = (delegate* unmanaged[Stdcall]<uint, short*, void>)src.GetFuncPtr("glVertexAttrib4sv");
            _glVertexAttrib4ubv = (delegate* unmanaged[Stdcall]<uint, byte*, void>)src.GetFuncPtr("glVertexAttrib4ubv");
            _glVertexAttrib4uiv = (delegate* unmanaged[Stdcall]<uint, uint*, void>)src.GetFuncPtr("glVertexAttrib4uiv");
            _glVertexAttrib4usv = (delegate* unmanaged[Stdcall]<uint, ushort*, void>)src.GetFuncPtr("glVertexAttrib4usv");
            _glVertexAttribPointer = (delegate* unmanaged[Stdcall]<uint, int, uint, bool, int, void*, void>)src.GetFuncPtr("glVertexAttribPointer");
        }

        internal static void Unload()
        {
            _glAttachShader = null;
            _glBindAttribLocation = null;
            _glBlendEquationSeparate = null;
            _glCompileShader = null;
            _glCreateProgram = null;
            _glCreateShader = null;
            _glDeleteProgram = null;
            _glDeleteShader = null;
            _glDetachShader = null;
            _glDisableVertexAttribArray = null;
            _glDrawBuffers = null;
            _glEnableVertexAttribArray = null;
            _glGetActiveAttrib = null;
            _glGetActiveUniform = null;
            _glGetAttachedShaders = null;
            _glGetAttribLocation = null;
            _glGetProgramInfoLog = null;
            _glGetProgramiv = null;
            _glGetShaderInfoLog = null;
            _glGetShaderSource = null;
            _glGetShaderiv = null;
            _glGetUniformLocation = null;
            _glGetUniformfv = null;
            _glGetUniformiv = null;
            _glGetVertexAttribPointerv = null;
            _glGetVertexAttribdv = null;
            _glGetVertexAttribfv = null;
            _glGetVertexAttribiv = null;
            _glIsProgram = null;
            _glIsShader = null;
            _glLinkProgram = null;
            _glShaderSource = null;
            _glStencilFuncSeparate = null;
            _glStencilMaskSeparate = null;
            _glStencilOpSeparate = null;
            _glUniform1f = null;
            _glUniform1fv = null;
            _glUniform1i = null;
            _glUniform1iv = null;
            _glUniform2f = null;
            _glUniform2fv = null;
            _glUniform2i = null;
            _glUniform2iv = null;
            _glUniform3f = null;
            _glUniform3fv = null;
            _glUniform3i = null;
            _glUniform3iv = null;
            _glUniform4f = null;
            _glUniform4fv = null;
            _glUniform4i = null;
            _glUniform4iv = null;
            _glUniformMatrix2fv = null;
            _glUniformMatrix3fv = null;
            _glUniformMatrix4fv = null;
            _glUseProgram = null;
            _glValidateProgram = null;
            _glVertexAttrib1d = null;
            _glVertexAttrib1dv = null;
            _glVertexAttrib1f = null;
            _glVertexAttrib1fv = null;
            _glVertexAttrib1s = null;
            _glVertexAttrib1sv = null;
            _glVertexAttrib2d = null;
            _glVertexAttrib2dv = null;
            _glVertexAttrib2f = null;
            _glVertexAttrib2fv = null;
            _glVertexAttrib2s = null;
            _glVertexAttrib2sv = null;
            _glVertexAttrib3d = null;
            _glVertexAttrib3dv = null;
            _glVertexAttrib3f = null;
            _glVertexAttrib3fv = null;
            _glVertexAttrib3s = null;
            _glVertexAttrib3sv = null;
            _glVertexAttrib4Nbv = null;
            _glVertexAttrib4Niv = null;
            _glVertexAttrib4Nsv = null;
            _glVertexAttrib4Nub = null;
            _glVertexAttrib4Nubv = null;
            _glVertexAttrib4Nuiv = null;
            _glVertexAttrib4Nusv = null;
            _glVertexAttrib4bv = null;
            _glVertexAttrib4d = null;
            _glVertexAttrib4dv = null;
            _glVertexAttrib4f = null;
            _glVertexAttrib4fv = null;
            _glVertexAttrib4iv = null;
            _glVertexAttrib4s = null;
            _glVertexAttrib4sv = null;
            _glVertexAttrib4ubv = null;
            _glVertexAttrib4uiv = null;
            _glVertexAttrib4usv = null;
            _glVertexAttribPointer = null;
        }
    }
}
