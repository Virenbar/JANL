Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Команда возвращающая <typeparamref name="T"/>
	''' </summary>
	<Obsolete>
	Public Class ScalarCommand(Of T)

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand

		Public Function Execute() As T
			Return SQLHelper.ExecuteScalar(Of T)(Command)
		End Function

		Public Function Execute(conn As SqlConnection) As T
			Return SQLHelper.ExecuteScalar(Of T)(Command, conn)
		End Function

		Public Function Execute(tr As SqlTransaction) As T
			Return SQLHelper.ExecuteScalar(Of T)(Command, tr)
		End Function

		Public Function ExecuteAsync() As Task(Of T)
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task(Of T)
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command, conn)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task(Of T)
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command, tr)
		End Function

	End Class
End Namespace