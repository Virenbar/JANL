Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace SQL
	''' <summary>
	''' Процедура возвращающая <see cref="DataTable"/>
	''' </summary>
	Public Class SelectProcedure
		Inherits SQLProcedure(Of DataTable)

		''' <summary>
		''' Создаёт новую процедуру с именем вызывающего метода
		''' </summary>
		Public Sub New(<CallerMemberName> Optional Name As String = Nothing)
			MyBase.New(Name)
		End Sub

		''' <summary>
		''' Выполнить с указанным соединением
		''' </summary>
		Public Overrides Function Execute(Connection As SqlConnection) As DataTable
			Dim Result = New DataTable() With {.Locale = Globalization.CultureInfo.CurrentCulture}
			SQLCommand.Connection = Connection
			Using adapter As New SqlDataAdapter(SQLCommand)
				adapter.Fill(Result)
			End Using
			Return Result
		End Function

		''' <summary>
		''' Асинхронно выполнить с указанным соединением
		''' </summary>
		Public Overrides Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of DataTable)
			Dim Result = New DataTable() With {.Locale = Globalization.CultureInfo.CurrentCulture}
			SQLCommand.Connection = Connection
			Using R = Await SQLCommand.ExecuteReaderAsync()
				Await Task.Run(Sub() Result.Load(R))
			End Using
			Return Result
		End Function

	End Class
End Namespace