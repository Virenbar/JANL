Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL
	Public Class NonQueryCommand
		Implements INonQueryCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand Implements INonQueryCommand.Command

		Public Sub Execute() Implements INonQueryCommand.Execute
			SQLHelper.ExecuteNonQuery(Command)
		End Sub

		Public Sub Execute(tr As SqlTransaction) Implements INonQueryCommand.Execute
			SQLHelper.ExecuteNonQuery(Command, tr)
		End Sub

		Public Sub Execute(conn As SqlConnection) Implements INonQueryCommand.Execute
			SQLHelper.ExecuteNonQuery(Command, conn)
		End Sub

		Public Function ExecuteAsync() As Task Implements INonQueryCommand.ExecuteAsync
			Return SQLHelper.ExecuteNonQueryAsync(Command)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task Implements INonQueryCommand.ExecuteAsync
			Return SQLHelper.ExecuteNonQueryAsync(Command, tr)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task Implements INonQueryCommand.ExecuteAsync
			Return SQLHelper.ExecuteNonQueryAsync(Command, conn)
		End Function

	End Class
End Namespace