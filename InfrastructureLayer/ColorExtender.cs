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
        public static Vector3 From01(this Color color) => new Vector3(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f);
        public static Color To01(this Vector3 color)
        {
            var r = color.X < 0 ? 0 : color.X > 1 ? 255 : color.X * 255;
            var g = color.Y < 0 ? 0 : color.Y > 1 ? 255 : color.Y * 255;
            var b = color.Z < 0 ? 0 : color.Z > 1 ? 255 : color.Z * 255;
            return Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
