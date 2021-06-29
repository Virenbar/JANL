Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL

	Public Interface INonQueryCommand
		Inherits ISQLCommand

		Sub Execute()

		Sub Execute(conn As SqlConnection)

		Sub Execute(tr As SqlTransaction)

		Function ExecuteAsync() As Task

		Function ExecuteAsync(conn As SqlConnection) As Task

		Function ExecuteAsync(tr As SqlTransaction) As Task

	End Interface

End Namespace