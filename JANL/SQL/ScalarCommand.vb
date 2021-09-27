Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Команда возвращающая <typeparamref name="T"/>
	''' </summary>
	Public Class ScalarCommand(Of T)
		Implements IScalarCommand(Of T)

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand Implements IScalarCommand(Of T).Command

		Public Function Execute() As T Implements IScalarCommand(Of T).Execute
			Return SQLHelper.ExecuteScalar(Of T)(Command)
		End Function

		Public Function Execute(conn As SqlConnection) As T Implements IScalarCommand(Of T).Execute
			Return SQLHelper.ExecuteScalar(Of T)(Command, conn)
		End Function

		Public Function Execute(tr As SqlTransaction) As T Implements IScalarCommand(Of T).Execute
			Return SQLHelper.ExecuteScalar(Of T)(Command, tr)
		End Function

		Public Function ExecuteAsync() As Task(Of T) Implements IScalarCommand(Of T).ExecuteAsync
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task(Of T) Implements IScalarCommand(Of T).ExecuteAsync
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command, conn)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task(Of T) Implements IScalarCommand(Of T).ExecuteAsync
			Return SQLHelper.ExecuteScalarAsync(Of T)(Command, tr)
		End Function

	End Class
End Namespace