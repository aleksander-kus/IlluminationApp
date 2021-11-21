using DomainLayer;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public interface IFillingService
    {
        void DrawSphereEdges(Bitmap bitmap, List<List<Vector3>> shapes);
        void FillTriangles(Bitmap bitmap, List<List<Vector3>> shapes, IlluminationParameters parameters);
    }
}