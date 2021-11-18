Namespace SQL

	Public MustInherit Class SQLText(Of T)
		Inherits BaseSQLCommand(Of T)

		Public Sub New(Text As String)
			MyBase.New(Text, CommandType.Text)
		End Sub

	End Class
End Namespace