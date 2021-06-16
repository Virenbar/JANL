using DGVTemplateEditor.Types;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;

namespace DGVTemplateEditor
{
	public partial class FormEditor : Form
	{
		private bool SkipEvent = false;
		private readonly DataTable DT = new DataTable();
		private Design Design;

		public FormEditor()

		{
			InitializeComponent();
			FCTB_Template.SyntaxHighlighter.InitStyleSchema(Language.XML);
			FCTB_Template.SyntaxHighlighter.XMLSyntaxHighlight(FCTB_Template.Range);

			Design = new Design
			{
				Columns = new List<DesignColumn>
				{
					new DesignColumn("TestColumn1", "Test Column 1", 100, DataGridViewAutoSizeColumnMode.None, false),
					new DesignColumn("TestColumn2", "Test Column 2", 200, DataGridViewAutoSizeColumnMode.None, true),
					new DesignColumn("TestColumn3", "Test Column 3", 200, DataGridViewAutoSizeColumnMode.Fill, true),
					new DesignColumn("TestColumn4", "Test Column 4", 300, DataGridViewAutoSizeColumnMode.NotSet, true)
				}
			};
			RefreshDT();
			RefreshDGV();
			BS_Design.DataSource = Design;
			PG_Design.SelectedObject = BS_Design.Current;
			BS_Columns.DataSource = Design.Columns;
		}

		private void B_Export_Click(object sender, EventArgs e)
		{
			var XS = new XmlSerializer(typeof(DGVTemplate));
			using (var SW = new StringWriter())
			{
				XS.Serialize(SW, Design.ToTemplate());
				FCTB_Template.Text = SW.ToString();
			}
		}

		private void B_Import_Click(object sender, EventArgs e)
		{
			try
			{
				var XS = new XmlSerializer(typeof(DGVTemplate));
				using (var SR = new StringReader(FCTB_Template.Text))
				{
					var T = (DGVTemplate)XS.Deserialize(SR);
					Design = new Design(T);
					BS_Columns.DataSource = Design.Columns;

					RefreshDT();
					RefreshDGV();
				}
			}
			catch (Exception) { }
		}

		private void B_MoveLeft_Click(object sender, EventArgs e)
		{
			var i = BS_Columns.Position;
			var C = Design.Columns[i];
			Design.Columns.RemoveAt(i--);
			Design.Columns.Insert(i, C);

			BS_Columns.Position = i;
			RefreshDGV();
		}

		private void B_MoveRight_Click(object sender, EventArgs e)
		{
			var i = BS_Columns.Position;
			var C = Design.Columns[i];
			Design.Columns.RemoveAt(i++);
			Design.Columns.Insert(i, C);

			BS_Columns.Position = i;
			RefreshDGV();
		}

		private void BS_Columns_AddingNew(object sender, AddingNewEventArgs e)
		{
			var C = (Design)e.NewObject;
		}

		private void BS_Columns_CurrentChanged(object sender, EventArgs e)
		{
			B_MoveLeft.Enabled = !(BS_Columns.Position == 0);
			B_MoveRight.Enabled = !(BS_Columns.Position == (BS_Columns.Count - 1));
			PG_Column.SelectedObject = BS_Columns.Current;

			if (SkipEvent) return;
			RefreshDGV();
		}

		private void PG_Column_Leave(object sender, EventArgs e)
		{
			RefreshDGV();
		}

		private void RefreshDGV()
		{
			if (SkipEvent) return;
			SkipEvent = true;
			DGV_Template.Columns.Clear();
			foreach (var C in Design.Columns)
			{
				var DGVC = new DataGridViewTextBoxColumn()
				{
					Name = C.Name,
					HeaderText = C.Header,
					AutoSizeMode = C.AutoSizeMode,
					Width = C.Width,
					DataPropertyName = C.Name,
					SortMode = DataGridViewColumnSortMode.NotSortable
				};
				DGVC.DefaultCellStyle.ForeColor = C.ForeColor;
				DGVC.DefaultCellStyle.Font = C.Font;
				if (!C.Visible) { DGVC.DefaultCellStyle.BackColor = Color.SlateGray; };
				DGV_Template.Columns.Add(DGVC);
			}
			if (BS_Columns.Position >= 0) { DGV_Template.CurrentCell = DGV_Template.Rows[0].Cells[BS_Columns.Position]; }
			SkipEvent = false;
		}

		private void RefreshDT()
		{
			var DT = new DataTable();
			foreach (var C in Design.Columns) { DT.Columns.Add(new DataColumn(C.Name)); }

			var R = DT.NewRow();
			foreach (var C in Design.Columns) { R[C.Name] = $"{C.Header} Test"; }
			DT.Rows.Add(R);
			DGV_Template.DataSource = DT;
		}

		private void DGV_Template_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.ColumnIndex >= 0) { BS_Columns.Position = e.ColumnIndex; }
		}

		private void DGV_Template_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//if (e.ColumnIndex >= 0) { BS_Columns.Position = e.ColumnIndex; }
		}

		private void DGV_Template_SelectionChanged(object sender, EventArgs e)
		{
			//var i = DGV_Template.CurrentCell.ColumnIndex;
			//if (i >= 0) { BS_Columns.Position = i; }
		}

		private void DGV_Template_CurrentCellChanged(object sender, EventArgs e)
		{
			if (SkipEvent) return;
			SkipEvent = true;
			var i = DGV_Template.CurrentCell?.ColumnIndex;
			if (i.HasValue && i >= 0) { BS_Columns.Position = (int)i; }
			SkipEvent = false;
		}

		private void PG_Column_Validated(object sender, EventArgs e)
		{
			RefreshDGV();
		}

		private void DGV_Template_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex >= 0) { BS_Columns.Position = e.ColumnIndex; }
		}

		private void BS_Columns_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemAdded)
			{
				RefreshDT();
			}
		}

		private void FCTB_Template_TextChanged(object sender, TextChangedEventArgs e)
		{
			FCTB_Template.SyntaxHighlighter.XMLSyntaxHighlight(FCTB_Template.Range);
		}

		private void TSMI_Reset_Click(object sender, EventArgs e)
		{
			PG_Column.ResetSelectedProperty();
		}
	}
}