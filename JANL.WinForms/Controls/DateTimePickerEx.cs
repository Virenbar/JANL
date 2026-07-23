using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace JANL
{
    /// <summary>
    /// <see cref="DateTimePicker"/> с рабочей привязкой
    /// </summary>
    public sealed class DateTimePickerEx : DateTimePicker
    {
        /// <summary>
        ///
        /// </summary>
        public DateTimePickerEx()
        {
            base.ShowCheckBox = true;
            Format = DateTimePickerFormat.Short;
        }

        /// <summary>
        ///
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ShowCheckBox => base.ShowCheckBox;

        /// <summary>
        /// Значение
        /// </summary>
        [Bindable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public new DateTime? Value
        {
            get => Checked ? new DateTime?(base.Value) : null;
            set
            {
                base.Value = value ?? DateTime.Now;
                Checked = value.HasValue;
            }
        }

        /// <summary>
        /// Private
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (!Checked) { ForceWrite(); }
        }

        /// <summary>
        /// Private
        /// </summary>
        protected override void OnValidated(EventArgs e) => base.OnValidated(e);

        /// <summary>
        /// Private
        /// </summary>
        protected override void OnValueChanged(EventArgs eventargs) => base.OnValueChanged(eventargs);

        private void ForceWrite()
        {
            foreach (Binding B in DataBindings)
            {
                B.WriteValue();
            }
        }
    }
}