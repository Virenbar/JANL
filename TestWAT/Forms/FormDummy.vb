Public Class FormDummy

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(Text As String)
		Me.New()
		L_Text.Text = Text
	End Sub

End Class