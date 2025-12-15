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
    /// <summary>
    /// Элемент выбора месяца
    /// </summary>
    [Designer(typeof(HResizeOnly))]
    public partial class MonthPicker : UserControl
    {
        private readonly List<MonthItem> Months;

        /// <summary>
        /// Создаёт новы элемент выбора месяца
        /// </summary>
        public MonthPicker()
        {
            InitializeComponent();

            var T = DateTime.Today;
            Months = Enumerable.Range(1, 12).Select(i => new MonthItem(i)).ToList();
            CB_Month.DataSource = Months;
            CB_Month.DisplayMember = "Name";
            CB_Month.ValueMember = "Index";
            CB_Month.SelectedValue = T.Month;

            _MinYear = 2010;
            FillYear();
        }

        /// <summary>
        /// Вызывает <see cref="DateChanged"/>
        /// </summary>
        protected void OnDateChanged() => DateChanged?.Invoke(this, EventArgs.Empty);

        private void CB_Month_SelectedIndexChanged(object sender, EventArgs e) => OnDateChanged();

        private void CB_Year_SelectedIndexChanged(object sender, EventArgs e) => OnDateChanged();

        private void FillYear()
        {
            var Y = MaxYear ?? DateTime.Today.Year;
            CB_Year.DataSource = Enumerable.Range(MinYear, Y - MinYear + 1).ToList();
            if (MinYear <= Y) { CB_Year.Text = Y.ToString(); }
        }

        #region Properties
        private int? _MaxYear;
        private int _MinYear;

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
        /// Максимальный год
        /// </summary>
        [Browsable(true), Category("MonthPicker"), DefaultValue(null), Description("Максимальный год")]
        public int? MaxYear
        {
            get => _MaxYear;
            set
            {
                _MaxYear = value;
                FillYear();
            }
        }

        /// <summary>
        /// Минимальный год
        /// </summary>
        [Browsable(true), Category("MonthPicker"), DefaultValue(2010), Description("Минимальный год")]
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
        public int Month => (int)CB_Month.SelectedValue;

        /// <summary>
        /// Выбранный год
        /// </summary>
        [Browsable(false)]
        public int Year => (int)CB_Year.SelectedItem;

        #endregion Properties

        private struct MonthItem : IEquatable<MonthItem>
        {
            public MonthItem(int i)
            {
                Index = i;
                Name = $"{i:00} - {DateTimeFormatInfo.CurrentInfo.GetMonthName(i)}";
            }

            public int Index { get; set; }
            public string Name { get; set; }

            public bool Equals(MonthItem other) => Index.Equals(other);
        }

        /// <summary>
        /// Происходит при смене месяца
        /// </summary>
        public event EventHandler DateChanged;
    }
}