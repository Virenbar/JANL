using JANL.Animators;
using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.ExtendedControls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripSpinner : ToolStripLabel
    {
        private readonly Timer timer = new Timer { Interval = 100 };
        private Spinner _spinner;
        private int index;

        public ToolStripSpinner()
        {
            Spinner = Spinner.Predefined.Default;
            timer.Tick += (object _, EventArgs e) => UpdateSpinner();
        }

        public Spinner Spinner
        {
            get => _spinner;
            set
            {
                _spinner = value;
                ResetSpinner();
            }
        }

        public void Start() => timer.Start();

        public void Stop()
        {
            timer.Stop();
            ResetSpinner();
        }

        private void ResetSpinner()
        {
            timer.Interval = Spinner.Interval.Milliseconds;
            index = 0;
            Text = "-";
        }

        private void UpdateSpinner()
        {
            var frame = Spinner.Frames[index];
            index = (index + 1) % Spinner.Frames.Count;
            Text = frame;
        }
    }
}