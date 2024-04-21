using System.Runtime.InteropServices;

// TODO: Add documentation
#pragma warning disable 1591

namespace LWCSGL.OpenAL
{
    /// <summary>
    /// Constants for OpenAL 1.0
    /// </summary>
    public class AL10C
    {
        public const uint
            AL_INVALID = 0xFFFFFFFF,
            AL_NONE = 0x0,
            AL_FALSE = 0x0,
            AL_TRUE = 0x1;

        public const uint
            AL_NO_ERROR = 0x0,
            AL_INVALID_NAME = 0xA001,
            AL_INVALID_ENUM = 0xA002,
            AL_INVALID_VALUE = 0xA003,
            AL_INVALID_OPERATION = 0xA004,
            AL_OUT_OF_MEMORY = 0xA005;

        public const uint
            AL_DOPPLER_FACTOR = 0xC000,
            AL_DISTANCE_MODEL = 0xD000;

        public const uint
            AL_VENDOR = 0xB001,
            AL_VERSION = 0xB002,
            AL_RENDERER = 0xB003,
            AL_EXTENSIONS = 0xB004;

        public const uint
            AL_INVERSE_DISTANCE = 0xD001,
            AL_INVERSE_DISTANCE_CLAMPED = 0xD002;

        public const uint
            AL_SOURCE_ABSOLUTE = 0x201,
            AL_SOURCE_RELATIVE = 0x202;

        public const uint
            AL_POSITION = 0x1004,
            AL_VELOCITY = 0x1006,
            AL_GAIN = 0x100A;

        public const uint
            AL_CONE_INNER_ANGLE = 0x1001,
            AL_CONE_OUTER_ANGLE = 0x1002,
            AL_PITCH = 0x1003,
            AL_DIRECTION = 0x1005,
            AL_LOOPING = 0x1007,
            AL_BUFFER = 0x1009,
            AL_SOURCE_STATE = 0x1010,
            AL_CONE_OUTER_GAIN = 0x1022,
            AL_SOURCE_TYPE = 0x1027;

        public const uint
            AL_INITIAL = 0x1011,
            AL_PLAYING = 0x1012,
            AL_PAUSED = 0x1013,
            AL_STOPPED = 0x1014;

        public const uint AL_ORIENTATION = 0x100F;

        public const uint
            AL_BUFFERS_QUEUED = 0x1015,
            AL_BUFFERS_PROCESSED = 0x1016;

        public const uint
            AL_MIN_GAIN = 0x100D,
            AL_MAX_GAIN = 0x100E;

        public const uint
            AL_REFERENCE_DISTANCE = 0x1020,
            AL_ROLLOFF_FACTOR = 0x1021,
            AL_MAX_DISTANCE = 0x1023;

        public const uint
            AL_FREQUENCY = 0x2001,
            AL_BITS = 0x2002,
            AL_CHANNELS = 0x2003,
            AL_SIZE = 0x2004;

        public const uint
            AL_FORMAT_MONO8 = 0x1100,
            AL_FORMAT_MONO16 = 0x1101,
            AL_FORMAT_STEREO8 = 0x1102,
            AL_FORMAT_STEREO16 = 0x1103;

        public const uint
            AL_UNUSED = 0x2010,
            AL_PENDING = 0x2011,
            AL_PROCESSED = 0x2012;
    }
}
