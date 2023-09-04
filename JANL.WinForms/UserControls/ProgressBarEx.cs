using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class ProgressBarEx : UserControl
    {
        private readonly Stopwatch SW;
        private double _Percent;

        public ProgressBarEx()
        {
            InitializeComponent();
            SW = new Stopwatch();
        }

        [Browsable(false)]
        public double Percent
        {
            get => _Percent;
            set
            {
                _Percent = value;
                var P = (int)_Percent;
                PB.Value = P;
                UpdateText();
                if (P == 100) { Stop(); }
            }
        }

        public void Start() => SW.Restart();

        public void Stop() => SW.Stop();

        private void UpdateText()
        {
            L_Percent.Text = $"{_Percent}%";
            L_Elapsed.Text = SW.Elapsed.ToString(Defaults.TimespanFormat);
            var E = PB.Value == 0 ? 0 : (SW.ElapsedMilliseconds / PB.Value) * (100 - PB.Value);
            L_Estimated.Text = TimeSpan.FromMilliseconds(E).ToString(Defaults.TimespanFormat);
        }
    }
}