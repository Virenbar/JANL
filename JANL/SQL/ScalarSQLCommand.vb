Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	Public Class ScalarSQLCommand(Of T)
		Inherits BaseSQLCommand(Of T)

		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		Public Overrides Function Execute(Connection As SqlConnection) As T
			SQLCommand.Connection = Connection
			Dim Result = DirectCast(SQLCommand.ExecuteScalar(), T)
			Return Result
		End Function

		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of T)
			SQLCommand.Connection = Connection
			Dim Result = DirectCast(Await SQLCommand.ExecuteScalarAsync(), T)
			Return Result
		End Function

	End Class
End Namespace