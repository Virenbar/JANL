using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JANL
{
    /// <summary>
    /// Фильтр для DataGridView
    /// </summary>
    public class DGVFilter : ToolStripTextBox
    {
        private readonly Color OffColor = Color.Gray;
        private readonly string OffText = "Фильтр";
        private readonly Timer Timer = new Timer() { Interval = 1000 };
        private IEnumerable<string> Collumns;
        private DataGridView DGV;

        public DGVFilter()
        {
            DefaultLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
            Timer.Tick += Timer_Tick;
            LostFocus += DGVFilter_LostFocus;
            GotFocus += DGVFilter_GotFocus;
            KeyDown += DGVFilter_KeyDown;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="DGV">Таблица для поиска</param>
        /// <param name="Collumns">Столбцы для поиска</param>
        public void Init(DataGridView DGV, IEnumerable<string> Collumns)
        {
            this.DGV = DGV;
            this.Collumns = Collumns;
            {
                var Parent = DGV.FindForm();
                Parent.KeyPreview = true;
                Parent.KeyDown += DGV_Search_F;
            }
            ForeColor = OffColor;
            Text = OffText;
        }

        public void SetFilter(string str)
        {
            ForeColor = string.IsNullOrWhiteSpace(str) ? OffColor : Color.Empty;
            Text = str;
            ApplyFilter();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Text = "";
                    ApplyFilter();
                    return true;

                case Keys.Enter:
                    ApplyFilter();
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void ApplyFilter()
        {
            Timer.Stop();
            var BS = (BindingSource)DGV.DataSource;
            if (Text == "")
            {
                BS.Filter = null;
                return;
            }
            var LF = Collumns.Select(c => string.Format("({0} Like '%" + Text.Trim().Replace(" ", "%' AND {0} Like '%") + "%')", c));
            BS.Filter = string.Join(" OR ", LF);
            OnFilterApplied();
        }

        #region Properties

        public InputLanguage DefaultLanguage { get; set; }

        public int WaitTime
        {
            get => Timer.Interval;
            set => Timer.Interval = value;
        }

        #endregion Properties

        #region UI Events

        private void DGV_Search_F(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Focus();
                e.Handled = true;
            }
        }

        private void DGVFilter_GotFocus(object sender, EventArgs e)
        {
            if (ForeColor == OffColor)
            {
                ForeColor = Color.Empty;
                Text = "";
            }
            InputLanguage.CurrentInputLanguage = DefaultLanguage;
        }

        private void DGVFilter_KeyDown(object sender, KeyEventArgs e)
        {
            Timer.Stop();
            Timer.Start();
        }

        private void DGVFilter_LostFocus(object sender, EventArgs e)
        {
            if (Text.Length == 0)
            {
                ApplyFilter();
                ForeColor = OffColor;
                Text = OffText;
            }
        }

        #endregion UI Events

        private void Timer_Tick(object sender, EventArgs e) => ApplyFilter();

        #region Events

        protected void OnFilterApplied() => FilterApplied?.Invoke(this, EventArgs.Empty);

        public event EventHandler FilterApplied;

        #endregion Events
    }
}