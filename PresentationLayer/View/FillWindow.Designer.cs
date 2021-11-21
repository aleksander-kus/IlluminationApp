
namespace PresentationLayer
{
    partial class FillWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangulationBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kdLabel = new System.Windows.Forms.Label();
            this.kdTrackbar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ksLabel = new System.Windows.Forms.Label();
            this.ksTrackbar = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mLabel = new System.Windows.Forms.Label();
            this.mTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.kTrackbar = new System.Windows.Forms.TrackBar();
            this.sceneColorPreview = new System.Windows.Forms.PictureBox();
            this.sceneColorButton = new System.Windows.Forms.Button();
            this.textureRadioButton = new System.Windows.Forms.RadioButton();
            this.solidColorRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightColorPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeLightButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.resetAnimationButton = new System.Windows.Forms.Button();
            this.zLabel = new System.Windows.Forms.Label();
            this.stopAnimationButton = new System.Windows.Forms.Button();
            this.startAnimationButton = new System.Windows.Forms.Button();
            this.zTrackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackbar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackbar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.colorTable.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneColorPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightColorPreview)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 815);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuTable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1174, 821);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuTable
            // 
            this.menuTable.ColumnCount = 1;
            this.menuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTable.Controls.Add(this.groupBox1, 0, 0);
            this.menuTable.Controls.Add(this.groupBox2, 0, 1);
            this.menuTable.Controls.Add(this.groupBox3, 0, 2);
            this.menuTable.Controls.Add(this.groupBox5, 0, 3);
            this.menuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTable.Location = new System.Drawing.Point(824, 3);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowCount = 4;
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuTable.Size = new System.Drawing.Size(347, 815);
            this.menuTable.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangulationBar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulation precision";
            // 
            // triangulationBar
            // 
            this.triangulationBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangulationBar.Location = new System.Drawing.Point(3, 19);
            this.triangulationBar.Maximum = 15;
            this.triangulationBar.Minimum = 4;
            this.triangulationBar.Name = "triangulationBar";
            this.triangulationBar.Size = new System.Drawing.Size(335, 51);
            this.triangulationBar.TabIndex = 0;
            this.triangulationBar.Value = 10;
            this.triangulationBar.ValueChanged += new System.EventHandler(this.triangulationBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ilumination constants";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(335, 167);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kdLabel);
            this.panel2.Controls.Add(this.kdTrackbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 49);
            this.panel2.TabIndex = 3;
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Location = new System.Drawing.Point(145, 30);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(23, 15);
            this.kdLabel.TabIndex = 2;
            this.kdLabel.Text = "kd:";
            // 
            // kdTrackbar
            // 
            this.kdTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackbar.Location = new System.Drawing.Point(0, 0);
            this.kdTrackbar.Maximum = 100;
            this.kdTrackbar.Name = "kdTrackbar";
            this.kdTrackbar.Size = new System.Drawing.Size(329, 49);
            this.kdTrackbar.TabIndex = 1;
            this.kdTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kdTrackbar.Value = 50;
            this.kdTrackbar.ValueChanged += new System.EventHandler(this.kdTrackbar_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ksLabel);
            this.panel3.Controls.Add(this.ksTrackbar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 49);
            this.panel3.TabIndex = 4;
            // 
            // ksLabel
            // 
            this.ksLabel.AutoSize = true;
            this.ksLabel.Location = new System.Drawing.Point(145, 32);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(21, 15);
            this.ksLabel.TabIndex = 3;
            this.ksLabel.Text = "ks:";
            // 
            // ksTrackbar
            // 
            this.ksTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackbar.Location = new System.Drawing.Point(0, 0);
            this.ksTrackbar.Maximum = 100;
            this.ksTrackbar.Name = "ksTrackbar";
            this.ksTrackbar.Size = new System.Drawing.Size(329, 49);
            this.ksTrackbar.TabIndex = 2;
            this.ksTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ksTrackbar.Value = 50;
            this.ksTrackbar.ValueChanged += new System.EventHandler(this.ksTrackbar_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mLabel);
            this.panel4.Controls.Add(this.mTrackbar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 51);
            this.panel4.TabIndex = 5;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(145, 34);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(21, 15);
            this.mLabel.TabIndex = 4;
            this.mLabel.Text = "m:";
            // 
            // mTrackbar
            // 
            this.mTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackbar.Location = new System.Drawing.Point(0, 0);
            this.mTrackbar.Maximum = 100;
            this.mTrackbar.Minimum = 1;
            this.mTrackbar.Name = "mTrackbar";
            this.mTrackbar.Size = new System.Drawing.Size(329, 51);
            this.mTrackbar.TabIndex = 3;
            this.mTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackbar.Value = 50;
            this.mTrackbar.ValueChanged += new System.EventHandler(this.mTrackbar_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorTable);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 190);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // colorTable
            // 
            this.colorTable.ColumnCount = 1;
            this.colorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.colorTable.Controls.Add(this.groupBox4, 0, 1);
            this.colorTable.Controls.Add(this.panel1, 0, 0);
            this.colorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorTable.Location = new System.Drawing.Point(3, 19);
            this.colorTable.Name = "colorTable";
            this.colorTable.RowCount = 2;
            this.colorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.46309F));
            this.colorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.53691F));
            this.colorTable.Size = new System.Drawing.Size(335, 168);
            this.colorTable.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kLabel);
            this.groupBox4.Controls.Add(this.kTrackbar);
            this.groupBox4.Controls.Add(this.sceneColorPreview);
            this.groupBox4.Controls.Add(this.sceneColorButton);
            this.groupBox4.Controls.Add(this.textureRadioButton);
            this.groupBox4.Controls.Add(this.solidColorRadioButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 130);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scene color";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(145, 112);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(16, 15);
            this.kLabel.TabIndex = 5;
            this.kLabel.Text = "k:";
            // 
            // kTrackbar
            // 
            this.kTrackbar.Location = new System.Drawing.Point(0, 85);
            this.kTrackbar.Maximum = 100;
            this.kTrackbar.Name = "kTrackbar";
            this.kTrackbar.Size = new System.Drawing.Size(329, 45);
            this.kTrackbar.TabIndex = 4;
            this.kTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kTrackbar.ValueChanged += new System.EventHandler(this.kTrackBar1_ValueChanged);
            // 
            // sceneColorPreview
            // 
            this.sceneColorPreview.Location = new System.Drawing.Point(93, 20);
            this.sceneColorPreview.Name = "sceneColorPreview";
            this.sceneColorPreview.Size = new System.Drawing.Size(48, 23);
            this.sceneColorPreview.TabIndex = 3;
            this.sceneColorPreview.TabStop = false;
            this.sceneColorPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.sceneColorPreview_Paint);
            // 
            // sceneColorButton
            // 
            this.sceneColorButton.Location = new System.Drawing.Point(148, 20);
            this.sceneColorButton.Name = "sceneColorButton";
            this.sceneColorButton.Size = new System.Drawing.Size(175, 23);
            this.sceneColorButton.TabIndex = 2;
            this.sceneColorButton.Text = "Change scene color";
            this.sceneColorButton.UseVisualStyleBackColor = true;
            this.sceneColorButton.Click += new System.EventHandler(this.sceneColorButton_Click);
            // 
            // textureRadioButton
            // 
            this.textureRadioButton.AutoSize = true;
            this.textureRadioButton.Location = new System.Drawing.Point(6, 64);
            this.textureRadioButton.Name = "textureRadioButton";
            this.textureRadioButton.Size = new System.Drawing.Size(63, 19);
            this.textureRadioButton.TabIndex = 1;
            this.textureRadioButton.Text = "Texture";
            this.textureRadioButton.UseVisualStyleBackColor = true;
            this.textureRadioButton.Click += new System.EventHandler(this.textureRadioButton_Click);
            // 
            // solidColorRadioButton
            // 
            this.solidColorRadioButton.AutoSize = true;
            this.solidColorRadioButton.Checked = true;
            this.solidColorRadioButton.Location = new System.Drawing.Point(6, 22);
            this.solidColorRadioButton.Name = "solidColorRadioButton";
            this.solidColorRadioButton.Size = new System.Drawing.Size(81, 19);
            this.solidColorRadioButton.TabIndex = 0;
            this.solidColorRadioButton.TabStop = true;
            this.solidColorRadioButton.Text = "Solid color";
            this.solidColorRadioButton.UseVisualStyleBackColor = true;
            this.solidColorRadioButton.Click += new System.EventHandler(this.solidColorRadioButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lightColorPreview);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.changeLightButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 26);
            this.panel1.TabIndex = 2;
            // 
            // lightColorPreview
            // 
            this.lightColorPreview.Location = new System.Drawing.Point(119, 0);
            this.lightColorPreview.Name = "lightColorPreview";
            this.lightColorPreview.Size = new System.Drawing.Size(48, 23);
            this.lightColorPreview.TabIndex = 4;
            this.lightColorPreview.TabStop = false;
            this.lightColorPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.lightColorPreview_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current light color:";
            // 
            // changeLightButton
            // 
            this.changeLightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeLightButton.Location = new System.Drawing.Point(178, 0);
            this.changeLightButton.Name = "changeLightButton";
            this.changeLightButton.Size = new System.Drawing.Size(145, 23);
            this.changeLightButton.TabIndex = 0;
            this.changeLightButton.Text = "Change light color";
            this.changeLightButton.UseVisualStyleBackColor = true;
            this.changeLightButton.Click += new System.EventHandler(this.changeLightButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 473);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Light source animation";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.resetAnimationButton);
            this.panel5.Controls.Add(this.zLabel);
            this.panel5.Controls.Add(this.stopAnimationButton);
            this.panel5.Controls.Add(this.startAnimationButton);
            this.panel5.Controls.Add(this.zTrackbar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(335, 78);
            this.panel5.TabIndex = 0;
            // 
            // resetAnimationButton
            // 
            this.resetAnimationButton.Location = new System.Drawing.Point(249, 51);
            this.resetAnimationButton.Name = "resetAnimationButton";
            this.resetAnimationButton.Size = new System.Drawing.Size(77, 23);
            this.resetAnimationButton.TabIndex = 4;
            this.resetAnimationButton.Text = "Reset";
            this.resetAnimationButton.UseVisualStyleBackColor = true;
            this.resetAnimationButton.Click += new System.EventHandler(this.resetAnimationButton_Click);
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(104, 26);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(99, 15);
            this.zLabel.TabIndex = 3;
            this.zLabel.Text = "Source height (z):";
            // 
            // stopAnimationButton
            // 
            this.stopAnimationButton.Location = new System.Drawing.Point(133, 51);
            this.stopAnimationButton.Name = "stopAnimationButton";
            this.stopAnimationButton.Size = new System.Drawing.Size(77, 23);
            this.stopAnimationButton.TabIndex = 2;
            this.stopAnimationButton.Text = "Stop";
            this.stopAnimationButton.UseVisualStyleBackColor = true;
            this.stopAnimationButton.Click += new System.EventHandler(this.stopAnimationButton_Click);
            // 
            // startAnimationButton
            // 
            this.startAnimationButton.Location = new System.Drawing.Point(13, 51);
            this.startAnimationButton.Name = "startAnimationButton";
            this.startAnimationButton.Size = new System.Drawing.Size(77, 23);
            this.startAnimationButton.TabIndex = 1;
            this.startAnimationButton.Text = "Start";
            this.startAnimationButton.UseVisualStyleBackColor = true;
            this.startAnimationButton.Click += new System.EventHandler(this.startAnimationButton_Click);
            // 
            // zTrackbar
            // 
            this.zTrackbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.zTrackbar.Location = new System.Drawing.Point(0, 0);
            this.zTrackbar.Maximum = 800;
            this.zTrackbar.Name = "zTrackbar";
            this.zTrackbar.Size = new System.Drawing.Size(335, 45);
            this.zTrackbar.TabIndex = 0;
            this.zTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zTrackbar.Value = 100;
            this.zTrackbar.ValueChanged += new System.EventHandler(this.zTrackbar_ValueChanged);
            // 
            // FillWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 821);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FillWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillWindow";
            this.Load += new System.EventHandler(this.FillWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackbar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackbar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.colorTable.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneColorPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightColorPreview)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel menuTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar triangulationBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel colorTable;
        private System.Windows.Forms.Button changeLightButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton textureRadioButton;
        private System.Windows.Forms.RadioButton solidColorRadioButton;
        private System.Windows.Forms.Button sceneColorButton;
        private System.Windows.Forms.PictureBox sceneColorPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lightColorPreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar kdTrackbar;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.TrackBar ksTrackbar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TrackBar mTrackbar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar zTrackbar;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Button stopAnimationButton;
        private System.Windows.Forms.Button startAnimationButton;
        private System.Windows.Forms.Button resetAnimationButton;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.TrackBar kTrackbar;
    }
}