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
    public class ToolStripTaskProgress : ToolStripStatusLabel
    {
        public ToolStripTaskProgress()
        {
            Progress = new Progress<TaskProgress>(Handler);
            Clear();
        }

        public void Clear()
        {
            _status = "-";
            _value = "";
            UpdateText();
        }

        protected virtual void Handler(TaskProgress T)
        {
            if (T.HasStatus) { _status = T.Status; }
            if (T.HasValue)
            {
                _value = (T.Value + T.Max == 0) ? "" : $"{T.Value:N0}";
            }
            UpdateText();
        }

        protected virtual void UpdateText()
        {
            Text = $"{_text}: {_status} {_value}".Trim();
        }

        #region Properties

        #region Designer
        protected string _text = "Статус";

        [Browsable(true), DefaultValue("Статус")]
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

        protected string _status;
        protected string _value;

        [Browsable(false)]
        public Progress<TaskProgress> Progress { get; }

        [Browsable(false)]
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                UpdateText();
            }
        }

        [Browsable(false)]
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