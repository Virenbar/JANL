using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace JANL
{
    public class DateTimePickerEx : DateTimePicker
    {
        public DateTimePickerEx()
        {
            base.ShowCheckBox = true;
            Format = DateTimePickerFormat.Short;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ShowCheckBox => base.ShowCheckBox;

        [Bindable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public new DateTime? Value
        {
            get => Checked ? new DateTime?(base.Value) : null;
            set
            {
                base.Value = value ?? DateTime.Now;
                Checked = Value.HasValue;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (!Checked) { ForceWrite(); }
        }

        protected override void OnValidated(EventArgs e) => base.OnValidated(e);

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