Imports System.Threading
Imports TestWAT.Models
Imports JANL

Public Class FormTest
	Private TestObject As New TestModel()

	Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		BS_TestModel.DataSource = TestObject
		TestObject.TestString = "123"
	End Sub

#Region "Date"

	Private Sub B_Date2000_Click(sender As Object, e As EventArgs) Handles B_Date2000.Click
		TestObject.TestDate = New Date(2000, 1, 1)
	End Sub

	Private Sub B_DateNull_Click(sender As Object, e As EventArgs) Handles B_DateNull.Click
		TestObject.TestDate = Nothing
	End Sub

#End Region

#Region "Toggle Button & Cancel"
	Private CTS As CancellationTokenSource

	Private Async Sub TB_Test_ToggledOn(sender As Object, e As EventArgs) Handles TB_Test.ToggledOn
		Try
			CTS = New CancellationTokenSource()
			Dim B = Await SomeTaskAsync(CTS.Token)

			TB_Test.Toggled = False
		Catch ex As TaskCanceledException
		Catch ex As OperationCanceledException
		Finally
			TB_Test.Enabled = True
			CTS = Nothing
		End Try
	End Sub

	Private Sub TB_Test_ToggledOff(sender As Object, e As EventArgs) Handles TB_Test.ToggledOff
		TB_Test.Enabled = False
		CTS.Cancel()
	End Sub

	Private Async Sub CncB_Test_Run(sender As Object, e As CancelableButton.RunEventArgs) Handles CncB_Test.Run
		Try
			TSPB_Test.Value = 0
			Dim B = Await SomeTaskAsync(New Progress(Of Integer)(Sub(i) TSPB_Test.Value = i), e.CTS.Token)
		Catch ex As Exception
		Finally
			CncB_Test.ResetButton()
		End Try
	End Sub

	Private Shared Async Function SomeTaskAsync() As Task(Of Boolean)
		Return Await SomeTaskAsync(CancellationToken.None)
	End Function

	Private Shared Async Function SomeTaskAsync(CT As CancellationToken) As Task(Of Boolean)
		Return Await SomeTaskAsync(New Progress(Of Integer)(), CT)
	End Function

	Private Shared Async Function SomeTaskAsync(PP As IProgress(Of Integer), CT As CancellationToken) As Task(Of Boolean)
		Await Task.Delay(1000 * 2)
		Return Await Task.Run(
			Function() As Boolean
				For i = 1 To 100
					CT.ThrowIfCancellationRequested()
					Thread.Sleep(50)
					'Task.Delay(50, CT)
					PP.Report(i)
				Next
				Return True
			End Function)
	End Function

#End Region

#Region "Exception Box"

	Private Sub B_Exception_Click(sender As Object, e As EventArgs) Handles B_Exception.Click
		Try
			InnerExOne()
		Catch ex As Exception
			Dim EB = New ExceptionBox(ex)
			If EB.ShowDialog(Me) = DialogResult.Abort Then Application.Exit()
		End Try
	End Sub

	Private Sub InnerExOne()
		InnerExTwo()
	End Sub

	Private Sub InnerExTwo()
		Try
			InnerExThree()
		Catch ex As InvalidOperationException
			Throw New Exception("Произошла некоректная операция.", ex)
		End Try
	End Sub

	Private Shared Sub InnerExThree()
		Try
			InnerExFour()
		Catch ex As DivideByZeroException
			Throw New InvalidOperationException("Нельзя делить на ноль.", ex)
		End Try
	End Sub

	Private Shared Sub InnerExFour()
		InnerExFive()
	End Sub

	Private Shared Sub InnerExFive()
		Dim z As Integer = 0
		Dim x As Integer = 3 \ z
	End Sub

#End Region

	Private Shared Sub FormClosedOnce(e As Form, action As Action)
		Dim Handler As FormClosedEventHandler
		Handler = Sub(sender, args)
					  RemoveHandler e.FormClosed, Handler
					  action()
				  End Sub
		AddHandler e.FormClosed, Handler
	End Sub

	''' <summary>
	'''
	''' </summary>
	''' <param name="p">Родительская форма</param>
	''' <param name="c">Дочерняя форма</param>
	''' <param name="action">Действие при закрытии дочерней формы</param>
	Private Shared Sub AutoRemoveClosedHandler(p As Form, c As Form, action As Action)
		Dim ChildHandler As FormClosedEventHandler = Sub(sender, args) action()
		Dim ParentHandler As FormClosedEventHandler = Sub(sender, args) RemoveHandler c.FormClosed, ChildHandler
		AddHandler c.FormClosed, ChildHandler
		AddHandler p.FormClosed, ParentHandler
	End Sub

	Private Sub FB()
		Dim IsValid As Boolean = True

		If IsValid Then
		End If

		If IsValid = True Then
		End If

		If Not (IsValid = False) Then
		End If

		If (IsValid = False) <> True Then
		End If
	End Sub

#Region "StopWatch"

	Private Sub CancelableButton1_Run_1(sender As Object, e As CancelableButton.RunEventArgs) Handles CB_SW.Run
		SWL_Test.Start()
	End Sub

	Private Sub CancelableButton1_Cancel(sender As Object, e As EventArgs) Handles CB_SW.Cancel
		SWL_Test.Stop()
		CB_SW.ResetButton()
	End Sub

#End Region

#Region "ProgressBar"

	Private Async Sub B_PB_Click(sender As Object, e As EventArgs) Handles B_PB.Click
		B_PB.Enabled = False
		PBE_Test.Start()
		Dim PP As IProgress(Of Integer) = New Progress(Of Integer)(Sub(p) PBE_Test.Percent = p)
		For i = 0 To 100
			Await Task.Delay(100)
			PP.Report(i)
		Next
		B_PB.Enabled = True
	End Sub

#End Region

	Private Sub TB_Number_TextChanged(sender As Object, e As EventArgs) Handles TB_Number.TextChanged
		Dim I As Numerics.BigInteger = 0
		If Numerics.BigInteger.TryParse(TB_Number.Text, I) Then
			TB_NumberText.Text = NumberToText.NumberToText(I, NumberToText.Kind.Male)
		End If
	End Sub

End Class