using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public static class ColorExtender
    {
        public static Vector3 From255(this Color color)
        {
            var r = color.R < 0 ? 0 : color.R > 255 ? 1 : color.R / 255f;
            var g = color.G < 0 ? 0 : color.G > 255 ? 1 : color.G / 255f;
            var b = color.B < 0 ? 0 : color.B > 255 ? 1 : color.B / 255f;
            return new Vector3(r, g, b);
        }

        public static Color To255(this Vector3 color)
        {
            var r = color.X < 0 ? 0 : color.X > 1 ? 255 : color.X * 255;
            var g = color.Y < 0 ? 0 : color.Y > 1 ? 255 : color.Y * 255;
            var b = color.Z < 0 ? 0 : color.Z > 1 ? 255 : color.Z * 255;
            return Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
