using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    /// <summary>
    /// A bitmap represented as a list of bytes
    /// </summary>
    public class ByteBitmap
    {
        private readonly byte[] bitmap;
        public byte[] Bitmap => bitmap;
        public int BytesPerPixel { get; set; } = 4;
        public int Width { get; set; }
        public int Height { get; set; }

        /// <param name="width">Width in pixels</param>
        /// <param name="height">Height in pixels</param>
        /// <param name="bytesPerPixel"></param>
        public ByteBitmap(int width, int height, int bytesPerPixel = 4)
        {
            Width = width;
            Height = height;
            BytesPerPixel = bytesPerPixel;
            bitmap = new byte[Width * Height * BytesPerPixel];
        }

        public void SetPixel(int x, int y, Color color)
        {
            bitmap[y * Width * BytesPerPixel + x * BytesPerPixel] = color.B;
            bitmap[y * Width * BytesPerPixel + x * BytesPerPixel + 1] = color.G;
            bitmap[y * Width * BytesPerPixel + x * BytesPerPixel + 2] = color.R;
            bitmap[y * Width * BytesPerPixel + x * BytesPerPixel + 3] = color.A;
        }
    }
}
