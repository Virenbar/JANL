Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports JANL.SQL.Defaults

Namespace SQL
	''' <summary>
	''' Команда выполняющая процедуру и возвращающая <typeparamref name="T"/>
	''' </summary>
	''' <typeparam name="T">Тип возвращаемого процедурой значения</typeparam>
	Public MustInherit Class BaseSQLCommand(Of T)
		Implements IDisposable, ISQLCommand(Of T)

		Protected ReadOnly SQLCommand As SqlCommand

		Public Sub New(CommandText As String, Type As CommandType)
			SQLCommand = New SqlCommand(CommandText) With {.CommandType = Type, .CommandTimeout = DefaultTimeout}
			ConnectionString = DefaultConnection
		End Sub

		<Obsolete>
		Public Sub New(Name As String)
			Me.New(Name, CommandType.StoredProcedure)
		End Sub

		Public Sub Prepare()
			SQLCommand.Prepare()
		End Sub

#Region "Properties"

		''' <summary>
		''' Соединение для команды
		''' <para>По умолчанию используется значение <see cref="DefaultConnection"/></para>
		''' </summary>
		Public Property ConnectionString As String

		''' <summary>
		''' Параметры команды
		''' </summary>
		Public ReadOnly Property Parameters As SqlParameterCollection Implements ISQLCommand(Of T).Parameters
			Get
				Return SQLCommand.Parameters
			End Get
		End Property

		''' <summary>
		''' Время ожидания выполнения команды (в секундах)
		''' <para>По умолчанию используется значение <see cref="DefaultTimeout"/></para>
		''' </summary>
		Public Property Timeout As Integer Implements ISQLCommand(Of T).Timeout
			Get
				Return SQLCommand.CommandTimeout
			End Get
			Set
				SQLCommand.CommandTimeout = Value
			End Set
		End Property

#End Region

#Region "Synchronous"

		''' <summary>
		''' Выполняет команду с соединением по умолчанию
		''' </summary>
		Public Function Execute() As T Implements ISQLCommand(Of T).Execute
			Using Connection = NewConnection(ConnectionString)
				Return Execute(Connection)
			End Using
		End Function

		''' <summary>
		''' Выполняет команду в указанной транзакции
		''' </summary>
		Public Function Execute(Transaction As SqlTransaction) As T Implements ISQLCommand(Of T).Execute
			SQLCommand.Transaction = Transaction
			Return Execute(Transaction.Connection)
		End Function

		''' <summary>
		''' Выполняет команду с указанным соединением
		''' </summary>
		Public Function Execute(ConnectionString As String) As T Implements ISQLCommand(Of T).Execute
			Using Connection = NewConnection(ConnectionString)
				Return Execute(Connection)
			End Using
		End Function

		''' <summary>
		''' Выполняет команду с указанным соединением
		''' </summary>
		Public MustOverride Function Execute(Connection As SqlConnection) As T Implements ISQLCommand(Of T).Execute

		''' <summary>
		''' Создает и открывает новое соединение по умолчанию
		''' </summary>
		<Obsolete>
		Protected Shared Function NewConnection() As SqlConnection
			Return NewConnection(DefaultConnection)
		End Function

		''' <summary>
		''' Создает и открывает новое соединение
		''' </summary>
		Protected Shared Function NewConnection(ConnectionString As String) As SqlConnection
			Dim Connection = New SqlConnection(ConnectionString)
			If Connection.State <> ConnectionState.Open Then Connection.Open()
			Return Connection
		End Function

#End Region

#Region "Asynchronous"

		''' <summary>
		''' Асинхронно выполняет команду с соединением по умолчанию
		''' </summary>
		Public Async Function ExecuteAsync() As Task(Of T) Implements ISQLCommand(Of T).ExecuteAsync
			Using Connection = Await NewConnectionAsync(ConnectionString)
				Return Await ExecuteAsync(Connection)
			End Using
		End Function

		''' <summary>
		''' Асинхронно выполняет команду в указанной транзакции
		''' </summary>
		Public Function ExecuteAsync(Transaction As SqlTransaction) As Task(Of T) Implements ISQLCommand(Of T).ExecuteAsync
			SQLCommand.Transaction = Transaction
			Return ExecuteAsync(Transaction.Connection)
		End Function

		''' <summary>
		''' Асинхронно выполняет команду с указанным соединением
		''' </summary>
		Public Async Function ExecuteAsync(ConnectionString As String) As Task(Of T) Implements ISQLCommand(Of T).ExecuteAsync
			Using Connection = Await NewConnectionAsync(ConnectionString)
				Return Execute(Connection)
			End Using
		End Function

		''' <summary>
		''' Асинхронно выполняет команду с указанным соединением
		''' </summary>
		Public MustOverride Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of T) Implements ISQLCommand(Of T).ExecuteAsync

		''' <summary>
		''' Создает и открывает новое соединение по умолчанию
		''' </summary>
		<Obsolete>
		Protected Shared Function NewConnectionAsync() As Task(Of SqlConnection)
			Return NewConnectionAsync(DefaultConnection)
		End Function

		''' <summary>
		''' Создает и открывает новое соединение
		''' </summary>
		''' <returns></returns>
		Protected Shared Async Function NewConnectionAsync(ConnectionString As String) As Task(Of SqlConnection)
			Dim Connection = New SqlConnection(ConnectionString)
			If Connection.State <> ConnectionState.Open Then Await Connection.OpenAsync()
			Return Connection
		End Function

#End Region

#Region "IDisposable Support"
		Private disposedValue As Boolean

		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
		End Sub

		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not disposedValue Then
				If disposing Then
					SQLCommand.Dispose()
				End If
			End If
			disposedValue = True
		End Sub

#End Region

	End Class
End Namespace