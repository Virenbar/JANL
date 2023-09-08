using JANL.Extensions;
using JANL.Helpers;
using JANL.Managers;
using JANL.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JANL.UserControls
{
    [DefaultEvent(nameof(RowDoubleClick))]
    public partial class DataTableView : UserControl
    {
        private readonly List<string> Columns = new List<string>();
        private DataTable DT;

        public DataTableView()
        {
            InitializeComponent();
            TB_Filter.InputDone += TB_Filter_InputDone;
            DGV.AutoGenerateColumns = true;
            DGV.DoubleBuffered();
            DGV.DataSource = BS_View;
        }

        public T CurrentKeyCast<T>()
        {
            if (CurrentKey == null) { return default; }
            return (T)CurrentKey;
        }

        public T Field<T>(string name)
        {
            if (CurrentRow == null || !CurrentRow.Table.Columns.Contains(name)) { return default; }
            return CurrentRow.Field<T>(name);
        }

        public void SetDataTable(DataTable DT)
        {
            if (IsDisposed) { return; }
            try
            {
                if (Columns.Count == 0) { Columns.AddRange(DT.Columns.Cast<DataColumn>().Select(C => C.ColumnName)); }
                if (string.IsNullOrWhiteSpace(KeyName)) { KeyName = Columns.First(); }
                if (string.IsNullOrWhiteSpace(ValueName)) { ValueName = Columns.First(); }

                var oldDatatable = this.DT;
                var oldKey = CurrentKey;
                this.DT = DT;
                DGV.SetDataSource(DT);
                oldDatatable?.Dispose();
                if (oldKey != null) { BS_View.Position = BS_View.Find(KeyName, oldKey); }
            }
            catch (Exception E)
            {
                Msgs.ShowException(E);
            }
            finally
            {
                DGV.PerformLayout();
            }
            RefreshUI();
        }

        public void SetFilterColumns(IEnumerable<string> columns)
        {
            Columns.Clear();
            Columns.AddRange(columns);
            RefreshUI();
        }

        /// <summary>
        /// Apply template from <see cref="DGVManager"/>
        /// </summary>
        /// <param name="Template">Template Name</param>
        public void SetTemplate(string Template) => DGVManager.ApplyTemplate(DGV, Template);

        /// <summary>
        /// Apply template
        /// </summary>
        /// <param name="Template">Template</param>
        public void SetTemplate(DGVTemplate Template) => DGVManager.ApplyTemplate(DGV, Template);

        private void ApplyFilter()
        {
            var filter = TB_Filter.Text.Trim().RemoveSpecialCharacters();
            if (string.IsNullOrWhiteSpace(filter) || Columns.Count == 0)
            {
                BS_View.Filter = "";
                return;
            }

            var oldKey = CurrentKey;
            BS_View.Filter = FilterByMergedRow ? FilterHelper.RowFilterByRow(Columns, filter) : FilterHelper.RowFilterByColumns(Columns, filter);
            if (oldKey != null) { BS_View.Position = BS_View.Find(KeyName, oldKey); }
        }

        private void RefreshBN()
        {
            BNS1.Visible = B_Create.Visible || B_Edit.Visible || B_Delete.Visible;
            BNS2.Visible = B_Refresh.Visible;
        }

        private void RefreshUI()
        {
            TB_Filter.Enabled = Columns.Count > 0;
            B_Edit.Enabled = Count > 0;
            B_Delete.Enabled = Count > 0;
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
        /// Кол-во строк
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

        [Browsable(true), Category("DataTableView"), Description("Наименование ключа"), DefaultValue("")]
        public string KeyName { get; set; }

        [Browsable(true), Category("DataTableView"), Description("Кнопка обновить"), DefaultValue(true)]
        public bool RefreshVisible
        {
            get => B_Refresh.Visible;
            set
            {
                B_Refresh.Visible = value;
                RefreshBN();
            }
        }

        [Browsable(true), Category("DataTableView"), Description("Наименование значения"), DefaultValue("")]
        public string ValueName { get; set; }

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

        private void BNB_Refresh_Click(object sender, EventArgs e) => OnRefreshClick(EventArgs.Empty);

        private void BS_View_CurrentChanged(object sender, EventArgs e)
        {
            var row = CurrentRow;
            CurrentKey = row?.Field<object>(KeyName);
            CurrentValue = row?.Field<object>(ValueName).ToString();

            OnCurrentRowChanged(EventArgs.Empty);
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            OnRowDoubleClick(EventArgs.Empty);
        }

        private void TB_Filter_InputDone(object sender, EventArgs e)
        {
            ApplyFilter();
            RefreshUI();
        }

        #endregion UI Events

        #region Events

        protected void OnCreateClick(EventArgs args) => CreateClick?.Invoke(this, args);

        protected void OnCurrentRowChanged(EventArgs args) => CurrentRowChanged?.Invoke(this, args);

        protected void OnDeleteClick(EventArgs args) => DeleteClick?.Invoke(this, args);

        protected void OnEditClick(EventArgs args) => EditClick?.Invoke(this, args);

        protected void OnRefreshClick(EventArgs args) => RefreshClick?.Invoke(this, args);

        protected void OnRowDoubleClick(EventArgs args) => RowDoubleClick?.Invoke(this, args);

        [Category("DataTableView")]
        public event EventHandler CreateClick;

        [Category("DataTableView")]
        public event EventHandler CurrentRowChanged;

        [Category("DataTableView")]
        public event EventHandler DeleteClick;

        [Category("DataTableView")]
        public event EventHandler EditClick;

        [Category("DataTableView")]
        public event EventHandler RefreshClick;

        [Category("DataTableView")]
        public event EventHandler RowDoubleClick;

        #endregion Events
    }
}