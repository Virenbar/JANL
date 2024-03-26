Imports System.Threading

Public Class Test_ProgressTrackerBar
    Private Random As New Random(123)
    Private Max As Integer = 200

    Private Sub SomeTask(PP As IProgress(Of Integer))
        Dim Count = 0
        While Count < Max
            Thread.Sleep(Random.Next(50, 200))
            Count += 1 'Random.Next(1, 2)
            PP.Report(Count)

        End While
    End Sub

#Region "UI Events"

    Private Sub Start()
        PTB.Reset()
        PTB.Maximum = Max
        PTB.Start()
    End Sub

    Private Async Sub B_StartA_Click(sender As Object, e As EventArgs) Handles B_StartA.Click
        Start()
        Await Task.Run(Sub() SomeTask(PTB))
        PTB.Stop()
    End Sub

    Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click
        PTB.Stop()
    End Sub

    Private Sub Test_ProgressTrackerBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_StartM_Click(sender As Object, e As EventArgs) Handles B_StartM.Click
        Start()
    End Sub

    Private Sub B_Increment_Click(sender As Object, e As EventArgs) Handles B_Increment.Click
        PTB.Increment()
        'CType(PTB, IProgress(Of Integer)).Report(1)
    End Sub

#End Region

End Class