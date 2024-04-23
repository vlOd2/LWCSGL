namespace LWCSGL.Bindgen
{
    public class LWCSGLBindgen
    {
        private static readonly string[] TARGET_FEATURES =
        [
            "GL_VERSION_1_0",
            "GL_VERSION_1_1",
            "GL_VERSION_1_2",
            "GL_VERSION_1_3",
            "GL_VERSION_1_4",
            "GL_VERSION_1_5",
            "GL_VERSION_2_0",
            "GL_VERSION_2_1",
            "GL_VERSION_3_0",
            "GL_VERSION_3_1",
            "GL_VERSION_3_2",
            "GL_VERSION_3_3"
        ];

        private static readonly string[] TARGET_EXTENSIONS =
        [
            "GL_ARB_vertex_buffer_object",
            "GL_ARB_occlusion_query"
        ];

        static void Main(string[] args)
        {
            BindingsGenerator gen = new BindingsGenerator("gl.xml");
            gen.GenerateAPI(TARGET_FEATURES[0..2], [], "1.1");
            gen.GenerateAPI([TARGET_FEATURES[2]], [], "1.2");
            gen.GenerateAPI([TARGET_FEATURES[3]], [], "1.3");
            gen.GenerateAPI([TARGET_FEATURES[4]], [], "1.4");
            gen.GenerateAPI([TARGET_FEATURES[5]], [], "1.5");
            gen.GenerateAPI([TARGET_FEATURES[6]], [], "2.0");
            gen.GenerateAPI([TARGET_FEATURES[7]], [], "2.1");
            gen.GenerateAPI([TARGET_FEATURES[8]], [], "3.0");
            gen.GenerateAPI([TARGET_FEATURES[9]], [], "3.1");
            gen.GenerateAPI([TARGET_FEATURES[10]], [], "3.2");
            gen.GenerateAPI([TARGET_FEATURES[11]], [], "3.3");
            gen.GenerateAPI([], TARGET_EXTENSIONS, "ARB");
        }
    }
}