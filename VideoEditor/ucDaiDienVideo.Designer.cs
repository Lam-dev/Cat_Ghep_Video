namespace VideoEditor
{
    partial class ucDaiDienVideo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_duongDanVideo = new System.Windows.Forms.TableLayoutPanel();
            this.picbox_anhDaiDienVideo = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lb_dungLuong = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tenVideo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lb_duongDanVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhDaiDienVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_duongDanVideo
            // 
            this.lb_duongDanVideo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_duongDanVideo.ColumnCount = 2;
            this.lb_duongDanVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.05882F));
            this.lb_duongDanVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.94118F));
            this.lb_duongDanVideo.Controls.Add(this.picbox_anhDaiDienVideo, 0, 0);
            this.lb_duongDanVideo.Controls.Add(this.kryptonPanel1, 1, 0);
            this.lb_duongDanVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_duongDanVideo.Location = new System.Drawing.Point(0, 0);
            this.lb_duongDanVideo.Name = "lb_duongDanVideo";
            this.lb_duongDanVideo.RowCount = 1;
            this.lb_duongDanVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lb_duongDanVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.lb_duongDanVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.lb_duongDanVideo.Size = new System.Drawing.Size(170, 57);
            this.lb_duongDanVideo.TabIndex = 0;
            this.lb_duongDanVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // picbox_anhDaiDienVideo
            // 
            this.picbox_anhDaiDienVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picbox_anhDaiDienVideo.Location = new System.Drawing.Point(3, 3);
            this.picbox_anhDaiDienVideo.Name = "picbox_anhDaiDienVideo";
            this.picbox_anhDaiDienVideo.Size = new System.Drawing.Size(56, 50);
            this.picbox_anhDaiDienVideo.TabIndex = 0;
            this.picbox_anhDaiDienVideo.TabStop = false;
            this.picbox_anhDaiDienVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickAnhDaiDien);
            this.picbox_anhDaiDienVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lb_dungLuong);
            this.kryptonPanel1.Controls.Add(this.lb_tenVideo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(65, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(102, 51);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickAnhDaiDien);
            this.kryptonPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // lb_dungLuong
            // 
            this.lb_dungLuong.AccessibleDescription = "";
            this.lb_dungLuong.Location = new System.Drawing.Point(4, 28);
            this.lb_dungLuong.Name = "lb_dungLuong";
            this.lb_dungLuong.Size = new System.Drawing.Size(88, 20);
            this.lb_dungLuong.TabIndex = 1;
            this.lb_dungLuong.Values.Text = "kryptonLabel2";
            this.lb_dungLuong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickAnhDaiDien);
            this.lb_dungLuong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // lb_tenVideo
            // 
            this.lb_tenVideo.Location = new System.Drawing.Point(4, 4);
            this.lb_tenVideo.Name = "lb_tenVideo";
            this.lb_tenVideo.Size = new System.Drawing.Size(88, 20);
            this.lb_tenVideo.TabIndex = 0;
            this.lb_tenVideo.Values.Text = "kryptonLabel1";
            this.lb_tenVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickAnhDaiDien);
            this.lb_tenVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(65, 3);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(8, 20);
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // ucDaiDienVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_duongDanVideo);
            this.Name = "ucDaiDienVideo";
            this.Size = new System.Drawing.Size(170, 57);
            this.lb_duongDanVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhDaiDienVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_anhDaiDienVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_dungLuong;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tenVideo;
        public System.Windows.Forms.TableLayoutPanel lb_duongDanVideo;
    }
}
