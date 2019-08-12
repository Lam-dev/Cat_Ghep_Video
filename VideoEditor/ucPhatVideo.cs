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
using System.Runtime.InteropServices;



namespace VideoEditor
{

    public partial class ucPhatVideo : UserControl
    {
        VideoCapture _videoDangPhat;
        private bool _dangChay;
        private int _thoiGianDangPhat;
        private int _doDaiVideo;
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
                    Console.WriteLine("1111");
                }
                catch (Exception e)
                {
                    Console.WriteLine("eeeeeeeeeeeee{0}", e);
                }
            }
        }

        public int doDaiVideo
        {
            get { return _doDaiVideo; }
        }
        public bool dangChay
        {
            get { return bgw_chayVideo.IsBusy; }
            set { _dangChay = value; }
        }

        public ucPhatVideo()
        {
            InitializeComponent();

        }

        public void Pause()
        {
            bgw_chayVideo.CancelAsync();
            _dangChay = false;
            
        }

        public void Play()
        {
            bgw_chayVideo.RunWorkerAsync();
            if (bgw_chayVideo.IsBusy)
                _dangChay = true;
            
        }
        public void Play(string duongDanFile)
        {
            _videoDangPhat = new VideoCapture(duongDanFile);
            _doDaiVideo = (int)(_videoDangPhat.FrameCount / _videoDangPhat.Fps);
            if (bgw_chayVideo.IsBusy)
            { }
            else
            {
                bgw_chayVideo.RunWorkerAsync();
                if (bgw_chayVideo.IsBusy)
                    _dangChay = true;

            }
        }

        
        public void Stop()
        {
            bgw_chayVideo.CancelAsync();
            _dangChay = false;
        }

        private void bgw_chayVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                Mat khungHinh = new Mat();
                _videoDangPhat.Read(khungHinh);
                picBoxHienThiVideo.ImageIpl = khungHinh;
                System.Threading.Thread.Sleep(40);
                if (bgw_chayVideo.CancellationPending)
                    break;
             
            }
            
        }
    }
}
