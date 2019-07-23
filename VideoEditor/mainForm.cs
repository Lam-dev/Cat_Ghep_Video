using FFmpeg.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace VideoEditor
{
    public partial class mainForm : Form
    {
        string[] danhSachVideoPath;
     
        Engine ffmpeg = new Engine(@"..\..\libFFmpeg\ffmpeg.exe");
        Conversion x = new Conversion();
        int soVideoDuocChon = 0;
        int soVideoDaCat = 0;
        bool mouseStartHover = false;
        MediaFile playingVideo;
        int hangDuocChon;
        TimeSpan doDaiVideoDangPhat; 
        List<ThongTinCatVideo> danhSachVideoDuocCat = new List<ThongTinCatVideo>();
        string outputFilePath;
        public mainForm()
        {

            InitializeComponent();
            //xoaDsAnhDaiDien();
            comboBox_pickRate.SelectedIndex = 2;
        }

        private void button_layVideo_Click(object sender, EventArgs e)
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
                danhSachVideoPath = dialog_layVideo.FileNames;

                foreach (var videoPath in danhSachVideoPath)
                {

                    layAnhDaiDienVideo(videoPath);
                }
            }
        }

        private void thayDoiIconPlayPause()
        {
            if (vlcControl1.IsPlaying)
            {
                btn_phatDung.Values.Image = Properties.Resources.pause;
                timer_getPlayingTime.Stop();
            }
            else
            {
                btn_phatDung.Values.Image = Properties.Resources.play;
                timer_getPlayingTime.Start();
            }
            timer_choVLCphanHoi.Stop();
        }

        private async void layAnhDaiDienVideo(string path)
        {
            var inputFile = new MediaFile(path);
            var outputFile = new MediaFile(@"thum" + soVideoDuocChon.ToString() + ".jpg");
            var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(2) };
            var task  = ffmpeg.GetThumbnailAsync(inputFile, outputFile, options);
            if (task == null)
                return; 
            task.Wait(500);
         
            if (File.Exists(@"thum" + soVideoDuocChon.ToString() + ".jpg"))
            {
                listImage_dsAnhDaiDienVideo.Images.Add(Image.FromFile(@"thum" + soVideoDuocChon.ToString() + ".jpg"));
                listView_showListVideo.LargeImageList = listImage_dsAnhDaiDienVideo;
                //ListViewItem item = new ListViewItem(metaData.Duration.Minutes.ToString() + ":" +metaData.Duration.Seconds.ToString());
                ListViewItem item = new ListViewItem(path);
                item.ImageIndex = soVideoDuocChon;
                listView_showListVideo.Items.Add(item);
                soVideoDuocChon += 1;
            }
        }

        private async void listView_showListVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView_showListVideo.SelectedItems)
            {
                var listViewItem = item as ListViewItem;
                vlcControl1.Play(new FileInfo(listViewItem.Text));
                playingVideo = new MediaFile(listViewItem.Text);
                var metaData = await ffmpeg.GetMetaDataAsync(playingVideo);
                try
                {
                    userControl11.videoDuration = metaData.Duration;
                    doDaiVideoDangPhat = metaData.Duration;
                    tongThoiGian.Text = TimeSpanToString(doDaiVideoDangPhat);
                }
                catch
                {
                    Console.WriteLine("vvvvvv");
                }
                userControl11.reStartPoint();
                lb_videoInfor.Text = "";
                if (metaData != null)
                    lb_videoInfor.Text = metaData.VideoData.ToString() + "\n bitRate:" + metaData.VideoData.BitRateKbs
                        + "\nFPS:" + ((int)metaData.VideoData.Fps).ToString();
                else
                {
                    listView_showListVideo.Items.RemoveAt(listView_showListVideo.SelectedItems[0].Index);
                    return; 
                }
                if (metaData.AudioData != null)
                    lb_videoInfor.Text += "\nAudio:\n" + "SampleRate :" + metaData.AudioData.SampleRate +
                    "\nFormat: " + metaData.AudioData.Format + "\nChannel output: " + metaData.AudioData.ChannelOutput;
            }
            
        }

        private void xoaDsAnhDaiDien()
        {
            DirectoryInfo di = new DirectoryInfo(@"..\");
            foreach (FileInfo file in di.EnumerateFiles())
            {
                if(file.Name.Contains("thum"))
                    file.Delete();
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void themVideoVaoListView()
        {

        }
        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            GrV_thongTinCat.Columns[0].DataPropertyName = "videoPath";
            GrV_thongTinCat.Columns[1].DataPropertyName = "startTime";
            GrV_thongTinCat.Columns[2].DataPropertyName = "stopTime";
            GrV_thongTinCat.Columns[3].DataPropertyName = "subTime";
            GrV_thongTinCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrV_thongTinCat.AutoGenerateColumns = false;
            var dem = 0;
            while (true)
            {
                if (File.Exists(dem.ToString() + ".mp4"))
                    File.Delete(dem.ToString() + ".mp4");
                else
                    break;
                dem += 1;
            }
            for (int i = 0; i <= 12; i++)
            {
                hDau.Items.Add(i.ToString());
                hCuoi.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 59; i++)
            {
                mDau.Items.Add(i.ToString());
                mCuoi.Items.Add(i.ToString());
                sDau.Items.Add(i.ToString());
                sCuoi.Items.Add(i.ToString());
            }
        }

        private void vlcControl_Video_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                vlcControl1.Pause();
                timer_choVLCphanHoi.Start();
                
            }
            else
            {
                vlcControl1.Play();
                timer_choVLCphanHoi.Start();
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {


        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void stPoint_mouseDown(object sender, MouseEventArgs e)
        {
            mouseStartHover = true;
        }

        private void panel_mouseDown(object sender, MouseEventArgs e)
        {


        }

        private void nt_mouseUp(object sender, MouseEventArgs e)
        {
            mouseStartHover = false;
        }

        private void panel_mouseMove(object sender, MouseEventArgs e)
        {

            Console.WriteLine(panel.PointToClient(Cursor.Position).X.ToString());


        }

        private void formMouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine(panel.PointToClient(Cursor.Position).X.ToString());
        }

        private void stPoint_mouseMove(object sender, MouseEventArgs e)
        {
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void uc_poinChange(object sender, doubleScrollBarEvent e)
        {
            if (e.startPointChange == false)
            {
                hCuoi.Text = e.value.Hours.ToString();
                mCuoi.Text = e.value.Minutes.ToString();
                sCuoi.Text = e.value.Seconds.ToString();
            }
            else
            {
                hDau.Text = e.value.Hours.ToString();
                mDau.Text = e.value.Minutes.ToString();
                sDau.Text = e.value.Seconds.ToString();
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pickRate.SelectedIndex == 0) vlcControl1.Rate = (float)0.25;
            if (comboBox_pickRate.SelectedIndex == 1) vlcControl1.Rate = (float)0.5;
            if (comboBox_pickRate.SelectedIndex == 2) vlcControl1.Rate = (float)1;
            if (comboBox_pickRate.SelectedIndex == 3) vlcControl1.Rate = (float)1.5;
            if (comboBox_pickRate.SelectedIndex == 4) vlcControl1.Rate = (float)2;
            if (comboBox_pickRate.SelectedIndex == 5) vlcControl1.Rate = (float)4;

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void playingPointChange(object sender, playingPointEvent e)
        {
            vlcControl1.Time = (int)(e.value * 1000);
        }

        private void showListVideo_colClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void listVideoItem_mouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            //Console.WriteLine(e.Item.Text);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_cut_Click(object sender, EventArgs e)
        {

        }

        private TimeSpan SecondToTimespan(double totalSecond)
        {
            var h = totalSecond / 3600;
            totalSecond = totalSecond % 3600;
            var m = totalSecond / 60;
            var s = totalSecond % 60;
            return new TimeSpan((int)h, (int)m, (int)s);
        }

        private void kryptonGroupBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_up_Click(object sender, EventArgs e)
        {

        }

        private void BuildTxtFile(int numberOfVideo)
        {
            if (File.Exists("listVideo.txt"))
                File.Delete("listVideo.txt");
            FileStream fs = new FileStream("listVideo.txt", FileMode.CreateNew);//Tạo file mới tên là test.txt            
            StreamWriter sWriter = new StreamWriter(fs);//fs là 1 FileStream 
            for (int i = 0; i < numberOfVideo; i++)
            {
                sWriter.WriteLine("file '" + i.ToString() + ".mp4'");
            }
            sWriter.Flush();
            fs.Close();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            var xuatHien = 0;
            while (true)
            {
                if (File.Exists(xuatHien.ToString() + ".mp4"))
                    File.Delete(xuatHien.ToString() + ".mp4");
                else
                    break;
                xuatHien += 1;
            }
            if (tb_exportFilePath.Text == null | tb_exportFilePath.Text == "")
            {
                MessageBox.Show("Chọn vị trí lưu");
                return;
            }
            if (tb_exportFileName.Text == null | tb_exportFileName.Text == "")
            {
                MessageBox.Show("Nhập tên");
                return;
            }

            outputFilePath = tb_exportFilePath.Text + @"\" + tb_exportFileName.Text + cbb_dinhDangXuat.Text;
            if (File.Exists(outputFilePath))
            {
                MessageBox.Show("Tệp đã tồn tại");
                return;
            }

            if (danhSachVideoDuocCat.Count == 0)
            {
                MessageBox.Show("Không có phần video nào được ghép nối");
                return; 
            }
            panel_hienThiNutDung.Visible = true; 
            backgroundWorker_catVideo.RunWorkerAsync();
            
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            if (vlcControl1.GetCurrentMedia() == null)
                return;
            var cut = new ThongTinCatVideo()
            {
                videoPath = playingVideo.FileInfo.FullName,
                startTime = SecondToTimespan(userControl11.startPointTime).ToString(),
                stopTime = SecondToTimespan(userControl11.stopPointTime).ToString(),
                subTime = SecondToTimespan(userControl11.stopPointTime - userControl11.startPointTime).ToString(),
                startPosPercent = userControl11.startPointPos,
                stopPosPercent = userControl11.stopPointPos,
            };

            danhSachVideoDuocCat.Add(cut);
            GrV_thongTinCat.DataSource = null;
            GrV_thongTinCat.DataSource = danhSachVideoDuocCat;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_exportFilePath.Text = folderDlg.SelectedPath;
            }
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
                vlcControl1.Pause();
            else
                vlcControl1.Play();
        }

        private void vlcControlMouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (hangDuocChon > 0 & hangDuocChon < danhSachVideoDuocCat.Count)
            {
                doiChoPhanTu(hangDuocChon, hangDuocChon - 1);

                hangDuocChon -= 1;
                GrV_thongTinCat.DataSource = null;
                GrV_thongTinCat.DataSource = danhSachVideoDuocCat;
                GrV_thongTinCat.Rows[hangDuocChon + 1].Selected = false;
                GrV_thongTinCat.Rows[hangDuocChon].Selected = true;
            }
        }

        private void Grv_thongTinCutClick(object sender, DataGridViewCellEventArgs e)
        {
            hangDuocChon = e.RowIndex;
        }

        private async Task<bool> kiemTraCacVideoCungThongSo(int numberOfVideoAdd)
        {
            if (numberOfVideoAdd < 1)
                return true;
            var metaData1 = await ffmpeg.GetMetaDataAsync(new MediaFile("0.mp4"));
            if (metaData1 == null)
            {
                huyProcess();
                return true;
            }
            for (int i = 1; i < numberOfVideoAdd; i++)
            {
                var metaData2 = await ffmpeg.GetMetaDataAsync(new MediaFile((i).ToString() + ".mp4"));
                if (metaData2 == null)
                {
                    huyProcess();
                    return true;
                }
                var formatDiferent = metaData1.VideoData.Format != metaData2.VideoData.Format; 
                var sizeDiferent = metaData1.VideoData.FrameSize != metaData2.VideoData.FrameSize;
                var colorModelDiferent = metaData1.VideoData.ColorModel != metaData2.VideoData.ColorModel;
                var fpsDiferent = metaData1.VideoData.Fps != metaData2.VideoData.Fps;
                if (formatDiferent | sizeDiferent | colorModelDiferent | fpsDiferent)
                    return false; 
            }
            return true; 
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (hangDuocChon < 0)
                return;
            try
            {
                danhSachVideoDuocCat.RemoveAt(hangDuocChon);
            }
            catch
            {
                return;
            }
            GrV_thongTinCat.DataSource = null;
            GrV_thongTinCat.DataSource = danhSachVideoDuocCat;
            hangDuocChon -= 1;
            if (hangDuocChon > 0)
            {
                
                GrV_thongTinCat.Rows[hangDuocChon].Selected = true; 
            }
        }

        private void doiChoPhanTu(int index1, int index2 )
        {
            ThongTinCatVideo thongTin = danhSachVideoDuocCat[index1];
            danhSachVideoDuocCat[index1] = danhSachVideoDuocCat[index2];
            danhSachVideoDuocCat[index2] = thongTin;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (hangDuocChon < danhSachVideoDuocCat.Count - 1 & hangDuocChon >= 0)
            {
                doiChoPhanTu(hangDuocChon, hangDuocChon + 1);
                hangDuocChon += 1;
                GrV_thongTinCat.DataSource = null;
                GrV_thongTinCat.DataSource = danhSachVideoDuocCat;
                GrV_thongTinCat.Rows[hangDuocChon].Selected = true;
            }
        }

        private void timeGetPlayTime_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                var x = vlcControl1.Time;
                dangPhat.Text = TimeSpanToString(SecondToTimespan(x/1000));

            }
        }

        private string TimeSpanToString(TimeSpan h)
        {
            return (h.Hours.ToString() + ":" + h.Minutes.ToString() + ":" + h.Seconds.ToString());
        }

        private void btn_xoaVideo_Click(object sender, EventArgs e)
        {
            var videoDaChon = listView_showListVideo.SelectedItems;
            foreach (var video in videoDaChon)
            {
                listView_showListVideo.Items.RemoveAt((video as ListViewItem).Index);
            }
        }

        private void backgroundWoker_noiVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            var listArg = e.Argument as List<object>;
            FFmpeg.concatVideo((int)listArg[0], (string)listArg[1], (string)listArg[2], (string)listArg[3], (bool)listArg[4]);
        }

        private void backgroundWoker_noiVideo_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            panel_hienThiNutDung.Visible = false;
            MessageBox.Show("Đã xuất video thành công");
        }

        private void backgroundWorker_catVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            var dem = 0;
            foreach (var video in danhSachVideoDuocCat)
            {
                FFmpeg.cutVideo(video.videoPath, dem.ToString() + ".mp4", video.startTime, video.subTime);
                dem += 1;
            }
        }

        private async void backgroundWorker_catVideo_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            
            bool cungThongSo = false;
            try
            {
                cungThongSo = await kiemTraCacVideoCungThongSo(danhSachVideoDuocCat.Count);
            }
            catch
            {
                try
                {
                    cungThongSo = await kiemTraCacVideoCungThongSo(danhSachVideoDuocCat.Count);
                }
                catch(ArgumentException a)
                {
                    MessageBox.Show("Không thành công, hãy thử lại {0}",a.ParamName);
                    panel_hienThiNutDung.Visible = false;
                    return; 
                }
            }
            BuildTxtFile(danhSachVideoDuocCat.Count);
            List<object> argChoNoiVideo = new List<object>();
            argChoNoiVideo.Add(danhSachVideoDuocCat.Count);
            argChoNoiVideo.Add(outputFilePath);
            string[] rongDaiVideo = cbb_chonDoPhanGiai.Text.Split('x');
            argChoNoiVideo.Add(rongDaiVideo[0]);
            argChoNoiVideo.Add(rongDaiVideo[1]);
            argChoNoiVideo.Add(cungThongSo);
            backgroundWoker_noiVideo.RunWorkerAsync(argument: argChoNoiVideo);
        }

        private void tb_exportFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_choVLCphanHoi_Tick(object sender, EventArgs e)
        {
            thayDoiIconPlayPause();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(string.Format("Dừng ?"), "Dừng ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (backgroundWoker_noiVideo.IsBusy | backgroundWorker_catVideo.IsBusy)
                {
                    huyProcess();
                }
            }
        }

        private void huyProcess()
        {
            var ffmpegPr = Process.GetProcesses().Where(pr => pr.ProcessName == "ffmpeg");
            foreach (var process in ffmpegPr)
            {
                process.Kill();
                string outputFilePath = tb_exportFilePath.Text + @"\" + tb_exportFileName.Text + cbb_dinhDangXuat.Text;
                panel_hienThiNutDung.Visible = false;
                MessageBox.Show("Đã dừng");

            }
            ffmpegPr = Process.GetProcesses().Where(pr => pr.ProcessName == "ffmpeg");
            if (ffmpegPr.Count() == 0)
            {
                panel_hienThiNutDung.Visible = false;
            }
        }
        private void btn_playVideoCut_Click(object sender, EventArgs e)
        {
            ThongTinCatVideo video = null;
            try
            {
                video = danhSachVideoDuocCat[hangDuocChon];
            }
            catch
            {
                return;
            }
            if (video == null)
                return; 
            vlcControl1.Play(new FileInfo(video.videoPath));
            userControl11.startPointPos = video.startPosPercent;
            userControl11.stopPointPos = video.stopPosPercent;
        }

        private void kryptonComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var time = new TimeSpan(Int16.Parse(hDau.Text), Int16.Parse(mDau.Text), Int16.Parse(sDau.Text));
            //if (time.TotalSeconds >= 0 & time.TotalSeconds <= doDaiVideoDangPhat)
            //{
            //    calcPercentFromTime(true);
            //}
        }

        private void hDau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sDau_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void kryptonGroupBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cutTheoComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                var timeDau = new TimeSpan(Int16.Parse(hDau.Text), Int16.Parse(mDau.Text), Int16.Parse(sDau.Text));
                var timeCuoi = new TimeSpan(Int16.Parse(hCuoi.Text), Int16.Parse(mCuoi.Text), Int16.Parse(sCuoi.Text));
                if (timeDau.TotalSeconds >= 0 & timeDau <= timeCuoi & timeDau <= doDaiVideoDangPhat)
                {
                    userControl11.startPointTimeSpan = timeDau;
                }
                
                if (timeCuoi.TotalSeconds >= 0 & timeCuoi >= timeDau & timeCuoi <= doDaiVideoDangPhat)
                {
                    userControl11.stopPointTimeSpan = timeCuoi;
                }
            }
            catch
            {
            }
        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class ThongTinCatVideo
    {
        public string videoPath
        {
            get;
            set;

        }
        public string startTime
        {
            set;
            get;
        }
        public string stopTime { get; set; }
        public string subTime { get; set; }
        public double startPosPercent { get; set; }
        public double stopPosPercent { get; set; }
    }

}
