Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL

	Public Interface ISQLCommand(Of T)
		ReadOnly Property Parameters As SqlParameterCollection
		Property Timeout As Integer

		Function Execute() As T

		Function Execute(Connection As SqlConnection) As T

		Function Execute(Transaction As SqlTransaction) As T

		Function ExecuteAsync() As Task(Of T)

		Function ExecuteAsync(Connection As SqlConnection) As Task(Of T)

		Function ExecuteAsync(Transaction As SqlTransaction) As Task(Of T)

	End Interface

End Namespace