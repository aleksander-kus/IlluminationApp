using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FillWindow : Form, IFillView
    {
        public Timer Timer { get; set; } = new();
        private FillPresenter presenter;
        private bool isMouseDown = false;
        public FillWindow()
        {
            InitializeComponent();
            // Texture source https://spojniastargard.com/wp-content/uploads/2015/08/Basketball.png
            Texture = Properties.Resources.Basketball;
            // NormalMap source https://nomeradona.files.wordpress.com/2009/05/pebbles_normalmap.jpg
            NormalMap = Properties.Resources.pebbles_normalmap;
        }

        public FillPresenter Presenter { set => presenter = value; }

        public int CanvasSizeX => pictureBox1.Width;

        public int CanvasSizeY => pictureBox1.Height;

        public Bitmap CanvasImage { set => pictureBox1.Image = value; }
        public Image Texture { get; set; }
        public Image NormalMap { get; set; }

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
            kLabel.Text = $"k: {kTrackbar.Value / 100.0f:0.00}";

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
        private void kTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            presenter.Parameters.K = kTrackbar.Value / 100.0f;
            kLabel.Text = $"k: {kTrackbar.Value / 100.0f:0.00}";
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            presenter.RegisterClick(e.Location);
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
                presenter.RegisterMouseMove(e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            presenter.RegisterMouseUp();
            isMouseDown = false;
        }

        private void accurateButton_Click(object sender, EventArgs e)
        {
            presenter.Parameters.FillMode = DomainLayer.FillMode.Accurate;
            interpolationButton.Checked = false;
        }

        private void interpolationButton_Click(object sender, EventArgs e)
        {
            presenter.Parameters.FillMode = DomainLayer.FillMode.Interpolation;
            accurateButton.Checked = false;
        }
    }
}
