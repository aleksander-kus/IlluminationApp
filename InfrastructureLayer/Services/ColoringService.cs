using DomainLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace InfrastructureLayer.Services
{
    public class ColoringService : IColoringService
    {
        public void DrawSphereEdges(Bitmap bitmap, List<List<Vector3>> sphere)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            Parallel.For(0, sphere.Count, i =>
            {
                var triangle = sphere[i];
                for (int i = 0; i < triangle.Count; ++i)
                {
                    using Pen p = new Pen(Color.Black, 1);
                    graphics.DrawLine(p, new Point((int)triangle[i].X, (int)triangle[i].Y), new Point((int)triangle[(i + 1) % triangle.Count].X, (int)triangle[(i + 1) % triangle.Count].Y));
                }
            })
            foreach (var triangle in sphere)
            {

            }
        }
        public void FillTriangles(Bitmap bitmap, List<List<Vector3>> shapes, Color color, IlluminationParameters parameters)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Transparent);
            foreach (var shape in shapes)
                ScanLineColoring(graphics, shape, parameters);
        }

        private void ScanLineColoring(Graphics graphics, List<Vector3> shape, IlluminationParameters parameters)
        {
            var P = shape.Select((point, index) => (point.X, point.Y, index)).OrderBy(shape => shape.Y).ToArray();
            List<(int y_max, double x, double m)> AET = new();
            int ymin = (int)P[0].Y;
            int ymax = (int)P[^1].Y;
            int current_index = 0;
            for(int y = ymin; y <= ymax; ++y)
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
                    for (int j = (int)Math.Round(AET[i].x); j < AET[i + 1].x; ++j)
                    {
                        using Brush b = new SolidBrush(ComputeColor(new Vector3(j, y, CalculateZ(j, y, shape[0], shape[1], shape[2])), parameters));
                        graphics.FillRectangle(b, j, y, 1, 1);
                    }
                // Update the x value for each edge
                for(int i = 0; i < AET.Count; ++i)
                {
                    var (y_max, x, m) = AET[i];
                    AET[i] = (y_max, x + 1 / m, m);
                }
            }
        }
        private Color ComputeColor(Vector3 point, IlluminationParameters parameters)
        {
            if (point == new Vector3(407, 407, 0))
                return Color.Black;
            var I_O = new Vector3(1f, 0.5f, 0.5f);  // the base color of point
            var I_L = new Vector3(1, 1, 1);  // light color
            var N = Vector3.Normalize(point - new Vector3(parameters.Radius, parameters.Radius, 0));  // normal versor
            var V = new Vector3(0, 0, 1);
            var sourceLocation = new Vector3(parameters.Radius, parameters.Radius, parameters.Radius);

            var L = Vector3.Normalize(sourceLocation - point);
            var R = 2 * Vector3.Dot(N, L) * N - L;

            var actualColor1 = Vector3.Multiply(I_L * I_O, parameters.Kd * CosineBetweenVectors(N, L));
            var actualColor2 = Vector3.Multiply(I_L * I_O, parameters.Ks * (float)Math.Pow(CosineBetweenVectors(V, R), parameters.m));
            var r = (actualColor1 + actualColor2).To01();
            return r;
        }

        private float CosineBetweenVectors(Vector3 vec1, Vector3 vec2)
        {
            var ret = vec1.X * vec2.X + vec1.Y * vec2.Y + vec1.Z * vec2.Z;
            return Math.Max(ret, 0);
        }

        public static float CalculateZ(int x, int y, Vector3 P1, Vector3 P2, Vector3 P3)
        {
            float z = (P3.Z * (x - P1.X) * (y - P2.Y) + P1.Z * (x - P2.X) * (y - P3.Y) + P2.Z * (x - P3.X) * (y - P1.Y) - P2.Z * (x - P1.X) * (y - P3.Y) - P3.Z * (x - P2.X) * (y - P1.Y) - P1.Z * (x - P3.X) * (y - P2.Y))
                    / ((x - P1.X) * (y - P2.Y) + (x - P2.X) * (y - P3.Y) + (x - P3.X) * (y - P1.Y) - (x - P1.X) * (y - P3.Y) - (x - P2.X) * (y - P1.Y) - (x - P3.X) * (y - P2.Y));

            return z;
        }

        private Vector3 SubstractVectors(Vector3 vec1, Vector3 vec2) => new Vector3(vec2.X - vec1.X, vec2.Y - vec1.Y, vec2.Z - vec1.Z);
    }
}
