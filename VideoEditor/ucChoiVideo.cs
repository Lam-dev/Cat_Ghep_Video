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
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

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
        bool _khungZoomDuocGiu = false;
        bool _dangFit = true;

        public bool dangFit
        {
            get
            {
                return _dangFit;
            }

            set
            {
                _dangFit = value;
                KichThuocThayDoi();
            }
        }
        Rect khungZoom;
        public bool batZoomControl
        {
            get
            {
                return _batZoomControl;
            }
            set
            {
                try
                {

                    khungZoom = new Rect(0, 0, picbox_nhinToanCanh.Width, picbox_nhinToanCanh.Height);
                    if (value == false)
                    {
                        if (!picBox_hienThiVideo.InvokeRequired)
                        {
                            _batZoomControl = value;
                            picbox_nhinToanCanh.Visible = value;
                        }
                        else { }

                    }
                    else
                    {
                        _batZoomControl = value;
                        picbox_nhinToanCanh.Visible = value;
                    }
                    if(_dangFit)
                    {
                        dangFit = false;
                    }
                }
                catch { }

            }

        }
        public bool batKinhLup
        {
            set
            {
                if (value == false)
                    if (!picBox_hienThiVideo.InvokeRequired)
                    {
                        picBox_kinhLup.Visible = value;
                        _batKinhLup = value;
                    }
                    else
                    { }
                else
                {
                    picBox_kinhLup.Visible = value;
                    _batKinhLup = value;
                }
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

        public TimeSpan DoDaiVideo(string duongDan)
        {
            VideoCapture video = new VideoCapture(duongDan);
            var doDai = video.FrameCount / video.Fps * 1000;
            return new TimeSpan((long)(doDai * 10000));
        }
        public void Play(string duongDan)
        {
            try
            {
                _duongDanVideoDangPhat = duongDan;
                timer_thoiGianChuyenKhungHinh.Stop();
                timer_choVideoDungPhat_chuyenVideo.Start();
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
            khungHinhDangXem = null;
            picBox_kinhLup.Visible = false;
            picbox_nhinToanCanh.Visible = false;
        }
        private void Bgw_choiVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                var khungHinh = new Mat();
                _videoDangPhat.Read(khungHinh);
                khungHinhDangXem = khungHinh.Resize(new OpenCvSharp.Size(picBox_hienThiVideo.Width, picBox_hienThiVideo.Height), 0, 0, InterpolationFlags.Linear);

                if (_batZoomControl)
                {
                    HienThiKhungNhin(khungHinhDangXem);
                    picBox_hienThiVideo.ImageIpl = new Mat(khungHinhDangXem, new Rect(khungZoom.X * 4, khungZoom.Y * 4, khungZoom.Width * 4, khungZoom.Height * 4));
                }
                else
                {
                    if(timer_thongBaoDaChupHinh.Enabled)
                        OpenCvSharp.Cv2.PutText(khungHinhDangXem, " Da chup mot anh ", new OpenCvSharp.Point(100, 50), HersheyFonts.HersheyDuplex, 1, Scalar.Yellow, 1);

                    //Cv2.Flip(khungHinhDangXem, khungHinhDangXem, FlipMode.Y);
                    picBox_hienThiVideo.Invoke(new MethodInvoker(delegate
                    {
                        picBox_hienThiVideo.ImageIpl = khungHinhDangXem;
                    }));
                   
                }
                if (_batKinhLup)
                    LayHinhChoKinhLup();

            }
            catch (Exception ex)
            {
                timer_thoiGianChuyenKhungHinh.Stop();
                Console.WriteLine(ex);

            }
        }


        private void Timer_thoiGianChuyenKhungHinh_Tick(object sender, EventArgs e)
        {
            if (!bgw_choiVideo.IsBusy)
            {
                bgw_choiVideo.RunWorkerAsync();
                _thoiGianDangPhat = _videoDangPhat.PosMsec;
            }
            else {
            }
        }

        public void ChupHinh(string tenFile)
        {
            try
            {
                if (!bgw_luuHinhDuocChup.IsBusy)
                {
                    bgw_luuHinhDuocChup.RunWorkerAsync(argument: tenFile);
                    timer_thongBaoDaChupHinh.Start();
                }
            }
            catch { }
        }
        public struct _Audio
        {
            public int Volume;
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
                    if (!bgw_choiVideo.IsBusy)
                    {
                        var viTriChuot = picBox_hienThiVideo.PointToClient(Cursor.Position);
                        picBox_kinhLup.Location = new Point(viTriChuot.X - picBox_kinhLup.Width / 2, viTriChuot.Y - picBox_kinhLup.Height / 2);
                        if (!bgw_choiVideo.IsBusy)
                            LayHinhChoKinhLup();
                    }
                }
            }
            catch { }
        }

        public void ChuyenKinhLupRaGiua()
        {
            picBox_kinhLup.Location = new Point(picBox_hienThiVideo.Width / 2, picBox_hienThiVideo.Height / 2);
            picBox_kinhLup.Size = new Size((int)(this.Width / 5), (int)(this.Width / 5));
           
        }

        public void ChuyenKhungNhinToanCanhXuongGoc()
        {
            picbox_nhinToanCanh.Size = new Size(picBox_hienThiVideo.Width / 4, picBox_hienThiVideo.Height / 4);
            picbox_nhinToanCanh.Location = new Point(this.Width - picbox_nhinToanCanh.Width , this.Height- picbox_nhinToanCanh.Height);
            khungZoom = new Rect(0, 0, picbox_nhinToanCanh.Width, picbox_nhinToanCanh.Height);
        }

        private void LanChuot(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                if (phanTramKhungZoom < 10)
                    return;
                phanTramKhungZoom = phanTramKhungZoom - 6;
                var khungZoomWidth = (int)(picbox_nhinToanCanh.Width * phanTramKhungZoom / 100);
                var khungZoomHeight = (int)(picbox_nhinToanCanh.Height * phanTramKhungZoom / 100);
                int khungZoomX;
                khungZoomX = (int)(khungZoom.X + picbox_nhinToanCanh.Width * 6 / 200);
                int khungZoomY;
                khungZoomY = (int)(khungZoom.Y + picbox_nhinToanCanh.Height * 6 / 200);
                khungZoom = new Rect(khungZoomX, khungZoomY, khungZoomWidth, khungZoomHeight);

            }
            if (e.Delta > 0)
            {
                
                phanTramKhungZoom = phanTramKhungZoom + 6;
                if (phanTramKhungZoom > 100)
                {
                    phanTramKhungZoom = 100;
                    return;
                }
                var khungZoomWidth = (int)(picbox_nhinToanCanh.Width * phanTramKhungZoom / 100);
                var khungZoomHeight = (int)(picbox_nhinToanCanh.Height * phanTramKhungZoom / 100);
                int khungZoomX;
                if (khungZoom.X > 0)
                    if (khungZoom.X + khungZoomWidth >= picbox_nhinToanCanh.Width)
                        khungZoomX = (int)(picbox_nhinToanCanh.Width - khungZoomWidth);
                    else
                        khungZoomX = (int)(khungZoom.X - picbox_nhinToanCanh.Width * 6 / 200);
                else khungZoomX = 0;
                
                
                int khungZoomY;
                if (khungZoom.Y > 0)
                    if (khungZoom.Y + khungZoomHeight >= picbox_nhinToanCanh.Height)
                        khungZoomY = (int)(picbox_nhinToanCanh.Height - khungZoomHeight);
                    else
                        khungZoomY = (int)(khungZoom.Y - picbox_nhinToanCanh.Height * 6 / 200);
                else khungZoomY = 0;
                
                khungZoom = new Rect(khungZoomX, khungZoomY, khungZoomWidth, khungZoomHeight);
            }
            try
            {
                if (!timer_thoiGianChuyenKhungHinh.Enabled)
                {
                    HienThiKhungNhin(khungHinhDangXem);
                    picBox_hienThiVideo.ImageIpl = new Mat(khungHinhDangXem, new Rect(khungZoom.X * 4, khungZoom.Y * 4, khungZoom.Width * 4, khungZoom.Height * 4));
                }
            }
            catch { }
        }
        private void LayHinhChoKinhLup()
        {
            if(!bgw_layHinhChoKinhLup.IsBusy)
            {
                bgw_layHinhChoKinhLup.RunWorkerAsync();
            }
        }

        public void KichThuocThayDoi()
        {
            try
            {
                if (_dangFit)
                {
                    picBox_hienThiVideo.Dock = DockStyle.None;
                    double tiLeDaiRongVideo = (double)_videoDangPhat.FrameWidth / (double)_videoDangPhat.FrameHeight;
                    if (tiLeDaiRongVideo > (double)this.Width / (double)this.Height)
                    {
                        picBox_hienThiVideo.Size = new Size(this.Width, (int)(this.Width / tiLeDaiRongVideo));
                        picBox_hienThiVideo.Location = new Point(0, (int)((this.Height - picBox_hienThiVideo.Height) / 2));
                    }
                    else
                    {
                        picBox_hienThiVideo.Size = new Size((int)(this.Height * tiLeDaiRongVideo), this.Height);
                        picBox_hienThiVideo.Location = new Point((int)((this.Width - picBox_hienThiVideo.Width) / 2), 0);
                    }
                }
                else
                {
                    picBox_hienThiVideo.Dock = DockStyle.Fill;
                }
                ChuyenKhungNhinToanCanhXuongGoc();
            }
            catch { }
        }
        private void HienThiKhungNhin(Mat khungHinh)
        {
            var khungHinhToanCanh = khungHinh.Resize(new OpenCvSharp.Size(picbox_nhinToanCanh.Width, picbox_nhinToanCanh.Height), 0, 0, InterpolationFlags.Linear);
            //var khungZoom = new Rect(0, 0, (int)(picbox_nhinToanCanh.Width * phanTramKhungZoom /100), (int)(picbox_nhinToanCanh.Height * phanTramKhungZoom / 100));
            khungHinhToanCanh.Rectangle(khungZoom, Scalar.Yellow, 1);
            picbox_nhinToanCanh.ImageIpl = khungHinhToanCanh;
            
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
                picBox_kinhLup.Invoke(new MethodInvoker(delegate
                {
                    picBox_kinhLup.Image = BitmapConverter.ToBitmap(hinhDuocCat);
                }));
                hinhDuocCat.Dispose();

            }
            catch { }
        }

        private void picBox_nhinToanCanhMM(object sender, MouseEventArgs e)
        {
            try
            {
                if (_khungZoomDuocGiu)
                {
                    var viTriConTro = picbox_nhinToanCanh.PointToClient(Cursor.Position);
                    var khungZoomWidth = (int)(picbox_nhinToanCanh.Width * phanTramKhungZoom / 100);
                    var khungZoomHeight = (int)(picbox_nhinToanCanh.Height * phanTramKhungZoom / 100);
                    var khungZoomX = viTriConTro.X - khungZoomWidth / 2;
                    if (khungZoomX <= 0) khungZoomX = 0;
                    if (khungZoomX + khungZoomWidth >= picbox_nhinToanCanh.Width) khungZoomX = picbox_nhinToanCanh.Width - khungZoomWidth;
                    var khungZoomY = viTriConTro.Y - khungZoomHeight / 2;
                    if (khungZoomY <= 0) khungZoomY = 0;
                    if (khungZoomY + khungZoomHeight >= picbox_nhinToanCanh.Height) khungZoomY = picbox_nhinToanCanh.Height - khungZoomHeight;
                    khungZoom = new Rect(khungZoomX, khungZoomY, khungZoomWidth, khungZoomHeight);
                    if (!timer_thoiGianChuyenKhungHinh.Enabled)
                    {
                        HienThiKhungNhin(khungHinhDangXem);
                        picBox_hienThiVideo.ImageIpl = new Mat(khungHinhDangXem, new Rect(khungZoom.X * 4, khungZoom.Y * 4, khungZoom.Width * 4, khungZoom.Height * 4));
                    }
                }
            }
            catch (Exception a)
            {
                Console.Write(a);
            }
        }

        private void picbox_nhinToanCanhMD(object sender, MouseEventArgs e)
        {
            _khungZoomDuocGiu = true;
        }

        private void picBox_nhinToanCanhMU(object sender, MouseEventArgs e)
        {
            _khungZoomDuocGiu = false;
        }

        private void timer_thongBaoDaChupHinh_Tick(object sender, EventArgs e)
        {
            timer_thongBaoDaChupHinh.Stop();
        }

        
        private void bgw_luuHinhDuocChup_DoWork(object sender, DoWorkEventArgs e)
        {
            khungHinhDangXem.SaveImage((string)e.Argument);
           
                
            
            
        }

        private void timer_choVideoDungPhat_chuyenVideo_Tick(object sender, EventArgs e)
        {
            if (!bgw_choiVideo.IsBusy)
            {
                if (_videoDangPhat != null)
                {
                    _videoDangPhat.Dispose();
                    _videoDangPhat = null;
                }
                _videoDangPhat = new VideoCapture(_duongDanVideoDangPhat);
                KichThuocThayDoi();
                _doDaiVideo = _videoDangPhat.FrameCount / _videoDangPhat.Fps * 1000;
                timer_thoiGianChuyenKhungHinh.Interval = (int)(1 / _videoDangPhat.Fps * 1000);
                timer_thoiGianChuyenKhungHinh.Start();
                if (timer_thoiGianChuyenKhungHinh.Enabled) _dangChay = true;
                else _dangChay = false;
                timer_choVideoDungPhat_chuyenVideo.Stop();
            }
        }
    }
}
