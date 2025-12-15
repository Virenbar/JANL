using JANL.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Тестовое поле с проверкой через Regex
    /// </summary>
    public class RegexTextBox : TextBox
    {
        public RegexTextBox()
        {
            BackColor = Color.White;
            ValidColor = Colors.Common.Good;
            RequiredColor = Colors.Common.Unknown;
            InvalidColor = Colors.Common.Bad;
            Validate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            IsValid = Validate();
            base.OnTextChanged(e);
        }

        protected override void OnValidated(EventArgs e) => base.OnValidated(e);

        protected override void OnValidating(CancelEventArgs e)
        {
            IsValid = Validate();
            if (!IsValid && Message?.Length > 0 && Text.Length > 0)
            {
                e.Cancel = true;
                this.ShowWarning(Message);
            }

            base.OnValidating(e);
        }

        private bool Validate()
        {
            if (Pattern.Length == 0) { return true; }
            if (Text.Length == 0)
            {
                base.BackColor = Required ? RequiredColor : BackColor;
                return !Required;
            }

            var R = Regex.IsMatch(Text, Pattern);
            base.BackColor = R ? ValidColor : InvalidColor;
            return R;
        }

        #region Properties

        private string _Pattern = "";
        private bool _Required;

        /// <summary>
        /// Верно но ли заполнено поле
        /// </summary>
        [Browsable(false)]
        public bool IsValid { get; private set; }

        /// <summary>
        /// Сообщение при неверном заполнении поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(""), Description("Сообщение при неверном заполнении поля")]
        public string Message { get; set; }

        /// <summary>
        /// Шаблон проверки поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(""), Description("Шаблон проверки поля")]
        public string Pattern
        {
            get { return _Pattern; }
            set
            {
                _Pattern = value;
                Validate();
            }
        }

        /// <summary>
        /// Обязательно ли заполнение поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(false), Description("Обязательно ли заполнение поля")]
        public bool Required
        {
            get { return _Required; }
            set
            {
                _Required = value;
                Validate();
            }
        }

        #region Colors

        /// <summary>
        /// Цвет необязательного поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(typeof(Color), "0xFFFFFF"), Description("Цвет необязательного поля")]
        public new Color BackColor { get; set; }

        /// <summary>
        /// Цвет неверно заполненного поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(typeof(Color), "0xFFE4E1"), Description("Цвет неверно заполненного поля")]
        public Color InvalidColor { get; set; }

        /// <summary>
        /// Цвет обязательного поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(typeof(Color), "0xFFFFE0"), Description("Цвет обязательного поля")]
        public Color RequiredColor { get; set; }

        /// <summary>
        /// Цвет верно заполненного поля
        /// </summary>
        [Browsable(true), Category("RegexTextBox"), DefaultValue(typeof(Color), "0x90EE90"), Description("Цвет верно заполненного поля")]
        public Color ValidColor { get; set; }

        #endregion Colors

        #endregion Properties
    }
}