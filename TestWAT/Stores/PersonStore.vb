Imports TestWAT.Enums
Imports TestWAT.Models.Filters

Public Class PersonStore

    Public Sub New()
        KeyName = "Key"
        ValueName = "Value"
        FilterColumns = New List(Of String)({"Key", "Value", "Type", "TypeString"})
    End Sub

    Public ReadOnly Property KeyName As String
    Public ReadOnly Property ValueName As String
    Public ReadOnly Property FilterColumns As List(Of String)

    Public Function SelectList() As Task(Of DataTable)
        Return SelectList(New PersonFilter())
    End Function

    Public Async Function SelectList(Filter As PersonFilter) As Task(Of DataTable)
        Dim DT = New DataTable()
        DT.Columns.Add("Key", GetType(Integer))
        DT.Columns.Add("Value", GetType(String))
        DT.Columns.Add("Type", GetType(Integer))
        DT.Columns.Add("TypeString", GetType(String))
        For i = 0 To 150
            Dim Type = CType((i Mod 3) + 1, PersonType)
            If Filter.Type.HasValue AndAlso Type <> Filter.Type Then Continue For

            Dim R = DT.NewRow()
            R("Key") = i
            R("Value") = $"Person {i}"
            R("Type") = CInt(Type)
            R("TypeString") = Type.ToString()
            DT.Rows.Add(R)
        Next

        Await Task.Delay(1000)
        Return DT
    End Function

End Class