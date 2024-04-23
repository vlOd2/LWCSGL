#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// Constants for OpenGL 3.0
    /// </summary>
    public class GL30C
    {
        public const uint GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001u;
        public const uint GL_MAP_READ_BIT = 0x0001u;
        public const uint GL_MAP_WRITE_BIT = 0x0002u;
        public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004u;
        public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008u;
        public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010u;
        public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020u;
        public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506u;
        public const uint GL_MAX_CLIP_DISTANCES = 0x0D32u;
        public const uint GL_HALF_FLOAT = 0x140Bu;
        public const uint GL_CLIP_DISTANCE0 = 0x3000u;
        public const uint GL_CLIP_DISTANCE1 = 0x3001u;
        public const uint GL_CLIP_DISTANCE2 = 0x3002u;
        public const uint GL_CLIP_DISTANCE3 = 0x3003u;
        public const uint GL_CLIP_DISTANCE4 = 0x3004u;
        public const uint GL_CLIP_DISTANCE5 = 0x3005u;
        public const uint GL_CLIP_DISTANCE6 = 0x3006u;
        public const uint GL_CLIP_DISTANCE7 = 0x3007u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217u;
        public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218u;
        public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219u;
        public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821Au;
        public const uint GL_MAJOR_VERSION = 0x821Bu;
        public const uint GL_MINOR_VERSION = 0x821Cu;
        public const uint GL_NUM_EXTENSIONS = 0x821Du;
        public const uint GL_CONTEXT_FLAGS = 0x821Eu;
        public const uint GL_INDEX = 0x8222u;
        public const uint GL_COMPRESSED_RED = 0x8225u;
        public const uint GL_COMPRESSED_RG = 0x8226u;
        public const uint GL_RG = 0x8227u;
        public const uint GL_RG_INTEGER = 0x8228u;
        public const uint GL_R8 = 0x8229u;
        public const uint GL_R16 = 0x822Au;
        public const uint GL_RG8 = 0x822Bu;
        public const uint GL_RG16 = 0x822Cu;
        public const uint GL_R16F = 0x822Du;
        public const uint GL_R32F = 0x822Eu;
        public const uint GL_RG16F = 0x822Fu;
        public const uint GL_RG32F = 0x8230u;
        public const uint GL_R8I = 0x8231u;
        public const uint GL_R8UI = 0x8232u;
        public const uint GL_R16I = 0x8233u;
        public const uint GL_R16UI = 0x8234u;
        public const uint GL_R32I = 0x8235u;
        public const uint GL_R32UI = 0x8236u;
        public const uint GL_RG8I = 0x8237u;
        public const uint GL_RG8UI = 0x8238u;
        public const uint GL_RG16I = 0x8239u;
        public const uint GL_RG16UI = 0x823Au;
        public const uint GL_RG32I = 0x823Bu;
        public const uint GL_RG32UI = 0x823Cu;
        public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8u;
        public const uint GL_DEPTH_STENCIL = 0x84F9u;
        public const uint GL_UNSIGNED_INT_24_8 = 0x84FAu;
        public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5u;
        public const uint GL_RGBA32F = 0x8814u;
        public const uint GL_RGB32F = 0x8815u;
        public const uint GL_RGBA16F = 0x881Au;
        public const uint GL_RGB16F = 0x881Bu;
        public const uint GL_COMPARE_REF_TO_TEXTURE = 0x884Eu;
        public const uint GL_DEPTH24_STENCIL8 = 0x88F0u;
        public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1u;
        public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FDu;
        public const uint GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FFu;
        public const uint GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904u;
        public const uint GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905u;
        public const uint GL_CLAMP_VERTEX_COLOR = 0x891Au;
        public const uint GL_CLAMP_FRAGMENT_COLOR = 0x891Bu;
        public const uint GL_CLAMP_READ_COLOR = 0x891Cu;
        public const uint GL_FIXED_ONLY = 0x891Du;
        public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4Bu;
        public const uint GL_TEXTURE_RED_TYPE = 0x8C10u;
        public const uint GL_TEXTURE_GREEN_TYPE = 0x8C11u;
        public const uint GL_TEXTURE_BLUE_TYPE = 0x8C12u;
        public const uint GL_TEXTURE_ALPHA_TYPE = 0x8C13u;
        public const uint GL_TEXTURE_LUMINANCE_TYPE = 0x8C14u;
        public const uint GL_TEXTURE_INTENSITY_TYPE = 0x8C15u;
        public const uint GL_TEXTURE_DEPTH_TYPE = 0x8C16u;
        public const uint GL_UNSIGNED_NORMALIZED = 0x8C17u;
        public const uint GL_TEXTURE_1D_ARRAY = 0x8C18u;
        public const uint GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19u;
        public const uint GL_TEXTURE_2D_ARRAY = 0x8C1Au;
        public const uint GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1Bu;
        public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1Cu;
        public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1Du;
        public const uint GL_R11F_G11F_B10F = 0x8C3Au;
        public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3Bu;
        public const uint GL_RGB9_E5 = 0x8C3Du;
        public const uint GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3Eu;
        public const uint GL_TEXTURE_SHARED_SIZE = 0x8C3Fu;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76u;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7Fu;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80u;
        public const uint GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83u;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84u;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85u;
        public const uint GL_PRIMITIVES_GENERATED = 0x8C87u;
        public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88u;
        public const uint GL_RASTERIZER_DISCARD = 0x8C89u;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8Au;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8Bu;
        public const uint GL_INTERLEAVED_ATTRIBS = 0x8C8Cu;
        public const uint GL_SEPARATE_ATTRIBS = 0x8C8Du;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8Eu;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8Fu;
        public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6u;
        public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6u;
        public const uint GL_RENDERBUFFER_BINDING = 0x8CA7u;
        public const uint GL_READ_FRAMEBUFFER = 0x8CA8u;
        public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9u;
        public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAAu;
        public const uint GL_RENDERBUFFER_SAMPLES = 0x8CABu;
        public const uint GL_DEPTH_COMPONENT32F = 0x8CACu;
        public const uint GL_DEPTH32F_STENCIL8 = 0x8CADu;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3u;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4u;
        public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5u;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6u;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7u;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDBu;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDCu;
        public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDDu;
        public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDFu;
        public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0u;
        public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1u;
        public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2u;
        public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3u;
        public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4u;
        public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5u;
        public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6u;
        public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7u;
        public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8u;
        public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9u;
        public const uint GL_COLOR_ATTACHMENT10 = 0x8CEAu;
        public const uint GL_COLOR_ATTACHMENT11 = 0x8CEBu;
        public const uint GL_COLOR_ATTACHMENT12 = 0x8CECu;
        public const uint GL_COLOR_ATTACHMENT13 = 0x8CEDu;
        public const uint GL_COLOR_ATTACHMENT14 = 0x8CEEu;
        public const uint GL_COLOR_ATTACHMENT15 = 0x8CEFu;
        public const uint GL_COLOR_ATTACHMENT16 = 0x8CF0u;
        public const uint GL_COLOR_ATTACHMENT17 = 0x8CF1u;
        public const uint GL_COLOR_ATTACHMENT18 = 0x8CF2u;
        public const uint GL_COLOR_ATTACHMENT19 = 0x8CF3u;
        public const uint GL_COLOR_ATTACHMENT20 = 0x8CF4u;
        public const uint GL_COLOR_ATTACHMENT21 = 0x8CF5u;
        public const uint GL_COLOR_ATTACHMENT22 = 0x8CF6u;
        public const uint GL_COLOR_ATTACHMENT23 = 0x8CF7u;
        public const uint GL_COLOR_ATTACHMENT24 = 0x8CF8u;
        public const uint GL_COLOR_ATTACHMENT25 = 0x8CF9u;
        public const uint GL_COLOR_ATTACHMENT26 = 0x8CFAu;
        public const uint GL_COLOR_ATTACHMENT27 = 0x8CFBu;
        public const uint GL_COLOR_ATTACHMENT28 = 0x8CFCu;
        public const uint GL_COLOR_ATTACHMENT29 = 0x8CFDu;
        public const uint GL_COLOR_ATTACHMENT30 = 0x8CFEu;
        public const uint GL_COLOR_ATTACHMENT31 = 0x8CFFu;
        public const uint GL_DEPTH_ATTACHMENT = 0x8D00u;
        public const uint GL_STENCIL_ATTACHMENT = 0x8D20u;
        public const uint GL_FRAMEBUFFER = 0x8D40u;
        public const uint GL_RENDERBUFFER = 0x8D41u;
        public const uint GL_RENDERBUFFER_WIDTH = 0x8D42u;
        public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43u;
        public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44u;
        public const uint GL_STENCIL_INDEX1 = 0x8D46u;
        public const uint GL_STENCIL_INDEX4 = 0x8D47u;
        public const uint GL_STENCIL_INDEX8 = 0x8D48u;
        public const uint GL_STENCIL_INDEX16 = 0x8D49u;
        public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50u;
        public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51u;
        public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52u;
        public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53u;
        public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54u;
        public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55u;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56u;
        public const uint GL_MAX_SAMPLES = 0x8D57u;
        public const uint GL_RGBA32UI = 0x8D70u;
        public const uint GL_RGB32UI = 0x8D71u;
        public const uint GL_RGBA16UI = 0x8D76u;
        public const uint GL_RGB16UI = 0x8D77u;
        public const uint GL_RGBA8UI = 0x8D7Cu;
        public const uint GL_RGB8UI = 0x8D7Du;
        public const uint GL_RGBA32I = 0x8D82u;
        public const uint GL_RGB32I = 0x8D83u;
        public const uint GL_RGBA16I = 0x8D88u;
        public const uint GL_RGB16I = 0x8D89u;
        public const uint GL_RGBA8I = 0x8D8Eu;
        public const uint GL_RGB8I = 0x8D8Fu;
        public const uint GL_RED_INTEGER = 0x8D94u;
        public const uint GL_GREEN_INTEGER = 0x8D95u;
        public const uint GL_BLUE_INTEGER = 0x8D96u;
        public const uint GL_ALPHA_INTEGER = 0x8D97u;
        public const uint GL_RGB_INTEGER = 0x8D98u;
        public const uint GL_RGBA_INTEGER = 0x8D99u;
        public const uint GL_BGR_INTEGER = 0x8D9Au;
        public const uint GL_BGRA_INTEGER = 0x8D9Bu;
        public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DADu;
        public const uint GL_FRAMEBUFFER_SRGB = 0x8DB9u;
        public const uint GL_COMPRESSED_RED_RGTC1 = 0x8DBBu;
        public const uint GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBCu;
        public const uint GL_COMPRESSED_RG_RGTC2 = 0x8DBDu;
        public const uint GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBEu;
        public const uint GL_SAMPLER_1D_ARRAY = 0x8DC0u;
        public const uint GL_SAMPLER_2D_ARRAY = 0x8DC1u;
        public const uint GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3u;
        public const uint GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4u;
        public const uint GL_SAMPLER_CUBE_SHADOW = 0x8DC5u;
        public const uint GL_UNSIGNED_INT_VEC2 = 0x8DC6u;
        public const uint GL_UNSIGNED_INT_VEC3 = 0x8DC7u;
        public const uint GL_UNSIGNED_INT_VEC4 = 0x8DC8u;
        public const uint GL_INT_SAMPLER_1D = 0x8DC9u;
        public const uint GL_INT_SAMPLER_2D = 0x8DCAu;
        public const uint GL_INT_SAMPLER_3D = 0x8DCBu;
        public const uint GL_INT_SAMPLER_CUBE = 0x8DCCu;
        public const uint GL_INT_SAMPLER_1D_ARRAY = 0x8DCEu;
        public const uint GL_INT_SAMPLER_2D_ARRAY = 0x8DCFu;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1u;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2u;
        public const uint GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3u;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4u;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6u;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7u;
        public const uint GL_QUERY_WAIT = 0x8E13u;
        public const uint GL_QUERY_NO_WAIT = 0x8E14u;
        public const uint GL_QUERY_BY_REGION_WAIT = 0x8E15u;
        public const uint GL_QUERY_BY_REGION_NO_WAIT = 0x8E16u;
        public const uint GL_BUFFER_ACCESS_FLAGS = 0x911Fu;
        public const uint GL_BUFFER_MAP_LENGTH = 0x9120u;
        public const uint GL_BUFFER_MAP_OFFSET = 0x9121u;
    }
}
