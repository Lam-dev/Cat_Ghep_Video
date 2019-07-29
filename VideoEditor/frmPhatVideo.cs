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
                task.Wait(500);
                var file = File.Exists("thum.jpg");
                if (file)
                {
                    try
                    {
                        var imageStream = new FileStream("thum.jpg", FileMode.Open);
                        flowLayOut_chuaCacVideo.Invoke(new MethodInvoker(delegate ()
                        {
                            var videoControl = new ucDaiDienVideo(flowLayOut_chuaCacVideo.Controls.Count, (Bitmap)Bitmap.FromStream(imageStream), path, inputFile.FileInfo.Name , byteToMegabye(inputFile.FileInfo.Length));
                            flowLayOut_chuaCacVideo.Controls.Add(videoControl);
                            videoControl.anhDaiDienClick += new VideoEditor.anhDaiDienVideoClick(chonPhatVideo);
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
            vlc_phatVideo.Play(new FileInfo(e.filePath));
            var video = new MediaFile(e.filePath);
            thongTinVideo = await ffmpeg.GetMetaDataAsync(video);
            lb_tongThoiGian.Text = thongTinVideo.Duration.ToString();
            timer_layThoiGianVideo.Start();
        }

        private void frmPhatVideo_Load(object sender, EventArgs e)
        {
            timer_layThoiGianVideo.Stop();
        }

        private void flowLayOut_chuaCacVideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vlc_phatVideo_Click(object sender, EventArgs e)
        {

        }

        private void timer_layThoiGianVideo_Tick(object sender, EventArgs e)
        {
            if (vlc_phatVideo.IsPlaying)
            {
                var x = vlc_phatVideo.Time;
                lb_DangPhat.Text = mainForm.TimeSpanToString(mainForm.SecondToTimespan(x / 1000));
                ucCuonVideo1.phanTramHienTai = x / thongTinVideo.Duration.TotalMilliseconds * 100;
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
                lb_playPause.Values.Image = Properties.Resources.pause;
               
            }
            else
            {
                lb_playPause.Values.Image = Properties.Resources.play;
               
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
            timer_choVLCphanHoi.Stop();
            new mainForm().ShowDialog();
        }

        private void formResizeEnd(object sender, EventArgs e)
        {
            flowLayOut_chuaCacVideo.Size = new Size(flowLayOut_chuaCacVideo.Width, kryptonPanel1.Height - panel1.Height);
            vlc_phatVideo.Size = new Size((this.Width - kryptonPanel1.Width - 10), kryptonPanel1.Height - 70);
            panel_chuaThanhCuonVaNutNhan.Location = new Point(vlc_phatVideo.Location.X +(vlc_phatVideo.Width - panel_chuaThanhCuonVaNutNhan.Width)/2, kryptonPanel1.Location.Y + kryptonPanel1.Height - panel_chuaThanhCuonVaNutNhan.Height);
        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_gopVideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPhatVideo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
