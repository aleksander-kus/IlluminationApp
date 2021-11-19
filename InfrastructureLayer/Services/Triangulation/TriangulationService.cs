using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Services
{
    public class TriangulationService : ITriangulationService
    {
        public void DrawTriangulatedSphere(Bitmap bitmap, List<List<Vector3>> sphere)
        {
            throw new NotImplementedException();
        }

        public List<List<Point>> TriangulateSphere(int radius, int centerX, int centerY, int quantity)
        {
            throw new NotImplementedException();
        }

        List<List<Vector3>> ITriangulationService.TriangulateSphere(int radius, int centerX, int centerY, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
