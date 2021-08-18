Imports System.IO
Imports System.Threading.Tasks
Imports System.Xml.Serialization
Imports JANL.Types
Imports JANL.Extensions
Imports JANL.SQL

Public Class DGVManager

	<Obsolete("Use Templates property")>
	Public Shared Property Source As SelectCommand

	Public Shared Property Templates As New Dictionary(Of String, DGVTemplate)

	Public Shared Property Item(Name As String) As DGVTemplate
		Get
			Name = Name.ToLowerInvariant()
			If Not Templates.ContainsKey(Name) Then Return Nothing
			Return Templates(Name)
		End Get
		Set(value As DGVTemplate)
			Templates(Name.ToLowerInvariant) = value
		End Set
	End Property

	Public Shared Sub ApplyTemplate(DGV As DataGridView, T As String)
		Dim Name = T.ToString.ToLower()
		If Not Templates.ContainsKey(Name) Then Exit Sub
		ApplyTemplate(DGV, Templates(Name))
	End Sub

	Public Shared Sub ApplyTemplate(DGV As DataGridView, T As DGVTemplate)
		DGV.AutoGenerateColumns = False
		DGV.DoubleBuffered(True)
		DGV.ReadOnly = True
		DGV.RowHeadersVisible = False
		DGV.AllowUserToAddRows = False
		DGV.AllowUserToDeleteRows = False
		DGV.AllowUserToOrderColumns = False
		DGV.AllowUserToResizeRows = False

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

	Public Shared Function FromXML(XML As String) As DGVTemplate
		Return DGVTemplate.FromXML(XML)
	End Function

	<Obsolete("Use Templates property")>
	Public Shared Function Refresh() As Task
		Return RefreshTemplates()
	End Function

	Public Shared Function ToXML(T As DGVTemplate) As String
		Return DGVTemplate.ToXML(T)
	End Function

	<Obsolete>
	Private Shared Async Function RefreshTemplates() As Task
		Using DT = Await Source.ExecuteAsync()
			Templates.Clear()
			Dim XS As New XmlSerializer(GetType(DGVTemplate))
			For Each R As DataRow In DT.Rows
				Using SR = New StringReader(R.Field(Of String)("XMLTemplate"))
					Dim T = DirectCast(XS.Deserialize(SR), DGVTemplate)
					Templates.Add(R.Field(Of String)("N_DGVTemplate").ToLower, T)
				End Using
			Next
		End Using
	End Function

End Class