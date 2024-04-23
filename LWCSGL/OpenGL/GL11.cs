#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// OpenGL 1.1 APIs
    /// </summary>
    public unsafe static class GL11
    {
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glAccum;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glAlphaFunc;
        private static delegate* unmanaged[Stdcall]<uint, void> _glBegin;
        private static delegate* unmanaged[Stdcall]<int, int, float, float, float, float, byte[], void> _glBitmap;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glBlendFunc;
        private static delegate* unmanaged[Stdcall]<uint, void> _glCallList;
        private static delegate* unmanaged[Stdcall]<int, uint, nint, void> _glCallLists;
        private static delegate* unmanaged[Stdcall]<uint, void> _glClear;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glClearAccum;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glClearColor;
        private static delegate* unmanaged[Stdcall]<double, void> _glClearDepth;
        private static delegate* unmanaged[Stdcall]<float, void> _glClearIndex;
        private static delegate* unmanaged[Stdcall]<int, void> _glClearStencil;
        private static delegate* unmanaged[Stdcall]<uint, double[], void> _glClipPlane;
        private static delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void> _glColor3b;
        private static delegate* unmanaged[Stdcall]<sbyte[], void> _glColor3bv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glColor3d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glColor3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glColor3f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glColor3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glColor3i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glColor3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glColor3s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glColor3sv;
        private static delegate* unmanaged[Stdcall]<byte, byte, byte, void> _glColor3ub;
        private static delegate* unmanaged[Stdcall]<byte[], void> _glColor3ubv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glColor3ui;
        private static delegate* unmanaged[Stdcall]<uint[], void> _glColor3uiv;
        private static delegate* unmanaged[Stdcall]<ushort, ushort, ushort, void> _glColor3us;
        private static delegate* unmanaged[Stdcall]<ushort[], void> _glColor3usv;
        private static delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, sbyte, void> _glColor4b;
        private static delegate* unmanaged[Stdcall]<sbyte[], void> _glColor4bv;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glColor4d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glColor4dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glColor4f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glColor4fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glColor4i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glColor4iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, short, void> _glColor4s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glColor4sv;
        private static delegate* unmanaged[Stdcall]<byte, byte, byte, byte, void> _glColor4ub;
        private static delegate* unmanaged[Stdcall]<byte[], void> _glColor4ubv;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void> _glColor4ui;
        private static delegate* unmanaged[Stdcall]<uint[], void> _glColor4uiv;
        private static delegate* unmanaged[Stdcall]<ushort, ushort, ushort, ushort, void> _glColor4us;
        private static delegate* unmanaged[Stdcall]<ushort[], void> _glColor4usv;
        private static delegate* unmanaged[Stdcall]<bool, bool, bool, bool, void> _glColorMask;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glColorMaterial;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, uint, void> _glCopyPixels;
        private static delegate* unmanaged[Stdcall]<uint, void> _glCullFace;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glDeleteLists;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDepthFunc;
        private static delegate* unmanaged[Stdcall]<bool, void> _glDepthMask;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glDepthRange;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDisable;
        private static delegate* unmanaged[Stdcall]<uint, void> _glDrawBuffer;
        private static delegate* unmanaged[Stdcall]<int, int, uint, uint, nint, void> _glDrawPixels;
        private static delegate* unmanaged[Stdcall]<bool, void> _glEdgeFlag;
        private static delegate* unmanaged[Stdcall]<bool[], void> _glEdgeFlagv;
        private static delegate* unmanaged[Stdcall]<uint, void> _glEnable;
        private static delegate* unmanaged[Stdcall]<void> _glEnd;
        private static delegate* unmanaged[Stdcall]<void> _glEndList;
        private static delegate* unmanaged[Stdcall]<double, void> _glEvalCoord1d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glEvalCoord1dv;
        private static delegate* unmanaged[Stdcall]<float, void> _glEvalCoord1f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glEvalCoord1fv;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glEvalCoord2d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glEvalCoord2dv;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glEvalCoord2f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glEvalCoord2fv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, void> _glEvalMesh1;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, void> _glEvalMesh2;
        private static delegate* unmanaged[Stdcall]<int, void> _glEvalPoint1;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glEvalPoint2;
        private static delegate* unmanaged[Stdcall]<int, uint, float[], void> _glFeedbackBuffer;
        private static delegate* unmanaged[Stdcall]<void> _glFinish;
        private static delegate* unmanaged[Stdcall]<void> _glFlush;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glFogf;
        private static delegate* unmanaged[Stdcall]<uint, float[], void> _glFogfv;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glFogi;
        private static delegate* unmanaged[Stdcall]<uint, int[], void> _glFogiv;
        private static delegate* unmanaged[Stdcall]<uint, void> _glFrontFace;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, double, double, void> _glFrustum;
        private static delegate* unmanaged[Stdcall]<int, uint> _glGenLists;
        private static delegate* unmanaged[Stdcall]<uint, bool[], void> _glGetBooleanv;
        private static delegate* unmanaged[Stdcall]<uint, double[], void> _glGetClipPlane;
        private static delegate* unmanaged[Stdcall]<uint, double[], void> _glGetDoublev;
        private static delegate* unmanaged[Stdcall]<uint> _glGetError;
        private static delegate* unmanaged[Stdcall]<uint, float[], void> _glGetFloatv;
        private static delegate* unmanaged[Stdcall]<uint, int[], void> _glGetIntegerv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetLightfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetLightiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, double[], void> _glGetMapdv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetMapfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetMapiv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetMaterialfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetMaterialiv;
        private static delegate* unmanaged[Stdcall]<uint, float[], void> _glGetPixelMapfv;
        private static delegate* unmanaged[Stdcall]<uint, uint[], void> _glGetPixelMapuiv;
        private static delegate* unmanaged[Stdcall]<uint, ushort[], void> _glGetPixelMapusv;
        private static delegate* unmanaged[Stdcall]<byte[], void> _glGetPolygonStipple;
        private static delegate* unmanaged[Stdcall]<uint, nint> _glGetString;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetTexEnvfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetTexEnviv;
        private static delegate* unmanaged[Stdcall]<uint, uint, double[], void> _glGetTexGendv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetTexGenfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetTexGeniv;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, uint, nint, void> _glGetTexImage;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, float[], void> _glGetTexLevelParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, int[], void> _glGetTexLevelParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glGetTexParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glGetTexParameteriv;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glHint;
        private static delegate* unmanaged[Stdcall]<uint, void> _glIndexMask;
        private static delegate* unmanaged[Stdcall]<double, void> _glIndexd;
        private static delegate* unmanaged[Stdcall]<double[], void> _glIndexdv;
        private static delegate* unmanaged[Stdcall]<float, void> _glIndexf;
        private static delegate* unmanaged[Stdcall]<float[], void> _glIndexfv;
        private static delegate* unmanaged[Stdcall]<int, void> _glIndexi;
        private static delegate* unmanaged[Stdcall]<int[], void> _glIndexiv;
        private static delegate* unmanaged[Stdcall]<short, void> _glIndexs;
        private static delegate* unmanaged[Stdcall]<short[], void> _glIndexsv;
        private static delegate* unmanaged[Stdcall]<void> _glInitNames;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsEnabled;
        private static delegate* unmanaged[Stdcall]<uint, bool> _glIsList;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glLightModelf;
        private static delegate* unmanaged[Stdcall]<uint, float[], void> _glLightModelfv;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glLightModeli;
        private static delegate* unmanaged[Stdcall]<uint, int[], void> _glLightModeliv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glLightf;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glLightfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glLighti;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glLightiv;
        private static delegate* unmanaged[Stdcall]<int, ushort, void> _glLineStipple;
        private static delegate* unmanaged[Stdcall]<float, void> _glLineWidth;
        private static delegate* unmanaged[Stdcall]<uint, void> _glListBase;
        private static delegate* unmanaged[Stdcall]<void> _glLoadIdentity;
        private static delegate* unmanaged[Stdcall]<double[], void> _glLoadMatrixd;
        private static delegate* unmanaged[Stdcall]<float[], void> _glLoadMatrixf;
        private static delegate* unmanaged[Stdcall]<uint, void> _glLoadName;
        private static delegate* unmanaged[Stdcall]<uint, void> _glLogicOp;
        private static delegate* unmanaged[Stdcall]<uint, double, double, int, int, double[], void> _glMap1d;
        private static delegate* unmanaged[Stdcall]<uint, float, float, int, int, float[], void> _glMap1f;
        private static delegate* unmanaged[Stdcall]<uint, double, double, int, int, double, double, int, int, double[], void> _glMap2d;
        private static delegate* unmanaged[Stdcall]<uint, float, float, int, int, float, float, int, int, float[], void> _glMap2f;
        private static delegate* unmanaged[Stdcall]<int, double, double, void> _glMapGrid1d;
        private static delegate* unmanaged[Stdcall]<int, float, float, void> _glMapGrid1f;
        private static delegate* unmanaged[Stdcall]<int, double, double, int, double, double, void> _glMapGrid2d;
        private static delegate* unmanaged[Stdcall]<int, float, float, int, float, float, void> _glMapGrid2f;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glMaterialf;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glMaterialfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glMateriali;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glMaterialiv;
        private static delegate* unmanaged[Stdcall]<uint, void> _glMatrixMode;
        private static delegate* unmanaged[Stdcall]<double[], void> _glMultMatrixd;
        private static delegate* unmanaged[Stdcall]<float[], void> _glMultMatrixf;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glNewList;
        private static delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void> _glNormal3b;
        private static delegate* unmanaged[Stdcall]<sbyte[], void> _glNormal3bv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glNormal3d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glNormal3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glNormal3f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glNormal3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glNormal3i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glNormal3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glNormal3s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glNormal3sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, double, double, void> _glOrtho;
        private static delegate* unmanaged[Stdcall]<float, void> _glPassThrough;
        private static delegate* unmanaged[Stdcall]<uint, int, float[], void> _glPixelMapfv;
        private static delegate* unmanaged[Stdcall]<uint, int, uint[], void> _glPixelMapuiv;
        private static delegate* unmanaged[Stdcall]<uint, int, ushort[], void> _glPixelMapusv;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glPixelStoref;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glPixelStorei;
        private static delegate* unmanaged[Stdcall]<uint, float, void> _glPixelTransferf;
        private static delegate* unmanaged[Stdcall]<uint, int, void> _glPixelTransferi;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glPixelZoom;
        private static delegate* unmanaged[Stdcall]<float, void> _glPointSize;
        private static delegate* unmanaged[Stdcall]<uint, uint, void> _glPolygonMode;
        private static delegate* unmanaged[Stdcall]<byte[], void> _glPolygonStipple;
        private static delegate* unmanaged[Stdcall]<void> _glPopAttrib;
        private static delegate* unmanaged[Stdcall]<void> _glPopMatrix;
        private static delegate* unmanaged[Stdcall]<void> _glPopName;
        private static delegate* unmanaged[Stdcall]<uint, void> _glPushAttrib;
        private static delegate* unmanaged[Stdcall]<void> _glPushMatrix;
        private static delegate* unmanaged[Stdcall]<uint, void> _glPushName;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glRasterPos2d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glRasterPos2dv;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glRasterPos2f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glRasterPos2fv;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glRasterPos2i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glRasterPos2iv;
        private static delegate* unmanaged[Stdcall]<short, short, void> _glRasterPos2s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glRasterPos2sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glRasterPos3d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glRasterPos3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glRasterPos3f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glRasterPos3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glRasterPos3i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glRasterPos3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glRasterPos3s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glRasterPos3sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glRasterPos4d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glRasterPos4dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glRasterPos4f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glRasterPos4fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glRasterPos4i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glRasterPos4iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, short, void> _glRasterPos4s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glRasterPos4sv;
        private static delegate* unmanaged[Stdcall]<uint, void> _glReadBuffer;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, uint, uint, nint, void> _glReadPixels;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glRectd;
        private static delegate* unmanaged[Stdcall]<double[], double[], void> _glRectdv;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glRectf;
        private static delegate* unmanaged[Stdcall]<float[], float[], void> _glRectfv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glRecti;
        private static delegate* unmanaged[Stdcall]<int[], int[], void> _glRectiv;
        private static delegate* unmanaged[Stdcall]<short, short, short, short, void> _glRects;
        private static delegate* unmanaged[Stdcall]<short[], short[], void> _glRectsv;
        private static delegate* unmanaged[Stdcall]<uint, int> _glRenderMode;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glRotated;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glRotatef;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glScaled;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glScalef;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glScissor;
        private static delegate* unmanaged[Stdcall]<int, uint[], void> _glSelectBuffer;
        private static delegate* unmanaged[Stdcall]<uint, void> _glShadeModel;
        private static delegate* unmanaged[Stdcall]<uint, int, uint, void> _glStencilFunc;
        private static delegate* unmanaged[Stdcall]<uint, void> _glStencilMask;
        private static delegate* unmanaged[Stdcall]<uint, uint, uint, void> _glStencilOp;
        private static delegate* unmanaged[Stdcall]<double, void> _glTexCoord1d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glTexCoord1dv;
        private static delegate* unmanaged[Stdcall]<float, void> _glTexCoord1f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glTexCoord1fv;
        private static delegate* unmanaged[Stdcall]<int, void> _glTexCoord1i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glTexCoord1iv;
        private static delegate* unmanaged[Stdcall]<short, void> _glTexCoord1s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glTexCoord1sv;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glTexCoord2d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glTexCoord2dv;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glTexCoord2f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glTexCoord2fv;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glTexCoord2i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glTexCoord2iv;
        private static delegate* unmanaged[Stdcall]<short, short, void> _glTexCoord2s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glTexCoord2sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glTexCoord3d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glTexCoord3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glTexCoord3f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glTexCoord3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glTexCoord3i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glTexCoord3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glTexCoord3s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glTexCoord3sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glTexCoord4d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glTexCoord4dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glTexCoord4f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glTexCoord4fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glTexCoord4i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glTexCoord4iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, short, void> _glTexCoord4s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glTexCoord4sv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glTexEnvf;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glTexEnvfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glTexEnvi;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glTexEnviv;
        private static delegate* unmanaged[Stdcall]<uint, uint, double, void> _glTexGend;
        private static delegate* unmanaged[Stdcall]<uint, uint, double[], void> _glTexGendv;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glTexGenf;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glTexGenfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glTexGeni;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glTexGeniv;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, uint, uint, nint, void> _glTexImage1D;
        private static delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, uint, uint, nint, void> _glTexImage2D;
        private static delegate* unmanaged[Stdcall]<uint, uint, float, void> _glTexParameterf;
        private static delegate* unmanaged[Stdcall]<uint, uint, float[], void> _glTexParameterfv;
        private static delegate* unmanaged[Stdcall]<uint, uint, int, void> _glTexParameteri;
        private static delegate* unmanaged[Stdcall]<uint, uint, int[], void> _glTexParameteriv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glTranslated;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glTranslatef;
        private static delegate* unmanaged[Stdcall]<double, double, void> _glVertex2d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glVertex2dv;
        private static delegate* unmanaged[Stdcall]<float, float, void> _glVertex2f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glVertex2fv;
        private static delegate* unmanaged[Stdcall]<int, int, void> _glVertex2i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glVertex2iv;
        private static delegate* unmanaged[Stdcall]<short, short, void> _glVertex2s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glVertex2sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, void> _glVertex3d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glVertex3dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, void> _glVertex3f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glVertex3fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, void> _glVertex3i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glVertex3iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, void> _glVertex3s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glVertex3sv;
        private static delegate* unmanaged[Stdcall]<double, double, double, double, void> _glVertex4d;
        private static delegate* unmanaged[Stdcall]<double[], void> _glVertex4dv;
        private static delegate* unmanaged[Stdcall]<float, float, float, float, void> _glVertex4f;
        private static delegate* unmanaged[Stdcall]<float[], void> _glVertex4fv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glVertex4i;
        private static delegate* unmanaged[Stdcall]<int[], void> _glVertex4iv;
        private static delegate* unmanaged[Stdcall]<short, short, short, short, void> _glVertex4s;
        private static delegate* unmanaged[Stdcall]<short[], void> _glVertex4sv;
        private static delegate* unmanaged[Stdcall]<int, int, int, int, void> _glViewport;

        public static void glAccum(uint op, float value) { _glAccum(op, value); }
        public static void glAlphaFunc(uint func, float @ref) { _glAlphaFunc(func, @ref); }
        public static void glBegin(uint mode) { _glBegin(mode); }
        public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap) { _glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap); }
        public static void glBlendFunc(uint sfactor, uint dfactor) { _glBlendFunc(sfactor, dfactor); }
        public static void glCallList(uint list) { _glCallList(list); }
        public static void glCallLists(int n, uint type, nint lists) { _glCallLists(n, type, lists); }
        public static void glClear(uint mask) { _glClear(mask); }
        public static void glClearAccum(float red, float green, float blue, float alpha) { _glClearAccum(red, green, blue, alpha); }
        public static void glClearColor(float red, float green, float blue, float alpha) { _glClearColor(red, green, blue, alpha); }
        public static void glClearDepth(double depth) { _glClearDepth(depth); }
        public static void glClearIndex(float c) { _glClearIndex(c); }
        public static void glClearStencil(int s) { _glClearStencil(s); }
        public static void glClipPlane(uint plane, double[] equation) { _glClipPlane(plane, equation); }
        public static void glColor3b(sbyte red, sbyte green, sbyte blue) { _glColor3b(red, green, blue); }
        public static void glColor3bv(sbyte[] v) { _glColor3bv(v); }
        public static void glColor3d(double red, double green, double blue) { _glColor3d(red, green, blue); }
        public static void glColor3dv(double[] v) { _glColor3dv(v); }
        public static void glColor3f(float red, float green, float blue) { _glColor3f(red, green, blue); }
        public static void glColor3fv(float[] v) { _glColor3fv(v); }
        public static void glColor3i(int red, int green, int blue) { _glColor3i(red, green, blue); }
        public static void glColor3iv(int[] v) { _glColor3iv(v); }
        public static void glColor3s(short red, short green, short blue) { _glColor3s(red, green, blue); }
        public static void glColor3sv(short[] v) { _glColor3sv(v); }
        public static void glColor3ub(byte red, byte green, byte blue) { _glColor3ub(red, green, blue); }
        public static void glColor3ubv(byte[] v) { _glColor3ubv(v); }
        public static void glColor3ui(uint red, uint green, uint blue) { _glColor3ui(red, green, blue); }
        public static void glColor3uiv(uint[] v) { _glColor3uiv(v); }
        public static void glColor3us(ushort red, ushort green, ushort blue) { _glColor3us(red, green, blue); }
        public static void glColor3usv(ushort[] v) { _glColor3usv(v); }
        public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) { _glColor4b(red, green, blue, alpha); }
        public static void glColor4bv(sbyte[] v) { _glColor4bv(v); }
        public static void glColor4d(double red, double green, double blue, double alpha) { _glColor4d(red, green, blue, alpha); }
        public static void glColor4dv(double[] v) { _glColor4dv(v); }
        public static void glColor4f(float red, float green, float blue, float alpha) { _glColor4f(red, green, blue, alpha); }
        public static void glColor4fv(float[] v) { _glColor4fv(v); }
        public static void glColor4i(int red, int green, int blue, int alpha) { _glColor4i(red, green, blue, alpha); }
        public static void glColor4iv(int[] v) { _glColor4iv(v); }
        public static void glColor4s(short red, short green, short blue, short alpha) { _glColor4s(red, green, blue, alpha); }
        public static void glColor4sv(short[] v) { _glColor4sv(v); }
        public static void glColor4ub(byte red, byte green, byte blue, byte alpha) { _glColor4ub(red, green, blue, alpha); }
        public static void glColor4ubv(byte[] v) { _glColor4ubv(v); }
        public static void glColor4ui(uint red, uint green, uint blue, uint alpha) { _glColor4ui(red, green, blue, alpha); }
        public static void glColor4uiv(uint[] v) { _glColor4uiv(v); }
        public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) { _glColor4us(red, green, blue, alpha); }
        public static void glColor4usv(ushort[] v) { _glColor4usv(v); }
        public static void glColorMask(bool red, bool green, bool blue, bool alpha) { _glColorMask(red, green, blue, alpha); }
        public static void glColorMaterial(uint face, uint mode) { _glColorMaterial(face, mode); }
        public static void glCopyPixels(int x, int y, int width, int height, uint type) { _glCopyPixels(x, y, width, height, type); }
        public static void glCullFace(uint mode) { _glCullFace(mode); }
        public static void glDeleteLists(uint list, int range) { _glDeleteLists(list, range); }
        public static void glDepthFunc(uint func) { _glDepthFunc(func); }
        public static void glDepthMask(bool flag) { _glDepthMask(flag); }
        public static void glDepthRange(double n, double f) { _glDepthRange(n, f); }
        public static void glDisable(uint cap) { _glDisable(cap); }
        public static void glDrawBuffer(uint buf) { _glDrawBuffer(buf); }
        public static void glDrawPixels(int width, int height, uint format, uint type, nint pixels) { _glDrawPixels(width, height, format, type, pixels); }
        public static void glEdgeFlag(bool flag) { _glEdgeFlag(flag); }
        public static void glEdgeFlagv(bool[] flag) { _glEdgeFlagv(flag); }
        public static void glEnable(uint cap) { _glEnable(cap); }
        public static void glEnd() { _glEnd(); }
        public static void glEndList() { _glEndList(); }
        public static void glEvalCoord1d(double u) { _glEvalCoord1d(u); }
        public static void glEvalCoord1dv(double[] u) { _glEvalCoord1dv(u); }
        public static void glEvalCoord1f(float u) { _glEvalCoord1f(u); }
        public static void glEvalCoord1fv(float[] u) { _glEvalCoord1fv(u); }
        public static void glEvalCoord2d(double u, double v) { _glEvalCoord2d(u, v); }
        public static void glEvalCoord2dv(double[] u) { _glEvalCoord2dv(u); }
        public static void glEvalCoord2f(float u, float v) { _glEvalCoord2f(u, v); }
        public static void glEvalCoord2fv(float[] u) { _glEvalCoord2fv(u); }
        public static void glEvalMesh1(uint mode, int i1, int i2) { _glEvalMesh1(mode, i1, i2); }
        public static void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2) { _glEvalMesh2(mode, i1, i2, j1, j2); }
        public static void glEvalPoint1(int i) { _glEvalPoint1(i); }
        public static void glEvalPoint2(int i, int j) { _glEvalPoint2(i, j); }
        public static void glFeedbackBuffer(int size, uint type, float[] buffer) { _glFeedbackBuffer(size, type, buffer); }
        public static void glFinish() { _glFinish(); }
        public static void glFlush() { _glFlush(); }
        public static void glFogf(uint pname, float param) { _glFogf(pname, param); }
        public static void glFogfv(uint pname, float[] @params) { _glFogfv(pname, @params); }
        public static void glFogi(uint pname, int param) { _glFogi(pname, param); }
        public static void glFogiv(uint pname, int[] @params) { _glFogiv(pname, @params); }
        public static void glFrontFace(uint mode) { _glFrontFace(mode); }
        public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) { _glFrustum(left, right, bottom, top, zNear, zFar); }
        public static uint glGenLists(int range) { return _glGenLists(range); }
        public static void glGetBooleanv(uint pname, bool[] data) { _glGetBooleanv(pname, data); }
        public static void glGetClipPlane(uint plane, double[] equation) { _glGetClipPlane(plane, equation); }
        public static void glGetDoublev(uint pname, double[] data) { _glGetDoublev(pname, data); }
        public static uint glGetError() { return _glGetError(); }
        public static void glGetFloatv(uint pname, float[] data) { _glGetFloatv(pname, data); }
        public static void glGetIntegerv(uint pname, int[] data) { _glGetIntegerv(pname, data); }
        public static void glGetLightfv(uint light, uint pname, float[] @params) { _glGetLightfv(light, pname, @params); }
        public static void glGetLightiv(uint light, uint pname, int[] @params) { _glGetLightiv(light, pname, @params); }
        public static void glGetMapdv(uint target, uint query, double[] v) { _glGetMapdv(target, query, v); }
        public static void glGetMapfv(uint target, uint query, float[] v) { _glGetMapfv(target, query, v); }
        public static void glGetMapiv(uint target, uint query, int[] v) { _glGetMapiv(target, query, v); }
        public static void glGetMaterialfv(uint face, uint pname, float[] @params) { _glGetMaterialfv(face, pname, @params); }
        public static void glGetMaterialiv(uint face, uint pname, int[] @params) { _glGetMaterialiv(face, pname, @params); }
        public static void glGetPixelMapfv(uint map, float[] values) { _glGetPixelMapfv(map, values); }
        public static void glGetPixelMapuiv(uint map, uint[] values) { _glGetPixelMapuiv(map, values); }
        public static void glGetPixelMapusv(uint map, ushort[] values) { _glGetPixelMapusv(map, values); }
        public static void glGetPolygonStipple(byte[] mask) { _glGetPolygonStipple(mask); }
        public static nint glGetString(uint name) { return _glGetString(name); }
        public static void glGetTexEnvfv(uint target, uint pname, float[] @params) { _glGetTexEnvfv(target, pname, @params); }
        public static void glGetTexEnviv(uint target, uint pname, int[] @params) { _glGetTexEnviv(target, pname, @params); }
        public static void glGetTexGendv(uint coord, uint pname, double[] @params) { _glGetTexGendv(coord, pname, @params); }
        public static void glGetTexGenfv(uint coord, uint pname, float[] @params) { _glGetTexGenfv(coord, pname, @params); }
        public static void glGetTexGeniv(uint coord, uint pname, int[] @params) { _glGetTexGeniv(coord, pname, @params); }
        public static void glGetTexImage(uint target, int level, uint format, uint type, nint pixels) { _glGetTexImage(target, level, format, type, pixels); }
        public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params) { _glGetTexLevelParameterfv(target, level, pname, @params); }
        public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params) { _glGetTexLevelParameteriv(target, level, pname, @params); }
        public static void glGetTexParameterfv(uint target, uint pname, float[] @params) { _glGetTexParameterfv(target, pname, @params); }
        public static void glGetTexParameteriv(uint target, uint pname, int[] @params) { _glGetTexParameteriv(target, pname, @params); }
        public static void glHint(uint target, uint mode) { _glHint(target, mode); }
        public static void glIndexMask(uint mask) { _glIndexMask(mask); }
        public static void glIndexd(double c) { _glIndexd(c); }
        public static void glIndexdv(double[] c) { _glIndexdv(c); }
        public static void glIndexf(float c) { _glIndexf(c); }
        public static void glIndexfv(float[] c) { _glIndexfv(c); }
        public static void glIndexi(int c) { _glIndexi(c); }
        public static void glIndexiv(int[] c) { _glIndexiv(c); }
        public static void glIndexs(short c) { _glIndexs(c); }
        public static void glIndexsv(short[] c) { _glIndexsv(c); }
        public static void glInitNames() { _glInitNames(); }
        public static bool glIsEnabled(uint cap) { return _glIsEnabled(cap); }
        public static bool glIsList(uint list) { return _glIsList(list); }
        public static void glLightModelf(uint pname, float param) { _glLightModelf(pname, param); }
        public static void glLightModelfv(uint pname, float[] @params) { _glLightModelfv(pname, @params); }
        public static void glLightModeli(uint pname, int param) { _glLightModeli(pname, param); }
        public static void glLightModeliv(uint pname, int[] @params) { _glLightModeliv(pname, @params); }
        public static void glLightf(uint light, uint pname, float param) { _glLightf(light, pname, param); }
        public static void glLightfv(uint light, uint pname, float[] @params) { _glLightfv(light, pname, @params); }
        public static void glLighti(uint light, uint pname, int param) { _glLighti(light, pname, param); }
        public static void glLightiv(uint light, uint pname, int[] @params) { _glLightiv(light, pname, @params); }
        public static void glLineStipple(int factor, ushort pattern) { _glLineStipple(factor, pattern); }
        public static void glLineWidth(float width) { _glLineWidth(width); }
        public static void glListBase(uint @base) { _glListBase(@base); }
        public static void glLoadIdentity() { _glLoadIdentity(); }
        public static void glLoadMatrixd(double[] m) { _glLoadMatrixd(m); }
        public static void glLoadMatrixf(float[] m) { _glLoadMatrixf(m); }
        public static void glLoadName(uint name) { _glLoadName(name); }
        public static void glLogicOp(uint opcode) { _glLogicOp(opcode); }
        public static void glMap1d(uint target, double u1, double u2, int stride, int order, double[] points) { _glMap1d(target, u1, u2, stride, order, points); }
        public static void glMap1f(uint target, float u1, float u2, int stride, int order, float[] points) { _glMap1f(target, u1, u2, stride, order, points); }
        public static void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points) { _glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
        public static void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points) { _glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
        public static void glMapGrid1d(int un, double u1, double u2) { _glMapGrid1d(un, u1, u2); }
        public static void glMapGrid1f(int un, float u1, float u2) { _glMapGrid1f(un, u1, u2); }
        public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) { _glMapGrid2d(un, u1, u2, vn, v1, v2); }
        public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) { _glMapGrid2f(un, u1, u2, vn, v1, v2); }
        public static void glMaterialf(uint face, uint pname, float param) { _glMaterialf(face, pname, param); }
        public static void glMaterialfv(uint face, uint pname, float[] @params) { _glMaterialfv(face, pname, @params); }
        public static void glMateriali(uint face, uint pname, int param) { _glMateriali(face, pname, param); }
        public static void glMaterialiv(uint face, uint pname, int[] @params) { _glMaterialiv(face, pname, @params); }
        public static void glMatrixMode(uint mode) { _glMatrixMode(mode); }
        public static void glMultMatrixd(double[] m) { _glMultMatrixd(m); }
        public static void glMultMatrixf(float[] m) { _glMultMatrixf(m); }
        public static void glNewList(uint list, uint mode) { _glNewList(list, mode); }
        public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz) { _glNormal3b(nx, ny, nz); }
        public static void glNormal3bv(sbyte[] v) { _glNormal3bv(v); }
        public static void glNormal3d(double nx, double ny, double nz) { _glNormal3d(nx, ny, nz); }
        public static void glNormal3dv(double[] v) { _glNormal3dv(v); }
        public static void glNormal3f(float nx, float ny, float nz) { _glNormal3f(nx, ny, nz); }
        public static void glNormal3fv(float[] v) { _glNormal3fv(v); }
        public static void glNormal3i(int nx, int ny, int nz) { _glNormal3i(nx, ny, nz); }
        public static void glNormal3iv(int[] v) { _glNormal3iv(v); }
        public static void glNormal3s(short nx, short ny, short nz) { _glNormal3s(nx, ny, nz); }
        public static void glNormal3sv(short[] v) { _glNormal3sv(v); }
        public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) { _glOrtho(left, right, bottom, top, zNear, zFar); }
        public static void glPassThrough(float token) { _glPassThrough(token); }
        public static void glPixelMapfv(uint map, int mapsize, float[] values) { _glPixelMapfv(map, mapsize, values); }
        public static void glPixelMapuiv(uint map, int mapsize, uint[] values) { _glPixelMapuiv(map, mapsize, values); }
        public static void glPixelMapusv(uint map, int mapsize, ushort[] values) { _glPixelMapusv(map, mapsize, values); }
        public static void glPixelStoref(uint pname, float param) { _glPixelStoref(pname, param); }
        public static void glPixelStorei(uint pname, int param) { _glPixelStorei(pname, param); }
        public static void glPixelTransferf(uint pname, float param) { _glPixelTransferf(pname, param); }
        public static void glPixelTransferi(uint pname, int param) { _glPixelTransferi(pname, param); }
        public static void glPixelZoom(float xfactor, float yfactor) { _glPixelZoom(xfactor, yfactor); }
        public static void glPointSize(float size) { _glPointSize(size); }
        public static void glPolygonMode(uint face, uint mode) { _glPolygonMode(face, mode); }
        public static void glPolygonStipple(byte[] mask) { _glPolygonStipple(mask); }
        public static void glPopAttrib() { _glPopAttrib(); }
        public static void glPopMatrix() { _glPopMatrix(); }
        public static void glPopName() { _glPopName(); }
        public static void glPushAttrib(uint mask) { _glPushAttrib(mask); }
        public static void glPushMatrix() { _glPushMatrix(); }
        public static void glPushName(uint name) { _glPushName(name); }
        public static void glRasterPos2d(double x, double y) { _glRasterPos2d(x, y); }
        public static void glRasterPos2dv(double[] v) { _glRasterPos2dv(v); }
        public static void glRasterPos2f(float x, float y) { _glRasterPos2f(x, y); }
        public static void glRasterPos2fv(float[] v) { _glRasterPos2fv(v); }
        public static void glRasterPos2i(int x, int y) { _glRasterPos2i(x, y); }
        public static void glRasterPos2iv(int[] v) { _glRasterPos2iv(v); }
        public static void glRasterPos2s(short x, short y) { _glRasterPos2s(x, y); }
        public static void glRasterPos2sv(short[] v) { _glRasterPos2sv(v); }
        public static void glRasterPos3d(double x, double y, double z) { _glRasterPos3d(x, y, z); }
        public static void glRasterPos3dv(double[] v) { _glRasterPos3dv(v); }
        public static void glRasterPos3f(float x, float y, float z) { _glRasterPos3f(x, y, z); }
        public static void glRasterPos3fv(float[] v) { _glRasterPos3fv(v); }
        public static void glRasterPos3i(int x, int y, int z) { _glRasterPos3i(x, y, z); }
        public static void glRasterPos3iv(int[] v) { _glRasterPos3iv(v); }
        public static void glRasterPos3s(short x, short y, short z) { _glRasterPos3s(x, y, z); }
        public static void glRasterPos3sv(short[] v) { _glRasterPos3sv(v); }
        public static void glRasterPos4d(double x, double y, double z, double w) { _glRasterPos4d(x, y, z, w); }
        public static void glRasterPos4dv(double[] v) { _glRasterPos4dv(v); }
        public static void glRasterPos4f(float x, float y, float z, float w) { _glRasterPos4f(x, y, z, w); }
        public static void glRasterPos4fv(float[] v) { _glRasterPos4fv(v); }
        public static void glRasterPos4i(int x, int y, int z, int w) { _glRasterPos4i(x, y, z, w); }
        public static void glRasterPos4iv(int[] v) { _glRasterPos4iv(v); }
        public static void glRasterPos4s(short x, short y, short z, short w) { _glRasterPos4s(x, y, z, w); }
        public static void glRasterPos4sv(short[] v) { _glRasterPos4sv(v); }
        public static void glReadBuffer(uint src) { _glReadBuffer(src); }
        public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, nint pixels) { _glReadPixels(x, y, width, height, format, type, pixels); }
        public static void glRectd(double x1, double y1, double x2, double y2) { _glRectd(x1, y1, x2, y2); }
        public static void glRectdv(double[] v1, double[] v2) { _glRectdv(v1, v2); }
        public static void glRectf(float x1, float y1, float x2, float y2) { _glRectf(x1, y1, x2, y2); }
        public static void glRectfv(float[] v1, float[] v2) { _glRectfv(v1, v2); }
        public static void glRecti(int x1, int y1, int x2, int y2) { _glRecti(x1, y1, x2, y2); }
        public static void glRectiv(int[] v1, int[] v2) { _glRectiv(v1, v2); }
        public static void glRects(short x1, short y1, short x2, short y2) { _glRects(x1, y1, x2, y2); }
        public static void glRectsv(short[] v1, short[] v2) { _glRectsv(v1, v2); }
        public static int glRenderMode(uint mode) { return _glRenderMode(mode); }
        public static void glRotated(double angle, double x, double y, double z) { _glRotated(angle, x, y, z); }
        public static void glRotatef(float angle, float x, float y, float z) { _glRotatef(angle, x, y, z); }
        public static void glScaled(double x, double y, double z) { _glScaled(x, y, z); }
        public static void glScalef(float x, float y, float z) { _glScalef(x, y, z); }
        public static void glScissor(int x, int y, int width, int height) { _glScissor(x, y, width, height); }
        public static void glSelectBuffer(int size, uint[] buffer) { _glSelectBuffer(size, buffer); }
        public static void glShadeModel(uint mode) { _glShadeModel(mode); }
        public static void glStencilFunc(uint func, int @ref, uint mask) { _glStencilFunc(func, @ref, mask); }
        public static void glStencilMask(uint mask) { _glStencilMask(mask); }
        public static void glStencilOp(uint fail, uint zfail, uint zpass) { _glStencilOp(fail, zfail, zpass); }
        public static void glTexCoord1d(double s) { _glTexCoord1d(s); }
        public static void glTexCoord1dv(double[] v) { _glTexCoord1dv(v); }
        public static void glTexCoord1f(float s) { _glTexCoord1f(s); }
        public static void glTexCoord1fv(float[] v) { _glTexCoord1fv(v); }
        public static void glTexCoord1i(int s) { _glTexCoord1i(s); }
        public static void glTexCoord1iv(int[] v) { _glTexCoord1iv(v); }
        public static void glTexCoord1s(short s) { _glTexCoord1s(s); }
        public static void glTexCoord1sv(short[] v) { _glTexCoord1sv(v); }
        public static void glTexCoord2d(double s, double t) { _glTexCoord2d(s, t); }
        public static void glTexCoord2dv(double[] v) { _glTexCoord2dv(v); }
        public static void glTexCoord2f(float s, float t) { _glTexCoord2f(s, t); }
        public static void glTexCoord2fv(float[] v) { _glTexCoord2fv(v); }
        public static void glTexCoord2i(int s, int t) { _glTexCoord2i(s, t); }
        public static void glTexCoord2iv(int[] v) { _glTexCoord2iv(v); }
        public static void glTexCoord2s(short s, short t) { _glTexCoord2s(s, t); }
        public static void glTexCoord2sv(short[] v) { _glTexCoord2sv(v); }
        public static void glTexCoord3d(double s, double t, double r) { _glTexCoord3d(s, t, r); }
        public static void glTexCoord3dv(double[] v) { _glTexCoord3dv(v); }
        public static void glTexCoord3f(float s, float t, float r) { _glTexCoord3f(s, t, r); }
        public static void glTexCoord3fv(float[] v) { _glTexCoord3fv(v); }
        public static void glTexCoord3i(int s, int t, int r) { _glTexCoord3i(s, t, r); }
        public static void glTexCoord3iv(int[] v) { _glTexCoord3iv(v); }
        public static void glTexCoord3s(short s, short t, short r) { _glTexCoord3s(s, t, r); }
        public static void glTexCoord3sv(short[] v) { _glTexCoord3sv(v); }
        public static void glTexCoord4d(double s, double t, double r, double q) { _glTexCoord4d(s, t, r, q); }
        public static void glTexCoord4dv(double[] v) { _glTexCoord4dv(v); }
        public static void glTexCoord4f(float s, float t, float r, float q) { _glTexCoord4f(s, t, r, q); }
        public static void glTexCoord4fv(float[] v) { _glTexCoord4fv(v); }
        public static void glTexCoord4i(int s, int t, int r, int q) { _glTexCoord4i(s, t, r, q); }
        public static void glTexCoord4iv(int[] v) { _glTexCoord4iv(v); }
        public static void glTexCoord4s(short s, short t, short r, short q) { _glTexCoord4s(s, t, r, q); }
        public static void glTexCoord4sv(short[] v) { _glTexCoord4sv(v); }
        public static void glTexEnvf(uint target, uint pname, float param) { _glTexEnvf(target, pname, param); }
        public static void glTexEnvfv(uint target, uint pname, float[] @params) { _glTexEnvfv(target, pname, @params); }
        public static void glTexEnvi(uint target, uint pname, int param) { _glTexEnvi(target, pname, param); }
        public static void glTexEnviv(uint target, uint pname, int[] @params) { _glTexEnviv(target, pname, @params); }
        public static void glTexGend(uint coord, uint pname, double param) { _glTexGend(coord, pname, param); }
        public static void glTexGendv(uint coord, uint pname, double[] @params) { _glTexGendv(coord, pname, @params); }
        public static void glTexGenf(uint coord, uint pname, float param) { _glTexGenf(coord, pname, param); }
        public static void glTexGenfv(uint coord, uint pname, float[] @params) { _glTexGenfv(coord, pname, @params); }
        public static void glTexGeni(uint coord, uint pname, int param) { _glTexGeni(coord, pname, param); }
        public static void glTexGeniv(uint coord, uint pname, int[] @params) { _glTexGeniv(coord, pname, @params); }
        public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels) { _glTexImage1D(target, level, internalformat, width, border, format, type, pixels); }
        public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels) { _glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels); }
        public static void glTexParameterf(uint target, uint pname, float param) { _glTexParameterf(target, pname, param); }
        public static void glTexParameterfv(uint target, uint pname, float[] @params) { _glTexParameterfv(target, pname, @params); }
        public static void glTexParameteri(uint target, uint pname, int param) { _glTexParameteri(target, pname, param); }
        public static void glTexParameteriv(uint target, uint pname, int[] @params) { _glTexParameteriv(target, pname, @params); }
        public static void glTranslated(double x, double y, double z) { _glTranslated(x, y, z); }
        public static void glTranslatef(float x, float y, float z) { _glTranslatef(x, y, z); }
        public static void glVertex2d(double x, double y) { _glVertex2d(x, y); }
        public static void glVertex2dv(double[] v) { _glVertex2dv(v); }
        public static void glVertex2f(float x, float y) { _glVertex2f(x, y); }
        public static void glVertex2fv(float[] v) { _glVertex2fv(v); }
        public static void glVertex2i(int x, int y) { _glVertex2i(x, y); }
        public static void glVertex2iv(int[] v) { _glVertex2iv(v); }
        public static void glVertex2s(short x, short y) { _glVertex2s(x, y); }
        public static void glVertex2sv(short[] v) { _glVertex2sv(v); }
        public static void glVertex3d(double x, double y, double z) { _glVertex3d(x, y, z); }
        public static void glVertex3dv(double[] v) { _glVertex3dv(v); }
        public static void glVertex3f(float x, float y, float z) { _glVertex3f(x, y, z); }
        public static void glVertex3fv(float[] v) { _glVertex3fv(v); }
        public static void glVertex3i(int x, int y, int z) { _glVertex3i(x, y, z); }
        public static void glVertex3iv(int[] v) { _glVertex3iv(v); }
        public static void glVertex3s(short x, short y, short z) { _glVertex3s(x, y, z); }
        public static void glVertex3sv(short[] v) { _glVertex3sv(v); }
        public static void glVertex4d(double x, double y, double z, double w) { _glVertex4d(x, y, z, w); }
        public static void glVertex4dv(double[] v) { _glVertex4dv(v); }
        public static void glVertex4f(float x, float y, float z, float w) { _glVertex4f(x, y, z, w); }
        public static void glVertex4fv(float[] v) { _glVertex4fv(v); }
        public static void glVertex4i(int x, int y, int z, int w) { _glVertex4i(x, y, z, w); }
        public static void glVertex4iv(int[] v) { _glVertex4iv(v); }
        public static void glVertex4s(short x, short y, short z, short w) { _glVertex4s(x, y, z, w); }
        public static void glVertex4sv(short[] v) { _glVertex4sv(v); }
        public static void glViewport(int x, int y, int width, int height) { _glViewport(x, y, width, height); }

        internal static void Load(DelegatePtrSource src)
        {
            _glAccum = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glAccum");
            _glAlphaFunc = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glAlphaFunc");
            _glBegin = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glBegin");
            _glBitmap = (delegate* unmanaged[Stdcall]<int, int, float, float, float, float, byte[], void>)src.GetFuncPtr("glBitmap");
            _glBlendFunc = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glBlendFunc");
            _glCallList = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glCallList");
            _glCallLists = (delegate* unmanaged[Stdcall]<int, uint, nint, void>)src.GetFuncPtr("glCallLists");
            _glClear = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glClear");
            _glClearAccum = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glClearAccum");
            _glClearColor = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glClearColor");
            _glClearDepth = (delegate* unmanaged[Stdcall]<double, void>)src.GetFuncPtr("glClearDepth");
            _glClearIndex = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glClearIndex");
            _glClearStencil = (delegate* unmanaged[Stdcall]<int, void>)src.GetFuncPtr("glClearStencil");
            _glClipPlane = (delegate* unmanaged[Stdcall]<uint, double[], void>)src.GetFuncPtr("glClipPlane");
            _glColor3b = (delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void>)src.GetFuncPtr("glColor3b");
            _glColor3bv = (delegate* unmanaged[Stdcall]<sbyte[], void>)src.GetFuncPtr("glColor3bv");
            _glColor3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glColor3d");
            _glColor3dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glColor3dv");
            _glColor3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glColor3f");
            _glColor3fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glColor3fv");
            _glColor3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glColor3i");
            _glColor3iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glColor3iv");
            _glColor3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glColor3s");
            _glColor3sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glColor3sv");
            _glColor3ub = (delegate* unmanaged[Stdcall]<byte, byte, byte, void>)src.GetFuncPtr("glColor3ub");
            _glColor3ubv = (delegate* unmanaged[Stdcall]<byte[], void>)src.GetFuncPtr("glColor3ubv");
            _glColor3ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glColor3ui");
            _glColor3uiv = (delegate* unmanaged[Stdcall]<uint[], void>)src.GetFuncPtr("glColor3uiv");
            _glColor3us = (delegate* unmanaged[Stdcall]<ushort, ushort, ushort, void>)src.GetFuncPtr("glColor3us");
            _glColor3usv = (delegate* unmanaged[Stdcall]<ushort[], void>)src.GetFuncPtr("glColor3usv");
            _glColor4b = (delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, sbyte, void>)src.GetFuncPtr("glColor4b");
            _glColor4bv = (delegate* unmanaged[Stdcall]<sbyte[], void>)src.GetFuncPtr("glColor4bv");
            _glColor4d = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glColor4d");
            _glColor4dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glColor4dv");
            _glColor4f = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glColor4f");
            _glColor4fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glColor4fv");
            _glColor4i = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glColor4i");
            _glColor4iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glColor4iv");
            _glColor4s = (delegate* unmanaged[Stdcall]<short, short, short, short, void>)src.GetFuncPtr("glColor4s");
            _glColor4sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glColor4sv");
            _glColor4ub = (delegate* unmanaged[Stdcall]<byte, byte, byte, byte, void>)src.GetFuncPtr("glColor4ub");
            _glColor4ubv = (delegate* unmanaged[Stdcall]<byte[], void>)src.GetFuncPtr("glColor4ubv");
            _glColor4ui = (delegate* unmanaged[Stdcall]<uint, uint, uint, uint, void>)src.GetFuncPtr("glColor4ui");
            _glColor4uiv = (delegate* unmanaged[Stdcall]<uint[], void>)src.GetFuncPtr("glColor4uiv");
            _glColor4us = (delegate* unmanaged[Stdcall]<ushort, ushort, ushort, ushort, void>)src.GetFuncPtr("glColor4us");
            _glColor4usv = (delegate* unmanaged[Stdcall]<ushort[], void>)src.GetFuncPtr("glColor4usv");
            _glColorMask = (delegate* unmanaged[Stdcall]<bool, bool, bool, bool, void>)src.GetFuncPtr("glColorMask");
            _glColorMaterial = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glColorMaterial");
            _glCopyPixels = (delegate* unmanaged[Stdcall]<int, int, int, int, uint, void>)src.GetFuncPtr("glCopyPixels");
            _glCullFace = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glCullFace");
            _glDeleteLists = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glDeleteLists");
            _glDepthFunc = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDepthFunc");
            _glDepthMask = (delegate* unmanaged[Stdcall]<bool, void>)src.GetFuncPtr("glDepthMask");
            _glDepthRange = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glDepthRange");
            _glDisable = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDisable");
            _glDrawBuffer = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glDrawBuffer");
            _glDrawPixels = (delegate* unmanaged[Stdcall]<int, int, uint, uint, nint, void>)src.GetFuncPtr("glDrawPixels");
            _glEdgeFlag = (delegate* unmanaged[Stdcall]<bool, void>)src.GetFuncPtr("glEdgeFlag");
            _glEdgeFlagv = (delegate* unmanaged[Stdcall]<bool[], void>)src.GetFuncPtr("glEdgeFlagv");
            _glEnable = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glEnable");
            _glEnd = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glEnd");
            _glEndList = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glEndList");
            _glEvalCoord1d = (delegate* unmanaged[Stdcall]<double, void>)src.GetFuncPtr("glEvalCoord1d");
            _glEvalCoord1dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glEvalCoord1dv");
            _glEvalCoord1f = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glEvalCoord1f");
            _glEvalCoord1fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glEvalCoord1fv");
            _glEvalCoord2d = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glEvalCoord2d");
            _glEvalCoord2dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glEvalCoord2dv");
            _glEvalCoord2f = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glEvalCoord2f");
            _glEvalCoord2fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glEvalCoord2fv");
            _glEvalMesh1 = (delegate* unmanaged[Stdcall]<uint, int, int, void>)src.GetFuncPtr("glEvalMesh1");
            _glEvalMesh2 = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, void>)src.GetFuncPtr("glEvalMesh2");
            _glEvalPoint1 = (delegate* unmanaged[Stdcall]<int, void>)src.GetFuncPtr("glEvalPoint1");
            _glEvalPoint2 = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glEvalPoint2");
            _glFeedbackBuffer = (delegate* unmanaged[Stdcall]<int, uint, float[], void>)src.GetFuncPtr("glFeedbackBuffer");
            _glFinish = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glFinish");
            _glFlush = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glFlush");
            _glFogf = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glFogf");
            _glFogfv = (delegate* unmanaged[Stdcall]<uint, float[], void>)src.GetFuncPtr("glFogfv");
            _glFogi = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glFogi");
            _glFogiv = (delegate* unmanaged[Stdcall]<uint, int[], void>)src.GetFuncPtr("glFogiv");
            _glFrontFace = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glFrontFace");
            _glFrustum = (delegate* unmanaged[Stdcall]<double, double, double, double, double, double, void>)src.GetFuncPtr("glFrustum");
            _glGenLists = (delegate* unmanaged[Stdcall]<int, uint>)src.GetFuncPtr("glGenLists");
            _glGetBooleanv = (delegate* unmanaged[Stdcall]<uint, bool[], void>)src.GetFuncPtr("glGetBooleanv");
            _glGetClipPlane = (delegate* unmanaged[Stdcall]<uint, double[], void>)src.GetFuncPtr("glGetClipPlane");
            _glGetDoublev = (delegate* unmanaged[Stdcall]<uint, double[], void>)src.GetFuncPtr("glGetDoublev");
            _glGetError = (delegate* unmanaged[Stdcall]<uint>)src.GetFuncPtr("glGetError");
            _glGetFloatv = (delegate* unmanaged[Stdcall]<uint, float[], void>)src.GetFuncPtr("glGetFloatv");
            _glGetIntegerv = (delegate* unmanaged[Stdcall]<uint, int[], void>)src.GetFuncPtr("glGetIntegerv");
            _glGetLightfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetLightfv");
            _glGetLightiv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetLightiv");
            _glGetMapdv = (delegate* unmanaged[Stdcall]<uint, uint, double[], void>)src.GetFuncPtr("glGetMapdv");
            _glGetMapfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetMapfv");
            _glGetMapiv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetMapiv");
            _glGetMaterialfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetMaterialfv");
            _glGetMaterialiv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetMaterialiv");
            _glGetPixelMapfv = (delegate* unmanaged[Stdcall]<uint, float[], void>)src.GetFuncPtr("glGetPixelMapfv");
            _glGetPixelMapuiv = (delegate* unmanaged[Stdcall]<uint, uint[], void>)src.GetFuncPtr("glGetPixelMapuiv");
            _glGetPixelMapusv = (delegate* unmanaged[Stdcall]<uint, ushort[], void>)src.GetFuncPtr("glGetPixelMapusv");
            _glGetPolygonStipple = (delegate* unmanaged[Stdcall]<byte[], void>)src.GetFuncPtr("glGetPolygonStipple");
            _glGetString = (delegate* unmanaged[Stdcall]<uint, nint>)src.GetFuncPtr("glGetString");
            _glGetTexEnvfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetTexEnvfv");
            _glGetTexEnviv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetTexEnviv");
            _glGetTexGendv = (delegate* unmanaged[Stdcall]<uint, uint, double[], void>)src.GetFuncPtr("glGetTexGendv");
            _glGetTexGenfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetTexGenfv");
            _glGetTexGeniv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetTexGeniv");
            _glGetTexImage = (delegate* unmanaged[Stdcall]<uint, int, uint, uint, nint, void>)src.GetFuncPtr("glGetTexImage");
            _glGetTexLevelParameterfv = (delegate* unmanaged[Stdcall]<uint, int, uint, float[], void>)src.GetFuncPtr("glGetTexLevelParameterfv");
            _glGetTexLevelParameteriv = (delegate* unmanaged[Stdcall]<uint, int, uint, int[], void>)src.GetFuncPtr("glGetTexLevelParameteriv");
            _glGetTexParameterfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glGetTexParameterfv");
            _glGetTexParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glGetTexParameteriv");
            _glHint = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glHint");
            _glIndexMask = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glIndexMask");
            _glIndexd = (delegate* unmanaged[Stdcall]<double, void>)src.GetFuncPtr("glIndexd");
            _glIndexdv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glIndexdv");
            _glIndexf = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glIndexf");
            _glIndexfv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glIndexfv");
            _glIndexi = (delegate* unmanaged[Stdcall]<int, void>)src.GetFuncPtr("glIndexi");
            _glIndexiv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glIndexiv");
            _glIndexs = (delegate* unmanaged[Stdcall]<short, void>)src.GetFuncPtr("glIndexs");
            _glIndexsv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glIndexsv");
            _glInitNames = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glInitNames");
            _glIsEnabled = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsEnabled");
            _glIsList = (delegate* unmanaged[Stdcall]<uint, bool>)src.GetFuncPtr("glIsList");
            _glLightModelf = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glLightModelf");
            _glLightModelfv = (delegate* unmanaged[Stdcall]<uint, float[], void>)src.GetFuncPtr("glLightModelfv");
            _glLightModeli = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glLightModeli");
            _glLightModeliv = (delegate* unmanaged[Stdcall]<uint, int[], void>)src.GetFuncPtr("glLightModeliv");
            _glLightf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glLightf");
            _glLightfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glLightfv");
            _glLighti = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glLighti");
            _glLightiv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glLightiv");
            _glLineStipple = (delegate* unmanaged[Stdcall]<int, ushort, void>)src.GetFuncPtr("glLineStipple");
            _glLineWidth = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glLineWidth");
            _glListBase = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glListBase");
            _glLoadIdentity = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glLoadIdentity");
            _glLoadMatrixd = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glLoadMatrixd");
            _glLoadMatrixf = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glLoadMatrixf");
            _glLoadName = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glLoadName");
            _glLogicOp = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glLogicOp");
            _glMap1d = (delegate* unmanaged[Stdcall]<uint, double, double, int, int, double[], void>)src.GetFuncPtr("glMap1d");
            _glMap1f = (delegate* unmanaged[Stdcall]<uint, float, float, int, int, float[], void>)src.GetFuncPtr("glMap1f");
            _glMap2d = (delegate* unmanaged[Stdcall]<uint, double, double, int, int, double, double, int, int, double[], void>)src.GetFuncPtr("glMap2d");
            _glMap2f = (delegate* unmanaged[Stdcall]<uint, float, float, int, int, float, float, int, int, float[], void>)src.GetFuncPtr("glMap2f");
            _glMapGrid1d = (delegate* unmanaged[Stdcall]<int, double, double, void>)src.GetFuncPtr("glMapGrid1d");
            _glMapGrid1f = (delegate* unmanaged[Stdcall]<int, float, float, void>)src.GetFuncPtr("glMapGrid1f");
            _glMapGrid2d = (delegate* unmanaged[Stdcall]<int, double, double, int, double, double, void>)src.GetFuncPtr("glMapGrid2d");
            _glMapGrid2f = (delegate* unmanaged[Stdcall]<int, float, float, int, float, float, void>)src.GetFuncPtr("glMapGrid2f");
            _glMaterialf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glMaterialf");
            _glMaterialfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glMaterialfv");
            _glMateriali = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glMateriali");
            _glMaterialiv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glMaterialiv");
            _glMatrixMode = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glMatrixMode");
            _glMultMatrixd = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glMultMatrixd");
            _glMultMatrixf = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glMultMatrixf");
            _glNewList = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glNewList");
            _glNormal3b = (delegate* unmanaged[Stdcall]<sbyte, sbyte, sbyte, void>)src.GetFuncPtr("glNormal3b");
            _glNormal3bv = (delegate* unmanaged[Stdcall]<sbyte[], void>)src.GetFuncPtr("glNormal3bv");
            _glNormal3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glNormal3d");
            _glNormal3dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glNormal3dv");
            _glNormal3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glNormal3f");
            _glNormal3fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glNormal3fv");
            _glNormal3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glNormal3i");
            _glNormal3iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glNormal3iv");
            _glNormal3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glNormal3s");
            _glNormal3sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glNormal3sv");
            _glOrtho = (delegate* unmanaged[Stdcall]<double, double, double, double, double, double, void>)src.GetFuncPtr("glOrtho");
            _glPassThrough = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glPassThrough");
            _glPixelMapfv = (delegate* unmanaged[Stdcall]<uint, int, float[], void>)src.GetFuncPtr("glPixelMapfv");
            _glPixelMapuiv = (delegate* unmanaged[Stdcall]<uint, int, uint[], void>)src.GetFuncPtr("glPixelMapuiv");
            _glPixelMapusv = (delegate* unmanaged[Stdcall]<uint, int, ushort[], void>)src.GetFuncPtr("glPixelMapusv");
            _glPixelStoref = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glPixelStoref");
            _glPixelStorei = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glPixelStorei");
            _glPixelTransferf = (delegate* unmanaged[Stdcall]<uint, float, void>)src.GetFuncPtr("glPixelTransferf");
            _glPixelTransferi = (delegate* unmanaged[Stdcall]<uint, int, void>)src.GetFuncPtr("glPixelTransferi");
            _glPixelZoom = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glPixelZoom");
            _glPointSize = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glPointSize");
            _glPolygonMode = (delegate* unmanaged[Stdcall]<uint, uint, void>)src.GetFuncPtr("glPolygonMode");
            _glPolygonStipple = (delegate* unmanaged[Stdcall]<byte[], void>)src.GetFuncPtr("glPolygonStipple");
            _glPopAttrib = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glPopAttrib");
            _glPopMatrix = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glPopMatrix");
            _glPopName = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glPopName");
            _glPushAttrib = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glPushAttrib");
            _glPushMatrix = (delegate* unmanaged[Stdcall]<void>)src.GetFuncPtr("glPushMatrix");
            _glPushName = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glPushName");
            _glRasterPos2d = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glRasterPos2d");
            _glRasterPos2dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glRasterPos2dv");
            _glRasterPos2f = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glRasterPos2f");
            _glRasterPos2fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glRasterPos2fv");
            _glRasterPos2i = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glRasterPos2i");
            _glRasterPos2iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glRasterPos2iv");
            _glRasterPos2s = (delegate* unmanaged[Stdcall]<short, short, void>)src.GetFuncPtr("glRasterPos2s");
            _glRasterPos2sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glRasterPos2sv");
            _glRasterPos3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glRasterPos3d");
            _glRasterPos3dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glRasterPos3dv");
            _glRasterPos3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glRasterPos3f");
            _glRasterPos3fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glRasterPos3fv");
            _glRasterPos3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glRasterPos3i");
            _glRasterPos3iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glRasterPos3iv");
            _glRasterPos3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glRasterPos3s");
            _glRasterPos3sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glRasterPos3sv");
            _glRasterPos4d = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glRasterPos4d");
            _glRasterPos4dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glRasterPos4dv");
            _glRasterPos4f = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glRasterPos4f");
            _glRasterPos4fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glRasterPos4fv");
            _glRasterPos4i = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glRasterPos4i");
            _glRasterPos4iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glRasterPos4iv");
            _glRasterPos4s = (delegate* unmanaged[Stdcall]<short, short, short, short, void>)src.GetFuncPtr("glRasterPos4s");
            _glRasterPos4sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glRasterPos4sv");
            _glReadBuffer = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glReadBuffer");
            _glReadPixels = (delegate* unmanaged[Stdcall]<int, int, int, int, uint, uint, nint, void>)src.GetFuncPtr("glReadPixels");
            _glRectd = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glRectd");
            _glRectdv = (delegate* unmanaged[Stdcall]<double[], double[], void>)src.GetFuncPtr("glRectdv");
            _glRectf = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glRectf");
            _glRectfv = (delegate* unmanaged[Stdcall]<float[], float[], void>)src.GetFuncPtr("glRectfv");
            _glRecti = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glRecti");
            _glRectiv = (delegate* unmanaged[Stdcall]<int[], int[], void>)src.GetFuncPtr("glRectiv");
            _glRects = (delegate* unmanaged[Stdcall]<short, short, short, short, void>)src.GetFuncPtr("glRects");
            _glRectsv = (delegate* unmanaged[Stdcall]<short[], short[], void>)src.GetFuncPtr("glRectsv");
            _glRenderMode = (delegate* unmanaged[Stdcall]<uint, int>)src.GetFuncPtr("glRenderMode");
            _glRotated = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glRotated");
            _glRotatef = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glRotatef");
            _glScaled = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glScaled");
            _glScalef = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glScalef");
            _glScissor = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glScissor");
            _glSelectBuffer = (delegate* unmanaged[Stdcall]<int, uint[], void>)src.GetFuncPtr("glSelectBuffer");
            _glShadeModel = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glShadeModel");
            _glStencilFunc = (delegate* unmanaged[Stdcall]<uint, int, uint, void>)src.GetFuncPtr("glStencilFunc");
            _glStencilMask = (delegate* unmanaged[Stdcall]<uint, void>)src.GetFuncPtr("glStencilMask");
            _glStencilOp = (delegate* unmanaged[Stdcall]<uint, uint, uint, void>)src.GetFuncPtr("glStencilOp");
            _glTexCoord1d = (delegate* unmanaged[Stdcall]<double, void>)src.GetFuncPtr("glTexCoord1d");
            _glTexCoord1dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glTexCoord1dv");
            _glTexCoord1f = (delegate* unmanaged[Stdcall]<float, void>)src.GetFuncPtr("glTexCoord1f");
            _glTexCoord1fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glTexCoord1fv");
            _glTexCoord1i = (delegate* unmanaged[Stdcall]<int, void>)src.GetFuncPtr("glTexCoord1i");
            _glTexCoord1iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glTexCoord1iv");
            _glTexCoord1s = (delegate* unmanaged[Stdcall]<short, void>)src.GetFuncPtr("glTexCoord1s");
            _glTexCoord1sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glTexCoord1sv");
            _glTexCoord2d = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glTexCoord2d");
            _glTexCoord2dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glTexCoord2dv");
            _glTexCoord2f = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glTexCoord2f");
            _glTexCoord2fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glTexCoord2fv");
            _glTexCoord2i = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glTexCoord2i");
            _glTexCoord2iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glTexCoord2iv");
            _glTexCoord2s = (delegate* unmanaged[Stdcall]<short, short, void>)src.GetFuncPtr("glTexCoord2s");
            _glTexCoord2sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glTexCoord2sv");
            _glTexCoord3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glTexCoord3d");
            _glTexCoord3dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glTexCoord3dv");
            _glTexCoord3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glTexCoord3f");
            _glTexCoord3fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glTexCoord3fv");
            _glTexCoord3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glTexCoord3i");
            _glTexCoord3iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glTexCoord3iv");
            _glTexCoord3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glTexCoord3s");
            _glTexCoord3sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glTexCoord3sv");
            _glTexCoord4d = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glTexCoord4d");
            _glTexCoord4dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glTexCoord4dv");
            _glTexCoord4f = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glTexCoord4f");
            _glTexCoord4fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glTexCoord4fv");
            _glTexCoord4i = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glTexCoord4i");
            _glTexCoord4iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glTexCoord4iv");
            _glTexCoord4s = (delegate* unmanaged[Stdcall]<short, short, short, short, void>)src.GetFuncPtr("glTexCoord4s");
            _glTexCoord4sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glTexCoord4sv");
            _glTexEnvf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glTexEnvf");
            _glTexEnvfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glTexEnvfv");
            _glTexEnvi = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glTexEnvi");
            _glTexEnviv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glTexEnviv");
            _glTexGend = (delegate* unmanaged[Stdcall]<uint, uint, double, void>)src.GetFuncPtr("glTexGend");
            _glTexGendv = (delegate* unmanaged[Stdcall]<uint, uint, double[], void>)src.GetFuncPtr("glTexGendv");
            _glTexGenf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glTexGenf");
            _glTexGenfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glTexGenfv");
            _glTexGeni = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glTexGeni");
            _glTexGeniv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glTexGeniv");
            _glTexImage1D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, uint, uint, nint, void>)src.GetFuncPtr("glTexImage1D");
            _glTexImage2D = (delegate* unmanaged[Stdcall]<uint, int, int, int, int, int, uint, uint, nint, void>)src.GetFuncPtr("glTexImage2D");
            _glTexParameterf = (delegate* unmanaged[Stdcall]<uint, uint, float, void>)src.GetFuncPtr("glTexParameterf");
            _glTexParameterfv = (delegate* unmanaged[Stdcall]<uint, uint, float[], void>)src.GetFuncPtr("glTexParameterfv");
            _glTexParameteri = (delegate* unmanaged[Stdcall]<uint, uint, int, void>)src.GetFuncPtr("glTexParameteri");
            _glTexParameteriv = (delegate* unmanaged[Stdcall]<uint, uint, int[], void>)src.GetFuncPtr("glTexParameteriv");
            _glTranslated = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glTranslated");
            _glTranslatef = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glTranslatef");
            _glVertex2d = (delegate* unmanaged[Stdcall]<double, double, void>)src.GetFuncPtr("glVertex2d");
            _glVertex2dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glVertex2dv");
            _glVertex2f = (delegate* unmanaged[Stdcall]<float, float, void>)src.GetFuncPtr("glVertex2f");
            _glVertex2fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glVertex2fv");
            _glVertex2i = (delegate* unmanaged[Stdcall]<int, int, void>)src.GetFuncPtr("glVertex2i");
            _glVertex2iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glVertex2iv");
            _glVertex2s = (delegate* unmanaged[Stdcall]<short, short, void>)src.GetFuncPtr("glVertex2s");
            _glVertex2sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glVertex2sv");
            _glVertex3d = (delegate* unmanaged[Stdcall]<double, double, double, void>)src.GetFuncPtr("glVertex3d");
            _glVertex3dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glVertex3dv");
            _glVertex3f = (delegate* unmanaged[Stdcall]<float, float, float, void>)src.GetFuncPtr("glVertex3f");
            _glVertex3fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glVertex3fv");
            _glVertex3i = (delegate* unmanaged[Stdcall]<int, int, int, void>)src.GetFuncPtr("glVertex3i");
            _glVertex3iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glVertex3iv");
            _glVertex3s = (delegate* unmanaged[Stdcall]<short, short, short, void>)src.GetFuncPtr("glVertex3s");
            _glVertex3sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glVertex3sv");
            _glVertex4d = (delegate* unmanaged[Stdcall]<double, double, double, double, void>)src.GetFuncPtr("glVertex4d");
            _glVertex4dv = (delegate* unmanaged[Stdcall]<double[], void>)src.GetFuncPtr("glVertex4dv");
            _glVertex4f = (delegate* unmanaged[Stdcall]<float, float, float, float, void>)src.GetFuncPtr("glVertex4f");
            _glVertex4fv = (delegate* unmanaged[Stdcall]<float[], void>)src.GetFuncPtr("glVertex4fv");
            _glVertex4i = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glVertex4i");
            _glVertex4iv = (delegate* unmanaged[Stdcall]<int[], void>)src.GetFuncPtr("glVertex4iv");
            _glVertex4s = (delegate* unmanaged[Stdcall]<short, short, short, short, void>)src.GetFuncPtr("glVertex4s");
            _glVertex4sv = (delegate* unmanaged[Stdcall]<short[], void>)src.GetFuncPtr("glVertex4sv");
            _glViewport = (delegate* unmanaged[Stdcall]<int, int, int, int, void>)src.GetFuncPtr("glViewport");
        }

        internal static void Unload()
        {
            _glAccum = null;
            _glAlphaFunc = null;
            _glBegin = null;
            _glBitmap = null;
            _glBlendFunc = null;
            _glCallList = null;
            _glCallLists = null;
            _glClear = null;
            _glClearAccum = null;
            _glClearColor = null;
            _glClearDepth = null;
            _glClearIndex = null;
            _glClearStencil = null;
            _glClipPlane = null;
            _glColor3b = null;
            _glColor3bv = null;
            _glColor3d = null;
            _glColor3dv = null;
            _glColor3f = null;
            _glColor3fv = null;
            _glColor3i = null;
            _glColor3iv = null;
            _glColor3s = null;
            _glColor3sv = null;
            _glColor3ub = null;
            _glColor3ubv = null;
            _glColor3ui = null;
            _glColor3uiv = null;
            _glColor3us = null;
            _glColor3usv = null;
            _glColor4b = null;
            _glColor4bv = null;
            _glColor4d = null;
            _glColor4dv = null;
            _glColor4f = null;
            _glColor4fv = null;
            _glColor4i = null;
            _glColor4iv = null;
            _glColor4s = null;
            _glColor4sv = null;
            _glColor4ub = null;
            _glColor4ubv = null;
            _glColor4ui = null;
            _glColor4uiv = null;
            _glColor4us = null;
            _glColor4usv = null;
            _glColorMask = null;
            _glColorMaterial = null;
            _glCopyPixels = null;
            _glCullFace = null;
            _glDeleteLists = null;
            _glDepthFunc = null;
            _glDepthMask = null;
            _glDepthRange = null;
            _glDisable = null;
            _glDrawBuffer = null;
            _glDrawPixels = null;
            _glEdgeFlag = null;
            _glEdgeFlagv = null;
            _glEnable = null;
            _glEnd = null;
            _glEndList = null;
            _glEvalCoord1d = null;
            _glEvalCoord1dv = null;
            _glEvalCoord1f = null;
            _glEvalCoord1fv = null;
            _glEvalCoord2d = null;
            _glEvalCoord2dv = null;
            _glEvalCoord2f = null;
            _glEvalCoord2fv = null;
            _glEvalMesh1 = null;
            _glEvalMesh2 = null;
            _glEvalPoint1 = null;
            _glEvalPoint2 = null;
            _glFeedbackBuffer = null;
            _glFinish = null;
            _glFlush = null;
            _glFogf = null;
            _glFogfv = null;
            _glFogi = null;
            _glFogiv = null;
            _glFrontFace = null;
            _glFrustum = null;
            _glGenLists = null;
            _glGetBooleanv = null;
            _glGetClipPlane = null;
            _glGetDoublev = null;
            _glGetError = null;
            _glGetFloatv = null;
            _glGetIntegerv = null;
            _glGetLightfv = null;
            _glGetLightiv = null;
            _glGetMapdv = null;
            _glGetMapfv = null;
            _glGetMapiv = null;
            _glGetMaterialfv = null;
            _glGetMaterialiv = null;
            _glGetPixelMapfv = null;
            _glGetPixelMapuiv = null;
            _glGetPixelMapusv = null;
            _glGetPolygonStipple = null;
            _glGetString = null;
            _glGetTexEnvfv = null;
            _glGetTexEnviv = null;
            _glGetTexGendv = null;
            _glGetTexGenfv = null;
            _glGetTexGeniv = null;
            _glGetTexImage = null;
            _glGetTexLevelParameterfv = null;
            _glGetTexLevelParameteriv = null;
            _glGetTexParameterfv = null;
            _glGetTexParameteriv = null;
            _glHint = null;
            _glIndexMask = null;
            _glIndexd = null;
            _glIndexdv = null;
            _glIndexf = null;
            _glIndexfv = null;
            _glIndexi = null;
            _glIndexiv = null;
            _glIndexs = null;
            _glIndexsv = null;
            _glInitNames = null;
            _glIsEnabled = null;
            _glIsList = null;
            _glLightModelf = null;
            _glLightModelfv = null;
            _glLightModeli = null;
            _glLightModeliv = null;
            _glLightf = null;
            _glLightfv = null;
            _glLighti = null;
            _glLightiv = null;
            _glLineStipple = null;
            _glLineWidth = null;
            _glListBase = null;
            _glLoadIdentity = null;
            _glLoadMatrixd = null;
            _glLoadMatrixf = null;
            _glLoadName = null;
            _glLogicOp = null;
            _glMap1d = null;
            _glMap1f = null;
            _glMap2d = null;
            _glMap2f = null;
            _glMapGrid1d = null;
            _glMapGrid1f = null;
            _glMapGrid2d = null;
            _glMapGrid2f = null;
            _glMaterialf = null;
            _glMaterialfv = null;
            _glMateriali = null;
            _glMaterialiv = null;
            _glMatrixMode = null;
            _glMultMatrixd = null;
            _glMultMatrixf = null;
            _glNewList = null;
            _glNormal3b = null;
            _glNormal3bv = null;
            _glNormal3d = null;
            _glNormal3dv = null;
            _glNormal3f = null;
            _glNormal3fv = null;
            _glNormal3i = null;
            _glNormal3iv = null;
            _glNormal3s = null;
            _glNormal3sv = null;
            _glOrtho = null;
            _glPassThrough = null;
            _glPixelMapfv = null;
            _glPixelMapuiv = null;
            _glPixelMapusv = null;
            _glPixelStoref = null;
            _glPixelStorei = null;
            _glPixelTransferf = null;
            _glPixelTransferi = null;
            _glPixelZoom = null;
            _glPointSize = null;
            _glPolygonMode = null;
            _glPolygonStipple = null;
            _glPopAttrib = null;
            _glPopMatrix = null;
            _glPopName = null;
            _glPushAttrib = null;
            _glPushMatrix = null;
            _glPushName = null;
            _glRasterPos2d = null;
            _glRasterPos2dv = null;
            _glRasterPos2f = null;
            _glRasterPos2fv = null;
            _glRasterPos2i = null;
            _glRasterPos2iv = null;
            _glRasterPos2s = null;
            _glRasterPos2sv = null;
            _glRasterPos3d = null;
            _glRasterPos3dv = null;
            _glRasterPos3f = null;
            _glRasterPos3fv = null;
            _glRasterPos3i = null;
            _glRasterPos3iv = null;
            _glRasterPos3s = null;
            _glRasterPos3sv = null;
            _glRasterPos4d = null;
            _glRasterPos4dv = null;
            _glRasterPos4f = null;
            _glRasterPos4fv = null;
            _glRasterPos4i = null;
            _glRasterPos4iv = null;
            _glRasterPos4s = null;
            _glRasterPos4sv = null;
            _glReadBuffer = null;
            _glReadPixels = null;
            _glRectd = null;
            _glRectdv = null;
            _glRectf = null;
            _glRectfv = null;
            _glRecti = null;
            _glRectiv = null;
            _glRects = null;
            _glRectsv = null;
            _glRenderMode = null;
            _glRotated = null;
            _glRotatef = null;
            _glScaled = null;
            _glScalef = null;
            _glScissor = null;
            _glSelectBuffer = null;
            _glShadeModel = null;
            _glStencilFunc = null;
            _glStencilMask = null;
            _glStencilOp = null;
            _glTexCoord1d = null;
            _glTexCoord1dv = null;
            _glTexCoord1f = null;
            _glTexCoord1fv = null;
            _glTexCoord1i = null;
            _glTexCoord1iv = null;
            _glTexCoord1s = null;
            _glTexCoord1sv = null;
            _glTexCoord2d = null;
            _glTexCoord2dv = null;
            _glTexCoord2f = null;
            _glTexCoord2fv = null;
            _glTexCoord2i = null;
            _glTexCoord2iv = null;
            _glTexCoord2s = null;
            _glTexCoord2sv = null;
            _glTexCoord3d = null;
            _glTexCoord3dv = null;
            _glTexCoord3f = null;
            _glTexCoord3fv = null;
            _glTexCoord3i = null;
            _glTexCoord3iv = null;
            _glTexCoord3s = null;
            _glTexCoord3sv = null;
            _glTexCoord4d = null;
            _glTexCoord4dv = null;
            _glTexCoord4f = null;
            _glTexCoord4fv = null;
            _glTexCoord4i = null;
            _glTexCoord4iv = null;
            _glTexCoord4s = null;
            _glTexCoord4sv = null;
            _glTexEnvf = null;
            _glTexEnvfv = null;
            _glTexEnvi = null;
            _glTexEnviv = null;
            _glTexGend = null;
            _glTexGendv = null;
            _glTexGenf = null;
            _glTexGenfv = null;
            _glTexGeni = null;
            _glTexGeniv = null;
            _glTexImage1D = null;
            _glTexImage2D = null;
            _glTexParameterf = null;
            _glTexParameterfv = null;
            _glTexParameteri = null;
            _glTexParameteriv = null;
            _glTranslated = null;
            _glTranslatef = null;
            _glVertex2d = null;
            _glVertex2dv = null;
            _glVertex2f = null;
            _glVertex2fv = null;
            _glVertex2i = null;
            _glVertex2iv = null;
            _glVertex2s = null;
            _glVertex2sv = null;
            _glVertex3d = null;
            _glVertex3dv = null;
            _glVertex3f = null;
            _glVertex3fv = null;
            _glVertex3i = null;
            _glVertex3iv = null;
            _glVertex3s = null;
            _glVertex3sv = null;
            _glVertex4d = null;
            _glVertex4dv = null;
            _glVertex4f = null;
            _glVertex4fv = null;
            _glVertex4i = null;
            _glVertex4iv = null;
            _glVertex4s = null;
            _glVertex4sv = null;
            _glViewport = null;
        }
    }
}
