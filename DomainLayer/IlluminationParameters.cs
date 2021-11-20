using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class IlluminationParameters
    {
        public float Kd { get; set; } = 0.5f;
        public float Ks { get; set; } = 0.5f;
        public int m { get; set; } = 50;
        public Color SceneColor { get; set; }
        public Color LightColor { get; set; }
        public int Radius { get; set; }
    }
}
