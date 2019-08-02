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
    public delegate void anhDaiDienVideoClick(object sender, anhDaiDienArgs e);

    
    public partial class ucDaiDienVideo : UserControl
    {

        public event anhDaiDienVideoClick anhDaiDienClick;
        public event MouseEventHandler iMouseMove;
        public ucDaiDienVideo(int index, Bitmap image, string filePath, string tenFile, string dungLuong)
        {
            InitializeComponent();
            picbox_anhDaiDienVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            _index = index;
            _filePath = filePath;
            picbox_anhDaiDienVideo.Image = image;
            lb_tenVideo.Text = tenFile;
            lb_dungLuong.Text = dungLuong;
        }

        int _index { get; set; }
        public int index
        {
            set { _index = value; }
        }
        string _filePath { get; set; }
        string _dungLuong { get; set; }
        string _tenFile { get; set; }
        private void clickAnhDaiDien(object sender, MouseEventArgs e)
        {

            var anhDaiDienVideoArg = new anhDaiDienArgs()
            {
                index = _index,
                filePath = _filePath
            };
            anhDaiDienVideoClick anhDaiDienClicks = anhDaiDienClick;
            if (anhDaiDienClicks != null)
            {
                anhDaiDienClicks(this, anhDaiDienVideoArg);
            }
        }
       
        private void ucMouseMove(object sender, MouseEventArgs e)
        {
            MouseEventHandler ucMouseMove = iMouseMove;
            if (ucMouseMove != null)
            {
                ucMouseMove(sender, e);
            }
        }
    }
    public class  anhDaiDienArgs : EventArgs
    {
        public int index { get; set; }
        public string filePath { get; set; }
    }

}
