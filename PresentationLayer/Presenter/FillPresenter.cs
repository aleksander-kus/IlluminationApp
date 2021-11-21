using DomainLayer;
using InfrastructureLayer;
using InfrastructureLayer.Services;
using System.Collections.Generic;
using System.Drawing;
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
        public int AnimationTime { get; set; } = 5000;
        private readonly IAnimationService animationService;
        private readonly ITriangulationService triangulationService;
        private readonly IFillingService coloringService;

        public FillPresenter(IFillView view)
        {
            this.view = view;
            bitmap = new(view.CanvasSizeX, view.CanvasSizeY);
            this.view.CanvasImage = bitmap;
            this.view.Timer.Interval = AnimationTime;
            this.view.Timer.Tick += Timer_Tick;
            
            triangulationService = new TriService();
            coloringService = new FillingService(new ColorService());
            animationService = new AnimationService(AnimationTime, Parameters);
            Parameters = new()
            {
                Radius = view.CanvasSizeX / 2,
                SceneColor = Color.Green,
                LightColor = Color.White,
                LightSourcePosition = new Point(view.CanvasSizeX / 2, view.CanvasSizeY / 2)
            };
            Parameters.Radius = view.CanvasSizeX / 2;
            Parameters.PropertyChanged += Parameters_PropertyChanged;
        }

        private void Timer_Tick(object sender, System.EventArgs e) => animationService.AnimateFrame();

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
