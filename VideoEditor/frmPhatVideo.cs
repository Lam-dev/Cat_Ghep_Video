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
        ThongTinVideo thongTinVideo;
        List<ucDaiDienVideo> dsVideoControl = new List<ucDaiDienVideo>();
        bool dangGiuCtr = false;
        bool dangChonNhieu = false;
        List<int> dsDangChon = new List<int>();
        Form hinhTheoThoiGian = new FrmAnhTheoThoiGian();
        public frmPhatVideo()
        {
            InitializeComponent();
            ucChoiVideo.dangFit = true;
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
                try
                {

                    var anhDaiDien = ucChoiVideo.LayAnhDaiDienVideo(path);
                    flowLayOut_chuaCacVideo.Invoke(new MethodInvoker(delegate ()
                    {
                        dsVideoControl.Add(new ucDaiDienVideo(flowLayOut_chuaCacVideo.Controls.Count, anhDaiDien, path, inputFile.FileInfo.Name, byteToMegabye(inputFile.FileInfo.Length)));
                        flowLayOut_chuaCacVideo.Controls.Add(dsVideoControl[dsVideoControl.Count - 1]);
                        dsVideoControl[dsVideoControl.Count - 1].anhDaiDienClick += new VideoEditor.anhDaiDienVideoClick(chonPhatVideo);
                        dsVideoControl[dsVideoControl.Count - 1].iMouseMove += new MouseEventHandler(danhSachVideo_MM);
                    }));


                }
                catch
                { }

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
                ucChoiVideo.Play(e.filePath);
                layThongTinVideo(e.filePath);
               
                timer_layThoiGianVideo.Start();
                dangChonNhieu = false;
                dsDangChon.Clear();
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseLeave;
                panel_chonVideoBanDau.Visible = false;
                ucChoiVideo.BackColor = Color.Black;

            }
        }

        private void layThongTinVideo(string video)
        {
            var thoiGianVideo = ucChoiVideo.DoDaiVideo(video);
            var duongDanFile = new FileInfo(video);
            thongTinVideo = new ThongTinVideo()
            {
                Duration = thoiGianVideo,
                TenVideo = duongDanFile.Name.Split('.')[0],
                DuongDanCuaVideo = video,
            };
            lb_tongThoiGian.Text = thongTinVideo.Duration.ToString();
        }
        private void frmPhatVideo_Load(object sender, EventArgs e)
        {
            canChinhForm();
        }

        private void timer_layThoiGianVideo_Tick(object sender, EventArgs e)
        {
            if (ucChoiVideo.dangChay)
            {
                var x = ucChoiVideo.thoiGianDangPhat;
                lb_DangPhat.Text = mainForm.TimeSpanToString(mainForm.SecondToTimespan(x / 1000));
                ucThanhTruot_tuaVideo.phanTramHienTai = x / thongTinVideo.Duration.TotalMilliseconds * 100;
            }
            else
            {
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.playleave;
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
                ucChoiVideo.thoiGianDangPhat = (int)thoiGianTuongUng;
                lb_DangPhat.Text = mainForm.TimeSpanToString(mainForm.SecondToTimespan(thoiGianTuongUng / 1000));
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
            if (ucChoiVideo.dangChay)
            {

                lb_playPause.Values.Image = Properties.Resources.pauseEnter;
                panel_chonVideoBanDau.Visible = false;
            }
            else
            {
                lb_playPause.Values.Image = Properties.Resources.playEnter;

            }

        }

        private void playPauseMouseClick(object sender, MouseEventArgs e)
        {
            if (ucChoiVideo.dangChay)
            {
                ucChoiVideo.Pause();
            }
            else
            {
                ucChoiVideo.Play();
            }
            thayDoiIconPlayPause();
        }

        private void gopVideoClick(object sender, MouseEventArgs e)
        {
            ucChoiVideo.Stop();
            panel_chonVideoBanDau.Visible = true;
            //timer_choVLCphanHoi.Stop();
            var catVideoForm = new mainForm();
            catVideoForm.ShowDialog();
            catVideoForm.Dispose();
        }

        private void formResizeEnd(object sender, EventArgs e)
        {
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
            var danhSachChuanBiXoa = dsVideoControl.FindAll(c => c.lb_duongDanVideo.BackColor == Color.Yellow);
            if (danhSachChuanBiXoa.FindAll(c => c.duongDanVideo == thongTinVideo.DuongDanCuaVideo).Count != 0)
            {
                ucChoiVideo.Stop();
                panel_chonVideoBanDau.Visible = true;
                ucChoiVideo.BackColor = Color.MediumTurquoise;

            }
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

        private void thayDoiGiaTriAmThanh(object sender, cuonVideoArgs e)
        {

            ucChoiVideo.Audio.Volume = (int)e.phanTramThanhCuon;
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
            ucChoiVideo.Stop();
            panel_chonVideoBanDau.Visible = true;
            ucChoiVideo.BackColor = Color.MediumTurquoise; 


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
                    ucChoiVideo.Play(danhSachPath[0]);
                    panel_chonVideoBanDau.Visible = false;
                    layThongTinVideo(danhSachPath[0]);
                    timer_layThoiGianVideo.Start();
                    lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseLeave;
                    ucChoiVideo.BackColor = Color.Black;
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

        private void canChinhForm()
        {
            panel1.Location = new Point(0, 0);
            flowLayOut_chuaCacVideo.Size = new Size(kryptonPanel1.Width, kryptonPanel1.Height - panel1.Height);
            panel_congCu.Size = new Size(this.Width - kryptonPanel1.Width, panel_congCu.Height);
            panel_congCu.Location = new Point(kryptonPanel1.Width, 0);
            panel_dieuKhien.Location = new Point(kryptonPanel1.Width + kryptonPanel1.Location.X, kryptonPanel1.Location.X + kryptonPanel1.Height - panel_dieuKhien.Height);
            panel_dieuKhien.Width = panel_congCu.Width;
            ucChoiVideo.Location = new Point(panel_congCu.Location.X, panel_congCu.Height);
            ucChoiVideo.Size = new Size(panel_congCu.Width - 15, panel_dieuKhien.Location.Y - panel_congCu.Height);
            lb_DangPhat.Location = new Point(0, lb_DangPhat.Location.Y);
            lb_tongThoiGian.Location = new Point(panel_dieuKhien.Width - lb_tongThoiGian.Width, lb_tongThoiGian.Location.Y);
            ucThanhTruot_tuaVideo.Location = new Point(lb_DangPhat.Width, ucThanhTruot_tuaVideo.Location.Y);
            ucThanhTruot_tuaVideo.Width = lb_tongThoiGian.Location.X - lb_DangPhat.Width;
            panel_chuaCacNutDieuKhien.Location = new Point((panel_dieuKhien.Width - panel_chuaCacNutDieuKhien.Width) / 2, panel_chuaCacNutDieuKhien.Location.Y);
            ucChoiVideo.ChuyenKinhLupRaGiua();
            ucChoiVideo.ChuyenKhungNhinToanCanhXuongGoc();
            ucChoiVideo.KichThuocThayDoi();
        }

        private void lb_tien10sMC(object sender, MouseEventArgs e)
        {
            ucChoiVideo.tocDoPhat = (float)1;
            nextSpeed.Text = "";
            prevSpeed.Text = "";
            ucChoiVideo.thoiGianDangPhat = ucChoiVideo.thoiGianDangPhat + 10000;
        }

        private void lb_quayLai10s_MC(object sender, MouseEventArgs e)
        {
            ucChoiVideo.tocDoPhat = (float)1;
            nextSpeed.Text = "";
            prevSpeed.Text = "";
            ucChoiVideo.thoiGianDangPhat = ucChoiVideo.thoiGianDangPhat - 10000;
        }

        private void nutDieuKhien_MC(object sender, MouseEventArgs e)
        {
            switch (nextSpeed.Text)
            {
                case "":
                case "0.75":
                case "1X":
                case "0.5":
                case "0.25":
                    nextSpeed.Text = "1.5X";
                    prevSpeed.Text = "";
                    ucChoiVideo.tocDoPhat = (float)1.5;
                    break;
                case "1.5X":
                    nextSpeed.Text = "2X";
                    ucChoiVideo.tocDoPhat = (float)2;
                    break;
                case "2X":
                    nextSpeed.Text = "3X";
                    ucChoiVideo.tocDoPhat = (float)3;
                    break;
                case "3X":
                    nextSpeed.Text = "4X";
                    ucChoiVideo.tocDoPhat = (float)4;
                    break;
                case "4X":
                    nextSpeed.Text = "";
                    ucChoiVideo.tocDoPhat = (float)1;
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
                    ucChoiVideo.tocDoPhat = (float)0.75;
                    break;
                case "0.75X":
                    prevSpeed.Text = "0.5X";
                    ucChoiVideo.tocDoPhat = (float)0.5;
                    break;
                case "0.5X":
                    prevSpeed.Text = "0.25X";
                    ucChoiVideo.tocDoPhat = (float)0.25;
                    break;
                case "0.25X":
                    prevSpeed.Text = "";
                    ucChoiVideo.tocDoPhat = (float)1;
                    break;
            }
        }

        private void ZoomlenME(object sender, EventArgs e)
        {
            btnZoomLen.Values.Image = VideoEditor.Properties.Resources.zoomLenEnter;
        }

        private void ZoomLenML(object sender, EventArgs e)
        {
            btnZoomLen.Values.Image = VideoEditor.Properties.Resources.zoomLen;
        }

        private void ZoomControlME(object sender, EventArgs e)
        {
            zoomControl.Values.Image = VideoEditor.Properties.Resources.zoomEnter;
        }

        private void ZoomControlML(object sender, EventArgs e)
        {
            zoomControl.Values.Image = VideoEditor.Properties.Resources.zoom;
        }

        private void btnZoomLenMC(object sender, MouseEventArgs e)
        {
           
            ucChoiVideo.batKinhLup = !ucChoiVideo.batKinhLup;
        }

        private void btnZoomControlMC(object sender, MouseEventArgs e)
        {
            ucChoiVideo.batZoomControl = !ucChoiVideo.batZoomControl;
        }

        private void btnChupManHinhME(object sender, EventArgs e)
        {
            btnChupManHinh.Values.Image = VideoEditor.Properties.Resources.cameraMouseEnter;
        }

        private void btnChupManHinhML(object sender, EventArgs e)
        {
            btnChupManHinh.Values.Image = VideoEditor.Properties.Resources.camera;
        }

        private void lb_gopVideoME(object sender, EventArgs e)
        {
            lb_gopVideo.Values.Image = VideoEditor.Properties.Resources.mergeMouseEnter;
        }

        private void lb_gopVideoML(object sender, EventArgs e)
        {
            lb_gopVideo.Values.Image = VideoEditor.Properties.Resources.merge;
        }

        private void btnFitFillME(object sender, EventArgs e)
        {
            if (ucChoiVideo.dangFit)
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fitMouseEnter;
            else
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fillMouseEnter;
        }

        private void btnFitFillML(object sender, EventArgs e)
        {
            if (ucChoiVideo.dangFit)
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fit;
            else
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fill;
        }

        private void btnFitFillMC(object sender, MouseEventArgs e)
        {
            if (ucChoiVideo.dangFit)
            {
                ucChoiVideo.dangFit = false;
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fitMouseEnter;
            }
            else
            {
                ucChoiVideo.dangFit = true;
                btnFitFill.Values.Image = VideoEditor.Properties.Resources.fillMouseEnter;
            }
        }

        #region
        private void tuaNhanh_ML(object sender, EventArgs e)
        {
            lb_tuaNhanh.Values.Image = VideoEditor.Properties.Resources.speedUpMouseLeave;
        }

        private void tien10s_ML(object sender, EventArgs e)
        {
            lb_tien10s.Values.Image = VideoEditor.Properties.Resources.next10sMouseLeave;
        }

        private void lb_stop_ML(object sender, EventArgs e)
        {
            lb_stop.Values.Image = VideoEditor.Properties.Resources.stopLeave;
        }

        private void lb_playPause_ML(object sender, EventArgs e)
        {
            if (ucChoiVideo.dangChay)
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseLeave;
            else
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.playleave;
            return;
        }

        private void lb_lui10s_ML(object sender, EventArgs e)
        {
            lb_quayLai10s.Values.Image = VideoEditor.Properties.Resources.pre10sMouseLeave;
        }

        private void lb_tuaCham_ML(object sender, EventArgs e)
        {
            lb_tuaCham.Values.Image = VideoEditor.Properties.Resources.speedDownMouseLeave;
        }

        private void lb_themVideo_ML(object sender, EventArgs e)
        {
            lb_themVideo.Values.Image = VideoEditor.Properties.Resources.addImage;
        }

        private void lb_xoaDaiDien_ML(object sender, EventArgs e)
        {
            lb_xoaDaiDien.Values.Image = VideoEditor.Properties.Resources.Webp_net_resizeimage__3_;
        }

        private void tuaNhanh_ME(object sender, EventArgs e)
        {
            lb_tuaNhanh.Values.Image = VideoEditor.Properties.Resources.speedUpMouseEnter;
        }

        private void tien10s_ME(object sender, EventArgs e)
        {
            lb_tien10s.Values.Image = VideoEditor.Properties.Resources.next10sMouseEnter;
        }

        private void lb_stop_ME(object sender, EventArgs e)
        {
            lb_stop.Values.Image = VideoEditor.Properties.Resources.stopEnter;
        }

        private void lb_playPause_ME(object sender, EventArgs e)
        {
            if (ucChoiVideo.dangChay)
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.pauseEnter;
            else
                lb_playPause.Values.Image = VideoEditor.Properties.Resources.playEnter;
        }

        private void lb_lui10s_ME(object sender, EventArgs e)
        {
            lb_quayLai10s.Values.Image = VideoEditor.Properties.Resources.pre10sMouseEnter;
        }

        private void lb_themVideo_ME(object sender, EventArgs e)
        {
            lb_themVideo.Values.Image = VideoEditor.Properties.Resources.addImageLeave;
        }

        private void lb_xoaDaiDien_ME(object sender, EventArgs e)
        {
            lb_xoaDaiDien.Values.Image = VideoEditor.Properties.Resources.Webp_net_resizeimage_leave;
        }

        private void lb_tuaCham_ME(object sender, EventArgs e)
        {
            lb_tuaCham.Values.Image = VideoEditor.Properties.Resources.speedDownMouseEnter;
        }
        #endregion

        private void chupAnhMC(object sender, MouseEventArgs e)
        {
            var gioChup = DateTime.Now;
            ucChoiVideo.ChupHinh($"{thongTinVideo.TenVideo}_{gioChup.Hour}_{gioChup.Minute}_{gioChup.Second}_{gioChup.Millisecond}.jpg");
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            hinhTheoThoiGian.Show();
            hinhTheoThoiGian.TopLevel = true;
            
        }

        private void timer_videoDungPhat_chuyenVideo_Tick(object sender, EventArgs e)
        {

        }
    }

    public class ThongTinVideo
    {
        public TimeSpan Duration;
        public string TenVideo;
        public string DuongDanCuaVideo;

    }
}