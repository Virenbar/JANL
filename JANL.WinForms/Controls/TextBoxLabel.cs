using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Текстовое поле с заголовком
    /// </summary>
    public class TextBoxLabel : TextBox
    {
        /// <summary>
        /// Создаёт новое текстовое поле с заголовком
        /// </summary>
        public TextBoxLabel()
        {
            ForeColor = Color.Black;
            LabelColor = Color.SlateGray;
        }

        private void UpdateColor() => base.ForeColor = IsText ? ForeColor : LabelColor;

        private bool focused;

        #region Properties

        #region Designer
        private string LabelValue = "";
        private string TextValue = "";

        /// <summary>
        /// Цвет текста
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x000000"), Description("Цвет текста")]
        public new Color ForeColor { get; set; }

        /// <summary>
        /// Текст заголовка
        /// </summary>
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

        /// <summary>
        /// Цвет заголовка
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x708090"), Description("Цвет заголовка")]
        public Color LabelColor { get; set; }

        /// <summary>
        /// Текущий текст
        /// </summary>
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

        /// <summary>
        /// Отображается ли сейчас заголовок
        /// </summary>
        [Browsable(false)]
        public bool IsLabel => TextValue?.Length == 0;

        /// <summary>
        /// Отображается ли сейчас текст
        /// </summary>
        [Browsable(false)]
        public bool IsText => TextValue?.Length > 0;

        #endregion Properties

        #region Overrides

        /// <summary>
        ///
        /// </summary>
        protected override void OnGotFocus(EventArgs e)
        {
            focused = true;
            base.Text = TextValue;
            UpdateColor();
            base.OnGotFocus(e);
        }

        /// <summary>
        ///
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            focused = false;
            TextValue = base.Text;
            if (base.Text.Length == 0) { base.Text = Label; }
            base.OnLostFocus(e);
        }

        /// <summary>
        ///
        /// </summary>
        protected override void OnTextChanged(EventArgs e)
        {
            if (focused) { TextValue = base.Text; }
            UpdateColor();
            base.OnTextChanged(e);
        }

        #endregion Overrides
    }
}