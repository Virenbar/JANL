using JANL.Managers;
using System;
using System.Data;
using System.Windows.Forms;

namespace JANL.Controls
{
    internal class DataGridViewExtended : DataGridView
    {
        private readonly BindingSource BS;

        public DataGridViewExtended()
        {
            BS = new BindingSource();
            DataSource = BS;
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        public DataRow Current => ((DataRowView)BS.Current)?.Row;

        public void SetDataTable(DataTable DT) => BS.DataSource = DT;

        public void SetTemplate(string Template) => DGVManager.ApplyTemplate(this, Template);

        public T Field<T>(string Name)
        {
            if (Current == null || !Current.Table.Columns.Contains(Name)) { return default; }
            return Current.Field<T>(Name);
        }
    }
}