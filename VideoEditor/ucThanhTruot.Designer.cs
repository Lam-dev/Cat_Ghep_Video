namespace VideoEditor
{
    partial class ucThanhTruot
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
            this.panel_nen = new System.Windows.Forms.Panel();
            this.panel_redPoint = new System.Windows.Forms.Panel();
            this.panel_duongRay = new System.Windows.Forms.Panel();
            this.panel_daQua = new System.Windows.Forms.Panel();
            this.panel_nen.SuspendLayout();
            this.panel_duongRay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nen
            // 
            this.panel_nen.BackColor = System.Drawing.Color.Transparent;
            this.panel_nen.Controls.Add(this.panel_redPoint);
            this.panel_nen.Controls.Add(this.panel_duongRay);
            this.panel_nen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nen.Location = new System.Drawing.Point(0, 0);
            this.panel_nen.Name = "panel_nen";
            this.panel_nen.Size = new System.Drawing.Size(635, 41);
            this.panel_nen.TabIndex = 0;
            this.panel_nen.SizeChanged += new System.EventHandler(this.thanhTruot_sizeChange);
            this.panel_nen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // panel_redPoint
            // 
            this.panel_redPoint.BackColor = System.Drawing.Color.Red;
            this.panel_redPoint.ForeColor = System.Drawing.Color.Transparent;
            this.panel_redPoint.Location = new System.Drawing.Point(152, 0);
            this.panel_redPoint.Name = "panel_redPoint";
            this.panel_redPoint.Size = new System.Drawing.Size(42, 41);
            this.panel_redPoint.TabIndex = 1;
            this.panel_redPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MD);
            this.panel_redPoint.MouseLeave += new System.EventHandler(this.diemPhat_MLeave);
            this.panel_redPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MM);
            this.panel_redPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diemPhat_MU);
            // 
            // panel_duongRay
            // 
            this.panel_duongRay.BackColor = System.Drawing.Color.White;
            this.panel_duongRay.Controls.Add(this.panel_daQua);
            this.panel_duongRay.Location = new System.Drawing.Point(15, 13);
            this.panel_duongRay.Name = "panel_duongRay";
            this.panel_duongRay.Size = new System.Drawing.Size(608, 13);
            this.panel_duongRay.TabIndex = 0;
            this.panel_duongRay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucMouseClick);
            this.panel_duongRay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMouseMove);
            // 
            // panel_daQua
            // 
            this.panel_daQua.BackColor = System.Drawing.Color.Red;
            this.panel_daQua.Location = new System.Drawing.Point(3, 0);
            this.panel_daQua.Name = "panel_daQua";
            this.panel_daQua.Size = new System.Drawing.Size(160, 13);
            this.panel_daQua.TabIndex = 0;
            this.panel_daQua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucMouseClick);
            // 
            // ucThanhTruot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_nen);
            this.Name = "ucThanhTruot";
            this.Size = new System.Drawing.Size(635, 41);
            this.Load += new System.EventHandler(this.ucThanTruot_load);
            this.panel_nen.ResumeLayout(false);
            this.panel_duongRay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nen;
        private System.Windows.Forms.Panel panel_duongRay;
        private System.Windows.Forms.Panel panel_redPoint;
        private System.Windows.Forms.Panel panel_daQua;
    }
}
