﻿using System;
using System.Runtime.InteropServices;

/*
 * Code originally written by Dart (https://github.com/dart25)
 * Modified to meet the needs of the library
*/

namespace LWCSGL.OpenGL 
{
    internal class GLPtrSource : IDisposable
    {
        private const string LIBRARY_NAME = "OpenGL32.dll";

        [DllImport("KERNEL32.DLL")]
        private static extern nint GetProcAddress(nint module, [MarshalAs(UnmanagedType.LPStr)] string procName);
        
        [DllImport("KERNEL32.DLL")]
        private static extern nint LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string lib);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(nint hLibModule);

        private static readonly nint libHandle = LoadLibraryA(LIBRARY_NAME);

        public nint GetFuncPtr(string func)
        {
            nint addr = WGL.wglGetProcAddress(func);
            if (addr == nint.Zero) addr = GetProcAddress(libHandle, func);
            return addr;
        }

        public void Dispose()
        {
            FreeLibrary(libHandle);
        }
    }
}