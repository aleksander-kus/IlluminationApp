using System.Collections.Generic;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public interface ITriangulationService
    {
        List<List<Vector3>> TriangulateSphere(int radius, int centerX, int centerY, int quantity);
    }
}
