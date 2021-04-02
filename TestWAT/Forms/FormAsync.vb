Imports System.ComponentModel

Public Class FormAsync
	Private LoadTask As Task

	Private Async Sub FormAsync_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadTask = Task.Delay(1000 * 5)
		Await LoadTask
		Button1.Enabled = True
	End Sub

	Protected Overrides Sub OnClosing(e As CancelEventArgs)
		If Not LoadTask.IsCompleted Then e.Cancel = True
		MyBase.OnClosing(e)
	End Sub

	Private Sub FormAsync_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Dispose()
	End Sub

	Private Sub FormAsync_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

End Class