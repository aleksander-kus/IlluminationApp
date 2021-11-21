using DomainLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public class ColorService : IColorService
    {
        public Color ComputeColor(Vector3 point, IlluminationParameters parameters)
        {
            // the base color of point
            var I_O = parameters.ColoringMode == ColoringMode.SolidColor ? parameters.SceneColor.From255() : GetColorFromTexture(point, parameters).From255();
            // light color
            var I_L = parameters.LightColor.From255();
            // normal versor gotten from ball
            var N_ball = Vector3.Normalize(point - new Vector3(parameters.Radius, parameters.Radius, 0));
            // normal versor from normalMap
            var color = parameters.NormalMap.GetPixel((int)point.X, (int)point.Y).From255();
            var N_normalMap = Multiply(Vector3.Normalize(2 * color - Vector3.One), N_ball);
            var N = Vector3.Normalize(N_ball * parameters.K + N_normalMap * (1 - parameters.K));
            // additional versors
            var V = new Vector3(0, 0, 1);
            var sourceLocation = new Vector3(parameters.LightSourcePosition.X, parameters.LightSourcePosition.Y, parameters.Radius + parameters.Z);
            var L = Vector3.Normalize(sourceLocation - point);
            var R = 2 * Vector3.Dot(N, L) * N - L;

            var actualColor1 = I_L * I_O * parameters.Kd * CosineBetweenVectors(N, L);
            var actualColor2 = I_L * I_O * parameters.Ks * (float)Math.Pow(CosineBetweenVectors(V, R), parameters.M);
            return (actualColor1 + actualColor2).To255();
        }

        private static Color GetColorFromTexture(Vector3 point, IlluminationParameters parameters)
        {
            return parameters.Texture.GetPixel((int)point.X, (int)point.Y);
        }

        private static Vector3 Multiply(Vector3 v, Vector3 n)
        {
            var B = (n.Z == 1) ? new Vector3(0, 1, 0) : Vector3.Normalize(n * new Vector3(0, 0, 1));
            var T = Vector3.Normalize(Vector3.Cross(B, n));
            return Vector3.Normalize(T * v.X + B * v.Y + n * v.Z);
        }

        private static float CosineBetweenVectors(Vector3 vec1, Vector3 vec2)
        {
            var ret = vec1.X * vec2.X + vec1.Y * vec2.Y + vec1.Z * vec2.Z;
            return Math.Max(ret, 0);
        }
    }
}
