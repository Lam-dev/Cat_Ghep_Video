namespace VideoEditor
{
    partial class frmPhatVideo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhatVideo));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayOut_chuaCacVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_xoaDaiDien = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_themVideo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGallery1 = new ComponentFactory.Krypton.Ribbon.KryptonGallery();
            this.bgw_choLayAnhDaiDien = new System.ComponentModel.BackgroundWorker();
            this.vlc_phatVideo = new Vlc.DotNet.Forms.VlcControl();
            this.lb_DangPhat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tongThoiGian = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timer_layThoiGianVideo = new System.Windows.Forms.Timer(this.components);
            this.lb_playPause = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timer_choVLCphanHoi = new System.Windows.Forms.Timer(this.components);
            this.lb_gopVideo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel_chuaThanhCuonVaNutNhan = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ucCuonVideo1 = new VideoEditor.ucCuonVideo();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlc_phatVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_chuaThanhCuonVaNutNhan)).BeginInit();
            this.panel_chuaThanhCuonVaNutNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.flowLayOut_chuaCacVideo);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(178, 651);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayOut_chuaCacVideo
            // 
            this.flowLayOut_chuaCacVideo.AutoScroll = true;
            this.flowLayOut_chuaCacVideo.BackColor = System.Drawing.Color.Transparent;
            this.flowLayOut_chuaCacVideo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayOut_chuaCacVideo.Location = new System.Drawing.Point(0, 41);
            this.flowLayOut_chuaCacVideo.Name = "flowLayOut_chuaCacVideo";
            this.flowLayOut_chuaCacVideo.Size = new System.Drawing.Size(178, 610);
            this.flowLayOut_chuaCacVideo.TabIndex = 1;
            this.flowLayOut_chuaCacVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayOut_chuaCacVideo_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 44);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.3211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.6789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.lb_xoaDaiDien, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_themVideo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lb_xoaDaiDien
            // 
            this.lb_xoaDaiDien.AutoSize = false;
            this.lb_xoaDaiDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_xoaDaiDien.Location = new System.Drawing.Point(131, 3);
            this.lb_xoaDaiDien.Name = "lb_xoaDaiDien";
            this.lb_xoaDaiDien.Size = new System.Drawing.Size(44, 38);
            this.lb_xoaDaiDien.TabIndex = 4;
            this.lb_xoaDaiDien.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__3_;
            this.lb_xoaDaiDien.Values.Text = "";
            // 
            // lb_themVideo
            // 
            this.lb_themVideo.AutoSize = false;
            this.lb_themVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_themVideo.Location = new System.Drawing.Point(94, 3);
            this.lb_themVideo.Name = "lb_themVideo";
            this.lb_themVideo.Size = new System.Drawing.Size(31, 38);
            this.lb_themVideo.TabIndex = 3;
            this.lb_themVideo.Values.Image = global::VideoEditor.Properties.Resources.addImage;
            this.lb_themVideo.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.lb_themVideo.Values.Text = "";
            this.lb_themVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_themVideoClick);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 38);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Danh sách";
            // 
            // kryptonGallery1
            // 
            this.kryptonGallery1.ImageList = null;
            this.kryptonGallery1.Location = new System.Drawing.Point(709, 145);
            this.kryptonGallery1.Name = "kryptonGallery1";
            this.kryptonGallery1.Size = new System.Drawing.Size(8, 8);
            this.kryptonGallery1.TabIndex = 1;
            // 
            // bgw_choLayAnhDaiDien
            // 
            this.bgw_choLayAnhDaiDien.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_choLayAnhDaiDien_DoWork);
            // 
            // vlc_phatVideo
            // 
            this.vlc_phatVideo.BackColor = System.Drawing.Color.White;
            this.vlc_phatVideo.ForeColor = System.Drawing.Color.Transparent;
            this.vlc_phatVideo.Location = new System.Drawing.Point(184, 3);
            this.vlc_phatVideo.Name = "vlc_phatVideo";
            this.vlc_phatVideo.Size = new System.Drawing.Size(939, 587);
            this.vlc_phatVideo.Spu = -1;
            this.vlc_phatVideo.TabIndex = 2;
            this.vlc_phatVideo.Text = "vlcControl1";
            this.vlc_phatVideo.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlc_phatVideo.VlcLibDirectory")));
            this.vlc_phatVideo.VlcMediaplayerOptions = null;
            this.vlc_phatVideo.Click += new System.EventHandler(this.vlc_phatVideo_Click);
            // 
            // lb_DangPhat
            // 
            this.lb_DangPhat.AutoSize = false;
            this.lb_DangPhat.Location = new System.Drawing.Point(54, 20);
            this.lb_DangPhat.Name = "lb_DangPhat";
            this.lb_DangPhat.Size = new System.Drawing.Size(58, 25);
            this.lb_DangPhat.TabIndex = 4;
            this.lb_DangPhat.Values.Text = "0:0:0";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(92, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(21, 25);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "/";
            // 
            // lb_tongThoiGian
            // 
            this.lb_tongThoiGian.AutoSize = false;
            this.lb_tongThoiGian.Location = new System.Drawing.Point(108, 20);
            this.lb_tongThoiGian.Name = "lb_tongThoiGian";
            this.lb_tongThoiGian.Size = new System.Drawing.Size(76, 25);
            this.lb_tongThoiGian.TabIndex = 6;
            this.lb_tongThoiGian.Values.Text = "0:0:0";
            // 
            // timer_layThoiGianVideo
            // 
            this.timer_layThoiGianVideo.Interval = 1000;
            this.timer_layThoiGianVideo.Tick += new System.EventHandler(this.timer_layThoiGianVideo_Tick);
            // 
            // lb_playPause
            // 
            this.lb_playPause.AutoSize = false;
            this.lb_playPause.Location = new System.Drawing.Point(3, 16);
            this.lb_playPause.Name = "lb_playPause";
            this.lb_playPause.Size = new System.Drawing.Size(36, 32);
            this.lb_playPause.TabIndex = 7;
            this.lb_playPause.Values.Image = global::VideoEditor.Properties.Resources.pause;
            this.lb_playPause.Values.Text = "";
            this.lb_playPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playPauseMouseClick);
            // 
            // timer_choVLCphanHoi
            // 
            this.timer_choVLCphanHoi.Tick += new System.EventHandler(this.timer_choVLCphanHoi_Tick);
            // 
            // lb_gopVideo
            // 
            this.lb_gopVideo.Location = new System.Drawing.Point(870, 16);
            this.lb_gopVideo.Name = "lb_gopVideo";
            this.lb_gopVideo.Size = new System.Drawing.Size(31, 26);
            this.lb_gopVideo.TabIndex = 8;
            this.lb_gopVideo.Values.Image = global::VideoEditor.Properties.Resources.merge;
            this.lb_gopVideo.Values.Text = "";
            this.lb_gopVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.lb_gopVideo_Paint);
            this.lb_gopVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gopVideoClick);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(826, 16);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(31, 27);
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Image = global::VideoEditor.Properties.Resources.camera;
            this.kryptonLabel3.Values.Text = "";
            this.kryptonLabel3.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel3_Paint);
            // 
            // panel_chuaThanhCuonVaNutNhan
            // 
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.lb_tongThoiGian);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.kryptonLabel1);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.kryptonLabel3);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.lb_DangPhat);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.ucCuonVideo1);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.lb_gopVideo);
            this.panel_chuaThanhCuonVaNutNhan.Controls.Add(this.lb_playPause);
            this.panel_chuaThanhCuonVaNutNhan.Location = new System.Drawing.Point(199, 596);
            this.panel_chuaThanhCuonVaNutNhan.Name = "panel_chuaThanhCuonVaNutNhan";
            this.panel_chuaThanhCuonVaNutNhan.Size = new System.Drawing.Size(915, 55);
            this.panel_chuaThanhCuonVaNutNhan.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.panel_chuaThanhCuonVaNutNhan.TabIndex = 10;
            // 
            // ucCuonVideo1
            // 
            this.ucCuonVideo1.Location = new System.Drawing.Point(0, 1);
            this.ucCuonVideo1.Name = "ucCuonVideo1";
            this.ucCuonVideo1.phanTramHienTai = 0D;
            this.ucCuonVideo1.Size = new System.Drawing.Size(914, 10);
            this.ucCuonVideo1.TabIndex = 3;
            this.ucCuonVideo1.thanhCuonDangTruot += new VideoEditor.cuonVideoHandle(this.thanhTruotDangCuon);
            this.ucCuonVideo1.Load += new System.EventHandler(this.ucCuonVideo1_Load);
            // 
            // frmPhatVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 651);
            this.Controls.Add(this.vlc_phatVideo);
            this.Controls.Add(this.kryptonGallery1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel_chuaThanhCuonVaNutNhan);
            this.MinimumSize = new System.Drawing.Size(1136, 400);
            this.Name = "frmPhatVideo";
            this.Text = "Phát video";
            this.MaximizedBoundsChanged += new System.EventHandler(this.formResizeEnd);
            this.MaximumSizeChanged += new System.EventHandler(this.formResizeEnd);
            this.MinimumSizeChanged += new System.EventHandler(this.formResizeEnd);
            this.Load += new System.EventHandler(this.frmPhatVideo_Load_1);
            this.ResizeEnd += new System.EventHandler(this.formResizeEnd);
            this.Resize += new System.EventHandler(this.formResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.vlc_phatVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_chuaThanhCuonVaNutNhan)).EndInit();
            this.panel_chuaThanhCuonVaNutNhan.ResumeLayout(false);
            this.panel_chuaThanhCuonVaNutNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_xoaDaiDien;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_themVideo;
        private System.Windows.Forms.FlowLayoutPanel flowLayOut_chuaCacVideo;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Ribbon.KryptonGallery kryptonGallery1;
        private System.ComponentModel.BackgroundWorker bgw_choLayAnhDaiDien;
        private Vlc.DotNet.Forms.VlcControl vlc_phatVideo;
        private ucCuonVideo ucCuonVideo1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_DangPhat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tongThoiGian;
        private System.Windows.Forms.Timer timer_layThoiGianVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_playPause;
        private System.Windows.Forms.Timer timer_choVLCphanHoi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_gopVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_chuaThanhCuonVaNutNhan;
    }
}