Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

''' <summary>
''' Класс для работы с SQL командами V2.3
''' (ﾉಥ益ಥ）ﾉ彡ɐɯǝɥɔSllᴉℲ
''' </summary>
Public Class SQL

	''' <summary>
	''' Соединение по умолчанию
	''' </summary>
	Public Shared Property DefaultConn As String

	''' <summary>
	''' Время ожидания по умолчанию
	''' </summary>
	Public Shared Property DefaultTimeout As Integer = 0

	''' <summary>
	''' Создает и открывает новое соединение по умолчанию
	''' </summary>
	Public Shared Function NewConnection() As SqlConnection
		Return NewConnection(DefaultConn)
	End Function

	''' <summary>
	''' Создает и открывает новое соединение
	''' </summary>
	Public Shared Function NewConnection(str As String) As SqlConnection
		Dim conn = New SqlConnection(str)
		If conn.State <> ConnectionState.Open Then conn.Open()
		Return conn
	End Function

	''' <summary>
	''' Начинает транзакцию используя соединение по умолчанию
	''' </summary>
	Public Shared Function NewTransaction() As SqlTransaction
		Dim conn = NewConnection()
		Return conn.BeginTransaction(IsolationLevel.ReadCommitted)
	End Function

	''' <summary>
	''' Начинает транзакцию используя соединение
	''' </summary>
	Public Shared Function NewTransaction(str As String) As SqlTransaction
		Dim conn = NewConnection(str)
		Return conn.BeginTransaction(IsolationLevel.ReadCommitted)
	End Function

	''' <summary>
	''' Создаёт новую комманду с именем вызывающего метода
	''' </summary>
	Public Shared Function NewCommand(<CallerMemberName> Optional name As String = Nothing) As SqlCommand
		Return New SqlCommand(name) With {.CommandType = CommandType.StoredProcedure, .CommandTimeout = DefaultTimeout}
	End Function

#Region "NonQuery"

	Friend Shared Sub ExecuteNonQuery(command As SqlCommand)
		Using conn = NewConnection()
			ExecuteNonQuery(command, conn)
		End Using
	End Sub

	Friend Shared Sub ExecuteNonQuery(command As SqlCommand, tr As SqlTransaction)
		command.Transaction = tr
		ExecuteNonQuery(command, tr.Connection)
	End Sub

	Friend Shared Sub ExecuteNonQuery(command As SqlCommand, conn As SqlConnection)
		Dim result As Integer
		Using command
			command.Connection = conn
			result = command.ExecuteNonQuery()
		End Using
	End Sub

#End Region

#Region "Scalar"

	Friend Shared Function ExecuteScalar(Of T)(command As SqlCommand) As T
		Return DirectCast(ExecuteScalar(command), T)
	End Function

	Friend Shared Function ExecuteScalar(Of T)(command As SqlCommand, tr As SqlTransaction) As T
		Return DirectCast(ExecuteScalar(command, tr), T)
	End Function

	Friend Shared Function ExecuteScalar(Of T)(command As SqlCommand, conn As SqlConnection) As T
		Return DirectCast(ExecuteScalar(command, conn), T)
	End Function

	Friend Shared Function ExecuteScalar(command As SqlCommand) As Object
		Using conn = NewConnection()
			Return ExecuteScalar(command, conn)
		End Using
	End Function

	Friend Shared Function ExecuteScalar(command As SqlCommand, tr As SqlTransaction) As Object
		command.Transaction = tr
		Return ExecuteScalar(command, tr.Connection)
	End Function

	Friend Shared Function ExecuteScalar(command As SqlCommand, conn As SqlConnection) As Object
		Dim result As Object
		Using command
			command.Connection = conn
			result = command.ExecuteScalar()
		End Using
		Return result
	End Function

#End Region

#Region "Select"

	Friend Shared Function ExecuteSelect(command As SqlCommand) As DataTable
		Using conn = NewConnection()
			Return ExecuteSelect(command, conn)
		End Using
	End Function

	Friend Shared Function ExecuteSelect(command As SqlCommand, tr As SqlTransaction) As DataTable
		command.Transaction = tr
		Return ExecuteSelect(command, tr.Connection)
	End Function

	Friend Shared Function ExecuteSelect(command As SqlCommand, conn As SqlConnection) As DataTable
		Dim result = New DataTable() With {.Locale = Globalization.CultureInfo.CurrentCulture}
		Using command
			command.Connection = conn
			Using adapter As New SqlDataAdapter(command)
				adapter.FillSchema(result, SchemaType.Mapped)
				adapter.Fill(result)
			End Using
		End Using
		Return result
	End Function

	Friend Shared Function ExecuteSelect(command As String) As DataTable
		Dim result = New DataTable() With {.Locale = Globalization.CultureInfo.CurrentCulture}
		Using conn = NewConnection(), adapter As New SqlDataAdapter(command, conn)
			adapter.Fill(result)
		End Using
		Return result
	End Function

#End Region

#Region "Asynchronous"

	''' <summary>
	''' Создает и открывает новое соединение по умолчанию
	''' </summary>
	''' <returns></returns>
	Public Shared Function NewConnectionAsync() As Task(Of SqlConnection)
		Return NewConnectionAsync(DefaultConn)
	End Function

	''' <summary>
	''' Создает и открывает новое соединение
	''' </summary>
	''' <returns></returns>
	Public Shared Async Function NewConnectionAsync(str As String) As Task(Of SqlConnection)
		Dim conn = New SqlConnection(str)
		If conn.State <> ConnectionState.Open Then Await conn.OpenAsync()
		Return conn
	End Function

#Region "NonQuery"

	Friend Shared Async Function ExecuteNonQueryAsync(command As SqlCommand) As Task(Of Integer)
		Using conn = Await NewConnectionAsync()
			Return Await ExecuteNonQueryAsync(command, conn)
		End Using
	End Function

	Friend Shared Function ExecuteNonQueryAsync(command As SqlCommand, tr As SqlTransaction) As Task(Of Integer)
		command.Transaction = tr
		Return ExecuteNonQueryAsync(command, tr.Connection)
	End Function

	Friend Shared Async Function ExecuteNonQueryAsync(command As SqlCommand, conn As SqlConnection) As Task(Of Integer)
		Dim result As Integer
		Using command
			command.Connection = conn
			result = Await command.ExecuteNonQueryAsync()
		End Using
		Return result
	End Function

#End Region

#Region "Scalar"

	Friend Shared Async Function ExecuteScalarAsync(Of T)(command As SqlCommand) As Task(Of T)
		Return DirectCast(Await ExecuteScalarAsync(command), T)
	End Function

	Friend Shared Async Function ExecuteScalarAsync(Of T)(command As SqlCommand, tr As SqlTransaction) As Task(Of T)
		Return DirectCast(Await ExecuteScalarAsync(command, tr), T)
	End Function

	Friend Shared Async Function ExecuteScalarAsync(Of T)(command As SqlCommand, conn As SqlConnection) As Task(Of T)
		Return DirectCast(Await ExecuteScalarAsync(command, conn), T)
	End Function

	Friend Shared Async Function ExecuteScalarAsync(command As SqlCommand) As Task(Of Object)
		Using conn = Await NewConnectionAsync()
			Return Await ExecuteScalarAsync(command, conn)
		End Using
	End Function

	Friend Shared Function ExecuteScalarAsync(command As SqlCommand, tr As SqlTransaction) As Task(Of Object)
		command.Transaction = tr
		Return ExecuteScalarAsync(command, tr.Connection)
	End Function

	Friend Shared Async Function ExecuteScalarAsync(command As SqlCommand, conn As SqlConnection) As Task(Of Object)
		Dim result As Object
		Using command
			command.Connection = conn
			result = Await command.ExecuteScalarAsync()
		End Using
		Return result
	End Function

#End Region

#Region "Select"

	Friend Shared Async Function ExecuteSelectAsync(command As SqlCommand) As Task(Of DataTable)
		Using conn = Await NewConnectionAsync()
			Return Await ExecuteSelectAsync(command, conn)
		End Using
	End Function

	Friend Shared Function ExecuteSelectAsync(command As SqlCommand, tr As SqlTransaction) As Task(Of DataTable)
		command.Transaction = tr
		Return ExecuteSelectAsync(command, tr.Connection)
	End Function

	Friend Shared Async Function ExecuteSelectAsync(command As SqlCommand, conn As SqlConnection) As Task(Of DataTable)
		Dim result = New DataTable() With {.Locale = Globalization.CultureInfo.CurrentCulture}
		Using command
			command.Connection = conn
			Using R = Await command.ExecuteReaderAsync()
				Await Task.Run(
					Sub()
						result.Load(R)
					End Sub)
			End Using
		End Using
		Return result
	End Function

#End Region

#End Region

#Region "Command Wrappers"

	Public Class SelectCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand

		Public Function Execute() As DataTable
			Return ExecuteSelect(Command)
		End Function

		Public Function Execute(tr As SqlTransaction) As DataTable
			Return ExecuteSelect(Command, tr)
		End Function

		Public Function Execute(conn As SqlConnection) As DataTable
			Return ExecuteSelect(Command, conn)
		End Function

		Public Function ExecuteAsync() As Task(Of DataTable)
			Return ExecuteSelectAsync(Command)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task(Of DataTable)
			Return ExecuteSelectAsync(Command, tr)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task(Of DataTable)
			Return ExecuteSelectAsync(Command, conn)
		End Function

	End Class

	Public Class ScalarCommand(Of T)

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand

		Public Function Execute() As T
			Return ExecuteScalar(Of T)(Command)
		End Function

		Public Function Execute(conn As SqlConnection) As T
			Return ExecuteScalar(Of T)(Command, conn)
		End Function

		Public Function Execute(tr As SqlTransaction) As T
			Return ExecuteScalar(Of T)(Command, tr)
		End Function

		Public Function ExecuteAsync() As Task(Of T)
			Return ExecuteScalarAsync(Of T)(Command)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task(Of T)
			Return ExecuteScalarAsync(Of T)(Command, conn)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task(Of T)
			Return ExecuteScalarAsync(Of T)(Command, tr)
		End Function

	End Class

	Public Class NonQueryCommand
		Implements ISQLCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand

		Public Sub Execute() Implements ISQLCommand.Execute
			ExecuteNonQuery(Command)
		End Sub

		Public Sub Execute(tr As SqlTransaction) Implements ISQLCommand.Execute
			ExecuteNonQuery(Command, tr)
		End Sub

		Public Sub Execute(conn As SqlConnection) Implements ISQLCommand.Execute
			ExecuteNonQuery(Command, conn)
		End Sub

		Public Async Function ExecuteAsync() As Task
			Await ExecuteNonQueryAsync(Command)
		End Function

		Public Async Function ExecuteAsync(tr As SqlTransaction) As Task
			Await ExecuteNonQueryAsync(Command, tr)
		End Function

		Public Async Function ExecuteAsync(conn As SqlConnection) As Task
			Await ExecuteNonQueryAsync(Command, conn)
		End Function

	End Class

	Public Interface ISQLCommand

		Sub Execute()

		Sub Execute(tr As SqlTransaction)

		Sub Execute(conn As SqlConnection)

	End Interface

	Private MustInherit Class BaseCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand
	End Class
#End Region

End Class