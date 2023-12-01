using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripTextBoxLabel : ToolStripTextBox
    {
        private readonly Timer Timer = new Timer { Interval = 1000 };

        public ToolStripTextBoxLabel()
        {
            ForeColor = Color.Black;
            LabelColor = Color.SlateGray;
            ToolTipText = "Esc - очистить фильтр";
            Timer.Tick += Timer_Tick;
        }

        private void CompleteInput()
        {
            Timer.Stop();
            OnInputDone(EventArgs.Empty);
        }

        private void Timer_Tick(object sender, EventArgs e) => CompleteInput();

        private void UpdateColor() => base.ForeColor = IsText ? ForeColor : LabelColor;

        #region Properties

        #region Designer
        private string LabelValue = "";
        private string TextValue = "";

        [Browsable(true), Category("TextBoxLabel"), DefaultValue(typeof(Color), "0x000000")]
        public new Color ForeColor { get; set; }

        [Browsable(true), Category("TextBoxLabel"), DefaultValue(""), Description("Заголовок")]
        public string Label
        {
            get => LabelValue;
            set
            {
                if (LabelValue == value) { return; }
                LabelValue = value;
                if (TextValue?.Length == 0) { base.Text = LabelValue; }
                UpdateColor();
            }
        }

        [Browsable(true), Category("TextBoxLabel"), DefaultValue(typeof(Color), "0x708090"), Description("Цвет заголовка")]
        public Color LabelColor { get; set; }

        [Browsable(true), Category("TextBoxLabel"), DefaultValue(""), Description("Текст")]
        public new string Text
        {
            get => TextValue;
            set
            {
                if (TextValue == value) { return; }
                TextValue = value;
                base.Text = IsText ? TextValue : LabelValue;
                UpdateColor();
            }
        }

        [Browsable(true), Category("TextBoxLabel"), DefaultValue(1000)]
        public int WaitTime
        {
            get => Timer.Interval;
            set => Timer.Interval = value;
        }

        #endregion Designer

        [Browsable(false)]
        public bool IsText => TextValue?.Length > 0;

        [Browsable(false)]
        public bool IsLabel => TextValue?.Length == 0;

        #endregion Properties

        #region Overrides

        protected override void OnGotFocus(EventArgs e)
        {
            base.Text = TextValue;
            base.OnGotFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            Timer.Stop();
            Timer.Start();
            base.OnKeyDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (base.Text.Length == 0) { base.Text = Label; }
            CompleteInput();
            base.OnLostFocus(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Focused) { TextValue = base.Text; }
            UpdateColor();
            base.OnTextChanged(e);
        }

        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    base.Text = "";
                    CompleteInput();
                    return true;

                case Keys.Enter:
                    CompleteInput();
                    return true;

                default: return base.ProcessCmdKey(ref m, keyData);
            }
        }

        #endregion Overrides

        #region Events

        protected void OnInputDone(EventArgs e) => InputDone?.Invoke(this, e);

        public event EventHandler InputDone;

        #endregion Events
    }
}