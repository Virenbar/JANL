Imports JANL.Extensions

Public Class Test_ButtonAwaiter

    Private Sub Test_ButtonAwaiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Task = ButtonLoop()
    End Sub

    Private Run As Boolean = True

    Private Async Function ToTask(btn As Button) As Task
        While Run
            Await btn
            TextBox1.Text = btn.Text
            btn.Enabled = False
            Await Task.Delay(200)
            btn.Enabled = True
        End While
    End Function

    Private Async Function ButtonLoop() As Task
        Await Task.WhenAny(ToTask(Button1))
    End Function

End Class