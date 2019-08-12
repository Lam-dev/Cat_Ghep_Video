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
    public delegate void NhanNhaNutCuonHandle(object sender, NutCuonDuocNhanArgs NutCuonArgs);
    public partial class ucThanhTruot : UserControl
    {
        public ucThanhTruot()
        {
            InitializeComponent();
        }
        private bool mouseHold = false;
        private int bienDoTruot;
        private Color _mauCuaDiem = Color.Red;
        private Color _mauDuongRay = Color.White;
        private void ucThanTruot_load(object sender, EventArgs e)
        {
            tinhKichThuoc();
        }
        public Color mauCuaDiem
        {
            get { return _mauCuaDiem; }
            set
            {
                _mauCuaDiem = value;
                panel_daQua.BackColor = _mauCuaDiem;
                panel_redPoint.BackColor = _mauCuaDiem;
            }
        }
        public Color mauDuongRay
        {
            get { return _mauDuongRay; }
            set
            {
                _mauDuongRay = value;
                panel_duongRay.BackColor = _mauDuongRay;

            }
        }
        private double _phanTramHienTai;
        public double phanTramHienTai
        {
            get
            {
                return _phanTramHienTai;
            }
            set
            {
                panel_redPoint.Location = new Point((int)(bienDoTruot * value / 100));
                panel_daQua.Size = new Size(panel_redPoint.Location.X, panel_duongRay.Height);
                _phanTramHienTai = value;
            }
        }

        private void tinhKichThuoc()
        {
            panel_redPoint.Size = new Size(panel_nen.Height, panel_nen.Height);
            panel_duongRay.Size = new Size((panel_nen.Width - panel_redPoint.Width) ,(int)(panel_nen.Height / 2));
            panel_duongRay.Location = new Point(panel_redPoint.Width / 2, (panel_nen.Height - panel_duongRay.Height) / 2);
            panel_daQua.Location = new Point(0, 0);
            panel_daQua.Size = new Size(panel_redPoint.Location.X, panel_duongRay.Height);
            bienDoTruot = panel_nen.Width  - panel_redPoint.Width;
        }
        public event NhanNhaNutCuonHandle nhanNhaNutCuon;
        private void diemPhat_MD(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            var nutCuonArg = new NutCuonDuocNhanArgs()
            {
                duocNhanXuong = true,
            };
            if (nhanNhaNutCuon != null)
                nhanNhaNutCuon(this, nutCuonArg);

        }

        private void diemPhat_MU(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            var nutCuonArg = new NutCuonDuocNhanArgs()
            {
                duocNhanXuong = false,
            };
            if (nhanNhaNutCuon != null)
                nhanNhaNutCuon(this, nutCuonArg);
            var phanTramThanhCuon = (double)panel_redPoint.Location.X / (double)(bienDoTruot) * 100;

            var arg = new cuonVideoArgs()
            {
                phanTramThanhCuon = phanTramThanhCuon,

            };
            if (thanhCuonDangTruot != null)
                thanhCuonDangTruot(this, arg);
        }
        public event cuonVideoHandle thanhCuonDangTruot;
        private void diemPhat_MM(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                var mousePos = panel_nen.PointToClient(Cursor.Position).X;
                panel_redPoint.Location = new Point(mousePos - panel_redPoint.Width / 2);
                panel_daQua.Size = new Size(panel_redPoint.Location.X, panel_duongRay.Height);
                if (mousePos - panel_redPoint.Width / 2 <= 1)
                {
                    panel_redPoint.Location = new Point(0);
                    return;
                }
                if (mousePos + panel_redPoint.Width / 2 >= panel_nen.Width - 1)
                {
                    panel_redPoint.Location = new Point(panel_nen.Width - panel_redPoint.Width);
                    return;
                }
                //var phanTramThanhCuon = (double)panel_redPoint.Location.X / (double)(bienDoTruot) * 100;
                
                //var arg = new cuonVideoArgs()
                //{
                //    phanTramThanhCuon = phanTramThanhCuon,

                //};
                //if(thanhCuonDangTruot != null)
                //    thanhCuonDangTruot(this, arg);
            }
        }

        private void diemPhat_MLeave(object sender, EventArgs e)
        {
            panel_redPoint.Visible = false;
        }

        private void ucMouseMove(object sender, MouseEventArgs e)
        {
            if (panel_nen.PointToClient(Cursor.Position).X >= panel_redPoint.Location.X & panel_nen.PointToClient(Cursor.Position).X <= panel_redPoint.Location.X + panel_redPoint.Width)
            {
                panel_redPoint.Visible = true;
            }
            else
            {
                panel_redPoint.Visible = false;
            }
        }

        private void ucMouseClick(object sender, MouseEventArgs e)
        {
            panel_redPoint.Location = new Point(e.X - panel_redPoint.Width / 2);
            panel_daQua.Size = new Size(panel_redPoint.Location.X, panel_duongRay.Height);
            var phanTramThanhCuon = (double)panel_redPoint.Location.X / (double)(bienDoTruot) * 100;

            var arg = new cuonVideoArgs()
            {
                phanTramThanhCuon = phanTramThanhCuon,

            };
            if (thanhCuonDangTruot != null)
                thanhCuonDangTruot(this, arg);
        }

        private void thanhTruot_sizeChange(object sender, EventArgs e)
        {
            tinhKichThuoc();
        }

    }
    public class NutCuonDuocNhanArgs : EventArgs
    {
        public bool duocNhanXuong;
    }
   
}
