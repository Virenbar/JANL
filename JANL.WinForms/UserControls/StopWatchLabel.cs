using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class StopWatchLabel : UserControl
    {
        private const string Format = @"d\.hh\:mm\:ss";
        private readonly Stopwatch StopWatch;
        private readonly Timer Timer;

        public StopWatchLabel()
        {
            InitializeComponent();

            Timer = new Timer { Interval = 100 };
            Timer.Tick += Timer_Tick;
            StopWatch = new Stopwatch();

            ImageWaiting = PB_Image.InitialImage;
            ImageRunning = PB_Image.Image;
            PB_Image.Image = ImageWaiting;
            L_Prefix.Text = "Time passed:";
            L_Time.Text = TimeSpan.Zero.ToString(Format);
            UpdateText();
        }

        public void Reset()
        {
            Stop();
            L_Time.Text = TimeSpan.Zero.ToString(Format);
        }

        public void Start()
        {
            StopWatch.Restart();
            Timer.Start();
            PB_Image.Image = ImageRunning;
        }

        public void Stop()
        {
            Timer.Stop();
            StopWatch.Stop();
            PB_Image.Image = ImageWaiting;
        }

        private void Timer_Tick(object sender, EventArgs e) => UpdateText();

        private void UpdateText()
        {
            L_Time.Text = TimeElapsed.ToString(Format);
        }

        #region Properties

        #region Designer

        [Browsable(true), Category("StopWatchLabel")]
        public Image ImageRunning { get; set; }

        [Browsable(true), Category("StopWatchLabel")]
        public Image ImageWaiting { get; set; }

        [Browsable(true), Category("StopWatchLabel"), DefaultValue("Time passed:")]
        public string Prefix
        {
            get => L_Prefix.Text;
            set => L_Prefix.Text = value;
        }

        [Browsable(true), Category("StopWatchLabel"), DefaultValue(100)]
        public int RefreshInterval
        {
            get => Timer.Interval;
            set => Timer.Interval = value;
        }

        [Browsable(true), Category("StopWatchLabel"), DefaultValue(true)]
        public bool ShowImage
        {
            get => PB_Image.Visible;
            set => PB_Image.Visible = value;
        }

        #endregion Designer

        [Browsable(false)]
        public TimeSpan TimeElapsed => StopWatch.Elapsed;

        #endregion Properties
    }
}