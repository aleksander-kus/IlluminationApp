using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public interface IColoringService
    {
        void FillTriangles(Bitmap bitmap, List<List<Vector3>> shapes, Color color);
        void DrawSphereEdges(Bitmap bitmap, List<List<Vector3>> shapes);
    }
}