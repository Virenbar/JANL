Imports System.IO
Imports System.Threading.Tasks
Imports System.Xml.Serialization
Imports JANL.Types
Imports JANL.Extensions
Imports JANL.SQL

Public Class DGVManager
	Private Shared ReadOnly TemplatesDict As New Dictionary(Of String, DGVTemplate)

	Public Shared Sub ApplyTemplate(DGV As DataGridView, T As String)
		Dim Name = T.ToString.ToLower()
		If Not TemplatesDict.ContainsKey(Name) Then Exit Sub
		DGV.AutoGenerateColumns = False
		DGV.DoubleBuffered(True)
		DGV.ReadOnly = True
		DGV.AllowUserToAddRows = False
		DGV.AllowUserToDeleteRows = False
		DGV.AllowUserToOrderColumns = False
		'DGV.AllowUserToResizeColumns = False
		DGV.AllowUserToResizeRows = False

		DGV.Columns.Clear()
		For Each C In TemplatesDict(Name).Columns
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

	Public Shared Function Refresh() As Task
		Return RefreshTemplates()
	End Function

	Public Shared Property Source As SelectCommand

	Private Shared Async Function RefreshTemplates() As Task
		Using DT = Await Source.ExecuteAsync()
			TemplatesDict.Clear()
			Dim XS As New XmlSerializer(GetType(DGVTemplate))
			For Each R As DataRow In DT.Rows
				Using SR = New StringReader(R.Field(Of String)("XMLTemplate"))
					Dim T = DirectCast(XS.Deserialize(SR), DGVTemplate)
					TemplatesDict.Add(R.Field(Of String)("N_DGVTemplate").ToLower, T)
				End Using
			Next
		End Using
	End Function

End Class