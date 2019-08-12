namespace VideoEditor
{
    partial class ucPhatVideo
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
            this.picBoxHienThiVideo = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.bgw_chayVideo = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHienThiVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHienThiVideo
            // 
            this.picBoxHienThiVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxHienThiVideo.Location = new System.Drawing.Point(0, 0);
            this.picBoxHienThiVideo.Name = "picBoxHienThiVideo";
            this.picBoxHienThiVideo.Size = new System.Drawing.Size(591, 319);
            this.picBoxHienThiVideo.TabIndex = 0;
            this.picBoxHienThiVideo.TabStop = false;
            // 
            // bgw_chayVideo
            // 
            this.bgw_chayVideo.WorkerSupportsCancellation = true;
            this.bgw_chayVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_chayVideo_DoWork);
            // 
            // ucPhatVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxHienThiVideo);
            this.Name = "ucPhatVideo";
            this.Size = new System.Drawing.Size(591, 319);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHienThiVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picBoxHienThiVideo;
        private System.ComponentModel.BackgroundWorker bgw_chayVideo;
    }
}
