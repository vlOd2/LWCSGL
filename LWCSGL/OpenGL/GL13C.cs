#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// Constants for OpenGL 1.3
    /// </summary>
    public class GL13C
    {
        public const uint GL_MULTISAMPLE_BIT = 0x20000000u;
        public const uint GL_MULTISAMPLE = 0x809Du;
        public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809Eu;
        public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809Fu;
        public const uint GL_SAMPLE_COVERAGE = 0x80A0u;
        public const uint GL_SAMPLE_BUFFERS = 0x80A8u;
        public const uint GL_SAMPLES = 0x80A9u;
        public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AAu;
        public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80ABu;
        public const uint GL_CLAMP_TO_BORDER = 0x812Du;
        public const uint GL_TEXTURE0 = 0x84C0u;
        public const uint GL_TEXTURE1 = 0x84C1u;
        public const uint GL_TEXTURE2 = 0x84C2u;
        public const uint GL_TEXTURE3 = 0x84C3u;
        public const uint GL_TEXTURE4 = 0x84C4u;
        public const uint GL_TEXTURE5 = 0x84C5u;
        public const uint GL_TEXTURE6 = 0x84C6u;
        public const uint GL_TEXTURE7 = 0x84C7u;
        public const uint GL_TEXTURE8 = 0x84C8u;
        public const uint GL_TEXTURE9 = 0x84C9u;
        public const uint GL_TEXTURE10 = 0x84CAu;
        public const uint GL_TEXTURE11 = 0x84CBu;
        public const uint GL_TEXTURE12 = 0x84CCu;
        public const uint GL_TEXTURE13 = 0x84CDu;
        public const uint GL_TEXTURE14 = 0x84CEu;
        public const uint GL_TEXTURE15 = 0x84CFu;
        public const uint GL_TEXTURE16 = 0x84D0u;
        public const uint GL_TEXTURE17 = 0x84D1u;
        public const uint GL_TEXTURE18 = 0x84D2u;
        public const uint GL_TEXTURE19 = 0x84D3u;
        public const uint GL_TEXTURE20 = 0x84D4u;
        public const uint GL_TEXTURE21 = 0x84D5u;
        public const uint GL_TEXTURE22 = 0x84D6u;
        public const uint GL_TEXTURE23 = 0x84D7u;
        public const uint GL_TEXTURE24 = 0x84D8u;
        public const uint GL_TEXTURE25 = 0x84D9u;
        public const uint GL_TEXTURE26 = 0x84DAu;
        public const uint GL_TEXTURE27 = 0x84DBu;
        public const uint GL_TEXTURE28 = 0x84DCu;
        public const uint GL_TEXTURE29 = 0x84DDu;
        public const uint GL_TEXTURE30 = 0x84DEu;
        public const uint GL_TEXTURE31 = 0x84DFu;
        public const uint GL_ACTIVE_TEXTURE = 0x84E0u;
        public const uint GL_CLIENT_ACTIVE_TEXTURE = 0x84E1u;
        public const uint GL_MAX_TEXTURE_UNITS = 0x84E2u;
        public const uint GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3u;
        public const uint GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4u;
        public const uint GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5u;
        public const uint GL_TRANSPOSE_COLOR_MATRIX = 0x84E6u;
        public const uint GL_SUBTRACT = 0x84E7u;
        public const uint GL_COMPRESSED_ALPHA = 0x84E9u;
        public const uint GL_COMPRESSED_LUMINANCE = 0x84EAu;
        public const uint GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EBu;
        public const uint GL_COMPRESSED_INTENSITY = 0x84ECu;
        public const uint GL_COMPRESSED_RGB = 0x84EDu;
        public const uint GL_COMPRESSED_RGBA = 0x84EEu;
        public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EFu;
        public const uint GL_NORMAL_MAP = 0x8511u;
        public const uint GL_REFLECTION_MAP = 0x8512u;
        public const uint GL_TEXTURE_CUBE_MAP = 0x8513u;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514u;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515u;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516u;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517u;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518u;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519u;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851Au;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851Bu;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851Cu;
        public const uint GL_COMBINE = 0x8570u;
        public const uint GL_COMBINE_RGB = 0x8571u;
        public const uint GL_COMBINE_ALPHA = 0x8572u;
        public const uint GL_RGB_SCALE = 0x8573u;
        public const uint GL_ADD_SIGNED = 0x8574u;
        public const uint GL_INTERPOLATE = 0x8575u;
        public const uint GL_CONSTANT = 0x8576u;
        public const uint GL_PRIMARY_COLOR = 0x8577u;
        public const uint GL_PREVIOUS = 0x8578u;
        public const uint GL_SOURCE0_RGB = 0x8580u;
        public const uint GL_SOURCE1_RGB = 0x8581u;
        public const uint GL_SOURCE2_RGB = 0x8582u;
        public const uint GL_SOURCE0_ALPHA = 0x8588u;
        public const uint GL_SOURCE1_ALPHA = 0x8589u;
        public const uint GL_SOURCE2_ALPHA = 0x858Au;
        public const uint GL_OPERAND0_RGB = 0x8590u;
        public const uint GL_OPERAND1_RGB = 0x8591u;
        public const uint GL_OPERAND2_RGB = 0x8592u;
        public const uint GL_OPERAND0_ALPHA = 0x8598u;
        public const uint GL_OPERAND1_ALPHA = 0x8599u;
        public const uint GL_OPERAND2_ALPHA = 0x859Au;
        public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0u;
        public const uint GL_TEXTURE_COMPRESSED = 0x86A1u;
        public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2u;
        public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3u;
        public const uint GL_DOT3_RGB = 0x86AEu;
        public const uint GL_DOT3_RGBA = 0x86AFu;
    }
}
