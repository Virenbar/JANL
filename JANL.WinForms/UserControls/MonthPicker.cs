using JANL.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace JANL.UserControls
{
    [Designer(typeof(HResizeOnly))]
    public partial class MonthPicker : UserControl
    {
        private int _MinYear;
        private List<MonthItem> Months;

        public MonthPicker()
        {
            InitializeComponent();

            var T = DateTime.Today;
            Months = Enumerable.Range(1, 12).Select(i => new MonthItem(System.Convert.ToUInt16(i), DateTimeFormatInfo.CurrentInfo.GetMonthName(i))).ToList();
            CB_Month.DataSource = Months;
            CB_Month.DisplayMember = "Name";
            CB_Month.ValueMember = "Index";
            CB_Month.SelectedValue = System.Convert.ToUInt16(T.Month);

            _MinYear = 2010;
            FillYear();
        }

        /// <summary>
        /// Первый день месяца
        /// </summary>
        [Browsable(true), Category("MonthPicker")]
        public DateTime FirstDate => new DateTime(Year, Month, 1);

        /// <summary>
        /// Последний день месяца
        /// </summary>
        [Browsable(true), Category("MonthPicker")]
        public DateTime LastDate => new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));

        /// <summary>
        /// Минимальный год
        /// </summary>
        [Browsable(true), Category("MonthPicker"), DefaultValue(2010)]
        public int MinYear
        {
            get => _MinYear;
            set
            {
                _MinYear = value;
                FillYear();
            }
        }

        /// <summary>
        /// Выбранный месяц
        /// </summary>
        [Browsable(false)]
        public ushort Month => (ushort)CB_Month.SelectedValue;

        /// <summary>
        /// Выбранный год
        /// </summary>
        [Browsable(false)]
        public int Year => (int)CB_Year.SelectedItem;

        protected void OnDateChanged() => DateChanged?.Invoke(this, EventArgs.Empty);

        private void CB_Month_SelectedIndexChanged(object sender, EventArgs e) => OnDateChanged();

        private void CB_Year_SelectedIndexChanged(object sender, EventArgs e) => OnDateChanged();

        private void FillYear()
        {
            var Y = DateTime.Today.Year;
            CB_Year.DataSource = Enumerable.Range(MinYear, Y - MinYear + 1).ToList();
            if (MinYear <= Y) { CB_Year.Text = Y.ToString(); }
        }

        private struct MonthItem
        {
            public MonthItem(ushort I, string N)
            {
                Index = I;
                Name = N;
            }

            public ushort Index { get; set; }
            public string Name { get; set; }
        }

        public event EventHandler DateChanged;
    }
}