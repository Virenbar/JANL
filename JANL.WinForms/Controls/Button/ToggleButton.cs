using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Кнопка с переключением
    /// </summary>
    public class ToggleButton : Button
    {
        private Image ImageOff;
        private string TextOff;

        #region Properties

        #region Designer

        private bool _toggled;

        /// <summary>
        /// Изображение включенной кнопки
        /// </summary>
        [Localizable(true), Category("ToggleButton")]
        public Image ImageOn { get; set; }

        /// <summary>
        /// Текст включенной кнопки
        /// </summary>
        [Localizable(true), Category("ToggleButton")]
        public string TextOn { get; set; }

        /// <summary>
        /// Переключена ли кнопка
        /// </summary>
        [Browsable(true), Category("ToggleButton"), DefaultValue(false)]
        public bool Toggled
        {
            get => _toggled;
            set
            {
                if (_toggled == value) { return; }

                if (value) { ToggleOn(); }
                else { ToggleOff(); }

            }
        }

        #endregion Designer

        #endregion Properties

        /// <summary>
        /// Private
        /// </summary>
        protected override void OnClick(EventArgs e)
        {
            Toggled = !Toggled;
            base.OnClick(e);
            if (Toggled) { OnToggleOn(e); }
            else { OnToggleOff(e); }
        }

        private void ToggleOff()
        {
            _toggled = false;
            Text = TextOff;
            Image = ImageOff;
        }

        private void ToggleOn()
        {
            _toggled = true;
            TextOff = Text;
            ImageOff = Image;
            Text = TextOn;
            Image = ImageOn;
        }

        #region Events

        /// <summary>
        /// Вызывает <see cref="ToggledOff"/>
        /// </summary>
        protected void OnToggleOff(EventArgs e) => ToggledOff?.Invoke(this, e);

        /// <summary>
        /// Вызывает <see cref="ToggledOn"/>
        /// </summary>
        protected void OnToggleOn(EventArgs e) => ToggledOn?.Invoke(this, e);

        /// <summary>
        /// Происходит при переключении в выключенное состояние
        /// </summary>
        [Browsable(true), Category("Action")]
        public event EventHandler ToggledOff;

        /// <summary>
        /// Происходит при переключении во включенное состояние
        /// </summary>
        [Browsable(true), Category("Action")]
        public event EventHandler ToggledOn;

        #endregion Events
    }
}