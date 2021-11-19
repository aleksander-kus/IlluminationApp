using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Services
{
    public interface ITriangulationService
    {
        List<List<Vector3>> TriangulateSphere(int radius, int centerX, int centerY, int quantity);
    }
}
