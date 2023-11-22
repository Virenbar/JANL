﻿Imports System.Threading

Public Class Test_ProgressTrackerBar
    Private Random As New Random(123)

    Private Sub SomeTask(PP As IProgress(Of Integer))
        For index = 1 To 200
            Thread.Sleep(Random.Next(50, 100))
            PP.Report(Random.Next(1, 2))
        Next
    End Sub

#Region "UI Events"

    Private Async Sub B_StartA_Click(sender As Object, e As EventArgs) Handles B_StartA.Click
        PTB.Reset()
        PTB.Maximum = 200
        PTB.Start()
        Await Task.Run(Sub() SomeTask(PTB))
        PTB.Stop()
    End Sub

    Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click

    End Sub

    Private Sub Test_ProgressTrackerBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class