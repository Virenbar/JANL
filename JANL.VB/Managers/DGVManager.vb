Imports JANL.Extensions
Imports JANL.Types

Public Class DGVManager

	Public Shared Property Templates As New Dictionary(Of String, DGVTemplate)

	Public Shared Property Item(Name As String) As DGVTemplate
		Get
			Name = Name.ToLowerInvariant()
			If Not Templates.ContainsKey(Name) Then Return Nothing
			Return Templates(Name)
		End Get
		Set
			Templates(Name.ToLowerInvariant) = Value
		End Set
	End Property

	Public Shared Sub ApplyTemplate(DGV As DataGridView, T As String)
		EditDGV(DGV)
		Dim Name = T.ToLowerInvariant()
		If Templates.ContainsKey(Name) Then EditDGVColumns(DGV, Templates(Name))
	End Sub

	Public Shared Sub ApplyTemplate(DGV As DataGridView, T As DGVTemplate)
		EditDGV(DGV)
		EditDGVColumns(DGV, T)
	End Sub

	Public Shared Function FromXML(XML As String) As DGVTemplate
		Return DGVTemplate.FromXML(XML)
	End Function

	Public Shared Function ToXML(T As DGVTemplate) As String
		Return DGVTemplate.ToXML(T)
	End Function

	Private Shared Sub EditDGV(DGV As DataGridView)
		DGV.DoubleBuffered(True)
		DGV.ReadOnly = True
		DGV.RowHeadersVisible = False
		DGV.AllowUserToAddRows = False
		DGV.AllowUserToDeleteRows = False
		DGV.AllowUserToOrderColumns = False
		DGV.AllowUserToResizeRows = False
	End Sub

	Private Shared Sub EditDGVColumns(DGV As DataGridView, T As DGVTemplate)
		DGV.AutoGenerateColumns = False
		DGV.Columns.Clear()
		For Each C In T.Columns
			Dim DGVC = New DataGridViewTextBoxColumn() With {
				.Name = C.Name,
				.HeaderText = C.Header,
				.AutoSizeMode = C.AutoSizeMode,
				.Width = C.Width,
				.DataPropertyName = C.Name,
				.Visible = C.Visible
			}
			DGV.Columns.Add(DGVC)
		Next
	End Sub

End Class

Public Class DGVSettings

	Public Sub New()
		AllowRowsResize = False
	End Sub

	Public Property AllowRowsResize As Boolean
End Class