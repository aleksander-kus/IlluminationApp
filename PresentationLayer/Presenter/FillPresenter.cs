using DomainLayer;
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
        private int triangulationPrecision = 11;
        public int TriangulationPrecision { 
            set
            {
                triangulationPrecision = value;
                CalculateTriangulation();
                ColorBitmap();
            }
        }
        public IlluminationParameters Parameters = new();
        private readonly ITriangulationService triangulationService;
        private readonly IColoringService coloringService;

        public FillPresenter(IFillView view)
        {
            this.view = view;
            bitmap = new(view.CanvasSizeX, view.CanvasSizeY);
            this.view.CanvasImage = bitmap;
            
            triangulationService = new TriService();
            coloringService = new ColoringService();
            Parameters = new()
            {
                Radius = view.CanvasSizeX / 2,
                SceneColor = Color.Green,
                LightColor = Color.White
            };
            Parameters.Radius = view.CanvasSizeX / 2;
            Parameters.PropertyChanged += Parameters_PropertyChanged;
            CalculateTriangulation();
            ColorBitmap();
        }

        private void Parameters_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ColorBitmap();
        }

        private void CalculateTriangulation() =>
            triangulatedSphere = triangulationService.TriangulateSphere(bitmap.Height / 2, bitmap.Width / 2, bitmap.Height / 2, triangulationPrecision);

        private void ColorBitmap()
        {
            view.CanvasImage = new Bitmap(bitmap);
            coloringService.FillTriangles(bitmap, triangulatedSphere, Color.Green, Parameters);
            //coloringService.DrawSphereEdges(bitmap, triangulatedSphere);
            view.CanvasImage = bitmap;
            view.Redraw();
        }
    }
}
