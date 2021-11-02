Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Команда
	''' </summary>
	<Obsolete>
	Public Class NonQueryCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand

		Public Sub Execute()
			SQLHelper.ExecuteNonQuery(Command)
		End Sub

		Public Sub Execute(tr As SqlTransaction)
			SQLHelper.ExecuteNonQuery(Command, tr)
		End Sub

		Public Sub Execute(conn As SqlConnection)
			SQLHelper.ExecuteNonQuery(Command, conn)
		End Sub

		Public Function ExecuteAsync() As Task
			Return SQLHelper.ExecuteNonQueryAsync(Command)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task
			Return SQLHelper.ExecuteNonQueryAsync(Command, tr)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task
			Return SQLHelper.ExecuteNonQueryAsync(Command, conn)
		End Function

	End Class
End Namespace