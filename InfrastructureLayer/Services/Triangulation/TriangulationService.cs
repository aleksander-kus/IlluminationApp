using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace InfrastructureLayer.Services
{
    public class TriangulationService : ITriangulationService
    {
        public List<List<Vector3>> TriangulateSphere(int radius, int centerX, int centerY, int levels)
        {
            var pointsPerLevel = levels * 4;
            Vector3[] points = new Vector3[levels * pointsPerLevel + 1];
            (int, int, int)[] triangles = new (int, int, int)[2 * levels * pointsPerLevel - pointsPerLevel];
            List<List<Vector3>> TriangluatedSphere = new();

            int pointIndex = 0, triangleIndex = 0;
            // for every level
            for (var level = 0; level < levels; level++)
            {
                // we go around the circle
                for (var index = 0; index < pointsPerLevel; index++)
                {
                    var latitude = 2 * Math.PI * level / pointsPerLevel;
                    var longitude = 2 * Math.PI * (index + level * 0.5) / pointsPerLevel;

                    // determine the exact location of the point
                    Vector3 point = new()
                    {
                        X = (int)(Math.Cos(latitude) * Math.Cos(longitude) * radius + centerX),
                        Y = (int)(Math.Cos(latitude) * Math.Sin(longitude) * radius + centerY),
                        Z = (float)Math.Sin(latitude) * radius
                    };

                    points[pointIndex++] = point;

                    // save the indices of points to triangles
                    if (level < levels - 1)
                    {
                        triangles[triangleIndex++] = (index + level * pointsPerLevel, (index + 1) % pointsPerLevel + level * pointsPerLevel, index + (level + 1) * pointsPerLevel);
                        triangles[triangleIndex++] = ((index + 1) % pointsPerLevel + level * pointsPerLevel, (index + 1) % pointsPerLevel + (level + 1) * pointsPerLevel, index + (level + 1) * pointsPerLevel);
                    }
                }
            }
            points[levels * pointsPerLevel] = new Vector3(centerX, centerY, radius);

            // handle triangles on the top
            for (int index = 0; index < pointsPerLevel; index++)
                triangles[triangleIndex++] = (index + (levels - 1) * pointsPerLevel, (index + 1) % pointsPerLevel + (levels - 1) * pointsPerLevel, levels * pointsPerLevel);

            TriangluatedSphere = triangles.Select(triangle => new List<Vector3>
            {
                points[triangle.Item1],
                points[triangle.Item2],
                points[triangle.Item3],
            }).ToList();

            return TriangluatedSphere;
        }
    }
}
