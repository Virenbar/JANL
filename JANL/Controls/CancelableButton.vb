Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading

''' <summary>
''' Кнопка с возможность отмены задачи.
''' При повторном нажатии происходит отмена.
''' При завершении или отмене необходимо вызвать <see cref="CancelableButton.ResetButton()"/>
''' </summary>
Public Class CancelableButton
	Inherits Button
	Private _IsCanceled As Boolean
	Private _IsPressed As Boolean
	Private CTS As CancellationTokenSource
	Private DefaultImage As Image
	Private DefaultText As String

	Public Sub New()
		MyBase.New()
		TextCancel = "Отменить"
		TextCanceled = "Отмена"
	End Sub

#Region "Properties"

#Region "Designer"

	<Browsable(True), Category("Appearance")>
	Public Property ImageCancel As Image

	<Browsable(True), Category("Appearance")>
	Public Property ImageCanceled As Image

	<Browsable(True), Category("Appearance"), DefaultValue("Отменить")>
	Public Property TextCancel As String

	<Browsable(True), Category("Appearance"), DefaultValue("Отмена")>
	Public Property TextCanceled As String

#End Region

	<Browsable(False)>
	Public Property IsCanceled As Boolean
		Get
			Return _IsCanceled
		End Get
		Private Set(value As Boolean)
			_IsCanceled = value
		End Set
	End Property

	<Browsable(False)>
	Public Property IsPressed As Boolean
		Get
			Return _IsPressed
		End Get
		Private Set(value As Boolean)
			_IsPressed = value
		End Set
	End Property

#End Region

	''' <summary>
	''' Сброс состояния кнопки
	''' </summary>
	Public Sub ResetButton()
		If Not IsPressed Then Exit Sub
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

	''' <summary>
	''' Вызывает событие <see cref="CancelableButton.Cancel"/>
	''' </summary>
	Protected Sub OnCancel(e As EventArgs)
		RaiseEvent Cancel(Me, e)
	End Sub

	''' <summary>
	''' Вызывает событие <see cref="CancelableButton.Run"/>
	''' </summary>
	Protected Sub OnRun(e As RunEventArgs)
		RaiseEvent Run(Me, e)
	End Sub

	Public Class RunEventArgs
		Inherits EventArgs

		''' <summary>
		''' Токен отмены, получает сигнал отмены при отмене пользователем.
		''' </summary>
		Public Property CTS As CancellationTokenSource

	End Class

	''' <summary>
	''' Происходит при отмене пользователем
	''' </summary>
	<Browsable(True), Category("Action")>
	Public Event Cancel(sender As Object, e As EventArgs)

	''' <summary>
	''' Происходит при запуске пользователем
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e">Объект класса <see cref="RunEventArgs"/>, содержащий данные события.</param>
	<Browsable(True), Category("Action")>
	Public Event Run(sender As Object, e As RunEventArgs)

#End Region

End Class