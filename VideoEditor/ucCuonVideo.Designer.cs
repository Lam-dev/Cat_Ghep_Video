namespace VideoEditor
{
    partial class ucCuonVideo
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
            this.panel_diemDangPhat = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel_duongRay = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panel_diemDangPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_duongRay)).BeginInit();
            this.panel_duongRay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_diemDangPhat
            // 
            this.panel_diemDangPhat.Location = new System.Drawing.Point(3, 0);
            this.panel_diemDangPhat.Name = "panel_diemDangPhat";
            this.panel_diemDangPhat.Size = new System.Drawing.Size(22, 21);
            this.panel_diemDangPhat.StateNormal.Color1 = System.Drawing.SystemColors.Highlight;
            this.panel_diemDangPhat.TabIndex = 0;
            this.panel_diemDangPhat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MD);
            this.panel_diemDangPhat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MM);
            this.panel_diemDangPhat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MU);
            // 
            // panel_duongRay
            // 
            this.panel_duongRay.Controls.Add(this.panel_diemDangPhat);
            this.panel_duongRay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_duongRay.Location = new System.Drawing.Point(0, 0);
            this.panel_duongRay.Name = "panel_duongRay";
            this.panel_duongRay.Size = new System.Drawing.Size(501, 21);
            this.panel_duongRay.TabIndex = 0;
            // 
            // ucCuonVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_duongRay);
            this.Name = "ucCuonVideo";
            this.Size = new System.Drawing.Size(501, 21);
            this.Load += new System.EventHandler(this.ucCuonVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_diemDangPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_duongRay)).EndInit();
            this.panel_duongRay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_diemDangPhat;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_duongRay;
    }
}
