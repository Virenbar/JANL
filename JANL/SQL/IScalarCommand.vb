Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL

	Public Interface IScalarCommand(Of T)
		Inherits ISQLCommand

		Function Execute() As T

		Function Execute(conn As SqlConnection) As T

		Function Execute(tr As SqlTransaction) As T

		Function ExecuteAsync() As Task(Of T)

		Function ExecuteAsync(conn As SqlConnection) As Task(Of T)

		Function ExecuteAsync(tr As SqlTransaction) As Task(Of T)

	End Interface

End Namespace