﻿namespace VideoEditor
{
    partial class ucChoiVideo
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
            this.components = new System.ComponentModel.Container();
            this.picBox_hienThiVideo = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.bgw_choiVideo = new System.ComponentModel.BackgroundWorker();
            this.timer_thoiGianChuyenKhungHinh = new System.Windows.Forms.Timer(this.components);
            this.picbox_nhinToanCanh = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.picBox_kinhLup = new VideoEditor.pictureBoxTron();
            this.bgw_layHinhChoKinhLup = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hienThiVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nhinToanCanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_kinhLup)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hienThiVideo
            // 
            this.picBox_hienThiVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_hienThiVideo.Location = new System.Drawing.Point(0, 0);
            this.picBox_hienThiVideo.Name = "picBox_hienThiVideo";
            this.picBox_hienThiVideo.Size = new System.Drawing.Size(563, 334);
            this.picBox_hienThiVideo.TabIndex = 0;
            this.picBox_hienThiVideo.TabStop = false;
            this.picBox_hienThiVideo.SizeChanged += new System.EventHandler(this.picBoxSizeChanged);
            this.picBox_hienThiVideo.Click += new System.EventHandler(this.picBox_hienThiVideo_Click);
            this.picBox_hienThiVideo.MouseEnter += new System.EventHandler(this.picbox_nhinToanCanhME);
            // 
            // bgw_choiVideo
            // 
            this.bgw_choiVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_choiVideo_DoWork);
            // 
            // timer_thoiGianChuyenKhungHinh
            // 
            this.timer_thoiGianChuyenKhungHinh.Tick += new System.EventHandler(this.Timer_thoiGianChuyenKhungHinh_Tick);
            // 
            // picbox_nhinToanCanh
            // 
            this.picbox_nhinToanCanh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picbox_nhinToanCanh.Location = new System.Drawing.Point(385, 225);
            this.picbox_nhinToanCanh.Name = "picbox_nhinToanCanh";
            this.picbox_nhinToanCanh.Size = new System.Drawing.Size(178, 106);
            this.picbox_nhinToanCanh.TabIndex = 2;
            this.picbox_nhinToanCanh.TabStop = false;
            this.picbox_nhinToanCanh.Visible = false;
            this.picbox_nhinToanCanh.MouseEnter += new System.EventHandler(this.picbox_nhinToanCanhME);
            // 
            // picBox_kinhLup
            // 
            this.picBox_kinhLup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picBox_kinhLup.Location = new System.Drawing.Point(13, 84);
            this.picBox_kinhLup.Name = "picBox_kinhLup";
            this.picBox_kinhLup.Size = new System.Drawing.Size(158, 146);
            this.picBox_kinhLup.TabIndex = 1;
            this.picBox_kinhLup.TabStop = false;
            this.picBox_kinhLup.Visible = false;
            this.picBox_kinhLup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KinhLupMD);
            this.picBox_kinhLup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KinhLupMM);
            this.picBox_kinhLup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KinhLupMU);
            // 
            // bgw_layHinhChoKinhLup
            // 
            this.bgw_layHinhChoKinhLup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_layHinhChoKinhLup_DoWork);
            // 
            // ucChoiVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picbox_nhinToanCanh);
            this.Controls.Add(this.picBox_kinhLup);
            this.Controls.Add(this.picBox_hienThiVideo);
            this.Name = "ucChoiVideo";
            this.Size = new System.Drawing.Size(563, 334);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hienThiVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nhinToanCanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_kinhLup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picBox_hienThiVideo;
        private System.ComponentModel.BackgroundWorker bgw_choiVideo;
        private System.Windows.Forms.Timer timer_thoiGianChuyenKhungHinh;
        private pictureBoxTron picBox_kinhLup;
        private OpenCvSharp.UserInterface.PictureBoxIpl picbox_nhinToanCanh;
        private System.ComponentModel.BackgroundWorker bgw_layHinhChoKinhLup;
    }
}
