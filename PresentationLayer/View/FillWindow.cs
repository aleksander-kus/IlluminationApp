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

        private void triangulationBar_ValueChanged(object sender, EventArgs e)
        {
            presenter.TriangulationPrecision = triangulationBar.Value;
        }
    }
}
