using DomainLayer;
using System;
using System.Drawing;
using System.Linq;

namespace InfrastructureLayer
{
    public class AnimationService : IAnimationService
    {
        private readonly IlluminationParameters parameters;
        private readonly int numberOfPoints;
        private Point[] points;
        private int current = 0;

        public AnimationService(int interval, int time, IlluminationParameters parameters)
        {
            this.parameters = parameters;
            numberOfPoints = time / interval / 5;
            points = new Point[numberOfPoints];
            GeneratePointsOnSpiral();
        }
        public void AnimateFrame()
        {
            if (current == points.Length)
                return;
            parameters.LightSourcePosition = points[current];
            ++current;
        }

        public void ResetAnimation()
        {
            parameters.LightSourcePosition = points[0];
            current = 0;
        }

        private void GeneratePointsOnSpiral()
        {
            const int numberOfCircles = 10;
            
            float angle, scale;

            for (int i = 0; i < numberOfPoints; i++)
            {
                angle = (float)(i * 2 * Math.PI / (numberOfPoints / numberOfCircles));
                scale = 1 - (float) i / numberOfPoints;

                points[i].X = (int)Math.Round(parameters.CanvasX / 2 * (1 + scale * Math.Cos(angle)));
                points[i].Y = (int)Math.Round(parameters.CanvasY / 2 * (1 + scale * Math.Sin(angle)));
            }
            points = points.Reverse().ToArray();
        }
    }
}
