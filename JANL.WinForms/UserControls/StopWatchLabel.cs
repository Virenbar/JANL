using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
namespace JANL.UserControls
{
    /// <summary>
    /// Элемент для отображения прошедшего времени
    /// </summary>
    public partial class StopWatchLabel : UserControl
    {
        private readonly Stopwatch StopWatch;
        private readonly Timer Timer;

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
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
            L_Time.Text = TimeSpan.Zero.ToString(Defaults.TimespanFormat);
            UpdateText();
        }

        /// <summary>
        /// Останавливает и сбрасывает измерение
        /// </summary>
        public void Reset()
        {
            Stop();
            L_Time.Text = TimeSpan.Zero.ToString(Defaults.TimespanFormat);
        }

        /// <summary>
        /// Останавливает измерение
        /// </summary>
        public void Start()
        {
            StopWatch.Restart();
            Timer.Start();
            PB_Image.Image = ImageRunning;
        }

        /// <summary>
        /// Запускает измерение
        /// </summary>
        public void Stop()
        {
            Timer.Stop();
            StopWatch.Stop();
            PB_Image.Image = ImageWaiting;
        }

        private void Timer_Tick(object sender, EventArgs e) => UpdateText();

        private void UpdateText()
        {
            L_Time.Text = TimeElapsed.ToString(Defaults.TimespanFormat);
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

        /// <summary>
        /// Прошедшее время
        /// </summary>
        [Browsable(false)]
        public TimeSpan TimeElapsed => StopWatch.Elapsed;

        #endregion Properties
    }
}