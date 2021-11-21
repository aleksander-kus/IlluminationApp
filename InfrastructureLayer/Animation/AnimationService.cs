using DomainLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class AnimationService : IAnimationService
    {
        private IlluminationParameters parameters;
        const int iNumRevs = 3;
        Point[] points;
        int iNumPoints;
        int current = 0;

        public AnimationService(int interval, int time, IlluminationParameters parameters)
        {
            this.parameters = parameters;
            iNumPoints = time / interval / 5;
            points = new Point[iNumPoints];
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
            const int iNumRevs = 10;
            
            float fAngle, fScale;

            for (int i = 0; i < iNumPoints; i++)
            {
                fAngle = (float)(i * 2 * Math.PI / (iNumPoints / iNumRevs));
                fScale = 1 - (float)i / iNumPoints;

                points[i].X = (int)Math.Round(parameters.CanvasX / 2 * (1 + fScale * Math.Cos(fAngle)));
                points[i].Y = (int)Math.Round(parameters.CanvasY / 2 * (1 + fScale * Math.Sin(fAngle)));
            }
            points = points.Reverse().ToArray();
        }
    }
}
