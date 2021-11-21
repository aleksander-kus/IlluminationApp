using DomainLayer;
using System;
using System.Drawing;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public class ColorService : IColorService
    {
        public Color ComputeColor(Vector3 point, IlluminationParameters parameters)
        {
            if (point == new Vector3(parameters.Radius, parameters.Radius, parameters.Radius))
                return parameters.SceneColor;
            // the base color of point
            var I_O = parameters.ColoringMode == ColoringMode.SolidColor ? parameters.SceneColor.From255() : 
                GetColorFromTexture(point, parameters).From255();
            // light color
            var I_L = parameters.LightColor.From255();
            // normal versor
            var N = Vector3.Normalize(point - new Vector3(parameters.Radius, parameters.Radius, 0));  
            // additional versors
            var V = new Vector3(0, 0, 1);
            var sourceLocation = new Vector3(parameters.LightSourcePosition.X, parameters.LightSourcePosition.Y, parameters.Radius + parameters.Z);
            var L = Vector3.Normalize(sourceLocation - point);
            var R = 2 * Vector3.Dot(N, L) * N - L;

            var actualColor1 = Vector3.Multiply(I_L * I_O, parameters.Kd * CosineBetweenVectors(N, L));
            var actualColor2 = Vector3.Multiply(I_L * I_O, parameters.Ks * (float)Math.Pow(CosineBetweenVectors(V, R), parameters.M));
            return (actualColor1 + actualColor2).To255();
        }

        public Color GetColorFromTexture(Vector3 point, IlluminationParameters parameters)
        {
            return Color.White;
        }

        private static float CosineBetweenVectors(Vector3 vec1, Vector3 vec2)
        {
            var ret = vec1.X * vec2.X + vec1.Y * vec2.Y + vec1.Z * vec2.Z;
            return Math.Max(ret, 0);
        }
    }
}
