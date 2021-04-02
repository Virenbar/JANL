Public Class ProgressBarEx
	Private SW As Stopwatch

	Public Sub New()
		InitializeComponent()
		SW = New Stopwatch()
	End Sub

#Region "Properties"

	Public Property Percent() As Integer
		Get
			Return PB.Value
		End Get
		Set(value As Integer)
			PB.Value = value

		End Set
	End Property

#End Region

	Private Sub UpdateEstimated()
		Dim E = SW.Elapsed.Milliseconds / PB.Value
		L_Estimated.Text = ""
	End Sub

	Public Sub Start()
		SW.Start()
	End Sub

	Public Sub [Stop]()
		SW.Reset()
	End Sub

End Class