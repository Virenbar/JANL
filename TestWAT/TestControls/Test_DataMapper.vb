Imports System.Data.SqlClient
Imports System.IO
Imports JANL.Data

Public Class Test_DataMapper
    Private ReadOnly DT As New DataTable()

    Public Sub New()
        InitializeComponent()

        DT.Columns.Add("Date", GetType(Date))
        DT.Columns.Add("String", GetType(String))
        DT.Columns.Add("TestDecimal", GetType(Decimal))
    End Sub

    Private Sub B_Object_Click(sender As Object, e As EventArgs) Handles B_Object.Click
        Dim Input = New TestModelData() With {
            .TestDate = Now,
            .TestString = Path.GetRandomFileName,
            .TestDecimal = 0D
        }
        '
        Dim Command = New SqlCommand()
        Dim Output = Command.Parameters
        SQLDataMapper.ReadFromObject(Output, Input)
    End Sub

    Private Sub B_SQL_Click(sender As Object, e As EventArgs) Handles B_SQL.Click
        Dim Input = DT.NewRow()
        Input.SetField("Date", Now)
        Input.SetField("String", Path.GetRandomFileName)
        Input.SetField("TestDecimal", 0D)
        'DT.Rows.Add(Input)
        '
        Dim Output = New TestModelData()
        SQLDataMapper.WriteToObject(Output, Input)
    End Sub

    Public Class TestModelData

        <SQLData("Date")>
        Public Property TestDate As Date?

        <SQLData("String")>
        Public Property TestString As String

        <SQLData>
        Public Property TestDecimal As Decimal

    End Class
End Class