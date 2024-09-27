using JANL.Designers;
using JANL.Extensions;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace JANL.UserControls
{
    [DefaultBindingProperty("Value")]
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Value")]
    [Designer(typeof(HResizeOnly))]
    public partial class YearPicker : UserControl
    {
        public YearPicker()
        {
            InitializeComponent();
            MinYear = 2000;
            MaxYear = 3000;
            NUD_Year.Value = DateTime.Today.Year;
        }

        #region Properties

        /// <summary>
        /// Максимальный год
        /// </summary>
        [Browsable(true), Category("YearPicker"), DefaultValue(3000)]
        public int MaxYear
        {
            get => (int)NUD_Year.Maximum;
            set => NUD_Year.Maximum = value;
        }

        /// <summary>
        /// Минимальный год
        /// </summary>
        [Browsable(true), Category("YearPicker"), DefaultValue(2000)]
        public int MinYear
        {
            get => (int)NUD_Year.Minimum;
            set => NUD_Year.Minimum = value;
        }

        /// <summary>
        /// Выбранный год
        /// </summary>
        [Browsable(true), Category("YearPicker"), DefaultValue(null)]
        [RefreshProperties(RefreshProperties.All)]
        public int? Value
        {
            get => CB_Year.Checked ? (int?)NUD_Year.Value : null;
            set
            {
                if (value == NUD_Year.Value && CB_Year.Checked) { return; }
                if (value.HasValue)
                {
                    CB_Year.Checked = true;
                    NUD_Year.Value = value.Value.Clamp(MinYear, MaxYear);
                }
                else
                {
                    CB_Year.Checked = false;
                }
            }
        }

        #endregion Properties

        #region Events

        protected void OnValueChanged() => ValueChanged?.Invoke(this, EventArgs.Empty);

        private void CB_Year_CheckedChanged(object sender, EventArgs e)
        {
            OnValueChanged();
        }

        private void NUD_Year_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged();
        }

        public event EventHandler ValueChanged;

        #endregion Events
    }
}