using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LWCSGL
{
    /// <summary>
    /// Extensions for Bitmaps
    /// </summary>
    public static class BitmapEx
    {
        /// <summary>
        /// https://docs.oracle.com/javase/8/docs/api/java/awt/image/BufferedImage.html
        /// </summary>
        public static void GetRGB(this Bitmap image, int startX, int startY, int w, int h, int[] rgbArray, int offset, int scansize)
        {
            const int PixelWidth = 3;
            const PixelFormat PixelFormat = PixelFormat.Format24bppRgb;

            if (image == null) throw new ArgumentNullException("image");
            if (rgbArray == null) throw new ArgumentNullException("rgbArray");
            if (startX < 0 || startX + w > image.Width) throw new ArgumentOutOfRangeException("startX");
            if (startY < 0 || startY + h > image.Height) throw new ArgumentOutOfRangeException("startY");
            if (w < 0 || w > scansize || w > image.Width) throw new ArgumentOutOfRangeException("w");
            if (h < 0 || rgbArray.Length < offset + h * scansize || h > image.Height) throw new ArgumentOutOfRangeException("h");

            BitmapData data = image.LockBits(new Rectangle(startX, startY, w, h), ImageLockMode.ReadOnly, PixelFormat);
            try
            {
                byte[] pixelData = new byte[data.Stride];
                for (int scanline = 0; scanline < data.Height; scanline++)
                {
                    Marshal.Copy(data.Scan0 + scanline * data.Stride, pixelData, 0, data.Stride);
                    for (int pixeloffset = 0; pixeloffset < data.Width; pixeloffset++)
                    {
                        rgbArray[offset + scanline * scansize + pixeloffset] =
                            (pixelData[pixeloffset * PixelWidth + 2] << 16) +
                            (pixelData[pixeloffset * PixelWidth + 1] << 8) +
                            pixelData[pixeloffset * PixelWidth];
                    }
                }
            }
            finally
            {
                image.UnlockBits(data);
            }
        }

        /// <summary>
        /// https://docs.oracle.com/javase/8/docs/api/java/awt/image/BufferedImage.html
        /// </summary>
        public static void GetARGB(this Bitmap image, int startX, int startY, int w, int h, int[] rgbArray, int offset, int scansize)
        {
            const int PixelWidth = 4;
            const PixelFormat PixelFormat = PixelFormat.Format32bppArgb;

            if (image == null) throw new ArgumentNullException("image");
            if (rgbArray == null) throw new ArgumentNullException("rgbArray");
            if (startX < 0 || startX + w > image.Width) throw new ArgumentOutOfRangeException("startX");
            if (startY < 0 || startY + h > image.Height) throw new ArgumentOutOfRangeException("startY");
            if (w < 0 || w > scansize || w > image.Width) throw new ArgumentOutOfRangeException("w");
            if (h < 0 || rgbArray.Length < offset + h * scansize || h > image.Height) throw new ArgumentOutOfRangeException("h");

            BitmapData data = image.LockBits(new Rectangle(startX, startY, w, h), ImageLockMode.ReadOnly, PixelFormat);
            try
            {
                byte[] pixelData = new byte[data.Stride];
                for (int scanline = 0; scanline < data.Height; scanline++)
                {
                    Marshal.Copy(data.Scan0 + scanline * data.Stride, pixelData, 0, data.Stride);
                    for (int pixeloffset = 0; pixeloffset < data.Width; pixeloffset++)
                    {
                        rgbArray[offset + scanline * scansize + pixeloffset] =
                            (pixelData[pixeloffset * PixelWidth + 3] << 24) +
                            (pixelData[pixeloffset * PixelWidth + 2] << 16) +
                            (pixelData[pixeloffset * PixelWidth + 1] << 8) +
                            pixelData[pixeloffset * PixelWidth];
                    }
                }
            }
            finally
            {
                image.UnlockBits(data);
            }
        }
    }
}
