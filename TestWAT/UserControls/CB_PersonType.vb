Imports JANL.Controls
Imports TestWAT.Enums

Public Class CB_PersonType
    Inherits DataTableComboBox

    Public Sub New()
        MyBase.New("K_Type", "N_Type")
    End Sub

    Public ReadOnly Property Type As PersonType?
        Get
            Return CurrentRow?.Field(Of PersonType?)(KeyName)
        End Get
    End Property

    Protected Overrides Function GetDataTable() As DataTable
        Dim DT = New DataTable()
        DT.Columns.Add("K_Type", GetType(Integer))
        DT.Columns.Add("N_Type", GetType(String))

        Dim R = DT.NewRow()
        R("K_Type") = PersonType.FL
        R("N_Type") = "ФЛ"
        DT.Rows.Add(R)
        '
        R = DT.NewRow()
        R("K_Type") = PersonType.IP
        R("N_Type") = "ИП"
        DT.Rows.Add(R)
        '
        R = DT.NewRow()
        R("K_Type") = PersonType.UL
        R("N_Type") = "ЮЛ"
        DT.Rows.Add(R)
        '
        DT.AcceptChanges()
        Return DT
    End Function

End Class