using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace VideoEditor
{
    public partial class ucChoiVideo : UserControl
    {
        bool _dangGiuKinhLup = false;
        string _duongDanVideoDangPhat;
        VideoCapture _videoDangPhat;
        double _doDaiVideo;
        int _thoiGianDangPhat = 0;
        bool _dangChay = false;
        float _tocDoPhat = 1;
        Mat khungHinhDangXem;
        public _Audio Audio = new _Audio();
        bool _batKinhLup = false;
        bool _batZoomControl = false;
        int phanTramKhungZoom = 100;
        public bool batZoomControl
        {
            get
            {
                return _batZoomControl;
            }
            set
            {
                _batZoomControl = value;
                picbox_nhinToanCanh.Visible = value;

            }

        }
        public bool batKinhLup
        {
            set
            {
                picBox_kinhLup.Visible = value;
                _batKinhLup = value;
            }
            get
            {
                return _batKinhLup;
            }
        }
        public bool dangChay { get { return timer_thoiGianChuyenKhungHinh.Enabled; } }

        public float tocDoPhat
        {
            get { return _tocDoPhat; }
            set
            {
                try
                {
                    _tocDoPhat = value;
                    var tocDoHienTai = timer_thoiGianChuyenKhungHinh.Interval;
                    timer_thoiGianChuyenKhungHinh.Interval = (int)((1 / _videoDangPhat.Fps * 1000) / value);
                }
                catch { }
            }
        }
        public double doDaiVideo
        {
            get { return _doDaiVideo; }
        }
        public int thoiGianDangPhat
        {
            get
            {
                return _thoiGianDangPhat;
            }
            set
            {
                _thoiGianDangPhat = value;
                try
                {
                    _videoDangPhat.PosMsec = _thoiGianDangPhat;
                }
                catch
                { }
            }
        }
        public ucChoiVideo()
        {
            InitializeComponent();
            timer_thoiGianChuyenKhungHinh.Stop();
            picBox_hienThiVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            Audio.Volume = 0;
            this.picbox_nhinToanCanh.MouseWheel += new MouseEventHandler(LanChuot);
        }


        public void Play(string duongDan)
        {
            try
            {
                _duongDanVideoDangPhat = duongDan;
                _videoDangPhat = new VideoCapture(_duongDanVideoDangPhat);
                _doDaiVideo = _videoDangPhat.FrameCount / _videoDangPhat.Fps * 1000;
                timer_thoiGianChuyenKhungHinh.Interval = (int)(1 / _videoDangPhat.Fps * 1000);
                timer_thoiGianChuyenKhungHinh.Start();
                if (timer_thoiGianChuyenKhungHinh.Enabled) _dangChay = true;
                else _dangChay = false;
            }
            catch { }
        }

        public void Play()
        {
            if (_videoDangPhat != null)
            {
                timer_thoiGianChuyenKhungHinh.Start();
                if (timer_thoiGianChuyenKhungHinh.Enabled) _dangChay = true;
                else _dangChay = false;
            }
        }
        public void Pause()
        {
            timer_thoiGianChuyenKhungHinh.Stop();
            if (timer_thoiGianChuyenKhungHinh.Enabled) _dangChay = true;
            else _dangChay = false;
        }

        public void Stop()
        {
            timer_thoiGianChuyenKhungHinh.Stop();
            _videoDangPhat = null;
            picBox_hienThiVideo.ImageIpl = null;
        }
        private void Bgw_choiVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                var khungHinh = new Mat();
                _videoDangPhat.Read(khungHinh);
                khungHinhDangXem = khungHinh.Resize(new OpenCvSharp.Size(picBox_hienThiVideo.Width, picBox_hienThiVideo.Height), 0, 0, InterpolationFlags.Linear);
                picBox_hienThiVideo.ImageIpl = khungHinhDangXem;
                if (_batZoomControl)
                    HienThiKhungNhin(khungHinhDangXem);
                if (_batKinhLup)
                    LayHinhChoKinhLup();
            }
            catch
            {
                timer_thoiGianChuyenKhungHinh.Stop(); 
            }
        }


        private void Timer_thoiGianChuyenKhungHinh_Tick(object sender, EventArgs e)
        {
            if (!bgw_choiVideo.IsBusy)
            {
                bgw_choiVideo.RunWorkerAsync();
                _thoiGianDangPhat = _videoDangPhat.PosMsec;
            }
        }

        private void picBoxSizeChanged(object sender, EventArgs e)
        {

        }

        public struct _Audio
        {
            public int Volume;
        }

        private void picBox_hienThiVideo_Click(object sender, EventArgs e)
        {
        }

        private void KinhLupMD(object sender, MouseEventArgs e)
        {
            try
            {
                timer_thoiGianChuyenKhungHinh.Stop();
                _dangGiuKinhLup = true;
            }
            catch { }
        }

        private void KinhLupMU(object sender, MouseEventArgs e)
        {
            try
            {
                if (_dangChay) timer_thoiGianChuyenKhungHinh.Start();
                else timer_thoiGianChuyenKhungHinh.Stop();
                _dangGiuKinhLup = false;
            }
            catch { }
        }

        private void KinhLupMM(object sender, MouseEventArgs e)
        {
            try
            {
                if (_dangGiuKinhLup)
                {
                    var viTriChuot = picBox_hienThiVideo.PointToClient(Cursor.Position);
                    picBox_kinhLup.Location = new System.Drawing.Point(viTriChuot.X - picBox_kinhLup.Width / 2, viTriChuot.Y - picBox_kinhLup.Height / 2);
                    if (!bgw_choiVideo.IsBusy)
                        LayHinhChoKinhLup();
                }
            }
            catch { }
        }

        public void ChuyenKinhLupRaGiua()
        {
            picBox_kinhLup.Location = new System.Drawing.Point(picBox_hienThiVideo.Width / 2, picBox_hienThiVideo.Height / 2);
            picBox_kinhLup.Size = new System.Drawing.Size((int)(this.Width / 5), (int)(this.Width / 5));
           
        }

        public void ChuyenKhungNhinToanCanhXuongGoc()
        {
            picbox_nhinToanCanh.Size = new System.Drawing.Size(this.Width / 4, this.Height / 4);
            picbox_nhinToanCanh.Location = new System.Drawing.Point(picBox_hienThiVideo.Width - picbox_nhinToanCanh.Width, picBox_hienThiVideo.Height - picbox_nhinToanCanh.Height);
            
        }

        private void LanChuot(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                if (phanTramKhungZoom < 10)
                    return;
                phanTramKhungZoom = phanTramKhungZoom - 3;
                
            }
            if (e.Delta > 0)
            {
                
                phanTramKhungZoom = phanTramKhungZoom + 3;
                if (phanTramKhungZoom > 100) phanTramKhungZoom = 100;
            }
        }
        private void LayHinhChoKinhLup()
        {
            if(!bgw_layHinhChoKinhLup.IsBusy)
            {
                bgw_layHinhChoKinhLup.RunWorkerAsync();
            }
        }

        
        private Rect HienThiKhungNhin(Mat khungHinh)
        {
            var khungHinhToanCanh = khungHinh.Resize(new OpenCvSharp.Size(picbox_nhinToanCanh.Width, picbox_nhinToanCanh.Height), 0, 0, InterpolationFlags.Linear);
            var khungZoom = new Rect(0, 0, (int)(picbox_nhinToanCanh.Width * phanTramKhungZoom /100), (int)(picbox_nhinToanCanh.Height * phanTramKhungZoom / 100));
            khungHinhToanCanh.Rectangle(khungZoom, Scalar.Yellow, 1);
            picbox_nhinToanCanh.ImageIpl = khungHinhToanCanh;
            return khungZoom;
        }

        private void picbox_nhinToanCanhME(object sender, EventArgs e)
        {
            picbox_nhinToanCanh.Select();
        }

        public Bitmap LayAnhDaiDienVideo(string duongDanTep)
        {
            try
            {
                var video = new VideoCapture(duongDanTep);
                Mat anhDaiDien = new Mat();
                video.Read(anhDaiDien);
                return BitmapConverter.ToBitmap(anhDaiDien);
            }
            catch
            {
                return null;
            }

        }

        private void bgw_layHinhChoKinhLup_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Rect khungCat = new Rect(picBox_kinhLup.Location.X + picBox_kinhLup.Width / 3, picBox_kinhLup.Location.Y + picBox_kinhLup.Width / 3, picBox_kinhLup.Width / 3, picBox_kinhLup.Width / 3);
                Mat hinhDuocCat = new Mat(khungHinhDangXem, khungCat);
                hinhDuocCat = hinhDuocCat.Resize(new OpenCvSharp.Size(picBox_kinhLup.Width, picBox_kinhLup.Height), 0, 0, InterpolationFlags.Linear);
                picBox_kinhLup.Image = BitmapConverter.ToBitmap(hinhDuocCat);
            }
            catch { }
        }
    }
}
