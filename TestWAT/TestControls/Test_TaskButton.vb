Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Test_TaskButton

    Private Sub TB_Start_Click(sender As Object, e As JANL.Controls.TaskButton.ClickEventArgs) Handles TB_Start.Click
        e.Task = Count(e.CTS.Token)
    End Sub

    Private Async Function Count(token As CancellationToken) As Task
        For index = 1 To 10
            token.ThrowIfCancellationRequested()
            Await Task.Delay(1000)
            L_Count.Text = Regex.Replace(L_Count.Text, "\d+", $"{index}")
        Next
    End Function

End Class