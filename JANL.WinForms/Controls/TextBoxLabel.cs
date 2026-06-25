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
        private bool focused;

        /// <summary>
        /// Создаёт новое текстовое поле с заголовком
        /// </summary>
        public TextBoxLabel() { }

        private void UpdateColor() => base.ForeColor = IsText ? _foreColor : _labelColor;

        private void UpdateText() => base.Text = IsText ? _textValue : _labelValue;

        #region Properties

        #region Designer
        private Color _foreColor = Color.Black;
        private Color _labelColor = Color.SlateGray;
        private string _labelValue = "";
        private string _textValue = "";

        /// <summary>
        /// Цвет текста
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x000000"), Description("Цвет текста")]
        public new Color ForeColor
        {
            get => _foreColor;
            set
            {
                if (_foreColor == value) { return; }
                _foreColor = value;
                UpdateColor();
            }
        }

        /// <summary>
        /// Текст заголовка
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("Текст заголовка")]
        public string Label
        {
            get => _labelValue;
            set
            {
                if (_labelValue == value) { return; }
                _labelValue = value;
                UpdateText();
                UpdateColor();
            }
        }

        /// <summary>
        /// Цвет заголовка
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "0x708090"), Description("Цвет заголовка")]
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor == value) { return; }
                _labelColor = value;
                UpdateColor();
            }
        }

        /// <summary>
        /// Текущий текст
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("Текст")]
        public new string Text
        {
            get => _textValue;
            set
            {
                if (_textValue == value) { return; }
                _textValue = value;
                UpdateText();
                UpdateColor();
            }
        }

        #endregion Designer

        /// <summary>
        /// Отображается ли сейчас заголовок
        /// </summary>
        [Browsable(false)]
        public bool IsLabel => _textValue?.Length == 0;

        /// <summary>
        /// Отображается ли сейчас текст
        /// </summary>
        [Browsable(false)]
        public bool IsText => _textValue?.Length > 0;

        #endregion Properties

        #region Overrides

        /// <summary>
        /// Создает событие <see cref="ToolStripControlHost.GotFocus"/>
        /// </summary>
        protected override void OnGotFocus(EventArgs e)
        {
            focused = true;
            base.Text = _textValue;
            UpdateColor();
            base.OnGotFocus(e);
        }

        /// <summary>
        /// Создает событие <see cref="ToolStripControlHost.LostFocus"/>
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            focused = false;
            _textValue = base.Text;
            if (base.Text.Length == 0) { base.Text = Label; }
            base.OnLostFocus(e);
        }

        /// <summary>
        ///
        /// </summary>
        protected override void OnTextChanged(EventArgs e)
        {
            if (focused) { _textValue = base.Text; }
            UpdateColor();
            base.OnTextChanged(e);
        }

        #endregion Overrides
    }
}
