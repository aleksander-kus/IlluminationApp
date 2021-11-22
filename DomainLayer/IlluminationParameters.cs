using System.ComponentModel;
using System.Drawing;

namespace DomainLayer
{
    public class IlluminationParameters : INotifyPropertyChanged
    {
        private float k = 0.0f;
        public float K
        {
            get => k;
            set
            {
                k = value;
                OnPropertyChanged(nameof(K));
            }
        }
        private float kd = 0.5f;
        public float Kd { 
            get => kd;
            set
            {
                kd = value;
                OnPropertyChanged(nameof(Kd));
            }
        }
        private float ks = 0.5f;
        public float Ks
        {
            get => ks;
            set
            {
                ks = value;
                OnPropertyChanged(nameof(Ks));
            }
        }
        private int m = 50;
        public int M
        {
            get => m;
            set
            {
                m = value;
                OnPropertyChanged(nameof(M));
            }
        }

        private int z = 400;
        public int Z
        {
            get => z;
            set
            {
                z = value;
                OnPropertyChanged(nameof(Z));
            }
        }
        private Color sceneColor;
        public Color SceneColor { get => sceneColor;
            set
            {
                sceneColor = value;
                OnPropertyChanged(nameof(SceneColor));
            }
        }
        private Color lightColor;
        public Color LightColor
        {
            get => lightColor;
            set
            {
                lightColor = value;
                OnPropertyChanged(nameof(LightColor));
            }
        }

        public ByteBitmap Texture { get; set; }
        public ByteBitmap NormalMap { get; set; }

        private ColoringMode coloringMode = ColoringMode.SolidColor;
        public ColoringMode ColoringMode
        {
            get => coloringMode;
            set
            {
                if(coloringMode != value)
                {
                    coloringMode = value;
                    OnPropertyChanged(nameof(ColoringMode));
                }
            }
        }

        private FillMode fillMode = FillMode.Accurate;
        public FillMode FillMode
        {
            get => fillMode;
            set
            {
                if (fillMode != value)
                {
                    fillMode = value;
                    OnPropertyChanged(nameof(FillMode));
                }
            }
        }

        private Point lightSourcePosition = new Point(417, 417);
        public Point LightSourcePosition
        {
            get => lightSourcePosition;
            set
            {
                lightSourcePosition = value;
                OnPropertyChanged(nameof(LightSourcePosition));
            }
        }

        public int Radius { get; set; }

        public int CanvasX { get; set; }

        public int CanvasY { get; set; }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
