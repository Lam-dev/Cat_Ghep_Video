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
    public delegate void ScrollBarHandler(object sender, doubleScrollBarEvent e);
    public delegate void PlayingPointHandler(object sender, playingPointEvent e);
    public partial class UserControl1 : UserControl
    {
        private TimeSpan _videoDuration;
        public TimeSpan videoDuration
        {
            get { return _videoDuration; }
            set
            {
                _videoDuration = value;
                lb_startTime.Text = TimeSpanToString(SecondToTimespan(value.TotalSeconds * _startPointPos / 100));
                lb_stopPoint.Text = TimeSpanToString(SecondToTimespan(value.TotalSeconds * _stopPointPos / 100));
            }
        }
        private double _startPointPos = 0;
        private double _stopPointPos = 0;
        public double startPointPos
        {
            get
            {
                return _startPointPos;
            }
            set
            {
                _startPointPos = value;
                SB_startPoint.Location = new Point((int)mappingPosFromPercent(value, 0, bar.Width - SB_stopPoint.Width - poin_playing.Width), 0);
                lb_startTime.Location = new Point(SB_startPoint.Location.X, 0);
                lb_startTime.Text = TimeSpanToString(SecondToTimespan(_videoDuration.TotalSeconds * _startPointPos / 100));
                reStartPoint();
            }
        }
        public double stopPointPos
        {
            get
            {
                return _stopPointPos;
            }
            set
            {
                _stopPointPos = value;
                SB_stopPoint.Location = new Point((int)mappingPosFromPercent(value, SB_startPoint.Width + poin_playing.Width, bar.Width - SB_stopPoint.Width));
                lb_stopPoint.Location = new Point(SB_stopPoint.Location.X - lb_stopPoint.Width, 0);
                lb_stopPoint.Text = TimeSpanToString(SecondToTimespan(_videoDuration.TotalSeconds * _stopPointPos / 100));
            }
        }
        public double startPointTime { get => _startPointPos * videoDuration.TotalSeconds / 100; }
        public double stopPointTime { get => _stopPointPos * videoDuration.TotalSeconds / 100; }
        private TimeSpan _startPointTimeSpan;
        private TimeSpan _stopPointTimeSpan;

        public TimeSpan startPointTimeSpan
        {
            set
            {
                _startPointTimeSpan = value;
                lb_startTime.Text = TimeSpanToString(value);
                _startPointPos = value.TotalSeconds / _videoDuration.TotalSeconds * 100;
                SB_startPoint.Location = new Point((int)mappingPosFromPercent(_startPointPos, 0, bar.Width - SB_stopPoint.Width - poin_playing.Width), 0);
                lb_startTime.Location = new Point(SB_startPoint.Location.X, 0);
                lb_startTime.Text = TimeSpanToString(SecondToTimespan(_videoDuration.TotalSeconds * _startPointPos / 100));
            }
        }

        public TimeSpan stopPointTimeSpan
        {
            set
            {
                _stopPointTimeSpan = value;
                lb_stopPoint.Text = TimeSpanToString(value);
                _stopPointPos = value.TotalSeconds / _videoDuration.TotalSeconds * 100;
                SB_stopPoint.Location = new Point((int)mappingPosFromPercent(_stopPointPos, SB_startPoint.Width + poin_playing.Width, bar.Width - SB_stopPoint.Width));
                lb_stopPoint.Location = new Point(SB_stopPoint.Location.X - lb_stopPoint.Width, 0);
                reStartPoint();
            }

        }

        public double playingPointTime
        {
            set => calcPPoinPosFromPPTime(value);
        }
        //public int stopPointPos = 100;
        bool startPointHold = false;
        bool stopPointHold = false;
        bool pointPlayingHold = false;
        
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            SB_stopPoint.Location = new Point(bar.Width - SB_stopPoint.Width, 0);
            lb_stopPoint.Location = new Point(bar.Width - lb_stopPoint.Width, 0);
            _startPointPos = mappingValue(SB_startPoint.Location.X, 0, bar.Width - SB_startPoint.Width * 2 - poin_playing.Width);
            _stopPointPos = mappingValue(SB_stopPoint.Location.X, SB_startPoint.Width + poin_playing.Width, bar.Width - SB_stopPoint.Width);
        }

   
        public event ScrollBarHandler pointLocationChange;
        public event PlayingPointHandler playingPointChange; 

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void SB_startPoint_mouseDown(object sender, MouseEventArgs e)
        {
            startPointHold = true; 
        }

        private void stopButton_mouseMove(object sender, MouseEventArgs e)
        {
            startPointHold = false; 
        }

        private void SB_stopPoint_MouseDown(object sender, MouseEventArgs e)
        {
            stopPointHold = true;
        }

        private void SB_stopPoint_mouseUp(object sender, MouseEventArgs e)
        {
            stopPointHold = false; 
        }

        private int mappingValue(int curentPos, int minValue, int maxValue)
        {
            if (curentPos < minValue)
                return 0;
            if (curentPos > maxValue)
                return 100;
            return (int)((float)(curentPos - minValue) / (float)(maxValue - minValue) * 100);
 
        }

        private double mappingPosFromPercent(double percent, int minValue, int maxValue)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;
            return (maxValue - minValue) * percent / 100 + minValue;
        }

        private void SB_startPoint_mouseMove(object sender, MouseEventArgs e)
        {
            if (startPointHold)
            {
                var x = bar.PointToClient(Cursor.Position).X;
                if (x < (SB_startPoint.Width / 2))
                    return;
                if (x + SB_startPoint.Width / 2 >= poin_playing.Location.X  - 1 )
                {
                    if (poin_playing.Location.X + poin_playing.Width >= SB_stopPoint.Location.X - 1)
                    {
                        poin_playing.Location = new Point(SB_stopPoint.Location.X - poin_playing.Width - 1, 0);
                        SB_startPoint.Location = new Point(poin_playing.Location.X - SB_startPoint.Width - 1, 0);
                        return;
                    }
                    poin_playing.Location = new Point(x + SB_startPoint.Width / 2 + 1, 0);
                }
                SB_startPoint.Location = new Point(x - SB_startPoint.Width/2, 0);
                _startPointPos = mappingValue(SB_startPoint.Location.X, 0, bar.Width - SB_startPoint.Width * 2 - poin_playing.Width - 2);
                lb_startTime.Location = new Point(x, 0);
                if (lb_startTime.Location.X + lb_startTime.Width > lb_stopPoint.Location.X)
                {
                    lb_stopPoint.Location = new Point(lb_startTime.Location.X + lb_startTime.Width, 0);
                }
                lb_startTime.Text = TimeSpanToString(SecondToTimespan(_videoDuration.TotalSeconds* _startPointPos / 100));

                var arg = new doubleScrollBarEvent()
                {
                    startPointChange = true,
                    value = SecondToTimespan(_videoDuration.TotalSeconds / 100 * _startPointPos),
                    subTime = _stopPointPos - _startPointPos,
                };
                pointLocationChange(this, arg);
            }
        }

        private void SB_stopPoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (stopPointHold)
            {
                var x = bar.PointToClient(Cursor.Position).X;
                if (x > (bar.Width - SB_startPoint.Width / 2))
                    return;
                if (x - SB_stopPoint.Width / 2 <= poin_playing.Location.X + poin_playing.Width + 1)
                {
                    if (poin_playing.Location.X <= SB_startPoint.Location.X + SB_startPoint.Width + 1)
                    {
                        poin_playing.Location = new Point(SB_startPoint.Location.X + SB_startPoint.Width + 1, 0);
                        SB_stopPoint.Location = new Point(poin_playing.Location.X + poin_playing.Width + 1, 0);
                        return;
                    }
                    poin_playing.Location = new Point(x - SB_stopPoint.Width / 2 - poin_playing.Width - 1);
                }
                SB_stopPoint.Location = new Point(x - SB_stopPoint.Width/2, 0);
                _stopPointPos = mappingValue(SB_stopPoint.Location.X, SB_startPoint.Width + poin_playing.Width, bar.Width - SB_stopPoint.Width);
                lb_stopPoint.Location = new Point(x - lb_stopPoint.Width + SB_stopPoint.Width, 0);
                if (lb_stopPoint.Location.X < lb_startTime.Location.X + lb_startTime.Width)
                {
                    lb_stopPoint.Location = new Point(lb_startTime.Location.X + lb_startTime.Width, 0);
                }
                lb_stopPoint.Text = TimeSpanToString(SecondToTimespan(_videoDuration.TotalSeconds * _stopPointPos / 100));
                var arg = new doubleScrollBarEvent()
                {
                    startPointChange = false,
                    value = SecondToTimespan(_videoDuration.TotalSeconds * _stopPointPos / 100),
                    subTime = _stopPointPos - _startPointPos,
                };
                pointLocationChange(this, arg);
            }
        }

        private TimeSpan SecondToTimespan(double totalSecond)
        {
            var h = totalSecond / 3600;
            totalSecond = totalSecond % 3600;
            var m = totalSecond  / 60;
            var s = totalSecond % 60;
            if ((int)s > s)
                s -= 1;
            return new TimeSpan((int)h, (int)m, (int)s);
        }

        private string TimeSpanToString(TimeSpan h)
        {
            return (h.Hours.ToString() + ":" + h.Minutes.ToString() + ":" + h.Seconds.ToString());
        }

        private void poin_playingMD(object sender, MouseEventArgs e)
        {
            pointPlayingHold = true; 
        }

        private void poin_playingMU(object sender, MouseEventArgs e)
        {
            pointPlayingHold = false;
        }

        private void poin_playingMM(object sender, MouseEventArgs e)
        {
            if (pointPlayingHold)
            {
                var x = bar.PointToClient(Cursor.Position).X;
                if ((x - poin_playing.Width / 2) <= (SB_startPoint.Location.X + SB_startPoint.Width) | (x + poin_playing.Width / 2) >= (SB_stopPoint.Location.X ))
                    return;
                poin_playing.Location = new Point(x - poin_playing.Width / 2, 0);
            }
            
        }

        private void playingPoinChange(object sender, EventArgs e)
        {
            if (pointPlayingHold | startPointHold | stopPointHold)
            {
                var arg = new playingPointEvent()
                {
                    //value = ((float)poin_playing.Location.X / (float)bar.Width * (float)videoDuration.TotalSeconds)
                    value =(double)mappingValue(poin_playing.Location.X, SB_startPoint.Width+SB_startPoint.Location.X, SB_stopPoint.Location.X) * (double)(stopPointTime - startPointTime) / 100 + startPointTime
                };
                playingPointChange(this, arg);
            }
        }

        private void calcPPoinPosFromPPTime(double PPtime)
        {
            //var x = (PPtime-startPointTime)/(stopPointTime-startPointTime)*(SB_stopPoint.Location.X-(SB_startPoint.Location.X + SB_startPoint.Width))+ (SB_startPoint.Location.X + SB_startPoint.Width);
            //var x = PPtime / videoDuration.TotalSeconds * (bar.Width - SB_startPoint.Width - SB_stopPoint.Width - poin_playing.Width) + SB_startPoint.Width; 
            //poin_playing.Location = new Point((int)x, 0);
        }
        
        public void reStartPoint()
        {
            poin_playing.Location = new Point(SB_startPoint.Location.X + SB_startPoint.Width, 0);
            var arg = new playingPointEvent()
            {
                value = (double)mappingValue(poin_playing.Location.X, SB_startPoint.Width + SB_startPoint.Location.X, SB_stopPoint.Location.X) * (stopPointTime - startPointTime) / 100 + startPointTime
            };
            playingPointChange?.Invoke(this, arg);
        }

        private void lb_subTime_Click(object sender, EventArgs e)
        {

        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class doubleScrollBarEvent : EventArgs
    {
        public TimeSpan value { get; set;}
        public bool startPointChange { get; set;  }
        public double subTime { get; set;  }
    }

    public class playingPointEvent : EventArgs
    {
        public double value { get; set; }
    }

}
