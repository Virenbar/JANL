using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    /// <summary>
    /// Элемент отображения времени выполнения на <see cref="StatusStrip"/>
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripStopwatch : ToolStripLabel
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Timer timer = new Timer { Interval = 500 };

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public ToolStripStopwatch()

        {
            timer.Tick += (object _, EventArgs e) => UpdateText();
            UpdateText();
        }

        /// <summary>
        /// Останавливает и сбрасывает измерение
        /// </summary>
        public void Reset()
        {
            stopwatch.Reset();
            timer.Stop();
            UpdateText();
        }

        /// <summary>
        /// Запускает измерение
        /// </summary>
        public void Start()
        {
            stopwatch.Restart();
            timer.Start();
        }

        /// <summary>
        /// Останавливает измерение
        /// </summary>
        public void Stop()
        {
            stopwatch.Stop();
            timer.Stop();
            UpdateText();
        }

        /// <summary>
        /// Обновляет текст
        /// </summary>
        protected void UpdateText()
        {
            var time = TimeElapsed.ToString(Defaults.TimespanFormat);
            base.Text = ShowText ? $"{Text}: {time}" : time;
        }

        #region Properties

        #region Designer
        private string _text = "Stopwatch";

        /// <summary>
        /// Частота обновления
        /// </summary>
        [Browsable(true), Category("ToolStripStopwatch"), DefaultValue(500)]
        public int RefreshInterval
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        /// <summary>
        /// Показывать текст перед временем
        /// </summary>
        [Browsable(true), Category("ToolStripStopwatch"), DefaultValue(true)]
        public bool ShowText { get; set; }

        /// <summary>
        /// Текст перед временем
        /// </summary>
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

        /// <summary>
        /// Измеренное время
        /// </summary>
        [Browsable(false)]
        public TimeSpan TimeElapsed => stopwatch.Elapsed;

        #endregion Properties
    }
}