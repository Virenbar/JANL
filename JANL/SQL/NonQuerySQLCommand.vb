Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Команда выполняющая процедуру и возвращающая количество задействованных в процедуре строк.
	''' </summary>
	Public Class NonQuerySQLCommand
		Inherits BaseSQLCommand(Of Integer)

		''' <summary>
		''' Создаёт новую команду с именем вызывающего метода
		''' </summary>
		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		''' <summary>
		''' Выполняет команду с указанным соединением
		''' </summary>
		Public Overrides Function Execute(Connection As SqlConnection) As Integer
			SQLCommand.Connection = Connection
			Dim Result = SQLCommand.ExecuteNonQuery()
			Return Result
		End Function

		''' <summary>
		''' Асинхронно выполняет команду с указанным соединением
		''' </summary>
		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of Integer)
			SQLCommand.Connection = Connection
			Dim Result = Await SQLCommand.ExecuteNonQueryAsync()
			Return Result
		End Function

	End Class
End Namespace