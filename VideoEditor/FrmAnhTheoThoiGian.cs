using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class FrmAnhTheoThoiGian : Form
    {
        public FrmAnhTheoThoiGian()
        {
            InitializeComponent();
        }
        public void ThayDoiViTri(int x, int y)
        {
            this.Location = new Point(x, y); 
        }

        public void Anh(Bitmap anh)
        {
            picbox_hienThiAnh.Image = anh;
        }
    }
}
