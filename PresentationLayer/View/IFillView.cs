using System.Drawing;

namespace PresentationLayer
{
    public interface IFillView
    {
        FillPresenter Presenter { set; }
        public int CanvasSizeX { get; }
        public int CanvasSizeY { get; }
        public Bitmap CanvasImage { set; }

        public void Redraw();
    }
}
