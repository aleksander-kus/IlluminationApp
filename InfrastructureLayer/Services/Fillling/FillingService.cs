using DomainLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace InfrastructureLayer.Services
{
    public class FillingService : IFillingService
    {
        private readonly IColorService colorService;

        public FillingService(IColorService colorService)
        {
            this.colorService = colorService;
        }

        public void DrawSphereEdges(Bitmap bitmap, List<List<Vector3>> sphere)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            foreach(var shape in sphere)
                for(int i = 0; i < shape.Count; ++i)
                    graphics.DrawLine(Pens.Black, new Point((int)shape[i].X, (int)shape[i].Y), new Point((int)shape[(i + 1) % shape.Count].X, (int)shape[(i + 1) % shape.Count].Y));
        }
        public void FillTriangles(Bitmap bitmap, List<List<Vector3>> shapes, IlluminationParameters parameters)
        {
            // Lock the bitmap's bits.  
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
            ByteBitmap byteBitmap = new(bitmap.Width, bitmap.Height, bitmapData.Stride / bitmap.Width);
            //shapes.ForEach(shape => ScanLineColoring(byteBitmap, shape, parameters));
            Parallel.ForEach(shapes, shape => ScanLineColoring(byteBitmap, shape, parameters));
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(byteBitmap.Bitmap, 0, bitmapData.Scan0, byteBitmap.Bitmap.Length);

            // Unlock the bits.
            bitmap.UnlockBits(bitmapData);
        }

        private void ScanLineColoring(ByteBitmap bitmap, List<Vector3> shape, IlluminationParameters parameters)
        {
            var P = shape.Select((point, index) => (point.X, point.Y, index)).OrderBy(shape => shape.Y).ToArray();
            List<(int y_max, double x, double m)> AET = new();
            int ymin = (int)P[0].Y;
            int ymax = (int)P[^1].Y;
            int current_index = 0;
            Vector3 color1 = colorService.ComputeColor(shape[0], parameters).From255();
            Vector3 color2 = colorService.ComputeColor(shape[1], parameters).From255();
            Vector3 color3 = colorService.ComputeColor(shape[2], parameters).From255();
            for (int y = ymin; y <= ymax; ++y)
            {
                // For each point that was on the previous line
                while (P[current_index].Y == y - 1)
                {
                    var current_point = P[current_index];
                    // Find adjacent points
                    var previous_point = Array.Find(P, p => p.index == (current_point.index - 1 + P.Length) % P.Length);
                    var next_point = Array.Find(P, p => p.index == (current_point.index + 1 + P.Length) % P.Length);
                    if (previous_point.Y > current_point.Y)
                    {
                        double m = (current_point.Y - previous_point.Y) / (current_point.X - previous_point.X);
                        if(m != 0)
                            AET.Add(((int)previous_point.Y, P[current_index].X + 1 / m, m));
                    }
                    else
                    {
                        AET.RemoveAll(item => item.y_max == current_point.Y);
                    }
                    if (next_point.Y > current_point.Y)
                    {
                        double m = (current_point.Y - next_point.Y) / (current_point.X - next_point.X);
                        if (m != 0)
                            AET.Add(((int)next_point.Y, P[current_index].X + 1 / m, m));
                    }
                    else
                    {
                        AET.RemoveAll(item => item.y_max == current_point.Y);
                    }
                    ++current_index;
                }
                // Sort edges according to x
                AET.Sort((item1, item2) => item1.x.CompareTo(item2.x));
                // Fill pixels between every pair of edges
                for(int i = 0; i < AET.Count; i += 2)
                {
                    for (int x = (int)Math.Round(AET[i].x); x < AET[i + 1].x; ++x)
                    {
                        Color color = Color.Black;
                        float z = GetZ(x, y, shape[0], shape[1], shape[2]);
                        if (parameters.FillMode == FillMode.Interpolation)
                        {
                            var factors = GetInterpolationFactors(shape, new Vector3(x, y, z), parameters);
                            color = (color1 * factors.X + color2 * factors.Y + color3 * factors.Z).To255();
                        }
                        else
                            color = colorService.ComputeColor(new Vector3(x, y, z), parameters);
                        bitmap.SetPixel(x, y, color);
                    }
                }
                // Update the x value for each edge
                for(int i = 0; i < AET.Count; ++i)
                {
                    var (y_max, x, m) = AET[i];
                    AET[i] = (y_max, x + 1 / m, m);
                }
            }
        }

        private static Vector3 GetInterpolationFactors(List<Vector3> shape, Vector3 point, IlluminationParameters parameters)
        {
            var f1 = shape[0] - point;
            var f2 = shape[1] - point;
            var f3 = shape[2] - point;
            var TriangleArea = Vector3.Cross(shape[0] - shape[1], shape[0] - shape[2]).Length();
            var a1 = Vector3.Cross(f2, f3).Length() / TriangleArea;
            var a2 = Vector3.Cross(f3, f1).Length() / TriangleArea;
            var a3 = Vector3.Cross(f1, f2).Length() / TriangleArea;
            return new Vector3(a1, a2, a3);
        }

        /// <summary>
        /// Calculate the third coordinate of a point, given three points of the plane it is on
        /// </summary>
        public static float GetZ(int x, int y, Vector3 p1, Vector3 p2, Vector3 p3)
        {
            float z1 = p1.Z * (x - p2.X) * (y - p3.Y) + p2.Z * (x - p3.X) * (y - p1.Y) + p3.Z * (x - p1.X) * (y - p2.Y) - p1.Z * (x - p3.X) * (y - p2.Y) - p2.Z * (x - p1.X) * (y - p3.Y) - p3.Z * (x - p2.X) * (y - p1.Y);
            float z2 = (x - p1.X) * (y - p2.Y) + (x - p2.X) * (y - p3.Y) + (x - p3.X) * (y - p1.Y) - (x - p1.X) * (y - p3.Y) - (x - p2.X) * (y - p1.Y) - (x - p3.X) * (y - p2.Y);

            return z1/z2;
        }
    }
}
