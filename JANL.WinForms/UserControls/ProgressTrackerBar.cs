using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class ProgressTrackerBar : UserControl, IProgress<int>
    {
        public ProgressTrackerBar()
        {
            InitializeComponent();
            Tracker = new ProgressTracker();
            Tracker.ProgressChanged += Tracker_ProgressChanged;
        }

        public void Reset()
        {
            Tracker.Reset();
            L_Count.Text = "-";
            L_Total.Text = "-";
            PB_Bar.Value = Tracker.Value;
            PB_Bar.Maximum = Tracker.Maximum;
            L_Elapsed.Text = "-";
            L_Average.Text = "-";
            L_Remaining.Text = "-";
        }

        public void Start() => Tracker.Start();

        public void Stop() => Tracker.Stop();

        private void RefreshUI()
        {
            L_Count.Text = $"{Tracker.Value}";
            L_Total.Text = $"{Tracker.Maximum}";
            PB_Bar.Value = Tracker.Value;
            PB_Bar.Maximum = Tracker.Maximum;
            L_Elapsed.Text = Tracker.TimeElapsed.ToString(Defaults.TimespanFormat);
            L_Average.Text = Tracker.TimeAverage.ToString(Defaults.TimespanFormat);
            L_Remaining.Text = Tracker.TimeRemaining.ToString(Defaults.TimespanFormat);
        }

        private void Tracker_ProgressChanged(object sender, int e)
        {
            RefreshUI();
        }

        void IProgress<int>.Report(int value) => ((IProgress<int>)Tracker).Report(value);

        #region Properties

        [Browsable(false)]
        public int Maximum
        {
            get => Tracker.Maximum;
            set => Tracker.Maximum = value;
        }

        [Browsable(false)]
        public int Value => Tracker.Value;

        [Browsable(false)]
        public ProgressTracker Tracker { get; }

        #region Designer

        [Browsable(true), Category("ProgressTrackerBar"), Description("Показывать процент"), DefaultValue(true)]
        public bool PercentVisible
        {
            get => L_Percent.Visible;
            set => L_Percent.Visible = value;
        }

        [Browsable(true), Category("ProgressTrackerBar"), Description("Лимит очереди"), DefaultValue(10)]
        public int QueueLimit
        {
            get => Tracker.QueueLimit;
            set => Tracker.QueueLimit = value;
        }

        [Browsable(true), Category("ProgressTrackerBar"), Description("Показывать среднее время"), DefaultValue(false)]
        public bool TimeAverageVisible
        {
            get => L_Average.Visible;
            set => L_Average.Visible = value;
        }

        [Browsable(true), Category("ProgressTrackerBar"), Description("Показывать пройденное время"), DefaultValue(true)]
        public bool TimeElapsedVisible
        {
            get => L_Elapsed.Visible;
            set => L_Elapsed.Visible = value;
        }

        [Browsable(true), Category("ProgressTrackerBar"), Description("Показывать оставшиеся время"), DefaultValue(true)]
        public bool TimeRemainingVisible
        {
            get => L_Remaining.Visible;
            set => L_Remaining.Visible = value;
        }

        [Browsable(true), Category("ProgressTrackerBar"), Description("Показывать значения"), DefaultValue(true)]
        public bool ValuesVisible
        {
            get => L_Count.Visible && L_Total.Visible;
            set
            {
                L_Count.Visible = value;
                L_Total.Visible = value;
            }
        }

        #endregion Designer

        #endregion Properties
    }
}