using System.Collections.Generic;

namespace LWCSGL.OpenGL
{
    /// <summary>
    /// This class encapsulates the properties for a given display mode.
    /// </summary>
    public class DisplayMode
    {
        internal int width;
        internal int height;
        internal bool fullscreen;
        internal int bitsPerPixel; // Colors
        internal int frequency;

        /// <summary>
        /// Construct a display mode.
        /// </summary>
        /// <param name="w">The display width</param>
        /// <param name="h">The display height</param>
        public DisplayMode(int w, int h)
        {
            width = w;
            height = h;
        }

        internal DisplayMode(int w, int h, bool fs, int bps, int freq)
        {
            width = w;
            height = h;
            fullscreen = fs;
            bitsPerPixel = bps;
            frequency = freq;
        }

        /// <summary>
        /// </summary>
        public int GetWidth() => width;

        /// <summary>
        /// </summary>
        public int GetHeight() => height;

        /// <summary>
        /// True if this instance can be used for fullscreen modes
        /// </summary>
        public bool IsFullscreenCapable() => fullscreen;

        /// <summary>
        /// </summary>
        public int GetBitsPerPixel() => bitsPerPixel;

        /// <summary>
        /// </summary>
        public int GetFrequency() => frequency;

        /// <summary>
        /// Returns the string representation of this display mode
        /// </summary>
        /// <returns>the string representation</returns>
        public override string ToString()
        {
            return $"{width}x{height}";
        }

        /// <summary>
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is DisplayMode mode &&
                   width == mode.width &&
                   height == mode.height &&
                   fullscreen == mode.fullscreen &&
                   bitsPerPixel == mode.bitsPerPixel &&
                   frequency == mode.frequency;
        }

        /// <summary>
        /// </summary>
        public override int GetHashCode()
        {
            int hashCode = -810904102;
            hashCode = hashCode * -1521134295 + width.GetHashCode();
            hashCode = hashCode * -1521134295 + height.GetHashCode();
            hashCode = hashCode * -1521134295 + fullscreen.GetHashCode();
            hashCode = hashCode * -1521134295 + bitsPerPixel.GetHashCode();
            hashCode = hashCode * -1521134295 + frequency.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// </summary>
        public static bool operator ==(DisplayMode left, DisplayMode right)
        {
            return EqualityComparer<DisplayMode>.Default.Equals(left, right);
        }

        /// <summary>
        /// </summary>
        public static bool operator !=(DisplayMode left, DisplayMode right)
        {
            return !(left == right);
        }
    }
}
