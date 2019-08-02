using FFmpeg.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{

    public partial class frmPhatVideo : Form
    {
        Engine ffmpeg = new Engine(@"..\..\libFFmpeg\ffmpeg.exe");
        MetaData thongTinVideo;
        List<ucDaiDienVideo> dsVideoControl = new List<ucDaiDienVideo>();
        bool dangGiuCtr = false;
        bool dangChonNhieu = false;
        List<int> dsDangChon = new List<int>();
        public frmPhatVideo()
        {
            InitializeComponent();
            this.vlc_phatVideo.VlcLibDirectory = new System.IO.DirectoryInfo(@"..\..\libvlc\win-x86");
            ((System.ComponentModel.ISupportInitialize)(this.vlc_phatVideo)).EndInit();
        }

        private async void lb_themVideoClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog_layVideo = new OpenFileDialog
            {
                InitialDirectory = @"",
                Title = "Chọn tệp video",
                Multiselect = true,
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "Video files (*.mp4, *.avi, *.flv, *.mov) | *.mp4; *.avi; *.flv; *.mov",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (dialog_layVideo.ShowDialog() == DialogResult.OK)
            {
                var danhSachPath = dialog_layVideo.FileNames;
                bgw_choLayAnhDaiDien.RunWorkerAsync(argument: danhSachPath);
            }
        }

        private void bgw_choLayAnhDaiDien_DoWork(object sender, DoWorkEventArgs e)
        {

            var danhSachVideo = ((string[])e.Argument).ToList();
            foreach (var path in danhSachVideo)
            {
                var inputFile = new MediaFile(path);
                var outputFile = new MediaFile("thum.jpg");
                var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(2) };
                var task = ffmpeg.GetThumbnailAsync(inputFile, outputFile, options);
                task.Wait(1000);
                var file = File.Exists("thum.jpg");
                if (file)
                {
                    try
                    {
                        var imageStream = new FileStream("thum.jpg", FileMode.Open);
                        flowLayOut_chuaCacVideo.Invoke(new MethodInvoker(delegate ()
                        {
                            dsVideoControl.Add(new ucDaiDienVideo(flowLayOut_chuaCacVideo.Controls.Count, (Bitmap)Bitmap.FromStream(imageStream), path, inputFile.FileInfo.Name, byteToMegabye(inputFile.FileInfo.Length)));
                            flowLayOut_chuaCacVideo.Controls.Add(dsVideoControl[dsVideoControl.Count - 1]);
                            dsVideoControl[dsVideoControl.Count - 1].anhDaiDienClick += new VideoEditor.anhDaiDienVideoClick(chonPhatVideo);
                            dsVideoControl[dsVideoControl.Count - 1].iMouseMove += new MouseEventHandler(danhSachVideo_MM);
                        }));
                        imageStream.Dispose();

                    }
                    catch
                    { }
                    File.Delete("thum.jpg");
                }
            }
        }

        private string byteToMegabye(long numberOfByte)
        {
            var megabyte = (double)numberOfByte / 1024 / 1024;
            var str = megabyte.ToString();
            var catPhan = str.Split('.');
            if (catPhan.Length == 2)
            {
                return catPhan[0] + '.' + catPhan[1].Substring(0, 2) + "MB";
            }
            if (catPhan.Length == 1)
                return catPhan[0] + "MB";
            return "";
        }

        private async void chonPhatVideo(object sender, anhDaiDienArgs e)
        {
            if (dangGiuCtr)
            {
                if (dsDangChon.Where(y => y == e.index).Count() != 0)
                {
                    dsDangChon.RemoveAll(y => y == e.index);
                }
                else
                {
                    dsVideoControl[e.index].lb_duongDanVideo.BackColor = Color.Yellow;
                    dsDangChon.Add(e.index);
                }
                dangChonNhieu = true;
            }
            else
            {
                vlc_phatVideo.Play(new FileInfo(e.filePath));
                var video = new MediaFile(e.filePath);
                //var task =  ffmpeg.GetMetaDataAsync(video);
                //lb_tongThoiGian.Text = thongTinVideo.Duration.ToString();
                await layThongTinVideo(video);
                timer_layThoiGianVideo.Start();
                dangChonNhieu = false;
                dsDangChon.Clear();
                timer_choVLCphanHoi.Start();
            }
        }

        private async Task<bool> layThongTinVideo(MediaFile video)
        {
            thongTinVideo = await ffmpeg.GetMetaDataAsync(video);
            while (true)
            {
                if (thongTinVideo != null)
                {
                    lb_tongThoiGian.Text = thongTinVideo.Duration.ToString();
                    return true;
                }
            }
        }

        private void frmPhatVideo_Load(object sender, EventArgs e)
        {
            canChinhForm();
        }

        private void timer_layThoiGianVideo_Tick(object sender, EventArgs e)
        {
            if (vlc_phatVideo.IsPlaying)
            {
                var x = vlc_phatVideo.Time;
                lb_DangPhat.Text = mainForm.TimeSpanToString(mainForm.SecondToTimespan(x / 1000));
                ucThanhTruot_tuaVideo.phanTramHienTai = x / thongTinVideo.Duration.TotalMilliseconds * 100;
            }
        }

        private void ucCuonVideo1_Load(object sender, EventArgs e)
        {

        }

        private void thanhTruotDangCuon(object sender, cuonVideoArgs e)
        {
            if (thongTinVideo == null)
            {
                return;
            }
            try
            {
                var thoiGianTuongUng = thongTinVideo.Duration.TotalMilliseconds * e.phanTramThanhCuon / 100;
                vlc_phatVideo.Time = (long)thoiGianTuongUng;
                lb_DangPhat.Text = mainForm.TimeSpanToString(mainForm.SecondToTimespan(vlc_phatVideo.Time / 1000));
            }
            catch
            {
                return;
            }
        }

        private void timer_choVLCphanHoi_Tick(object sender, EventArgs e)
        {
            thayDoiIconPlayPause();
        }

        private void thayDoiIconPlayPause()
        {
            if (vlc_phatVideo.IsPlaying)
            {

                lb_playPause.Values.Image = Properties.Resources.pauseLeave;
                panel_chonVideoBanDau.Visible = false;
            }
            else
            {
                lb_playPause.Values.Image = Properties.Resources.playleave;

            }
            timer_choVLCphanHoi.Stop();
        }

        private void playPauseMouseClick(object sender, MouseEventArgs e)
        {
            if (vlc_phatVideo.IsPlaying)
            {
                vlc_phatVideo.Pause();
                timer_choVLCphanHoi.Start();

            }
            else
            {
                vlc_phatVideo.Play();
                timer_choVLCphanHoi.Start();
            }
        }

        private void gopVideoClick(object sender, MouseEventArgs e)
        {
            vlc_phatVideo.Stop();
            panel_chonVideoBanDau.Visible = true;
            timer_choVLCphanHoi.Stop();
            new mainForm().ShowDialog();
        }

        private void formResizeEnd(object sender, EventArgs e)
        {
            //flowLayOut_chuaCacVideo.Size = new Size(flowLayOut_chuaCacVideo.Width, kryptonPanel1.Height - panel1.Height);
            //vlc_phatVideo.Size = new Size((this.Width - kryptonPanel1.Width - 10), kryptonPanel1.Height - 70);
            //panel_chuaThanhCuonVaNutNhan.Location = new Point(vlc_phatVideo.Location.X + (vlc_phatVideo.Width - panel_chuaThanhCuonVaNutNhan.Width) / 2, kryptonPanel1.Location.Y + kryptonPanel1.Height - panel_chuaThanhCuonVaNutNhan.Height);
            canChinhForm();
        }

        private void danhSachVideo_MM(object sender, MouseEventArgs e)
        {
            var x = flowLayOut_chuaCacVideo.PointToClient(Cursor.Position);
            for (int i = 0; i < flowLayOut_chuaCacVideo.Controls.Count; i++)
            {
                var diemCuoi = new Point(flowLayOut_chuaCacVideo.Controls[i].Location.X + flowLayOut_chuaCacVideo.Controls[i].Width, flowLayOut_chuaCacVideo.Controls[i].Location.Y + flowLayOut_chuaCacVideo.Controls[i].Height);
                if (lonHon(x, flowLayOut_chuaCacVideo.Controls[i].Location) & nhoHon(x, diemCuoi))
                {
                    dsVideoControl[i].lb_duongDanVideo.BackColor = Color.LightYellow;
                }
                else
                {
                    if (dangChonNhieu)
                    {
                        var re = dsDangChon.Where(y => y == i);
                        if (re.Count() != 0)
                        {
                            dsVideoControl[i].lb_duongDanVideo.BackColor = Color.Yellow;
                        }
                        else
                            dsVideoControl[i].lb_duongDanVideo.BackColor = Color.LightGray;
                    }
                    else
                    {
                        dsVideoControl[i].lb_duongDanVideo.BackColor = Color.LightGray;
                    }
                }
            }
        }

        public static bool lonHon(Point a, Point b)
        {
            if (a.X > b.X & a.Y > b.Y)
                return true;
            return false;
        }

        public static bool nhoHon(Point a, Point b)
        {
            if (a.X < b.X & a.Y < b.Y)
                return true;
            return false;
        }

        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                dangGiuCtr = true;
            }
        }

        private void formKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                dangGiuCtr = false;
            }
        }

        private void danhSachVideo_MC(object sender, MouseEventArgs e)
        {
            dangChonNhieu = false;
            dsDangChon.Clear();
        }

        private void xoaVideoTrongDanhSachClick(object sender, MouseEventArgs e)
        {
            dsVideoControl.RemoveAll(c => c.lb_duongDanVideo.BackColor == Color.Yellow);
            for (int i = 0; i < dsVideoControl.Count; i++)
            {
                dsVideoControl[i].index = i;
            }
            flowLayOut_chuaCacVideo.Controls.Clear();
            flowLayOut_chuaCacVideo.Controls.AddRange(dsVideoControl.ToArray());
            dsDangChon.Clear();
        }

        private void thayDoiAmThanh(object sender, cuonVideoArgs e)
        {

        }

        private void ucThanhTruot_tuaVideo_Load(object sender, EventArgs e)
        {
            ucThanhTruot_tuaVideo.mauCuaDiem = Color.FromArgb(255, 18, 150, 255);
            ucThanhTruot_tuaVideo.mauDuongRay = Color.FromArgb(255, 196, 196, 196);
        }

        private void ucThanhTruot_amThanh_Load(object sender, EventArgs e)
        {
            ucThanhTruot_amThanh.mauCuaDiem = Color.FromArgb(255, 18, 177, 251);
            ucThanhTruot_amThanh.mauDuongRay = Color.FromArgb(255, 196, 196, 196);
        }

        private void lb_DangPhat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_loa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_xoaDaiDien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timKiemMouseClick(object sender, MouseEventArgs e)
        {

        }


        private void thayDoiGiaTriAmThanh(object sender, cuonVideoArgs e)
        {

            vlc_phatVideo.Audio.Volume = (int)e.phanTramThanhCuon;
            if ((int)e.phanTramThanhCuon <= 5)
            {
                btn_loa.Values.Image = VideoEditor.Properties.Resources.speaker_mute;
            }
            else
            {
                btn_loa.Values.Image = VideoEditor.Properties.Resources.speaker;
            }
        }

        private void dungPhatVideoClick(object sender, MouseEventArgs e)
        {
            vlc_phatVideo.Stop();
            panel_chonVideoBanDau.Visible = true;
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_layVideo = new OpenFileDialog
            {
                InitialDirectory = @"",
                Title = "Chọn tệp video",
                Multiselect = true,
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "Video files (*.mp4, *.avi, *.flv, *.mov) | *.mp4; *.avi; *.flv; *.mov",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (dialog_layVideo.ShowDialog() == DialogResult.OK)
            {
                var danhSachPath = dialog_layVideo.FileNames;
                bgw_choLayAnhDaiDien.RunWorkerAsync(argument: danhSachPath);
                try
                {
                    vlc_phatVideo.Play(new FileInfo(danhSachPath[0]));
                    panel_chonVideoBanDau.Visible = false;
                    var video = new MediaFile(danhSachPath[0]);
                    await layThongTinVideo(video);
                    timer_layThoiGianVideo.Start();
                }
                catch
                {

                }

            }
        }

        private void playMouseEnter(object sender, EventArgs e)
        {
            lb_playPause.Values.Image = VideoEditor.Properties.Resources.Webp3;
        }

        private void playMouseLeave(object sender, EventArgs e)
        {
            lb_playPause.Values.Image = VideoEditor.Properties.Resources.playEnter;
        }

        private void lb_stop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nutDieuKhien_ME(object sender, EventArgs e)
        {
            if ((sender as Control) == lb_tuaCham)
            {
                lb_tuaCham.Values.Image = VideoEditor.Properties.Resources.speedDownMouseEnter;
                return;
            }
            if ((sender as Control) == lb_quayLai10s)
            {
                lb_quayLai10s.Values.Image = VideoEditor.Properties.Resources.pre10sMouseEnter;
                return; 
            }
            if ((sender as Control) == lb_stop)
            {
                lb_stop.Values.Image = VideoEditor.Properties.Resources.stopEnter;
                return; 
            }
            if ((sender as Control) == lb_tien10s)
            {
                lb_tien10s.Values.Image = VideoEditor.Properties.Resources.next10sMouseEnter;
                return; 
            }
            if ((sender as Control) == lb_tuaNhanh)
            {
                lb_tuaNhanh.Values.Image = VideoEditor.Properties.Resources.speedUpMouseEnter;
                return; 
            }
            if ((sender as Control) == lb_playPause)
            {
                if (vlc_phatVideo.IsPlaying)
                    lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseEnter;
                else
                    lb_playPause.Values.Image = VideoEditor.Properties.Resources.playEnter;
                return;
            }
            if ((sender as Control) == lb_themVideo)
            {
                lb_themVideo.Values.Image = VideoEditor.Properties.Resources.addImageLeave;
                return;
            }
            if ((sender as Control) == lb_)
            {
                lb_.Values.Image = VideoEditor.Properties.Resources.searchIconLeave;
                return;
            }
            if ((sender as Control) == lb_xoaDaiDien)
            {
                lb_xoaDaiDien.Values.Image = VideoEditor.Properties.Resources.Webp_net_resizeimage_leave;
                return;
            }

        }

        private void nutDieuKhien_ML(object sender, EventArgs e)
        {
            if ((sender as Control) == lb_tuaCham)
            {
                lb_tuaCham.Values.Image = VideoEditor.Properties.Resources.speedDownMouseLeave;
                return;
            }
            if ((sender as Control) == lb_quayLai10s)
            {
                lb_quayLai10s.Values.Image = VideoEditor.Properties.Resources.pre10sMouseLeave;
                return;
            }
            if ((sender as Control) == lb_stop)
            {
                lb_stop.Values.Image = VideoEditor.Properties.Resources.stopLeave;
                return;
            }
            if ((sender as Control) == lb_tien10s)
            {
                lb_tien10s.Values.Image = VideoEditor.Properties.Resources.next10sMouseLeave;
                return;
            }
            if ((sender as Control) == lb_tuaNhanh)
            {
                lb_tuaNhanh.Values.Image = VideoEditor.Properties.Resources.speedUpMouseLeave;
                return;
            }
            if ((sender as Control) == lb_playPause)
            {
                if (vlc_phatVideo.IsPlaying)
                    lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseLeave;
                else
                    lb_playPause.Values.Image = VideoEditor.Properties.Resources.playleave;
            }
            if ((sender as Control) == lb_themVideo)
            {
                lb_themVideo.Values.Image = VideoEditor.Properties.Resources.addImage;
                return;
            }
            if ((sender as Control) == lb_)
            {
                lb_.Values.Image = VideoEditor.Properties.Resources.searchIcon;
                return;
            }
            if ((sender as Control) == lb_xoaDaiDien)
            {
                lb_xoaDaiDien.Values.Image = VideoEditor.Properties.Resources.Webp_net_resizeimage__3_;
                return;
            }
        }

        private void vlc_phatVideo_Click(object sender, EventArgs e)
        {

        }
        private void canChinhForm()
        {
            panel1.Location = new Point(0, 0);
            flowLayOut_chuaCacVideo.Size = new Size(kryptonPanel1.Width, kryptonPanel1.Height - panel1.Height);
            panel_congCu.Size = new Size(this.Width - kryptonPanel1.Width, panel_congCu.Height);
            panel_congCu.Location = new Point(kryptonPanel1.Width, 0);
            panel_dieuKhien.Location = new Point(kryptonPanel1.Width +  kryptonPanel1.Location.X, kryptonPanel1.Location.X + kryptonPanel1.Height - panel_dieuKhien.Height);
            panel_dieuKhien.Width = panel_congCu.Width;
            vlc_phatVideo.Location = new Point(panel_congCu.Location.X, panel_congCu.Height);
            vlc_phatVideo.Size = new Size(panel_congCu.Width, panel_dieuKhien.Location.Y - panel_congCu.Height);
            lb_DangPhat.Location = new Point(0, lb_DangPhat.Location.Y);
            lb_tongThoiGian.Location = new Point(panel_dieuKhien.Width - lb_tongThoiGian.Width, lb_tongThoiGian.Location.Y);
            ucThanhTruot_tuaVideo.Location = new Point(lb_DangPhat.Width, ucThanhTruot_tuaVideo.Location.Y);
            ucThanhTruot_tuaVideo.Width = lb_tongThoiGian.Location.X - lb_DangPhat.Width;
            panel_chuaCacNutDieuKhien.Location = new Point((panel_dieuKhien.Width - panel_chuaCacNutDieuKhien.Width) / 2, panel_chuaCacNutDieuKhien.Location.Y);
        }

        private void lb_tien10sMC(object sender, MouseEventArgs e)
        {
            vlc_phatVideo.Rate = (float)1;
            nextSpeed.Text = "";
            prevSpeed.Text = "";
            vlc_phatVideo.Time = vlc_phatVideo.Time + 10000;
        }

        private void lb_quayLai10s_MC(object sender, MouseEventArgs e)
        {
            vlc_phatVideo.Rate = (float)1;
            nextSpeed.Text = "";
            prevSpeed.Text = "";
            vlc_phatVideo.Time = vlc_phatVideo.Time - 10000;
        }

        private void nutDieuKhien_MC(object sender, MouseEventArgs e)
        {
            switch(nextSpeed.Text)
            {
                case "":
                case "0.75":
                case "1X":
                case "0.5":
                case "0.25":
                    nextSpeed.Text = "1.5X";
                    prevSpeed.Text = "";
                    vlc_phatVideo.Rate = (float)1.5;
                    break;
                case "1.5X":
                    nextSpeed.Text = "2X";
                    vlc_phatVideo.Rate = (float)2;
                    break;
                case "2X":
                    nextSpeed.Text = "3X";
                    vlc_phatVideo.Rate = (float)3;
                    break;
                case "3X":
                    nextSpeed.Text = "4X";
                    vlc_phatVideo.Rate = (float)4;
                    break;
                case "4X":
                    nextSpeed.Text = "";
                    vlc_phatVideo.Rate = (float)1;
                    break;
            }
        }

        private void lb_tuaCham_MC(object sender, MouseEventArgs e)
        {
            switch (prevSpeed.Text)
            {
                case "":
                case "1X":
                case "1.5X":
                case "2X":
                case "3X":
                case "4X":
                    prevSpeed.Text = "0.75X";
                    nextSpeed.Text = "";
                    vlc_phatVideo.Rate = (float)0.75;
                    break;
                case "0.75X":
                    prevSpeed.Text = "0.5X";
                    vlc_phatVideo.Rate = (float)0.5;
                    break;
                case "0.5X":
                    prevSpeed.Text = "0.25X";
                    vlc_phatVideo.Rate = (float)0.25;
                    break;
                case "0.25X":
                    prevSpeed.Text = "";
                    vlc_phatVideo.Rate = (float)1;
                    break;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }
    }
}




