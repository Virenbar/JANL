'Imports JANL
'Imports JANL.Types

'Public Class TestLinks
'	Inherits BaseLinkList

'	Public Sub New(Parent As Integer)
'		MyBase.New(Parent, "ID")
'		DGVTemplate = New DGVTemplate({
'			New DGVTemplateColumn("ID", "Key", 100)})
'	End Sub

'	Public Overrides Async Function GetList() As Task(Of DataTable)
'		Dim DT = New DataTable()
'		DT.Columns.Add("ID", GetType(Integer))
'		DT.Columns.Add("Parent", GetType(String))
'		DT.Columns.Add("Value", GetType(String))
'		DT.Columns.Add("Type", GetType(String))

'		For i = 1 To 10
'			Dim R = DT.NewRow()
'			R("ID") = i
'			R("Parent") = $"Parent {Parent}"
'			R("Value") = $"Value {i}"
'			R("Type") = If(i Mod 2 = 0, "Even", "Odd")
'			DT.Rows.Add(R)
'		Next
'		Await Task.Delay(1000)
'		Return DT
'	End Function

'	Public Overrides Function EditItem(Key As Integer) As Form
'		Return New FormDummy($"Edit - {Key}")
'	End Function

'End Class