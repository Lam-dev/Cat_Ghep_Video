using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public delegate void cuonVideoHandle(object sender, cuonVideoArgs e);
    public partial class ucCuonVideo : UserControl
    {
        public ucCuonVideo()
        {
            InitializeComponent();
            
        }
   
        private int _doDaiTruotCuaDuongRay { get; set; }
        private double _phanTramHienTai;
        public double phanTramHienTai
        {
            get
            {
                return _phanTramHienTai;
            }
            set
            {
                panel_diemDangPhat.Location = new Point((int)(_doDaiTruotCuaDuongRay * value / 100));
                _phanTramHienTai = value;
            }
        }
        private bool mouseUp = false;

        private void diemPhat_MD(object sender, MouseEventArgs e)
        {
            mouseUp = true;
        }

        private void diemPhat_MU(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        public event cuonVideoHandle thanhCuonDangTruot;
        private void diemPhat_MM(object sender, MouseEventArgs e)
        {
            if (mouseUp)
            {
                var mousePos = panel_duongRay.PointToClient(Cursor.Position).X;
                panel_diemDangPhat.Location = new Point(mousePos - panel_diemDangPhat.Width / 2);
                if (mousePos - panel_diemDangPhat.Width / 2 < 0)
                {
                    panel_diemDangPhat.Location = new Point(0);
                    return;
                }
                if (mousePos + panel_diemDangPhat.Width / 2 > panel_duongRay.Width)
                {
                    panel_diemDangPhat.Location = new Point(panel_duongRay.Width - panel_diemDangPhat.Width);
                    return;
                }
                var phanTramThanhCuon = (double)panel_diemDangPhat.Location.X / (double)(_doDaiTruotCuaDuongRay) * 100;
                cuonVideoHandle truotThanhCuon = thanhCuonDangTruot;
                var arg = new cuonVideoArgs()
                {
                    phanTramThanhCuon = phanTramThanhCuon,
            
                };
                truotThanhCuon(this, arg);
            }
        }

        private void ucCuonVideo_Load(object sender, EventArgs e)
        {
            _doDaiTruotCuaDuongRay = panel_duongRay.Width - panel_diemDangPhat.Width - 1;
        }

    
    }
    public class cuonVideoArgs : EventArgs
    {
        public double phanTramThanhCuon { get; set; }
    }
}
