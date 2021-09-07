Imports System.Drawing

Namespace Types

	Public Class DGVTemplateColumn

		Public Sub New()
			Name = "Column"
			Header = "Header"
			Width = 100
			AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
			Visible = True
			ForeColor = ColorTranslator.ToHtml(Color.Black)
		End Sub

		Public Sub New(name As String, header As String, width As Integer, autoSizeMode As DataGridViewAutoSizeColumnMode, visible As Boolean)
			Me.New()
			Me.Name = name
			Me.Header = header
			Me.Width = width
			Me.AutoSizeMode = autoSizeMode
			Me.Visible = visible
		End Sub

		Public Sub New(name As String, header As String, width As Integer)
			Me.New(name, header, width, DataGridViewAutoSizeColumnMode.NotSet, True)
		End Sub

		Public Sub New(name As String, header As String, autoSizeMode As DataGridViewAutoSizeColumnMode)
			Me.New(name, header, 100, autoSizeMode, True)
		End Sub

		Public Property Name As String
		Public Property Header As String
		Public Property Width As Integer
		Public Property AutoSizeMode As DataGridViewAutoSizeColumnMode
		Public Property Visible As Boolean
		Public Property ForeColor As String
	End Class

End Namespace