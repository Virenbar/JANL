Imports System.ComponentModel
Imports System.Drawing

Public Class StopWatchLabel
	Private WithEvents Timer As Timer
	Private Const Format = "d\.hh\:mm\:ss"
	Private StopWatch As Stopwatch

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		Timer = New Timer() With {.Interval = 100}
		StopWatch = New Stopwatch()
		ImageWaiting = PB_Image.InitialImage
		ImageRunning = PB_Image.Image
		PB_Image.Image = ImageWaiting
		L_Prefix.Text = "Time passed:"
		L_Time.Text = TimeSpan.Zero.ToString(Format)
		UpdateText()
	End Sub

#Region "Properties"

#Region "Designer"

	<Browsable(True), Category("Appearance")>
	Public Property ImageRunning As Image

	<Browsable(True), Category("Appearance")>
	Public Property ImageWaiting As Image

	<Browsable(True), Category("Appearance"), DefaultValue("Time passed:")>
	Public Property Prefix As String
		Get
			Return L_Prefix.Text
		End Get
		Set(value As String)
			L_Prefix.Text = value
		End Set
	End Property

	<Browsable(True), Category("Appearance"), DefaultValue(100)>
	Public Property RefreshInterval As Integer
		Get
			Return Timer.Interval
		End Get
		Set(value As Integer)
			Timer.Interval = value
		End Set
	End Property

	<Browsable(True), Category("Appearance"), DefaultValue(True)>
	Public Property ShowImage As Boolean
		Get
			Return PB_Image.Visible
		End Get
		Set(value As Boolean)
			PB_Image.Visible = value
		End Set
	End Property

#End Region

	<Browsable(False)>
	Public ReadOnly Property TimeElapsed As TimeSpan
		Get
			Return StopWatch.Elapsed
		End Get
	End Property

#End Region

	Public Sub [Stop]()
		Timer.Stop()
		StopWatch.Stop()
		PB_Image.Image = ImageWaiting
	End Sub

	Public Sub Reset()
		[Stop]()
		L_Time.Text = TimeSpan.Zero.ToString(Format)
	End Sub

	Public Sub Start()
		StopWatch.Restart()
		Timer.Start()
		PB_Image.Image = ImageRunning
	End Sub

	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		UpdateText()
	End Sub

	Private Sub UpdateText()
		L_Time.Text = TimeElapsed.ToString(Format)
	End Sub

End Class