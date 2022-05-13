Imports TestWAT.Enums
Imports TestWAT.Models.Filters

Public Class FormPersonList

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        Persons = New PersonStore()
        'dt.Filter.Type = PersonType.FL
        'dt.PersonType=
    End Sub

    Private Persons As New PersonStore()
    Private Filter As New PersonFilter()

    Private Async Sub FormPersonList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_PersonType.AddEmptyRow = True
        CB_PersonType.FillComboBox()

        DTV_Person.FilterByMergedRow = True
        DTV_Person.WaitTime = 50
        DTV_Person.KeyName = Persons.KeyName
        DTV_Person.ValueName = Persons.ValueName
        DTV_Person.SetFilterColumns(Persons.FilterColumns)
        Await RefreshDT()
    End Sub

    Private Async Function RefreshDT() As Task
        DTV_Person.SetDataTable(Await Persons.GetDataTable(Filter))
    End Function

    Private Async Sub CB_PersonType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PersonType.SelectedIndexChanged
        FlowLayoutPanel1.Enabled = False
        Filter.Type = CB_PersonType.Type
        Await RefreshDT()
        FlowLayoutPanel1.Enabled = True
    End Sub

    Private Async Sub DTV_Person_RefreshClick(sender As Object, e As EventArgs) Handles DTV_Person.RefreshClick
        Await RefreshDT()
    End Sub

End Class