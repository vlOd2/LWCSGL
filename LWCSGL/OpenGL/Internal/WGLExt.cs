namespace LWCSGL.OpenGL.Internal
{
    internal unsafe class WGLExt
    {
        private static delegate* unmanaged[Stdcall]<int, bool> _wglSwapInterval;
        private static delegate* unmanaged[Stdcall]<int> _wglGetSwapInterval;

        public static bool wglSwapInterval(int interval) { return _wglSwapInterval(interval); }
        public static int wglGetSwapInterval() { return _wglGetSwapInterval(); }

        internal static void Load(DelegatePtrSource src)
        {
            _wglSwapInterval = (delegate* unmanaged[Stdcall]<int, bool>)src.GetFuncPtr("wglSwapIntervalEXT");
            _wglGetSwapInterval = (delegate* unmanaged[Stdcall]<int>)src.GetFuncPtr("wglGetSwapIntervalEXT");
        }

        internal static void Unload()
        {
            _wglSwapInterval = null;
            _wglGetSwapInterval = null;
        }
    }
}
