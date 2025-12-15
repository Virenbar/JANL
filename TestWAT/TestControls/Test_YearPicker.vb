Imports JANL.Models

Public Class Test_YearPicker
    Private TestObject As New TestObject()

    Private Sub B_2020_Click(sender As Object, e As EventArgs) Handles B_2020.Click
        TestObject.TestInteger = 2020
    End Sub

    Private Sub B_Null_Click(sender As Object, e As EventArgs) Handles B_Null.Click
        TestObject.TestInteger = Nothing
    End Sub

    Private Sub Test_YearPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BS_TestObject.DataSource = TestObject
        TestObject.TestInteger = 2020
    End Sub

End Class