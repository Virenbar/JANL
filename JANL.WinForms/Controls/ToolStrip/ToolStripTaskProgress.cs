using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    /// <summary>
    /// Отображает статус на основе <see cref="Progress"/>
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripTaskProgress : ToolStripStatusLabel
    {
        /// <summary>
        /// Создает новый элемент
        /// </summary>
        public ToolStripTaskProgress()
        {
            Progress = new Progress<TaskProgress>(Handler);
            Clear();
        }

        /// <summary>
        /// Очистить статус
        /// </summary>
        public void Clear()
        {
            _status = "-";
            _value = "";
            UpdateText();
        }

        private void Handler(TaskProgress T)
        {
            if (T.HasStatus) { _status = T.Status; }
            if (T.HasValue)
            {
                _value = (T.Value + T.Max == 0) ? "" : $"{T.Value:N0}";
            }
            UpdateText();
        }

        private void UpdateText()
        {
            if (!(_showStatus || _showValue || _text.Length > 0))
            {
                Text = string.Empty;
                return;
            }

            var SB = new StringBuilder();
            if (_text.Length > 0)
            {
                SB.Append("{_text}:");
            }
            if (_showStatus)
            {
                SB.Append($" {_status}");
            }
            if (_showValue)
            {
                SB.Append($" {_value}");
            }
            Text = SB.ToString();
        }

        #region Properties

        #region Designer
        private bool _showStatus = true;
        private bool _showValue = true;
        private string _text = "Статус";

        /// <summary>
        /// Показывать статус
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(true), Description("Показывать статус")]
        public bool ShowStatus
        {
            get => _showStatus;
            set
            {
                _showStatus = value;
                UpdateText();
            }
        }

        /// <summary>
        /// Показывать значение
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(true), Description("Показывать значение")]
        public bool ShowValue
        {
            get => _showValue;
            set
            {
                _showValue = value;
                UpdateText();
            }
        }

        /// <summary>
        /// Текст заголовка статуса
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue("Статус"), Description("Текст заголовка статуса")]
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

        private string _status;
        private string _value;

        /// <summary>
        /// <see cref="System.Progress{T}"/> для отправки статуса
        /// </summary>
        [Browsable(false)]
        public Progress<TaskProgress> Progress { get; }

        /// <summary>
        /// Текст статуса
        /// </summary>
        [Browsable(false), Description("Текст статуса")]
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                UpdateText();
            }
        }

        /// <summary>
        /// Значение статуса
        /// </summary>
        [Browsable(false), Description("Значение статуса")]
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateText();
            }
        }

        #endregion Properties
    }
}