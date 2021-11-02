Imports JANL.SQL

Public Class SQLCommands

	Public Shared Function UP_PEP_DBList() As SelectProcedure
		Dim Command = New SelectProcedure()
		Command.Prepare()
		Return Command
	End Function

End Class