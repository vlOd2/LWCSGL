#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 3.1_NINT APIs
    /// </summary>
    public unsafe static class GL31_NINT
    {
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glBindBufferBase;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, nint, nint, void> _glBindBufferRange;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, nint, nint, void> _glCopyBufferSubData;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, void> _glDrawArraysInstanced;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, nint, int, void> _glDrawElementsInstanced;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, void> _glGetActiveUniformBlockName;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void> _glGetActiveUniformBlockiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, void> _glGetActiveUniformName;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, uint, nint, void> _glGetActiveUniformsiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, nint, void> _glGetIntegeri_v;
        private static delegate* unmanaged[Stdcall]<uint, nint, uint> _glGetUniformBlockIndex;
        private static delegate* unmanaged[Stdcall]<uint, int, nint, nint, void> _glGetUniformIndices;
        private static delegate* unmanaged[Stdcall]<uint, void> _glPrimitiveRestartIndex;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glTexBuffer;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glUniformBlockBinding;

        public static void glBindBufferBase(uint target, uint index, uint buffer) { _glBindBufferBase(target, index, buffer); }
        public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size) { _glBindBufferRange(target, index, buffer, offset, size); }
        public static void glCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size) { _glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size); }
        public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount) { _glDrawArraysInstanced(mode, first, count, instancecount); }
        public static void glDrawElementsInstanced(uint mode, int count, uint type, nint indices, int instancecount) { _glDrawElementsInstanced(mode, count, type, indices, instancecount); }
        public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, nint length, nint uniformBlockName) { _glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName); }
        public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, nint @params) { _glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params); }
        public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, nint length, nint uniformName) { _glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName); }
        public static void glGetActiveUniformsiv(uint program, int uniformCount, nint uniformIndices, uint pname, nint @params) { _glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params); }
        public static void glGetIntegeri_v(uint target, uint index, nint data) { _glGetIntegeri_v(target, index, data); }
        public static uint glGetUniformBlockIndex(uint program, nint uniformBlockName) { return _glGetUniformBlockIndex(program, uniformBlockName); }
        public static void glGetUniformIndices(uint program, int uniformCount, nint uniformNames, nint uniformIndices) { _glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices); }
        public static void glPrimitiveRestartIndex(uint index) { _glPrimitiveRestartIndex(index); }
        public static void glTexBuffer(uint target, uint internalformat, uint buffer) { _glTexBuffer(target, internalformat, buffer); }
        public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) { _glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding); }

        internal static void Load(DelegatePtrSource src)
        {
            _glBindBufferBase = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glBindBufferBase");
            _glBindBufferRange = (delegate* unmanaged[Stdcall]<uint, uint, uint, nint, nint, void>)src.GetFuncPtr("glBindBufferRange");
            _glCopyBufferSubData = (delegate* unmanaged[Stdcall]<uint, uint, nint, nint, nint, void>)src.GetFuncPtr("glCopyBufferSubData");
            _glDrawArraysInstanced = (delegate* unmanaged[Stdcall]<uint, int, int, int, void>)src.GetFuncPtr("glDrawArraysInstanced");
            _glDrawElementsInstanced = (delegate* unmanaged[Stdcall]<uint, int, uint, nint, int, void>)src.GetFuncPtr("glDrawElementsInstanced");
            _glGetActiveUniformBlockName = (delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, void>)src.GetFuncPtr("glGetActiveUniformBlockName");
            _glGetActiveUniformBlockiv = (delegate* unmanaged[Stdcall]<uint, uint, uint, nint, void>)src.GetFuncPtr("glGetActiveUniformBlockiv");
            _glGetActiveUniformName = (delegate* unmanaged[Stdcall]<uint, uint, int, nint, nint, void>)src.GetFuncPtr("glGetActiveUniformName");
            _glGetActiveUniformsiv = (delegate* unmanaged[Stdcall]<uint, int, nint, uint, nint, void>)src.GetFuncPtr("glGetActiveUniformsiv");
            _glGetIntegeri_v = (delegate* unmanaged[Stdcall]<uint, uint, nint, void>)src.GetFuncPtr("glGetIntegeri_v");
            _glGetUniformBlockIndex = (delegate* unmanaged[Stdcall]<uint, nint, uint>)src.GetFuncPtr("glGetUniformBlockIndex");
            _glGetUniformIndices = (delegate* unmanaged[Stdcall]<uint, int, nint, nint, void>)src.GetFuncPtr("glGetUniformIndices");
            _glPrimitiveRestartIndex = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glPrimitiveRestartIndex");
            _glTexBuffer = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glTexBuffer");
            _glUniformBlockBinding = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glUniformBlockBinding");
        }

        internal static void Unload()
        {
            _glBindBufferBase = null;
            _glBindBufferRange = null;
            _glCopyBufferSubData = null;
            _glDrawArraysInstanced = null;
            _glDrawElementsInstanced = null;
            _glGetActiveUniformBlockName = null;
            _glGetActiveUniformBlockiv = null;
            _glGetActiveUniformName = null;
            _glGetActiveUniformsiv = null;
            _glGetIntegeri_v = null;
            _glGetUniformBlockIndex = null;
            _glGetUniformIndices = null;
            _glPrimitiveRestartIndex = null;
            _glTexBuffer = null;
            _glUniformBlockBinding = null;
        }
    }
}
