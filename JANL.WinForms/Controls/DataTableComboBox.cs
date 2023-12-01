using System;
using System.Data;
using System.Windows.Forms;

namespace JANL.Controls
{
    public abstract class DataTableComboBox : ComboBox
    {
        protected DataView DV;
        protected string KeyName;
        protected string ValueName;
        private static readonly DataSet DataTableCache = new DataSet("ComboBoxCache");
        private bool SuppressEvents = true;

        protected DataTableComboBox(string keyName, string valueName) : this()
        {
            KeyName = keyName;
            ValueName = valueName;
        }

        private DataTableComboBox() { AddEmptyRow = false; }

        /// <summary>
        /// Удаляет все таблицы из кэша
        /// </summary>
        public static void ClearCache() => DataTableCache.Tables.Clear();

        public void FillComboBox()
        {
            SuppressEvents = true;

            var TableName = $"ItemsOf{KeyName}{(AddEmptyRow ? "WithEmpty" : "")}";
            DataTable DT;
            if (UseCache && DataTableCache.Tables.Contains(TableName))
            {
                DT = DataTableCache.Tables[TableName];
            }
            else
            {
                DT = GetDataTable();
                if (AddEmptyRow)
                {
                    DT.Rows.InsertAt(GetEmptyRow(DT), 0);
                    DT.AcceptChanges();
                }
                if (UseCache)
                {
                    DT.TableName = TableName;
                    DataTableCache.Tables.Add(DT);
                }
            }
            DV = new DataView(DT);
            DataSource = DV;
            ValueMember = KeyName;
            DisplayMember = ValueName;
            if (string.IsNullOrWhiteSpace(ValueMember)) { ValueMember = DT.Columns[0].ColumnName; }

            SuppressEvents = false;
        }

        protected override void Dispose(bool disposing)
        {
            DV?.Dispose();
            base.Dispose(disposing);
        }

        protected abstract DataTable GetDataTable();

        protected virtual DataRow GetEmptyRow(DataTable DT)
        {
            var Row = DT.NewRow();
            Row[KeyName] = DBNull.Value;
            Row[ValueName] = "";
            return Row;
        }

        #region Properties

        /// <summary>
        /// Добавлять пустую строку в начале списка
        /// </summary>
        public bool AddEmptyRow { get; set; }

        /// <summary>
        /// Ключ выбранного значения
        /// </summary>
        public object CurrentKey => SelectedValue;

        /// <summary>
        /// Выбранное значение
        /// </summary>
        public string CurrentValue => GetItemText(SelectedItem);

        /// <summary>
        /// Выбранная строка
        /// </summary>
        protected DataRow CurrentRow => ((DataRowView)SelectedItem)?.Row;

        /// <summary>
        /// Фильтр строк
        /// </summary>
        protected string Filter
        {
            get => DV.RowFilter;
            set => DV.RowFilter = value;
        }

        /// <summary>
        /// Добавлять таблицу в кэш
        /// </summary>
        protected bool UseCache { get; set; }

        #endregion Properties

        #region Events

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (SuppressEvents) { return; }
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            if (SuppressEvents) { return; }
            base.OnSelectedItemChanged(e);
        }

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            if (SuppressEvents) { return; }
            base.OnSelectedValueChanged(e);
        }

        #endregion Events
    }
}