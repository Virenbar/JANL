using JANL.Extensions;
using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class DataTableView : UserControl
    {
        private IEnumerable<string> Collumns;
        private DataTable DT;
        private IDTSource DTSource;

        public DataTableView()
        {
            InitializeComponent();
            TB_Filter.InputDone += TB_Filter_InputDone;
            DGV.AutoGenerateColumns = true;
            DGV.DoubleBuffered();

            DGV.DataSource = BS_View;
        }

        public T Field<T>(string name)
        {
            if (CurrentRow == null) { return default; }
            return CurrentRow.Field<T>(name);
        }

        public async Task RefreshDT()
        {
            if (DTSource == null) { return; }
            try
            {
                var OldDT = DT;
                var OldKey = CurrentKey;
                DT = await DTSource.GetDataTable();
                DGV.SetDataSource(DT);
                OldDT?.Dispose();
                if (OldKey != null) { BS_View.Position = BS_View.Find(DTSource.KeyName, OldKey); }
            }
            catch (Exception E)
            {
                Msgs.ShowException(E);
            }
            finally
            {
                DGV.PerformLayout();
            }
        }

        public void RefreshUI()
        {
            B_Refresh.Enabled = DTSource != null;
            TB_Filter.Enabled = Collumns.Count() > 0;
        }

        public void SetDataTable(DataTable DT)
        {
            DTSource = null;
            Collumns = DT.Columns.Cast<DataColumn>().Select(C => C.ColumnName);
            this.DT = DT;
            DGV.SetDataSource(DT);
            RefreshUI();
        }

        public void SetDTSource(IDTSource DTS)
        {
            DTSource = DTS;
            Collumns = DTS.FilterCollumns;
            RefreshUI();
        }

        public void SetTemplate(string Template) => DGVManager.ApplyTemplate(DGV, Template);

        private void ApplyFilter()
        {
            var Filter = TB_Filter.Text.Trim().RemoveSpecialCharacters();
            if (string.IsNullOrWhiteSpace(Filter) || Collumns.Count() == 0)
            {
                BS_View.Filter = "";
                return;
            }

            var OldKey = CurrentKey;
            if (FilterByMergedRow)
            {
                var MergedRow = string.Join("+' '+", Collumns.Select(C => $"Convert({C},'System.String')"));
                var Terms = Filter.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                BS_View.Filter = string.Join(" AND ", Terms.Select(T => $"{MergedRow} LIKE '%{T}%'"));
            }
            else
            {
                var CollumnsFilters = Collumns.Select(C => string.Format("({0} LIKE '%" + Filter.Replace(" ", "%' AND {0} LIKE '%") + "%')", $"Convert( {C}, 'System.String')"));
                BS_View.Filter = string.Join(" OR ", CollumnsFilters);
            }
            if (OldKey != null) { BS_View.Position = BS_View.Find(DTSource.KeyName, OldKey); }
        }

        private void RefreshBN()
        {
            BNS1.Visible = B_Create.Visible || B_Edit.Visible || B_Delete.Visible;
            BNS2.Visible = B_Refresh.Visible;
        }

        #region Properties

        /// <summary>
        /// Кол-во строк(с фильтром)
        /// </summary>
        public int Count => BS_View.Count;

        /// <summary>
        /// Кол-во строк(без фильтра)
        /// </summary>
        public int CountFull => (((DataTable)BS_View.DataSource)?.Rows.Count).GetValueOrDefault();

        /// <summary>
        ///
        /// </summary>
        public string CountText => Count == CountFull ? $"{CountFull}" : $"{Count}/{CountFull}";

        public object CurrentKey { get; set; }

        /// <summary>
        /// Текущая выбранная строка
        /// </summary>
        public DataRow CurrentRow => ((DataRowView)BS_View.Current)?.Row;

        public string CurrentValue { get; private set; }

        /// <summary>
        ///
        /// </summary>
        public DataGridView DataGridView => DGV;

        public ContextMenu Menu
        {
            get => DGV.ContextMenu;
            set => DGV.ContextMenu = value;
        }

        #region Designer

        [Browsable(true), Category("DataTableView"), Description("Кнопка создать"), DefaultValue(false)]
        public bool CreateVisible
        {
            get => B_Create.Visible;
            set
            {
                B_Create.Visible = value;
                RefreshBN();
            }
        }

        [Browsable(true), Category("DataTableView"), Description("Кнопка удалить"), DefaultValue(false)]
        public bool DeleteVisible
        {
            get => B_Delete.Visible;
            set
            {
                B_Delete.Visible = value;
                RefreshBN();
            }
        }

        [Browsable(true), Category("DataTableView"), Description("Кнопка изменить"), DefaultValue(true)]
        public bool EditVisible
        {
            get => B_Edit.Visible;
            set
            {
                B_Edit.Visible = value;
                RefreshBN();
            }
        }

        /// <summary>
        /// Фильтровать по объединенным столбцам
        /// </summary>
        [Browsable(true), Category("DataTableView"), Description("Фильтровать по объединенным столбцам"), DefaultValue(false)]
        public bool FilterByMergedRow { get; set; }

        [Browsable(true), Category("DataTableView"), Description("Фильтр строк"), DefaultValue(true)]
        public bool FilterVisible
        {
            get => TB_Filter.Visible;
            set
            {
                TB_Filter.Visible = value;
                RefreshBN();
            }
        }

        [Browsable(true), Category("DataTableView"), Description("Фильтр строк"), DefaultValue(true)]
        public bool RefreshVisible
        {
            get => B_Refresh.Visible;
            set
            {
                B_Refresh.Visible = value;
                RefreshBN();
            }
        }

        /// <summary>
        /// Время ожидания следующего нажатия
        /// </summary>
        [Browsable(true), Category("DataTableView"), Description("Время ожидания следующего нажатия"), DefaultValue(1000)]
        public int WaitTime
        {
            get => TB_Filter.WaitTime;
            set => TB_Filter.WaitTime = value;
        }

        #endregion Designer

        #endregion Properties

        #region UI Events

        private void BNB_Delete_Click(object sender, EventArgs e) => OnDeleteClick(EventArgs.Empty);

        private void BNB_Edit_Click(object sender, EventArgs e) => OnEditClick(EventArgs.Empty);

        private void BNB_New_Click(object sender, EventArgs e) => OnCreateClick(EventArgs.Empty);

        private async void BNB_Refresh_Click(object sender, EventArgs e)
        {
            B_Refresh.Enabled = false;
            await RefreshDT();
            B_Refresh.Enabled = true;
        }

        private void BS_View_CurrentChanged(object sender, EventArgs e)
        {
            var R = CurrentRow;
            if (R == null || DTSource == null) { return; }

            CurrentKey = R.Field<object>(DTSource.KeyName);
            CurrentValue = R.Field<string>(DTSource.ValueName);
        }

        private void TB_Filter_InputDone(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        #endregion UI Events

        #region Events

        protected void OnCreateClick(EventArgs args) => CreateClick?.Invoke(this, args);

        protected void OnDeleteClick(EventArgs args) => DeleteClick?.Invoke(this, args);

        protected void OnEditClick(EventArgs args) => EditClick?.Invoke(this, args);

        public event EventHandler CreateClick;

        public event EventHandler DeleteClick;

        public event EventHandler EditClick;

        #endregion Events
    }
}