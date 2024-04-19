using System;

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// An exception thrown when performing OpenGL operations
    /// </summary>
    public class OpenGLException : Exception
    {
        internal OpenGLException(string msg) : base(msg) { }
    }
}
