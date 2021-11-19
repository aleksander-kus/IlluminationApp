using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public class ColoringService : IColoringService
    {
        public void DrawSphereEdges(Bitmap bitmap, List<List<Vector3>> sphere)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            foreach (var triangle in sphere)
            {
                for (int i = 0; i < triangle.Count; ++i)
                {
                    graphics.DrawRectangle(Pens.Black, triangle[i].X, triangle[i].Y, 1, 1);
                    using Pen p = new Pen(Color.Black, 1);
                    graphics.DrawLine(p, new Point((int)triangle[i].X, (int)triangle[i].Y), new Point((int)triangle[(i + 1) % triangle.Count].X, (int)triangle[(i + 1) % triangle.Count].Y));
                }
            }
        }
        public void FillTriangles(Bitmap bitmap, List<List<Vector3>> shapes, Color color)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Transparent);
            foreach (var shape in shapes)
                ScanLineColoring(graphics, shape);
        }

        private void ScanLineColoring(Graphics graphics, List<Vector3> shape)
        {
            var P = shape.Select((point, index) => (point.X, point.Y, index)).OrderBy(shape => shape.Y).ToArray();
            List<(int y_max, double x, double m)> AET = new();
            int ymin = (int)P[0].Y;
            int ymax = (int)P[^1].Y;
            int current_index = 0;
            for(int y = ymin; y <= ymax; ++y)
            {
                while (P[current_index].Y == y - 1)
                {
                    var current_point = P[current_index];
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
                    for (int j = (int)Math.Round(AET[i].x); j < AET[i + 1].x; ++j)
                        graphics.FillRectangle(Brushes.Green, j, y, 1, 1);
                }
                // Update the x value for each edge
                for(int i = 0; i < AET.Count; ++i)
                {
                    var (y_max, x, m) = AET[i];
                    AET[i] = (y_max, x + 1 / m, m);
                }
            }
        }
    }
}
