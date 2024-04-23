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

        private static void GenerateAPI(BindingsGenerator gen, 
            string[] targetFeatures, string[] targetExtensions, string revision)
        {
            gen.GenerateAPI(targetFeatures, targetExtensions, revision, true, false, false);
            gen.GenerateAPI(targetFeatures, targetExtensions, $"{revision}_PTR", false, false, true);
            gen.GenerateAPI(targetFeatures, targetExtensions, $"{revision}_NINT", true, true, true);
        }

        static void Main(string[] args)
        {
            BindingsGenerator gen = new BindingsGenerator("gl.xml");
            GenerateAPI(gen, TARGET_FEATURES[0..2], [], "1.1");
            GenerateAPI(gen, [TARGET_FEATURES[2]], [], "1.2");
            GenerateAPI(gen, [TARGET_FEATURES[3]], [], "1.3");
            GenerateAPI(gen, [TARGET_FEATURES[4]], [], "1.4");
            GenerateAPI(gen, [TARGET_FEATURES[5]], [], "1.5");
            GenerateAPI(gen, [TARGET_FEATURES[6]], [], "2.0");
            GenerateAPI(gen, [TARGET_FEATURES[7]], [], "2.1");
            GenerateAPI(gen, [TARGET_FEATURES[8]], [], "3.0");
            GenerateAPI(gen, [TARGET_FEATURES[9]], [], "3.1");
            GenerateAPI(gen, [TARGET_FEATURES[10]], [], "3.2");
            GenerateAPI(gen, [TARGET_FEATURES[11]], [], "3.3");
            GenerateAPI(gen, [], TARGET_EXTENSIONS, "ARB");
        }
    }
}