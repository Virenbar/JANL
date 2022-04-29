Imports JANL.Types
Imports TestWAT.Enums

Public Class PersonList
    Inherits BaseDTSource

    Public Sub New()
        MyBase.New("Key", "Value", {"Key", "Value", "Type", "TypeString"})
        Filter = New PersonFilter()
    End Sub

    Public Property Filter As PersonFilter

    Public Overrides Async Function GetDataTable() As Task(Of DataTable)
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

    Public Class PersonFilter

        Public Property Type As PersonType?

    End Class

End Class