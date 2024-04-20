using System;
using System.Numerics;
using System.Runtime.InteropServices;
using static LWCSGL.OpenGL.GL11;
using static LWCSGL.OpenGL.GL11C;

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// Utilities for OpenGL
    /// </summary>
    public static class GLU
    {
        private static float Deg2Rad(float degrees)
            => degrees * (float)Math.PI / 180.0F;

        /// <summary>
        /// Set up a perspective projection matrix
        /// </summary>
        /// <param name="fovy">Specifies the field of view angle, in degrees, in the y direction.</param>
        /// <param name="aspect">Specifies the aspect ratio that determines 
        /// the field of view in the x direction. 
        /// The aspect ratio is the ratio of x (width) to y (height). </param>
        /// <param name="zNear">Specifies the distance from the viewer to the near clipping plane (always positive). </param>
        /// <param name="zFar">Specifies the distance from the viewer to the far clipping plane (always positive). </param>
        public static void gluPerspective(float fovy,
            float aspect, float zNear, float zFar)
        {
            Matrix4x4 matrix = Matrix4x4.CreatePerspectiveFieldOfView(
                Deg2Rad(fovy), aspect, zNear, zFar);

            glMultMatrixf(new float[]
            {
                matrix.M11, matrix.M12, matrix.M13, matrix.M14,
                matrix.M21, matrix.M22, matrix.M23, matrix.M24,
                matrix.M31, matrix.M32, matrix.M33, matrix.M34,
                matrix.M41, matrix.M42, matrix.M43, matrix.M44,
            });
        }

        /// <summary>
        /// Wrapper for glGetString to return a managed string instance
        /// </summary>
        /// <param name="name">The name of the string to get</param>
        /// <returns>The result of glGetString or null on failure</returns>
        public static string GetGLString(uint name)
        {
            return Marshal.PtrToStringAnsi(glGetString(name));
        }

        /// <summary>
        /// Maps an OpenGL error code to a friendly error message
        /// </summary>
        /// <param name="errorCode">The OpenGL error code</param>
        /// <returns>The friendly error message or an empty string on failure</returns>
        public static string gluErrorString(uint errorCode)
        {
            switch (errorCode)
            {
                case GL_NO_ERROR:
                    return "No error";
                case GL_INVALID_ENUM:
                    return "Invalid enum";
                case GL_INVALID_VALUE:
                    return "Invalid value";
                case GL_INVALID_OPERATION:
                    return "Invalid operation";
                case GL_STACK_OVERFLOW:
                    return "Stack overflow";
                case GL_STACK_UNDERFLOW:
                    return "Stack underflow";
                case GL_OUT_OF_MEMORY:
                    return "Out of memory";
                default:
                    return "";
            }
        }
    }
}
