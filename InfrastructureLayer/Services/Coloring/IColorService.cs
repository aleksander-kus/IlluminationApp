using DomainLayer;
using System.Drawing;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public interface IColorService
    {
        Color ComputeColor(Vector3 point, IlluminationParameters parameters);
    }
}