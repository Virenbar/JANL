using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL
{
    public class ToggleButton : Button
    {
        private Image ImageOff;
        private string TextOff;

        #region Properties

        #region Designer

        private bool _toggled;

        [Localizable(true), Category("ToggleButton")]
        public Image ImageOn { get; set; }

        [Localizable(true), Category("ToggleButton")]
        public string TextOn { get; set; }

        [Browsable(true), Category("ToggleButton"), DefaultValue(false)]
        public bool Toggled
        {
            get => _toggled;
            set
            {
                if (value != _toggled)
                {
                    if (value) { ToggleOn(); }
                    else { ToggleOff(); }
                }
            }
        }

        #endregion Designer

        #endregion Properties

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

        protected void OnToggleOff(EventArgs e) => ToggledOff?.Invoke(this, e);

        protected void OnToggleOn(EventArgs e) => ToggledOn?.Invoke(this, e);

        [Browsable(true), Category("Action")]
        public event EventHandler ToggledOff;

        [Browsable(true), Category("Action")]
        public event EventHandler ToggledOn;

        #endregion Events
    }
}