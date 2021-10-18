Imports JANL.SQL

Public Class SQLCommands

	Public Shared Function UP_PEP_DBList() As SelectSQLCommand
		Dim Command = New SelectSQLCommand()
		Command.Prepare()
		Return Command
	End Function

End Class