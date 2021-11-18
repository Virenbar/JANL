Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Процедура возвращающая количество задействованных строк
	''' </summary>
	Public Class NonQueryProcedure
		Inherits SQLProcedure(Of Integer)

		''' <summary>
		''' Создаёт новую процедуру именем вызывающего метода
		''' </summary>
		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		''' <summary>
		''' Выполнить с указанным соединением
		''' </summary>
		Public Overrides Function Execute(Connection As SqlConnection) As Integer
			SQLCommand.Connection = Connection
			Dim Result = SQLCommand.ExecuteNonQuery()
			Return Result
		End Function

		''' <summary>
		''' Асинхронно выполнить с указанным соединением
		''' </summary>
		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of Integer)
			SQLCommand.Connection = Connection
			Dim Result = Await SQLCommand.ExecuteNonQueryAsync()
			Return Result
		End Function

	End Class
End Namespace