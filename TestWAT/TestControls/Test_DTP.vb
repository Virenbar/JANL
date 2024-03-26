Imports JANL.Models

Public Class Test_DTP
    Private TestObject As New TestObject()

    Private Sub B_Date2000_Click(sender As Object, e As EventArgs) Handles B_Date2000.Click
        TestObject.TestDate = New Date(2000, 1, 1)
    End Sub

    Private Sub B_DateNull_Click(sender As Object, e As EventArgs) Handles B_DateNull.Click
        TestObject.TestDate = Nothing
    End Sub

    Private Sub Test_DTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BS_TestModel.DataSource = TestObject
        TestObject.TestString = "123456"
    End Sub

End Class