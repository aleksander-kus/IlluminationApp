using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FillWindow : Form, IFillView
    {
        public Timer Timer { get; set; } = new();
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
            kdLabel.Text = $"kd: {kdTrackbar.Value / 100.0f:0.00}";
            ksLabel.Text = $"ks: {ksTrackbar.Value / 100.0f:0.00}";
            mLabel.Text = $"m: {mTrackbar.Value}";
            zLabel.Text = $"Source height (z): {zTrackbar.Value}";
        }

        private void kdTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.Kd = kdTrackbar.Value / 100.0f;
            kdLabel.Text = $"kd: {kdTrackbar.Value / 100.0f:0.00}";
        }

        private void ksTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.Ks = ksTrackbar.Value / 100.0f;
            ksLabel.Text = $"ks: {ksTrackbar.Value / 100.0f:0.00}";
        }

        private void mTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.M = mTrackbar.Value;
            mLabel.Text = $"m: {mTrackbar.Value}";
        }
        private void zTrackbar_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.Z = zTrackbar.Value;
            zLabel.Text = $"Source height (z): {zTrackbar.Value}";
        }

        private void triangulationBar_ValueChanged(object sender, EventArgs e)
        {
            presenter.TriangulationPrecision = triangulationBar.Value;
        }

        private Color? pickColor()
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
                return cd.Color;
            return null;
        }

        private void changeLightButton_Click(object sender, EventArgs e)
        {
            var color = pickColor();
            if (color.HasValue)
                presenter.Parameters.LightColor = color.Value;
            lightColorPreview.Invalidate();
        }

        private void sceneColorButton_Click(object sender, EventArgs e)
        {
            var color = pickColor();
            if (color.HasValue)
                presenter.Parameters.SceneColor = color.Value;
            sceneColorPreview.Invalidate();
        }

        private void sceneColorPreview_Paint(object sender, PaintEventArgs e)
        {
            using Brush brush = new SolidBrush(presenter.Parameters.SceneColor);
            e.Graphics.FillRectangle(brush, 0, 0, sceneColorPreview.Width, sceneColorPreview.Height);
        }

        private void lightColorPreview_Paint(object sender, PaintEventArgs e)
        {
            using Brush brush = new SolidBrush(presenter.Parameters.LightColor);
            e.Graphics.FillRectangle(brush, 0, 0, lightColorPreview.Width, lightColorPreview.Height);
        }

        private void solidColorRadioButton_Click(object sender, EventArgs e)
        {
            textureRadioButton.Checked = false;
            presenter.Parameters.ColoringMode = DomainLayer.ColoringMode.SolidColor;
        }

        private void textureRadioButton_Click(object sender, EventArgs e)
        {
            solidColorRadioButton.Checked = false;
            presenter.Parameters.ColoringMode = DomainLayer.ColoringMode.Texture;
        }

        private void startAnimationButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void stopAnimationButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void resetAnimationButton_Click(object sender, EventArgs e)
        {
            presenter.ResetAnimation();
            Timer.Stop();
        }
    }
}
