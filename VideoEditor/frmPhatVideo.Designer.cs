

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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayOut_chuaCacVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_themVideo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_xoaDaiDien = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bgw_choLayAnhDaiDien = new System.ComponentModel.BackgroundWorker();
            this.lb_DangPhat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tongThoiGian = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timer_layThoiGianVideo = new System.Windows.Forms.Timer(this.components);
            this.lb_playPause = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel_dieuKhien = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ucThanhTruot_tuaVideo = new VideoEditor.ucThanhTruot();
            this.panel_chuaCacNutDieuKhien = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.nextSpeed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.prevSpeed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tien10s = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tuaNhanh = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_quayLai10s = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_tuaCham = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_stop = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_loa = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_phongTo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ucThanhTruot_amThanh = new VideoEditor.ucThanhTruot();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_congCu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.zoomControl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnZoomLen = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnChupManHinh = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_gopVideo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel_chonVideoBanDau = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_chonVideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ucChoiVideo = new VideoEditor.ucChoiVideo();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dieuKhien)).BeginInit();
            this.panel_dieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_chuaCacNutDieuKhien)).BeginInit();
            this.panel_chuaCacNutDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_congCu)).BeginInit();
            this.panel_congCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_chonVideoBanDau)).BeginInit();
            this.panel_chonVideoBanDau.SuspendLayout();
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
            this.flowLayOut_chuaCacVideo.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayOut_chuaCacVideo.Name = "flowLayOut_chuaCacVideo";
            this.flowLayOut_chuaCacVideo.Size = new System.Drawing.Size(178, 610);
            this.flowLayOut_chuaCacVideo.TabIndex = 1;
            this.flowLayOut_chuaCacVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.danhSachVideo_MC);
            this.flowLayOut_chuaCacVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.danhSachVideo_MM);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.lb_themVideo);
            this.panel1.Controls.Add(this.lb_xoaDaiDien);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 44);
            this.panel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 11);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Danh sách";
            // 
            // lb_themVideo
            // 
            this.lb_themVideo.AutoSize = false;
            this.lb_themVideo.Location = new System.Drawing.Point(116, 2);
            this.lb_themVideo.Name = "lb_themVideo";
            this.lb_themVideo.Size = new System.Drawing.Size(26, 38);
            this.lb_themVideo.TabIndex = 3;
            this.lb_themVideo.Values.Image = global::VideoEditor.Properties.Resources.addImage;
            this.lb_themVideo.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.lb_themVideo.Values.Text = "";
            this.lb_themVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_themVideoClick);
            this.lb_themVideo.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_themVideo.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // lb_xoaDaiDien
            // 
            this.lb_xoaDaiDien.AutoSize = false;
            this.lb_xoaDaiDien.Location = new System.Drawing.Point(147, 1);
            this.lb_xoaDaiDien.Name = "lb_xoaDaiDien";
            this.lb_xoaDaiDien.Size = new System.Drawing.Size(29, 38);
            this.lb_xoaDaiDien.TabIndex = 4;
            this.lb_xoaDaiDien.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__3_;
            this.lb_xoaDaiDien.Values.Text = "";
            this.lb_xoaDaiDien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xoaVideoTrongDanhSachClick);
            this.lb_xoaDaiDien.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_xoaDaiDien.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // bgw_choLayAnhDaiDien
            // 
            this.bgw_choLayAnhDaiDien.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_choLayAnhDaiDien_DoWork);
            // 
            // lb_DangPhat
            // 
            this.lb_DangPhat.AutoSize = false;
            this.lb_DangPhat.Location = new System.Drawing.Point(21, 4);
            this.lb_DangPhat.Name = "lb_DangPhat";
            this.lb_DangPhat.Size = new System.Drawing.Size(58, 25);
            this.lb_DangPhat.TabIndex = 4;
            this.lb_DangPhat.Values.Text = "0:0:0";
            // 
            // lb_tongThoiGian
            // 
            this.lb_tongThoiGian.AutoSize = false;
            this.lb_tongThoiGian.Location = new System.Drawing.Point(865, 5);
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
            this.lb_playPause.Location = new System.Drawing.Point(151, 4);
            this.lb_playPause.Name = "lb_playPause";
            this.lb_playPause.Size = new System.Drawing.Size(51, 47);
            this.lb_playPause.TabIndex = 7;
            this.lb_playPause.Values.Image = global::VideoEditor.Properties.Resources.Webp3;
            this.lb_playPause.Values.Text = "";
            this.lb_playPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playPauseMouseClick);
            this.lb_playPause.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_playPause.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // panel_dieuKhien
            // 
            this.panel_dieuKhien.Controls.Add(this.lb_tongThoiGian);
            this.panel_dieuKhien.Controls.Add(this.ucThanhTruot_tuaVideo);
            this.panel_dieuKhien.Controls.Add(this.lb_DangPhat);
            this.panel_dieuKhien.Controls.Add(this.panel_chuaCacNutDieuKhien);
            this.panel_dieuKhien.Controls.Add(this.kryptonPanel3);
            this.panel_dieuKhien.Location = new System.Drawing.Point(181, 576);
            this.panel_dieuKhien.Name = "panel_dieuKhien";
            this.panel_dieuKhien.Size = new System.Drawing.Size(947, 75);
            this.panel_dieuKhien.StateCommon.Color1 = System.Drawing.Color.White;
            this.panel_dieuKhien.StateCommon.Color2 = System.Drawing.Color.White;
            this.panel_dieuKhien.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel_dieuKhien.StateDisabled.Color1 = System.Drawing.Color.White;
            this.panel_dieuKhien.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel_dieuKhien.StateNormal.Color1 = System.Drawing.Color.DarkGray;
            this.panel_dieuKhien.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel_dieuKhien.TabIndex = 10;
            // 
            // ucThanhTruot_tuaVideo
            // 
            this.ucThanhTruot_tuaVideo.BackColor = System.Drawing.Color.Transparent;
            this.ucThanhTruot_tuaVideo.Location = new System.Drawing.Point(87, 9);
            this.ucThanhTruot_tuaVideo.mauCuaDiem = System.Drawing.Color.Red;
            this.ucThanhTruot_tuaVideo.mauDuongRay = System.Drawing.Color.White;
            this.ucThanhTruot_tuaVideo.Name = "ucThanhTruot_tuaVideo";
            this.ucThanhTruot_tuaVideo.phanTramHienTai = 0D;
            this.ucThanhTruot_tuaVideo.Size = new System.Drawing.Size(768, 13);
            this.ucThanhTruot_tuaVideo.TabIndex = 10;
            this.ucThanhTruot_tuaVideo.thanhCuonDangTruot += new VideoEditor.cuonVideoHandle(this.thanhTruotDangCuon);
            this.ucThanhTruot_tuaVideo.Load += new System.EventHandler(this.ucThanhTruot_tuaVideo_Load);
            // 
            // panel_chuaCacNutDieuKhien
            // 
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.nextSpeed);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.prevSpeed);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_tien10s);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_playPause);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_tuaNhanh);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_quayLai10s);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_tuaCham);
            this.panel_chuaCacNutDieuKhien.Controls.Add(this.lb_stop);
            this.panel_chuaCacNutDieuKhien.Location = new System.Drawing.Point(278, 20);
            this.panel_chuaCacNutDieuKhien.Name = "panel_chuaCacNutDieuKhien";
            this.panel_chuaCacNutDieuKhien.Size = new System.Drawing.Size(393, 55);
            this.panel_chuaCacNutDieuKhien.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.panel_chuaCacNutDieuKhien.StateNormal.Color2 = System.Drawing.Color.Transparent;
            this.panel_chuaCacNutDieuKhien.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel_chuaCacNutDieuKhien.TabIndex = 22;
            // 
            // nextSpeed
            // 
            this.nextSpeed.Location = new System.Drawing.Point(346, 18);
            this.nextSpeed.Name = "nextSpeed";
            this.nextSpeed.Size = new System.Drawing.Size(6, 2);
            this.nextSpeed.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.nextSpeed.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSpeed.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.nextSpeed.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.nextSpeed.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.nextSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSpeed.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.nextSpeed.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.nextSpeed.TabIndex = 23;
            this.nextSpeed.Values.Text = "";
            // 
            // prevSpeed
            // 
            this.prevSpeed.Location = new System.Drawing.Point(4, 19);
            this.prevSpeed.Name = "prevSpeed";
            this.prevSpeed.Size = new System.Drawing.Size(6, 2);
            this.prevSpeed.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.prevSpeed.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevSpeed.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.prevSpeed.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.prevSpeed.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.prevSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevSpeed.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.prevSpeed.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.prevSpeed.TabIndex = 22;
            this.prevSpeed.Values.Text = "";
            // 
            // lb_tien10s
            // 
            this.lb_tien10s.AutoSize = false;
            this.lb_tien10s.Location = new System.Drawing.Point(253, 14);
            this.lb_tien10s.Name = "lb_tien10s";
            this.lb_tien10s.Size = new System.Drawing.Size(36, 32);
            this.lb_tien10s.TabIndex = 21;
            this.lb_tien10s.Values.Image = global::VideoEditor.Properties.Resources.next10sMouseLeave;
            this.lb_tien10s.Values.Text = "";
            this.lb_tien10s.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_tien10sMC);
            this.lb_tien10s.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_tien10s.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // lb_tuaNhanh
            // 
            this.lb_tuaNhanh.Location = new System.Drawing.Point(296, 16);
            this.lb_tuaNhanh.Name = "lb_tuaNhanh";
            this.lb_tuaNhanh.Size = new System.Drawing.Size(51, 27);
            this.lb_tuaNhanh.TabIndex = 19;
            this.lb_tuaNhanh.Values.Image = global::VideoEditor.Properties.Resources.speedUpMouseLeave;
            this.lb_tuaNhanh.Values.Text = "";
            this.lb_tuaNhanh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nutDieuKhien_MC);
            this.lb_tuaNhanh.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_tuaNhanh.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // lb_quayLai10s
            // 
            this.lb_quayLai10s.AutoSize = false;
            this.lb_quayLai10s.Location = new System.Drawing.Point(110, 14);
            this.lb_quayLai10s.Name = "lb_quayLai10s";
            this.lb_quayLai10s.Size = new System.Drawing.Size(36, 32);
            this.lb_quayLai10s.TabIndex = 15;
            this.lb_quayLai10s.Values.Image = global::VideoEditor.Properties.Resources.pre10sMouseLeave;
            this.lb_quayLai10s.Values.Text = "";
            this.lb_quayLai10s.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_quayLai10s_MC);
            this.lb_quayLai10s.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_quayLai10s.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // lb_tuaCham
            // 
            this.lb_tuaCham.Location = new System.Drawing.Point(49, 16);
            this.lb_tuaCham.Name = "lb_tuaCham";
            this.lb_tuaCham.Size = new System.Drawing.Size(51, 27);
            this.lb_tuaCham.TabIndex = 17;
            this.lb_tuaCham.Values.Image = global::VideoEditor.Properties.Resources.speedDownMouseLeave;
            this.lb_tuaCham.Values.Text = "";
            this.lb_tuaCham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_tuaCham_MC);
            this.lb_tuaCham.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_tuaCham.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // lb_stop
            // 
            this.lb_stop.AutoSize = false;
            this.lb_stop.Location = new System.Drawing.Point(211, 14);
            this.lb_stop.Name = "lb_stop";
            this.lb_stop.Size = new System.Drawing.Size(36, 32);
            this.lb_stop.TabIndex = 18;
            this.lb_stop.Values.Image = global::VideoEditor.Properties.Resources.stopLeave;
            this.lb_stop.Values.Text = "";
            this.lb_stop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dungPhatVideoClick);
            this.lb_stop.MouseEnter += new System.EventHandler(this.nutDieuKhien_ME);
            this.lb_stop.MouseLeave += new System.EventHandler(this.nutDieuKhien_ML);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_loa);
            this.kryptonPanel3.Controls.Add(this.lb_phongTo);
            this.kryptonPanel3.Controls.Add(this.ucThanhTruot_amThanh);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(744, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(203, 75);
            this.kryptonPanel3.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel3.TabIndex = 23;
            // 
            // btn_loa
            // 
            this.btn_loa.Location = new System.Drawing.Point(25, 38);
            this.btn_loa.Name = "btn_loa";
            this.btn_loa.Size = new System.Drawing.Size(31, 27);
            this.btn_loa.TabIndex = 14;
            this.btn_loa.Values.Image = global::VideoEditor.Properties.Resources.speaker;
            this.btn_loa.Values.Text = "";
            // 
            // lb_phongTo
            // 
            this.lb_phongTo.Location = new System.Drawing.Point(161, 38);
            this.lb_phongTo.Name = "lb_phongTo";
            this.lb_phongTo.Size = new System.Drawing.Size(31, 27);
            this.lb_phongTo.TabIndex = 20;
            this.lb_phongTo.Values.Image = global::VideoEditor.Properties.Resources.Webp2;
            this.lb_phongTo.Values.Text = "";
            // 
            // ucThanhTruot_amThanh
            // 
            this.ucThanhTruot_amThanh.BackColor = System.Drawing.Color.Transparent;
            this.ucThanhTruot_amThanh.Location = new System.Drawing.Point(62, 46);
            this.ucThanhTruot_amThanh.mauCuaDiem = System.Drawing.Color.Red;
            this.ucThanhTruot_amThanh.mauDuongRay = System.Drawing.Color.White;
            this.ucThanhTruot_amThanh.Name = "ucThanhTruot_amThanh";
            this.ucThanhTruot_amThanh.phanTramHienTai = 0D;
            this.ucThanhTruot_amThanh.Size = new System.Drawing.Size(74, 10);
            this.ucThanhTruot_amThanh.TabIndex = 13;
            this.ucThanhTruot_amThanh.thanhCuonDangTruot += new VideoEditor.cuonVideoHandle(this.thayDoiGiaTriAmThanh);
            this.ucThanhTruot_amThanh.Load += new System.EventHandler(this.ucThanhTruot_amThanh_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel_congCu
            // 
            this.panel_congCu.Controls.Add(this.kryptonPanel2);
            this.panel_congCu.Location = new System.Drawing.Point(181, 0);
            this.panel_congCu.Name = "panel_congCu";
            this.panel_congCu.Size = new System.Drawing.Size(947, 44);
            this.panel_congCu.StateNormal.Color1 = System.Drawing.Color.DimGray;
            this.panel_congCu.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel_congCu.TabIndex = 11;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.zoomControl);
            this.kryptonPanel2.Controls.Add(this.btnZoomLen);
            this.kryptonPanel2.Controls.Add(this.btnChupManHinh);
            this.kryptonPanel2.Controls.Add(this.lb_gopVideo);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(724, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(223, 44);
            this.kryptonPanel2.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel2.TabIndex = 15;
            // 
            // zoomControl
            // 
            this.zoomControl.Location = new System.Drawing.Point(92, 8);
            this.zoomControl.Name = "zoomControl";
            this.zoomControl.Size = new System.Drawing.Size(31, 27);
            this.zoomControl.TabIndex = 0;
            this.zoomControl.Values.Image = global::VideoEditor.Properties.Resources.zoom;
            this.zoomControl.Values.Text = "";
            this.zoomControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZoomControlMC);
            this.zoomControl.MouseEnter += new System.EventHandler(this.ZoomControlME);
            this.zoomControl.MouseLeave += new System.EventHandler(this.ZoomControlML);
            // 
            // btnZoomLen
            // 
            this.btnZoomLen.Location = new System.Drawing.Point(52, 8);
            this.btnZoomLen.Name = "btnZoomLen";
            this.btnZoomLen.Size = new System.Drawing.Size(31, 27);
            this.btnZoomLen.TabIndex = 15;
            this.btnZoomLen.Values.Image = global::VideoEditor.Properties.Resources.zoomLen;
            this.btnZoomLen.Values.Text = "";
            this.btnZoomLen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZoomLenMC);
            this.btnZoomLen.MouseEnter += new System.EventHandler(this.ZoomlenME);
            this.btnZoomLen.MouseLeave += new System.EventHandler(this.ZoomLenML);
            // 
            // btnChupManHinh
            // 
            this.btnChupManHinh.Location = new System.Drawing.Point(134, 7);
            this.btnChupManHinh.Name = "btnChupManHinh";
            this.btnChupManHinh.Size = new System.Drawing.Size(31, 27);
            this.btnChupManHinh.TabIndex = 14;
            this.btnChupManHinh.Values.Image = global::VideoEditor.Properties.Resources.camera;
            this.btnChupManHinh.Values.Text = "";
            this.btnChupManHinh.MouseEnter += new System.EventHandler(this.btnChupManHinhME);
            this.btnChupManHinh.MouseLeave += new System.EventHandler(this.btnChupManHinhML);
            // 
            // lb_gopVideo
            // 
            this.lb_gopVideo.Location = new System.Drawing.Point(178, 7);
            this.lb_gopVideo.Name = "lb_gopVideo";
            this.lb_gopVideo.Size = new System.Drawing.Size(31, 26);
            this.lb_gopVideo.TabIndex = 13;
            this.lb_gopVideo.Values.Image = global::VideoEditor.Properties.Resources.merge;
            this.lb_gopVideo.Values.Text = "";
            this.lb_gopVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gopVideoClick);
            this.lb_gopVideo.MouseEnter += new System.EventHandler(this.lb_gopVideoME);
            this.lb_gopVideo.MouseLeave += new System.EventHandler(this.lb_gopVideoML);
            // 
            // panel_chonVideoBanDau
            // 
            this.panel_chonVideoBanDau.Controls.Add(this.btn_chonVideo);
            this.panel_chonVideoBanDau.Location = new System.Drawing.Point(590, 275);
            this.panel_chonVideoBanDau.Name = "panel_chonVideoBanDau";
            this.panel_chonVideoBanDau.Size = new System.Drawing.Size(234, 101);
            this.panel_chonVideoBanDau.TabIndex = 14;
            // 
            // btn_chonVideo
            // 
            this.btn_chonVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_chonVideo.Location = new System.Drawing.Point(0, 0);
            this.btn_chonVideo.Name = "btn_chonVideo";
            this.btn_chonVideo.Size = new System.Drawing.Size(234, 101);
            this.btn_chonVideo.TabIndex = 12;
            this.btn_chonVideo.Values.Text = "Mở";
            this.btn_chonVideo.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ucChoiVideo
            // 
            this.ucChoiVideo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ucChoiVideo.batKinhLup = false;
            this.ucChoiVideo.batZoomControl = false;
            this.ucChoiVideo.Location = new System.Drawing.Point(181, 44);
            this.ucChoiVideo.Name = "ucChoiVideo";
            this.ucChoiVideo.Size = new System.Drawing.Size(941, 526);
            this.ucChoiVideo.TabIndex = 12;
            this.ucChoiVideo.thoiGianDangPhat = 1;
            this.ucChoiVideo.tocDoPhat = 1F;
            // 
            // frmPhatVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 651);
            this.Controls.Add(this.panel_chonVideoBanDau);
            this.Controls.Add(this.ucChoiVideo);
            this.Controls.Add(this.panel_congCu);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel_dieuKhien);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "frmPhatVideo";
            this.Text = "Phát video";
            this.MaximizedBoundsChanged += new System.EventHandler(this.formResizeEnd);
            this.MaximumSizeChanged += new System.EventHandler(this.formResizeEnd);
            this.MinimumSizeChanged += new System.EventHandler(this.formResizeEnd);
            this.Load += new System.EventHandler(this.frmPhatVideo_Load);
            this.ResizeEnd += new System.EventHandler(this.formResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.formKeyUp);
            this.Resize += new System.EventHandler(this.formResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dieuKhien)).EndInit();
            this.panel_dieuKhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_chuaCacNutDieuKhien)).EndInit();
            this.panel_chuaCacNutDieuKhien.ResumeLayout(false);
            this.panel_chuaCacNutDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_congCu)).EndInit();
            this.panel_congCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_chonVideoBanDau)).EndInit();
            this.panel_chonVideoBanDau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_xoaDaiDien;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_themVideo;
        private System.Windows.Forms.FlowLayoutPanel flowLayOut_chuaCacVideo;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgw_choLayAnhDaiDien;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_DangPhat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tongThoiGian;
        private System.Windows.Forms.Timer timer_layThoiGianVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_playPause;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_dieuKhien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_congCu;
        private ucThanhTruot ucThanhTruot_tuaVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btnChupManHinh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_gopVideo;
        private ucThanhTruot ucThanhTruot_amThanh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btn_loa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_stop;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tuaCham;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_quayLai10s;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tuaNhanh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_phongTo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_chonVideoBanDau;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_tien10s;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_chuaCacNutDieuKhien;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel prevSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nextSpeed;
        private ucChoiVideo ucChoiVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_chonVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btnZoomLen;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel zoomControl;
    }
}