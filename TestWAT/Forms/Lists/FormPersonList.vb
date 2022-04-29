Imports TestWAT.Enums

Public Class FormPersonList

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        Persons = New PersonList()
        'dt.Filter.Type = PersonType.FL
        'dt.PersonType=
    End Sub

    Private Persons As New PersonList()

    Private Sub FormPersonList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_PersonType.AddEmptyRow = True
        CB_PersonType.FillComboBox()
        DataTableView1.SetDTSource(Persons)
        DataTableView1.FilterByMergedRow = True
        DataTableView1.WaitTime = 50
    End Sub

    Private Async Sub CB_PersonType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PersonType.SelectedIndexChanged
        FlowLayoutPanel1.Enabled = False
        Persons.Filter.Type = CB_PersonType.Type
        Await DataTableView1.RefreshDT()
        FlowLayoutPanel1.Enabled = True
    End Sub

End Class