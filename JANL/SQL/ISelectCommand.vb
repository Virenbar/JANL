Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL

	Public Interface ISelectCommand
		Inherits ISQLCommand

		Function Execute() As DataTable

		Function Execute(conn As SqlConnection) As DataTable

		Function Execute(tr As SqlTransaction) As DataTable

		Function ExecuteAsync() As Task(Of DataTable)

		Function ExecuteAsync(conn As SqlConnection) As Task(Of DataTable)

		Function ExecuteAsync(tr As SqlTransaction) As Task(Of DataTable)

	End Interface

End Namespace