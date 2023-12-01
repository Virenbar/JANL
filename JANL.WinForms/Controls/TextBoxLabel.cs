using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Controls
{
    public class TextBoxLabel : TextBox
    {
        public TextBoxLabel()
        {
            ForeColor = Color.Black;
            LabelColor = Color.SlateGray;
        }

        private void UpdateColor() => base.ForeColor = IsText ? ForeColor : LabelColor;

        #region Properties

        #region Designer
        private string LabelValue = "";
        private string TextValue = "";

        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x000000")]
        public new Color ForeColor { get; set; }

        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("Заголовок")]
        public string Label
        {
            get => LabelValue;
            set
            {
                if (LabelValue == value) { return; }
                LabelValue = value;
                if (TextValue.Length == 0) { base.Text = LabelValue; }
                UpdateColor();
            }
        }

        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x708090"), Description("Цвет заголовка")]
        public Color LabelColor { get; set; }

        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("Текст")]
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

        #endregion Designer

        [Browsable(false)]
        public bool IsLabel => TextValue?.Length == 0;

        [Browsable(false)]
        public bool IsText => TextValue?.Length > 0;

        #endregion Properties

        #region Overrides

        protected override void OnGotFocus(EventArgs e)
        {
            base.Text = TextValue;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (base.Text.Length == 0) { base.Text = Label; }
            base.OnLostFocus(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Focused) { TextValue = base.Text; }
            UpdateColor();
            base.OnTextChanged(e);
        }

        #endregion Overrides
    }
}