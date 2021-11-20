using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FillWindow : Form, IFillView
    {
        private FillPresenter presenter;
        public FillWindow()
        {
            InitializeComponent();
        }

        public FillPresenter Presenter { set => presenter = value; }

        public int CanvasSizeX => pictureBox1.Width;

        public int CanvasSizeY => pictureBox1.Height;

        public Bitmap CanvasImage { set => pictureBox1.Image = value; }

        public void Redraw()
        {
            pictureBox1.Invalidate();
        }

        private void FillWindow_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            presenter.TriangulationPrecision = triangulationBar.Value;
        }

        private void kdTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.Kd = kdTrackbar.Value / 100.0f;
            presenter.ColorBitmap();
        }

        private void ksTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.Ks = ksTrackbar.Value / 100.0f;
            presenter.ColorBitmap();
        }

        private void mTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.m = mTrackbar.Value;
            presenter.ColorBitmap();
        }

        private void triangulationBar_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void triangulationBar_Scroll(object sender, EventArgs e)
        {
            presenter.TriangulationPrecision = triangulationBar.Value;

        }
    }
}
