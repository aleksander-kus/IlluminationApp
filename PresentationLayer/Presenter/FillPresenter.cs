using DomainLayer;
using InfrastructureLayer;
using InfrastructureLayer.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;

namespace PresentationLayer
{
    public class FillPresenter
    {
        private readonly IFillView view;
        private readonly Bitmap bitmap;
        private List<List<Vector3>> triangulatedSphere;
        private int triangulationPrecision;
        public int TriangulationPrecision { 
            set
            {
                triangulationPrecision = value;
                CalculateTriangulation();
                ColorBitmap();
            }
        }
        public IlluminationParameters Parameters { get; set; }
        public int AnimationTime { get; set; } = 10000;
        public int AnimationInterval { get; set; } = 10;
        private readonly IAnimationService animationService;
        private readonly ITriangulationService triangulationService;
        private readonly IFillingService coloringService;

        public FillPresenter(IFillView view)
        {
            this.view = view;
            bitmap = new(view.CanvasSizeX, view.CanvasSizeY);
            this.view.CanvasImage = bitmap;
            this.view.Timer.Interval = AnimationInterval;
            this.view.Timer.Tick += Timer_Tick;
            
            Parameters = new()
            {
                Radius = view.CanvasSizeX / 2,
                CanvasX = view.CanvasSizeX,
                CanvasY = view.CanvasSizeY,
                SceneColor = Color.Green,
                LightColor = Color.White,
                LightSourcePosition = new Point(view.CanvasSizeX / 2, view.CanvasSizeY / 2)
            };
            Parameters.Radius = view.CanvasSizeX / 2;
            Parameters.PropertyChanged += Parameters_PropertyChanged;
            triangulationService = new TriService();
            coloringService = new FillingService(new ColorService());
            animationService = new AnimationService(AnimationInterval, AnimationTime, Parameters);
            LoadTexture("C:\\Users\\alexq\\studia\\gk1\\lab2\\Basketball.png");
            Parameters.NormalMap = new ByteBitmap((Bitmap)Image.FromFile("C:\\Users\\alexq\\studia\\gk1\\lab2\\pebbles_normalmap.jpg"));
            //LoadTexture("C:\\Users\\alexq\\studia\\gk1\\lab2\\pebbles_normalmap.jpg");
        }

        public void ResetAnimation()
        {
            animationService.ResetAnimation();
            ColorBitmap();
        }

        private void LoadTexture(string path)
        {
            Parameters.Texture = new ByteBitmap((Bitmap)Image.FromFile(path));
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            animationService.AnimateFrame();
            ColorBitmap();
        }

        private void Parameters_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) => ColorBitmap();

        private void CalculateTriangulation() =>
            triangulatedSphere = triangulationService.TriangulateSphere(bitmap.Height / 2, bitmap.Width / 2, bitmap.Height / 2, triangulationPrecision);

        private void ColorBitmap()
        {
            view.CanvasImage = new Bitmap(bitmap);
            coloringService.FillTriangles(bitmap, triangulatedSphere, Parameters);
            coloringService.DrawSphereEdges(bitmap, triangulatedSphere);
            view.CanvasImage = bitmap;
            view.Redraw();
        }
    }
}
