namespace VideoEditor
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.listView_showListVideo = new System.Windows.Forms.ListView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_xoaVideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_layVideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.panel_hienThiNutDung = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_chonDoPhanGiai = new System.Windows.Forms.ComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_dinhDangXuat = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_export = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_exportFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_chonNoiLuu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_exportFileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_playVideoCut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lb_videoInfor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_cutVideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_up = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_remove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comboBox_pickRate = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.userControl11 = new VideoEditor.UserControl1();
            this.btn_phatDung = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.GrV_thongTinCat = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listImage_dsAnhDaiDienVideo = new System.Windows.Forms.ImageList(this.components);
            this.timer_getPlayingTime = new System.Windows.Forms.Timer(this.components);
            this.imageList_checkedList = new System.Windows.Forms.ImageList(this.components);
            this.timeGetPlayTime = new System.Windows.Forms.Timer(this.components);
            this.backgroundWoker_noiVideo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_catVideo = new System.ComponentModel.BackgroundWorker();
            this.timer_choVLCphanHoi = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_hienThiNutDung)).BeginInit();
            this.panel_hienThiNutDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_dinhDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_pickRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrV_thongTinCat)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45068F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.kryptonGroupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.31616F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.683836F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 668);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.listView_showListVideo);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(192, 624);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Danh sách video";
            // 
            // listView_showListVideo
            // 
            this.listView_showListVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_showListVideo.Location = new System.Drawing.Point(0, 0);
            this.listView_showListVideo.Name = "listView_showListVideo";
            this.listView_showListVideo.Size = new System.Drawing.Size(188, 600);
            this.listView_showListVideo.TabIndex = 0;
            this.listView_showListVideo.UseCompatibleStateImageBehavior = false;
            this.listView_showListVideo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.showListVideo_colClick);
            this.listView_showListVideo.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listVideoItem_mouseHover);
            this.listView_showListVideo.SelectedIndexChanged += new System.EventHandler(this.listView_showListVideo_SelectedIndexChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_xoaVideo);
            this.kryptonPanel1.Controls.Add(this.button_layVideo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 633);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(192, 32);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btn_xoaVideo
            // 
            this.btn_xoaVideo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_xoaVideo.Location = new System.Drawing.Point(121, 0);
            this.btn_xoaVideo.Name = "btn_xoaVideo";
            this.btn_xoaVideo.Size = new System.Drawing.Size(71, 32);
            this.btn_xoaVideo.TabIndex = 3;
            this.btn_xoaVideo.Values.Text = "Xóa";
            this.btn_xoaVideo.Click += new System.EventHandler(this.btn_xoaVideo_Click);
            // 
            // button_layVideo
            // 
            this.button_layVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_layVideo.Location = new System.Drawing.Point(0, 0);
            this.button_layVideo.Name = "button_layVideo";
            this.button_layVideo.Size = new System.Drawing.Size(115, 32);
            this.button_layVideo.TabIndex = 2;
            this.button_layVideo.Values.Text = "Thêm video";
            this.button_layVideo.Click += new System.EventHandler(this.button_layVideo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonGroupBox3);
            this.panel1.Controls.Add(this.btn_playVideoCut);
            this.panel1.Controls.Add(this.lb_videoInfor);
            this.panel1.Controls.Add(this.btn_cutVideo);
            this.panel1.Controls.Add(this.kryptonButton4);
            this.panel1.Controls.Add(this.btn_up);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.comboBox_pickRate);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.btn_phatDung);
            this.panel1.Controls.Add(this.vlcControl1);
            this.panel1.Controls.Add(this.kryptonGroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 668);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Location = new System.Drawing.Point(626, 459);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.panel_hienThiNutDung);
            this.kryptonGroupBox3.Panel.Controls.Add(this.cbb_chonDoPhanGiai);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox3.Panel.Controls.Add(this.cbb_dinhDangXuat);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox3.Panel.Controls.Add(this.btn_export);
            this.kryptonGroupBox3.Panel.Controls.Add(this.tb_exportFilePath);
            this.kryptonGroupBox3.Panel.Controls.Add(this.btn_chonNoiLuu);
            this.kryptonGroupBox3.Panel.Controls.Add(this.tb_exportFileName);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(309, 200);
            this.kryptonGroupBox3.TabIndex = 24;
            this.kryptonGroupBox3.Values.Heading = "Xuất tập tin";
            // 
            // panel_hienThiNutDung
            // 
            this.panel_hienThiNutDung.Controls.Add(this.kryptonButton1);
            this.panel_hienThiNutDung.Controls.Add(this.pictureBox1);
            this.panel_hienThiNutDung.Controls.Add(this.kryptonLabel4);
            this.panel_hienThiNutDung.Location = new System.Drawing.Point(4, 126);
            this.panel_hienThiNutDung.Name = "panel_hienThiNutDung";
            this.panel_hienThiNutDung.Size = new System.Drawing.Size(292, 47);
            this.panel_hienThiNutDung.TabIndex = 27;
            this.panel_hienThiNutDung.Visible = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(109, 8);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(97, 31);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Hủy";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VideoEditor.Properties.Resources.Webp1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(35, 13);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "Đang xử lý";
            // 
            // cbb_chonDoPhanGiai
            // 
            this.cbb_chonDoPhanGiai.FormattingEnabled = true;
            this.cbb_chonDoPhanGiai.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720",
            "960 x 640",
            "640x480 "});
            this.cbb_chonDoPhanGiai.Location = new System.Drawing.Point(90, 59);
            this.cbb_chonDoPhanGiai.Name = "cbb_chonDoPhanGiai";
            this.cbb_chonDoPhanGiai.Size = new System.Drawing.Size(146, 21);
            this.cbb_chonDoPhanGiai.TabIndex = 26;
            this.cbb_chonDoPhanGiai.Text = "1920x1080";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(4, 59);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel3.TabIndex = 25;
            this.kryptonLabel3.Values.Text = "Độ phân giải";
            // 
            // cbb_dinhDangXuat
            // 
            this.cbb_dinhDangXuat.DropDownWidth = 56;
            this.cbb_dinhDangXuat.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".avi"});
            this.cbb_dinhDangXuat.Location = new System.Drawing.Point(240, 34);
            this.cbb_dinhDangXuat.Name = "cbb_dinhDangXuat";
            this.cbb_dinhDangXuat.Size = new System.Drawing.Size(56, 21);
            this.cbb_dinhDangXuat.TabIndex = 24;
            this.cbb_dinhDangXuat.Text = ".mp4";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 33);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel2.TabIndex = 23;
            this.kryptonLabel2.Values.Text = "Tên tệp";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel1.TabIndex = 22;
            this.kryptonLabel1.Values.Text = "Nơi lưu";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(58, 137);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(217, 34);
            this.btn_export.TabIndex = 21;
            this.btn_export.Values.Text = "Xuất Video";
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // tb_exportFilePath
            // 
            this.tb_exportFilePath.Location = new System.Drawing.Point(90, 8);
            this.tb_exportFilePath.Name = "tb_exportFilePath";
            this.tb_exportFilePath.Size = new System.Drawing.Size(146, 20);
            this.tb_exportFilePath.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exportFilePath.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exportFilePath.TabIndex = 18;
            this.tb_exportFilePath.TextChanged += new System.EventHandler(this.tb_exportFilePath_TextChanged);
            // 
            // btn_chonNoiLuu
            // 
            this.btn_chonNoiLuu.Location = new System.Drawing.Point(240, 5);
            this.btn_chonNoiLuu.Name = "btn_chonNoiLuu";
            this.btn_chonNoiLuu.Size = new System.Drawing.Size(56, 27);
            this.btn_chonNoiLuu.TabIndex = 19;
            this.btn_chonNoiLuu.Values.Text = "....";
            this.btn_chonNoiLuu.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // tb_exportFileName
            // 
            this.tb_exportFileName.Location = new System.Drawing.Point(90, 34);
            this.tb_exportFileName.Name = "tb_exportFileName";
            this.tb_exportFileName.Size = new System.Drawing.Size(146, 20);
            this.tb_exportFileName.TabIndex = 20;
            // 
            // btn_playVideoCut
            // 
            this.btn_playVideoCut.Location = new System.Drawing.Point(572, 565);
            this.btn_playVideoCut.Name = "btn_playVideoCut";
            this.btn_playVideoCut.Size = new System.Drawing.Size(35, 34);
            this.btn_playVideoCut.TabIndex = 23;
            this.btn_playVideoCut.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__4_;
            this.btn_playVideoCut.Values.Text = "";
            this.btn_playVideoCut.Click += new System.EventHandler(this.btn_playVideoCut_Click);
            // 
            // lb_videoInfor
            // 
            this.lb_videoInfor.AutoSize = false;
            this.lb_videoInfor.Location = new System.Drawing.Point(703, 9);
            this.lb_videoInfor.Name = "lb_videoInfor";
            this.lb_videoInfor.Size = new System.Drawing.Size(243, 243);
            this.lb_videoInfor.TabIndex = 22;
            this.lb_videoInfor.Values.Text = "";
            // 
            // btn_cutVideo
            // 
            this.btn_cutVideo.Location = new System.Drawing.Point(14, 524);
            this.btn_cutVideo.Name = "btn_cutVideo";
            this.btn_cutVideo.Size = new System.Drawing.Size(68, 63);
            this.btn_cutVideo.TabIndex = 17;
            this.btn_cutVideo.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__5_;
            this.btn_cutVideo.Values.Text = "";
            this.btn_cutVideo.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(572, 524);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(35, 34);
            this.kryptonButton4.TabIndex = 16;
            this.kryptonButton4.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__2_;
            this.kryptonButton4.Values.Text = "";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(572, 484);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(35, 34);
            this.btn_up.TabIndex = 15;
            this.btn_up.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__1_;
            this.btn_up.Values.Text = "";
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(572, 605);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(35, 34);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Values.Image = global::VideoEditor.Properties.Resources.Webp_net_resizeimage__3_;
            this.btn_remove.Values.Text = "";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // comboBox_pickRate
            // 
            this.comboBox_pickRate.DropDownWidth = 63;
            this.comboBox_pickRate.Items.AddRange(new object[] {
            "x0.25",
            "x0.5",
            "x1",
            "x1.5",
            "x2",
            "x4"});
            this.comboBox_pickRate.Location = new System.Drawing.Point(703, 307);
            this.comboBox_pickRate.Name = "comboBox_pickRate";
            this.comboBox_pickRate.Size = new System.Drawing.Size(63, 21);
            this.comboBox_pickRate.TabIndex = 9;
            this.comboBox_pickRate.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(14, 391);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(683, 62);
            this.userControl11.TabIndex = 8;
            this.userControl11.videoDuration = System.TimeSpan.Parse("00:00:00");
            this.userControl11.pointLocationChange += new VideoEditor.ScrollBarHandler(this.uc_poinChange);
            this.userControl11.playingPointChange += new VideoEditor.PlayingPointHandler(this.playingPointChange);
            // 
            // btn_phatDung
            // 
            this.btn_phatDung.Location = new System.Drawing.Point(703, 334);
            this.btn_phatDung.Name = "btn_phatDung";
            this.btn_phatDung.Size = new System.Drawing.Size(63, 51);
            this.btn_phatDung.TabIndex = 4;
            this.btn_phatDung.Values.Image = global::VideoEditor.Properties.Resources.stop;
            this.btn_phatDung.Values.Text = "";
            this.btn_phatDung.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.White;
            this.vlcControl1.Location = new System.Drawing.Point(14, 25);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(683, 376);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 3;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            this.vlcControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vlcControlMouseClick);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(88, 459);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.GrV_thongTinCat);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(480, 200);
            this.kryptonGroupBox2.TabIndex = 13;
            this.kryptonGroupBox2.Values.Heading = "Các phần được cắt";
            this.kryptonGroupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox2_Paint);
            // 
            // GrV_thongTinCat
            // 
            this.GrV_thongTinCat.AllowUserToResizeRows = false;
            this.GrV_thongTinCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrV_thongTinCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrV_thongTinCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.video,
            this.batDau,
            this.ketThuc,
            this.thoiGian});
            this.GrV_thongTinCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrV_thongTinCat.Location = new System.Drawing.Point(0, 0);
            this.GrV_thongTinCat.MultiSelect = false;
            this.GrV_thongTinCat.Name = "GrV_thongTinCat";
            this.GrV_thongTinCat.RowHeadersVisible = false;
            this.GrV_thongTinCat.Size = new System.Drawing.Size(476, 176);
            this.GrV_thongTinCat.TabIndex = 12;
            this.GrV_thongTinCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_thongTinCutClick);
            // 
            // video
            // 
            this.video.HeaderText = "Video";
            this.video.Name = "video";
            // 
            // batDau
            // 
            this.batDau.HeaderText = "Bắt đầu";
            this.batDau.Name = "batDau";
            // 
            // ketThuc
            // 
            this.ketThuc.HeaderText = "Kết thúc";
            this.ketThuc.Name = "ketThuc";
            // 
            // thoiGian
            // 
            this.thoiGian.HeaderText = "Thời gian";
            this.thoiGian.Name = "thoiGian";
            // 
            // listImage_dsAnhDaiDienVideo
            // 
            this.listImage_dsAnhDaiDienVideo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.listImage_dsAnhDaiDienVideo.ImageSize = new System.Drawing.Size(100, 100);
            this.listImage_dsAnhDaiDienVideo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer_getPlayingTime
            // 
            this.timer_getPlayingTime.Enabled = true;
            this.timer_getPlayingTime.Interval = 1000;
            // 
            // imageList_checkedList
            // 
            this.imageList_checkedList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_checkedList.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList_checkedList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timeGetPlayTime
            // 
            this.timeGetPlayTime.Interval = 200;
            this.timeGetPlayTime.Tick += new System.EventHandler(this.timeGetPlayTime_Tick);
            // 
            // backgroundWoker_noiVideo
            // 
            this.backgroundWoker_noiVideo.WorkerSupportsCancellation = true;
            this.backgroundWoker_noiVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWoker_noiVideo_DoWork);
            this.backgroundWoker_noiVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWoker_noiVideo_Complete);
            // 
            // backgroundWorker_catVideo
            // 
            this.backgroundWorker_catVideo.WorkerSupportsCancellation = true;
            this.backgroundWorker_catVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_catVideo_DoWork);
            this.backgroundWorker_catVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_catVideo_Complete);
            // 
            // timer_choVLCphanHoi
            // 
            this.timer_choVLCphanHoi.Tick += new System.EventHandler(this.timer_choVLCphanHoi_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecotek- Cắt ghép video";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_hienThiNutDung)).EndInit();
            this.panel_hienThiNutDung.ResumeLayout(false);
            this.panel_hienThiNutDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_dinhDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_pickRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrV_thongTinCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.ListView listView_showListVideo;
        private System.Windows.Forms.ImageList listImage_dsAnhDaiDienVideo;
        private System.Windows.Forms.Panel panel1;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_phatDung;
        private UserControl1 userControl11;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBox_pickRate;
        private System.Windows.Forms.Timer timer_getPlayingTime;
        private System.Windows.Forms.ImageList imageList_checkedList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GrV_thongTinCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn video;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGian;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_up;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_remove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cutVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_exportFilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_chonNoiLuu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_exportFileName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_export;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_videoInfor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_playVideoCut;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_dinhDangXuat;
        private System.Windows.Forms.Timer timeGetPlayTime;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_layVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoaVideo;
        private System.ComponentModel.BackgroundWorker backgroundWoker_noiVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ComboBox cbb_chonDoPhanGiai;
        private System.ComponentModel.BackgroundWorker backgroundWorker_catVideo;
        private System.Windows.Forms.Timer timer_choVLCphanHoi;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_hienThiNutDung;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

