using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.ExtendedControls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripStopwatch : ToolStripLabel
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Timer timer = new Timer() { Interval = 500 };
        private string textValue = "Stopwatch";

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

        private void UpdateText()
        {
            base.Text = $"{textValue}: {stopwatch.Elapsed.ToString(Defaults.TimespanFormat)}";
        }

        #region Properties

        #region Designer

        [Browsable(true), Category("ToolStripStopwatch"), DefaultValue(500)]
        public int RefreshInterval
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        [Browsable(true), DefaultValue("Stopwatch")]
        public new string Text

        {
            get => textValue;
            set
            {
                textValue = value;
                UpdateText();
            }
        }

        #endregion Designer

        [Browsable(false)]
        public TimeSpan TimeElapsed => stopwatch.Elapsed;

        #endregion Properties
    }
}