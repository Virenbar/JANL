using JANL.Animators;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    /// <summary>
    ///
    /// </summary>
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

        #region Properties

        [Browsable(false)]
        public Spinner Spinner
        {
            get => _spinner;
            set
            {
                _spinner = value;
                ResetSpinner();
            }
        }

        [Browsable(false)]
        protected new string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        #endregion Properties
    }
}