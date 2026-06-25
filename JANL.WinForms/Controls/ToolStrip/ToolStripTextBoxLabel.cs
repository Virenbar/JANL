using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JANL.Controls
{
    /// <summary>
    /// Текстовое поле с заголовком и отложенным событием
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripTextBoxLabel : ToolStripTextBox
    {
        private readonly Timer Timer = new Timer { Interval = 1000 };
        private bool focused;

        /// <summary>
        /// Создаёт новое текстовое поле с заголовком
        /// </summary>
        public ToolStripTextBoxLabel()
        {
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
                if (_textValue?.Length == 0) { base.Text = _labelValue; }
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
                base.Text = IsText ? _textValue : _labelValue;
                UpdateColor();
            }
        }

        /// <summary>
        /// Время ожидания окончания ввода
        /// </summary>
        [Browsable(true), Category("TextBoxLabel"), DefaultValue(1000)]
        public int WaitTime
        {
            get => Timer.Interval;
            set => Timer.Interval = value;
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
        /// Создает событие <see cref="ToolStripControlHost.KeyDown"/>
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Timer.Stop();
            Timer.Start();
            base.OnKeyDown(e);
        }

        /// <summary>
        /// Создает событие <see cref="ToolStripControlHost.LostFocus"/>
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            focused = false;
            _textValue = base.Text;
            if (base.Text.Length == 0) { base.Text = Label; }
            CompleteInput();
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

        /// <summary>
        /// Обрабатывает управляющую клавишу.
        /// </summary>
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

        /// <summary>
        /// Вызывается при окончании ввода
        /// </summary>
        /// <param name="e"></param>
        protected void OnInputDone(EventArgs e) => InputDone?.Invoke(this, e);

        /// <summary>
        /// Происходит при окончании ввода
        /// </summary>
        public event EventHandler InputDone;

        #endregion Events
    }
}