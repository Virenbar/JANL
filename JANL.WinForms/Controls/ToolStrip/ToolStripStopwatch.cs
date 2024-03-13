using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    /// <summary>
    ///
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripStopwatch : ToolStripLabel
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Timer timer = new Timer { Interval = 500 };

        public ToolStripStopwatch()
        {
            timer.Tick += (object _, EventArgs e) => UpdateText();
            UpdateText();
        }

        public void Reset()
        {
            stopwatch.Reset();
            timer.Stop();
            UpdateText();
        }

        public void Start()
        {
            stopwatch.Restart();
            timer.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
            timer.Stop();
            UpdateText();
        }

        protected void UpdateText()
        {
            var time = stopwatch.Elapsed.ToString(Defaults.TimespanFormat);
            base.Text = ShowText ? $"{_text}: {time}" : time;
        }

        #region Properties

        #region Designer
        protected string _text = "Stopwatch";

        [Browsable(true), Category("ToolStripStopwatch"), DefaultValue(500)]
        public int RefreshInterval
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        [Browsable(true), Category("ToolStripStopwatch"), DefaultValue(true)]
        public bool ShowText { get; set; }

        [Browsable(true), DefaultValue("Stopwatch")]
        public new string Text

        {
            get => _text;
            set
            {
                _text = value;
                UpdateText();
            }
        }

        #endregion Designer

        [Browsable(false)]
        public TimeSpan TimeElapsed => stopwatch.Elapsed;

        #endregion Properties
    }
}