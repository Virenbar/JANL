Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	Public Class NonQuerySQLCommand
		Inherits BaseSQLCommand(Of Integer)

		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		Public Overrides Function Execute(Connection As SqlConnection) As Integer
			SQLCommand.Connection = Connection
			Dim Result = SQLCommand.ExecuteNonQuery()
			Return Result
		End Function

		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of Integer)
			SQLCommand.Connection = Connection
			Dim Result = Await SQLCommand.ExecuteNonQueryAsync()
			Return Result
		End Function

	End Class
End Namespace