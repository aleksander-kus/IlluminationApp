using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class IlluminationParameters : INotifyPropertyChanged
    {
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
        public int Radius { get; set; }

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
