Imports JANL.Excel
Imports OfficeOpenXml.Table

Public Class FormOffice
    Private Store As New PersonStore()

    Private Async Sub B_Auto_1_Click(sender As Object, e As EventArgs) Handles B_Auto_1.Click
        Using List = Await Store.SelectList()
            Dim Report = New AutoReport(List) With {
                .TableStyle = TableStyles.Medium4
            }
            Dim File = Report.Print("AutoReport#1.xlsx")
            Process.Start(File.FullName)
        End Using
    End Sub

End Class