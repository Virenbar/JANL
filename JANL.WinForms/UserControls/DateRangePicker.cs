using JANL.Extensions;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class DateRangePicker : UserControl
    {
        public DateRangePicker()
        {
            InitializeComponent();
            DTP_Begin.Value = DateTime.Now.FirstDay();
            DTP_End.Value = DateTime.Now.LastDay();
        }

        private void DTP_Begin_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_Begin.Focused && DTP_End.Value < DTP_Begin.Value)
            {
                DTP_End.Value = DTP_Begin.Value.LastDay();
            }
            OnDateChanged(EventArgs.Empty);
            OnDateBeginChanged(EventArgs.Empty);
        }

        private void DTP_End_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_End.Focused && DTP_Begin.Value > DTP_End.Value)
            {
                DTP_Begin.Value = DTP_End.Value.FirstDay();
            }
            OnDateChanged(EventArgs.Empty);
            OnDateEndChanged(EventArgs.Empty);
        }

        #region Properties

        [Browsable(false)]
        public DateTime DateBegin
        {
            get => DTP_Begin.Value;
            set => DTP_Begin.Value = value;
        }

        [Browsable(false)]
        public DateTime DateEnd
        {
            get => DTP_End.Value;
            set => DTP_End.Value = value;
        }

        [Browsable(true), Category("DateRangePicker"), DefaultValue("От")]
        public string LabelBegin
        {
            get => L_Begin.Text;
            set => L_Begin.Text = value;
        }

        [Browsable(true), Category("DateRangePicker"), DefaultValue("по")]
        public string LabelEnd
        {
            get => L_End.Text;
            set => L_End.Text = value;
        }

        #endregion Properties

        #region Events

        protected void OnDateBeginChanged(EventArgs args) => DateBeginChanged?.Invoke(this, args);

        protected void OnDateChanged(EventArgs args) => DateChanged?.Invoke(this, args);

        protected void OnDateEndChanged(EventArgs args) => DateEndChanged?.Invoke(this, args);

        /// <summary>
        /// Begin date changed
        /// </summary>
        public event EventHandler DateBeginChanged;

        /// <summary>
        /// Any date changed
        /// </summary>
        public event EventHandler DateChanged;

        /// <summary>
        /// End date changed
        /// </summary>
        public event EventHandler DateEndChanged;

        #endregion Events
    }
}