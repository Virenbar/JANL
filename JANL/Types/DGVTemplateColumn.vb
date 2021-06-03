Namespace Types

	Public Structure DGVTemplateColumn

		Public Sub New(name As String, header As String, width As Integer, autoSizeMode As DataGridViewAutoSizeColumnMode, visible As Boolean)
			Me.New()
			Me.Name = name
			Me.Header = header
			Me.Width = width
			Me.AutoSizeMode = autoSizeMode
			Me.Visible = visible
		End Sub

		Public Property Name As String
		Public Property Header As String
		Public Property Width As Integer
		Public Property AutoSizeMode As DataGridViewAutoSizeColumnMode
		Public Property Visible As Boolean
	End Structure

End Namespace