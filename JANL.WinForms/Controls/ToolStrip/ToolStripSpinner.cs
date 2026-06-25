using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using JANL.Animators;

namespace JANL.Controls
{
    /// <summary>
    /// Спиннер
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripSpinner : ToolStripLabel
    {
        private readonly Timer timer = new Timer { Interval = 100 };
        private int index;

        /// <summary>
        /// Создает элемент отображения спиннера
        /// </summary>
        public ToolStripSpinner()
        {
            Spinner = Spinner.Predefined.Default;
            timer.Tick += (object _, EventArgs e) => UpdateSpinner();
        }

        /// <summary>
        /// Запускает анимацию спиннера
        /// </summary>
        public void Start() => timer.Start();

        /// <summary>
        /// Останавливает анимацию спиннера
        /// </summary>
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
        private Spinner _spinner;

        /// <summary>
        /// Спиннер
        /// </summary>
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

        /// <summary>
        /// Текст
        /// </summary>
        [Browsable(false)]
        protected new string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        #endregion Properties
    }
}