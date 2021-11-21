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
        private List<(int shapeID, int vertexID)> movingVertex = new();

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
                LightSourcePosition = new Point(view.CanvasSizeX / 2, view.CanvasSizeY / 2),
                Texture = new ByteBitmap(new Bitmap(this.view.Texture)),
                NormalMap = new ByteBitmap(new Bitmap(this.view.NormalMap))
            };
            Parameters.Radius = view.CanvasSizeX / 2;
            Parameters.PropertyChanged += Parameters_PropertyChanged;
            triangulationService = new TriService();
            coloringService = new FillingService(new ColorService());
            animationService = new AnimationService(AnimationInterval, AnimationTime, Parameters);
        }

        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);

        private static bool IsPointClicked(Point point, Point mousePosition, int epsilon = 10) => SquaredDistance(point, mousePosition) <= epsilon * epsilon;

        public void RegisterClick(Point point)
        {
            for(int i = 0; i < triangulatedSphere.Count; ++i)
            {
                for(int j = 0; j < triangulatedSphere[i].Count; ++j)
                {
                    if(IsPointClicked(new Point((int)triangulatedSphere[i][j].X, (int)triangulatedSphere[i][j].Y), point))
                    {
                        movingVertex.Add((i, j));
                    }
                }
            }
        }

        public void RegisterMouseMove(Point point)
        {
            if (movingVertex.Count > 0)
            {
                movingVertex.ForEach(vertex => triangulatedSphere[vertex.shapeID][vertex.vertexID] = new Vector3(point.X, point.Y, triangulatedSphere[vertex.shapeID][vertex.vertexID].Z));
                ColorBitmap();
            }
        }

        public void RegisterMouseUp() => movingVertex.Clear();

        public void ResetAnimation()
        {
            animationService.ResetAnimation();
            ColorBitmap();
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
