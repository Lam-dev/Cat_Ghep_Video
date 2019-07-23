namespace VideoEditor
{
    partial class UserControl1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bar = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.SB_startPoint = new System.Windows.Forms.PictureBox();
            this.poin_playing = new System.Windows.Forms.PictureBox();
            this.SB_stopPoint = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lb_stopPoint = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_startTime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SB_startPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poin_playing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_stopPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.35391F));
            this.tableLayoutPanel1.Controls.Add(this.bar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bar
            // 
            this.bar.Controls.Add(this.SB_startPoint);
            this.bar.Controls.Add(this.poin_playing);
            this.bar.Controls.Add(this.SB_stopPoint);
            this.bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar.Location = new System.Drawing.Point(3, 3);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(481, 39);
            this.bar.StateNormal.Color1 = System.Drawing.Color.Gray;
            this.bar.TabIndex = 0;
            this.bar.Paint += new System.Windows.Forms.PaintEventHandler(this.bar_Paint);
            // 
            // SB_startPoint
            // 
            this.SB_startPoint.BackColor = System.Drawing.Color.MediumBlue;
            this.SB_startPoint.Location = new System.Drawing.Point(0, 0);
            this.SB_startPoint.Name = "SB_startPoint";
            this.SB_startPoint.Size = new System.Drawing.Size(24, 42);
            this.SB_startPoint.TabIndex = 0;
            this.SB_startPoint.TabStop = false;
            this.SB_startPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SB_startPoint_mouseDown);
            this.SB_startPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SB_startPoint_mouseMove);
            this.SB_startPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stopButton_mouseMove);
            // 
            // poin_playing
            // 
            this.poin_playing.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.poin_playing.Location = new System.Drawing.Point(24, 0);
            this.poin_playing.Name = "poin_playing";
            this.poin_playing.Size = new System.Drawing.Size(10, 43);
            this.poin_playing.TabIndex = 2;
            this.poin_playing.TabStop = false;
            this.poin_playing.LocationChanged += new System.EventHandler(this.playingPoinChange);
            this.poin_playing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.poin_playingMD);
            this.poin_playing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.poin_playingMM);
            this.poin_playing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.poin_playingMU);
            // 
            // SB_stopPoint
            // 
            this.SB_stopPoint.BackColor = System.Drawing.Color.Crimson;
            this.SB_stopPoint.Location = new System.Drawing.Point(456, 1);
            this.SB_stopPoint.Name = "SB_stopPoint";
            this.SB_stopPoint.Size = new System.Drawing.Size(24, 42);
            this.SB_stopPoint.TabIndex = 1;
            this.SB_stopPoint.TabStop = false;
            this.SB_stopPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SB_stopPoint_MouseDown);
            this.SB_stopPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SB_stopPoint_MouseMove);
            this.SB_stopPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SB_stopPoint_mouseUp);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lb_stopPoint);
            this.kryptonPanel2.Controls.Add(this.lb_startTime);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 48);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(481, 30);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // lb_stopPoint
            // 
            this.lb_stopPoint.AutoSize = false;
            this.lb_stopPoint.Location = new System.Drawing.Point(405, 0);
            this.lb_stopPoint.Name = "lb_stopPoint";
            this.lb_stopPoint.Size = new System.Drawing.Size(52, 28);
            this.lb_stopPoint.TabIndex = 1;
            this.lb_stopPoint.Values.Text = "stop";
            // 
            // lb_startTime
            // 
            this.lb_startTime.AutoSize = false;
            this.lb_startTime.Location = new System.Drawing.Point(0, 0);
            this.lb_startTime.Name = "lb_startTime";
            this.lb_startTime.Size = new System.Drawing.Size(57, 31);
            this.lb_startTime.TabIndex = 0;
            this.lb_startTime.Values.Text = "start";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(487, 81);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SB_startPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poin_playing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_stopPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel bar;
        private System.Windows.Forms.PictureBox SB_startPoint;
        private System.Windows.Forms.PictureBox SB_stopPoint;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_startTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_stopPoint;
        private System.Windows.Forms.PictureBox poin_playing;
    }
}
