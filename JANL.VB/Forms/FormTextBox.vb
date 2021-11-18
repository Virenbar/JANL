Public Class FormTextBox

	Public Sub New(Header As String, Text As String)
		InitializeComponent()

		MyBase.Text = Header
		Me.Text = Text
	End Sub

	Public Sub New(Header As String)
		Me.New(Header, "")
	End Sub

	Public Shadows Property Text As String
		Get
			Return TB.Text
		End Get
		Set
			TB.Text = Value
		End Set
	End Property

	Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub B_OK_Click(sender As Object, e As EventArgs) Handles B_OK.Click
		DialogResult = DialogResult.OK
		Close()
	End Sub

End Class