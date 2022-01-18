Imports System.ComponentModel

Public Class ProgressBarEx
	Private SW As Stopwatch
	Private _Percent As Double

	Public Sub New()
		InitializeComponent()
		SW = New Stopwatch()
	End Sub

#Region "Properties"

	<Browsable(False)>
	Public Property Percent() As Double
		Get
			Return _Percent
		End Get
		Set(value As Double)
			_Percent = value
			Dim P = CInt(_Percent)
			PB.Value = P
			UpdateText()
			If P = 100 Then [Stop]()
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
		L_Percent.Text = $"{_Percent:0.00}%"
		L_Elapsed.Text = SW.Elapsed.ToString("d\.hh\:mm\:ss")
		Dim E = If(PB.Value = 0, 0, (SW.ElapsedMilliseconds \ PB.Value) * (100 - PB.Value))
		L_Estimated.Text = TimeSpan.FromMilliseconds(E).ToString("d\.hh\:mm\:ss")
	End Sub

End Class