// TODO: Add documentation
#pragma warning disable 1591

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// Constants for OpenALC 1.0
    /// </summary>
    public class ALC10C
    {
        public const uint
            ALC_INVALID = 0xFFFFFFFF,
            ALC_FALSE = 0x0,
            ALC_TRUE = 0x1;

        public const uint
            ALC_FREQUENCY = 0x1007,
            ALC_REFRESH = 0x1008,
            ALC_SYNC = 0x1009;

        public const uint
            ALC_NO_ERROR = 0x0,
            ALC_INVALID_DEVICE = 0xA001,
            ALC_INVALID_CONTEXT = 0xA002,
            ALC_INVALID_ENUM = 0xA003,
            ALC_INVALID_VALUE = 0xA004,
            ALC_OUT_OF_MEMORY = 0xA005;

        public const uint
            ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004,
            ALC_DEVICE_SPECIFIER = 0x1005,
            ALC_EXTENSIONS = 0x1006;

        public const uint
            ALC_MAJOR_VERSION = 0x1000,
            ALC_MINOR_VERSION = 0x1001,
            ALC_ATTRIBUTES_SIZE = 0x1002,
            ALC_ALL_ATTRIBUTES = 0x1003;
    }
}
