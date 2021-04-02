Imports System.ComponentModel

Public Class ProgressBarEx
	Private SW As Stopwatch

	Public Sub New()
		InitializeComponent()
		SW = New Stopwatch()
	End Sub

#Region "Properties"

	<Browsable(False)>
	Public Property Percent() As Integer
		Get
			Return PB.Value
		End Get
		Set(value As Integer)
			PB.Value = value
			UpdateText()
			If value = 100 Then [Stop]()
		End Set
	End Property

#End Region

	Public Sub [Stop]()
		SW.Stop()
	End Sub

	Public Sub Start()
		SW.Restart()
	End Sub

	Private Sub UpdateText()
		L_Percent.Text = $"{PB.Value}%"
		L_Elapsed.Text = SW.Elapsed.ToString(Consts.TimeFormat)
		Dim E = If(PB.Value = 0, 0, (SW.ElapsedMilliseconds \ PB.Value) * (100 - PB.Value))
		L_Estimated.Text = TimeSpan.FromMilliseconds(E).ToString(Consts.TimeFormat)
	End Sub

End Class