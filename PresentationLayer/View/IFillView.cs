using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public interface IFillView
    {
        public Image Texture { get; set; }
        public Image NormalMap { get; set; }
        FillPresenter Presenter { set; }
        public int CanvasSizeX { get; }
        public int CanvasSizeY { get; }
        public Bitmap CanvasImage { set; }
        public Timer Timer { get; set; }
        public void Redraw();
    }
}
