Imports System.ComponentModel
Imports System.Drawing
Imports JANL.Types

Public Class DGVTemplateEditor
	Private ReadOnly DT As DataTable = New DataTable()
	Private Design As Design
	Private SkipDGVEvent As Boolean

	Public Function GetTemplate() As DGVTemplate
		Return Design.ToTemplate()
	End Function

	Public Sub SetTemplate(T As DGVTemplate)
		Design = New Design(T)
		ReCreateDGV()

		BS_Design.DataSource = Design
		BS_Columns.DataSource = Design.Columns
	End Sub

	Private Sub B_Export_Click(sender As Object, e As EventArgs) Handles B_Export.Click
		TB_XML.Text = DGVManager.ToXML(GetTemplate())
	End Sub

	Private Sub B_Import_Click(sender As Object, e As EventArgs) Handles B_Import.Click
		Try
			Dim T = DGVManager.FromXML(TB_XML.Text)
			SetTemplate(T)
		Catch ex As Exception
			Msgs.ShowError(ex.Message)
		End Try
	End Sub

	Private Sub CheckOrder()
		For Each C As DataGridViewTextBoxColumn In DGV_Template.Columns
			Debug.Print($"{C.HeaderText} {C.Index} {C.DisplayIndex}")
			If C.Index = C.DisplayIndex Then Continue For Else Exit For
			Exit Sub
		Next

		Dim TC = DGV_Template.Columns.Cast(Of DataGridViewTextBoxColumn).OrderBy(Function(C) C.DisplayIndex).Select(Function(C) DirectCast(C.Tag, DesignColumn).ToTemplate()).ToList()
		Dim T = New DGVTemplate With {.Columns = TC}
		SetTemplate(T)
	End Sub

	Private Sub DGVTemplateEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim T = New DGVTemplate With {
			.Columns = New List(Of DGVTemplateColumn) From {
				New DGVTemplateColumn("Column1", "Column1 Name", 100, DataGridViewAutoSizeColumnMode.None, False),
				New DGVTemplateColumn("Column2", "Column2 Name", 200, DataGridViewAutoSizeColumnMode.None, True),
				New DGVTemplateColumn("Column3", "Column3 Name", 200, DataGridViewAutoSizeColumnMode.Fill, True),
				New DGVTemplateColumn("Column4", "Column4 Name", 300, DataGridViewAutoSizeColumnMode.NotSet, True)}}
		SetTemplate(T)
	End Sub

	Private Sub ReCreateDGV()
		'If SkipDGVEvent Then Return
		SkipDGVEvent = True

		DGV_Template.Columns.Clear()
		Design.Columns.ForEach(Sub(C) DGV_Template.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = C.Name, .Tag = C}))

		SkipDGVEvent = False
		RefreshDGV()
	End Sub

	Private Sub RefreshDGV()
		'If SkipDGVEvent Then Return
		SkipDGVEvent = True

		For Each C As DataGridViewTextBoxColumn In DGV_Template.Columns
			Dim DC = DirectCast(C.Tag, DesignColumn)
			C.HeaderText = DC.Header
			C.AutoSizeMode = DC.AutoSizeMode
			C.Width = DC.Width
			C.DataPropertyName = DC.Name
			C.SortMode = DataGridViewColumnSortMode.NotSortable
			C.DefaultCellStyle.ForeColor = DC.ForeColor
			C.DefaultCellStyle.BackColor = If(DC.Visible, Color.White, Color.SlateGray)
			'C.DefaultCellStyle.Font = C.Font
		Next

		Dim DT = New DataTable()
		Design.Columns.ForEach(Sub(C) DT.Columns.Add(New DataColumn(C.Name)))
		Dim R = DT.NewRow()
		Design.Columns.ForEach(Sub(C) R(C.Name) = $"{C.Name} Data")
		DT.Rows.Add(R)
		DGV_Template.DataSource = DT

		If BS_Columns.Position > 0 Then
			DGV_Template.ClearSelection()
			DGV_Template.Item(BS_Columns.Position, 0).Selected = True
		End If

		SkipDGVEvent = False
	End Sub

#Region "BS Events"

	Private Sub BS_Columns_AddingNew(sender As Object, e As AddingNewEventArgs) Handles BS_Columns.AddingNew

	End Sub

	Private Sub BS_Columns_CurrentChanged(sender As Object, e As EventArgs) Handles BS_Columns.CurrentChanged
		PG_Column.SelectedObject = BS_Columns.Current
	End Sub

	Private Sub BS_Columns_CurrentItemChanged(sender As Object, e As EventArgs) Handles BS_Columns.CurrentItemChanged
		RefreshDGV()
	End Sub

	Private Sub BS_Columns_ListChanged(sender As Object, e As ListChangedEventArgs) Handles BS_Columns.ListChanged
		If (e.ListChangedType = ListChangedType.ItemDeleted OrElse e.ListChangedType = ListChangedType.ItemAdded) Then
			ReCreateDGV()
		End If
	End Sub

#End Region

#Region "DGV Events"

	Private Sub DGV_Template_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Template.CellMouseClick
		If e.ColumnIndex >= 0 Then BS_Columns.Position = e.ColumnIndex
	End Sub

	Private Sub DGV_Template_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Template.CellMouseDown
		Debug.Print($"Down: {e.Button.ToString}")
	End Sub

	Private Sub DGV_Template_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Template.CellMouseUp
		Debug.Print($"Up: {e.Button.ToString}")
		If e.Button = MouseButtons.Left Then CheckOrder()
	End Sub

	Private Sub DGV_Template_ColumnDisplayIndexChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles DGV_Template.ColumnDisplayIndexChanged
		Debug.Print($"Order I:{e.Column.HeaderText} DI:{e.Column.DisplayIndex}")
	End Sub

	Private Sub DGV_Template_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Template.ColumnHeaderMouseClick
		If e.ColumnIndex >= 0 Then BS_Columns.Position = e.ColumnIndex
	End Sub

#End Region

End Class