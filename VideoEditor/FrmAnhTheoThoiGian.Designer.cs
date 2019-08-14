namespace VideoEditor
{
    partial class FrmAnhTheoThoiGian
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
            this.picbox_hienThiAnh = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_hienThiAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_hienThiAnh
            // 
            this.picbox_hienThiAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_hienThiAnh.Location = new System.Drawing.Point(0, 0);
            this.picbox_hienThiAnh.Name = "picbox_hienThiAnh";
            this.picbox_hienThiAnh.Size = new System.Drawing.Size(192, 117);
            this.picbox_hienThiAnh.TabIndex = 0;
            this.picbox_hienThiAnh.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(52, 92);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // FrmAnhTheoThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 117);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.picbox_hienThiAnh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnhTheoThoiGian";
            this.Text = "anhTheoThoiGian";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_hienThiAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picbox_hienThiAnh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}