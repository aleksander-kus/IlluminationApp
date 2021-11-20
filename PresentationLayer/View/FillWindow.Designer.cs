
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
            this.kdTrackbar = new System.Windows.Forms.TrackBar();
            this.ksTrackbar = new System.Windows.Forms.TrackBar();
            this.mTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorTable = new System.Windows.Forms.TableLayoutPanel();
            this.changeLightButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sceneColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.colorTable.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.menuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTable.Location = new System.Drawing.Point(824, 3);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowCount = 3;
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
            this.tableLayoutPanel3.Controls.Add(this.kdTrackbar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ksTrackbar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.mTrackbar, 0, 2);
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
            // kdTrackbar
            // 
            this.kdTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackbar.Location = new System.Drawing.Point(3, 3);
            this.kdTrackbar.Maximum = 100;
            this.kdTrackbar.Name = "kdTrackbar";
            this.kdTrackbar.Size = new System.Drawing.Size(329, 49);
            this.kdTrackbar.TabIndex = 0;
            this.kdTrackbar.Value = 50;
            this.kdTrackbar.ValueChanged += new System.EventHandler(this.kdTrackbar_ValueChanged);
            // 
            // ksTrackbar
            // 
            this.ksTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackbar.Location = new System.Drawing.Point(3, 58);
            this.ksTrackbar.Maximum = 100;
            this.ksTrackbar.Name = "ksTrackbar";
            this.ksTrackbar.Size = new System.Drawing.Size(329, 49);
            this.ksTrackbar.TabIndex = 1;
            this.ksTrackbar.Value = 50;
            this.ksTrackbar.ValueChanged += new System.EventHandler(this.ksTrackbar_ValueChanged);
            // 
            // mTrackbar
            // 
            this.mTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackbar.Location = new System.Drawing.Point(3, 113);
            this.mTrackbar.Maximum = 100;
            this.mTrackbar.Minimum = 1;
            this.mTrackbar.Name = "mTrackbar";
            this.mTrackbar.Size = new System.Drawing.Size(329, 51);
            this.mTrackbar.TabIndex = 2;
            this.mTrackbar.Value = 50;
            this.mTrackbar.ValueChanged += new System.EventHandler(this.mTrackbar_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorTable);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // colorTable
            // 
            this.colorTable.ColumnCount = 1;
            this.colorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.colorTable.Controls.Add(this.changeLightButton, 0, 0);
            this.colorTable.Controls.Add(this.groupBox4, 0, 1);
            this.colorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorTable.Location = new System.Drawing.Point(3, 19);
            this.colorTable.Name = "colorTable";
            this.colorTable.RowCount = 2;
            this.colorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.46309F));
            this.colorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.53691F));
            this.colorTable.Size = new System.Drawing.Size(335, 149);
            this.colorTable.TabIndex = 0;
            // 
            // changeLightButton
            // 
            this.changeLightButton.Location = new System.Drawing.Point(3, 3);
            this.changeLightButton.Name = "changeLightButton";
            this.changeLightButton.Size = new System.Drawing.Size(329, 23);
            this.changeLightButton.TabIndex = 0;
            this.changeLightButton.Text = "Change light color";
            this.changeLightButton.UseVisualStyleBackColor = true;
            this.changeLightButton.Click += new System.EventHandler(this.changeLightButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sceneColorButton);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 114);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scene color";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Texture";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Solid color";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // sceneColorButton
            // 
            this.sceneColorButton.Location = new System.Drawing.Point(93, 20);
            this.sceneColorButton.Name = "sceneColorButton";
            this.sceneColorButton.Size = new System.Drawing.Size(230, 23);
            this.sceneColorButton.TabIndex = 2;
            this.sceneColorButton.Text = "Change scene color";
            this.sceneColorButton.UseVisualStyleBackColor = true;
            this.sceneColorButton.Click += new System.EventHandler(this.sceneColorButton_Click);
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
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.colorTable.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TrackBar kdTrackbar;
        private System.Windows.Forms.TrackBar ksTrackbar;
        private System.Windows.Forms.TrackBar mTrackbar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel colorTable;
        private System.Windows.Forms.Button changeLightButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button sceneColorButton;
    }
}