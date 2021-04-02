Imports System.ComponentModel
Imports System.Threading

Public Class CancelableButton
	Inherits Button
	Private _IsCanceled As Boolean
	Private _IsPressed As Boolean
	Private CTS As CancellationTokenSource
	Private DefaultImage As Image
	Private DefaultText As String

#Region "Properties"

	<Localizable(True), Category("Appearance")>
	Public Property ImageCancel As Image

	<Localizable(True), Category("Appearance")>
	Public Property ImageCanceled As Image

	Public Property IsCanceled As Boolean
		Get
			Return _IsCanceled
		End Get
		Private Set(value As Boolean)
			_IsCanceled = value
		End Set
	End Property

	Public Property IsPressed As Boolean
		Get
			Return _IsPressed
		End Get
		Private Set(value As Boolean)
			_IsPressed = value
		End Set
	End Property

	<Localizable(True), Category("Appearance"), DefaultValue("")>
	Public Property TextCancel As String

	<Localizable(True), Category("Appearance"), DefaultValue("")>
	Public Property TextCanceled As String

#End Region

	Public Sub ResetButton()
		SetDefault()
	End Sub

	Protected Overrides Sub OnClick(e As EventArgs)
		If Not IsPressed Then
			SetPressed()
			OnRun(New RunEventArgs With {.CTS = CTS})
		ElseIf Not IsCanceled Then
			SetCanceled()
			OnCancel(EventArgs.Empty)
		End If
		MyBase.OnClick(e)
	End Sub

	Private Sub SetCanceled()
		IsCanceled = True
		Text = TextCanceled
		Image = ImageCanceled
		Enabled = False
		CTS.Cancel()
	End Sub

	Private Sub SetDefault()
		IsPressed = False
		IsCanceled = False
		Text = DefaultText
		Image = DefaultImage
		Enabled = True
		CTS = Nothing
	End Sub

	Private Sub SetPressed()
		IsPressed = True
		DefaultText = Text
		DefaultImage = Image
		Text = TextCancel
		Image = ImageCancel
		CTS = New CancellationTokenSource()
	End Sub

#Region "Events"

	Protected Sub OnCancel(e As EventArgs)
		RaiseEvent Cancel(Me, e)
	End Sub

	Protected Sub OnRun(e As RunEventArgs)
		RaiseEvent Run(Me, e)
	End Sub

	Public Class RunEventArgs
		Inherits EventArgs
		Public Property CTS As CancellationTokenSource
	End Class

	<Browsable(True), Category("Action")>
	Public Event Cancel(sender As Object, e As EventArgs)

	<Browsable(True), Category("Action")>
	Public Event Run(sender As Object, e As RunEventArgs)

#End Region

End Class