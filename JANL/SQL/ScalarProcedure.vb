Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Процедура возвращающая <typeparamref name="T"/>
	''' </summary>
	''' <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
	Public Class ScalarProcedure(Of T)
		Inherits SQLProcedure(Of T)

		''' <summary>
		''' Создаёт новую процедуру с именем вызывающего метода
		''' </summary>
		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		''' <summary>
		''' Выполнить с указанным соединением
		''' </summary>
		Public Overrides Function Execute(Connection As SqlConnection) As T
			SQLCommand.Connection = Connection
			Dim Result = DirectCast(SQLCommand.ExecuteScalar(), T)
			Return Result
		End Function

		''' <summary>
		''' Асинхронно выполнить с указанным соединением
		''' </summary>
		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of T)
			SQLCommand.Connection = Connection
			Dim Result = DirectCast(Await SQLCommand.ExecuteScalarAsync(), T)
			Return Result
		End Function

	End Class
End Namespace