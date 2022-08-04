using JANL.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JANL.UserControls
{
    public partial class DGVTemplateEditor : UserControl
    {
        private Design Design;
        private bool SkipDGVEvent;

        public DGVTemplate GetTemplate() => Design.ToTemplate();

        public void SetTemplate(DGVTemplate Template)
        {
            Design = new Design(Template);
            ReCreateDGV();

            BS_Design.DataSource = Design;
            BS_Columns.DataSource = Design.Columns;
        }

        private void B_Export_Click(object sender, EventArgs e) => TB_XML.Text = DGVManager.ToXML(GetTemplate());

        private void B_Import_Click(object sender, EventArgs e)
        {
            try
            {
                var T = DGVManager.FromXML(TB_XML.Text);
                SetTemplate(T);
            }
            catch (Exception ex)
            {
                Msgs.ShowError(ex.Message);
            }
        }

        private void CheckOrder()
        {
            foreach (DataGridViewTextBoxColumn C in DGV_Template.Columns)
            {
                Debug.Print($"{C.HeaderText} { C.Index} { C.DisplayIndex}");
                if (C.Index != C.DisplayIndex) { break; }
                return;
            }
            var TC = DGV_Template.Columns.Cast<DataGridViewTextBoxColumn>().OrderBy(C => C.DisplayIndex).Select(C => ((DesignColumn)C.Tag).ToTemplate()).ToList();
            var T = new DGVTemplate { Columns = TC };
            SetTemplate(T);
        }

        private void DGVTemplateEditor_Load(object sender, EventArgs e)
        {
            var TC = new List<DGVTemplateColumn> {
                new DGVTemplateColumn("Column1", "Column1 Name", 100, DataGridViewAutoSizeColumnMode.None, false),
                new DGVTemplateColumn("Column2", "Column2 Name", 200, DataGridViewAutoSizeColumnMode.None, true),
                new DGVTemplateColumn("Column3", "Column3 Name", 200, DataGridViewAutoSizeColumnMode.Fill, true),
                new DGVTemplateColumn("Column4", "Column4 Name", 300, DataGridViewAutoSizeColumnMode.NotSet, true)
            };
            var T = new DGVTemplate { Columns = TC };
            SetTemplate(T);
        }

        private void ReCreateDGV()
        {
            SkipDGVEvent = true;
            DGV_Template.Columns.Clear();
            Design.Columns.ForEach(C => DGV_Template.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = C.Name, Tag = C }));

            SkipDGVEvent = false;
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            SkipDGVEvent = true;

            foreach (DataGridViewTextBoxColumn C in DGV_Template.Columns)
            {
                var DC = (DesignColumn)C.Tag;
                C.HeaderText = DC.Header;
                C.AutoSizeMode = DC.AutoSizeMode;
                C.Width = DC.Width;
                C.DataPropertyName = DC.Name;
                C.SortMode = DataGridViewColumnSortMode.NotSortable;
                C.DefaultCellStyle.ForeColor = DC.ForeColor;
                C.DefaultCellStyle.BackColor = DC.Visible ? Color.White : Color.SlateGray;
                //C.DefaultCellStyle.Font = C.Font;
            }

            var DT = new DataTable();
            Design.Columns.ForEach(C => DT.Columns.Add(new DataColumn(C.Name)));
            var R = DT.NewRow();
            Design.Columns.ForEach(C => R[C.Name] = $"{C.Name} Data");
            DT.Rows.Add(R);
            DGV_Template.DataSource = DT;

            if (BS_Columns.Position > 0)
            {
                DGV_Template.ClearSelection();
                DGV_Template[BS_Columns.Position, 0].Selected = true;
            }

            SkipDGVEvent = false;
        }

        #region BS Events

        private void BS_Columns_CurrentChanged(object sender, EventArgs e)
        {
            PG_Column.SelectedObject = BS_Columns.Current;
        }

        private void BS_Columns_CurrentItemChanged(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void BS_Columns_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemAdded)
            {
                ReCreateDGV();
            }
        }

        #endregion BS Events

        #region DGV Events

        private void DGV_Template_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0) { BS_Columns.Position = e.ColumnIndex; }
        }

        private void DGV_Template_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.Print($"Down: {e.Button}");
        }

        private void DGV_Template_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.Print($"Up: {e.Button}");
            if (e.Button == MouseButtons.Left) { CheckOrder(); }
        }

        private void DGV_Template_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Debug.Print($"Order I:{e.Column.HeaderText} DI:{e.Column.DisplayIndex}");
        }

        private void DGV_Template_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0) { BS_Columns.Position = e.ColumnIndex; }
        }

        #endregion DGV Events

        private void TSMI_Reset_Click(object sender, EventArgs e) => PG_Column.ResetSelectedProperty();
    }
}