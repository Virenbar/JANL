Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports JANL.SQL.Defaults

Namespace SQL

	Public MustInherit Class BaseSQLCommand(Of T)
		Implements IDisposable

		Protected SQLCommand As SqlCommand

		Public Sub New(Name As String)
			SQLCommand = New SqlCommand(Name) With {.CommandType = CommandType.StoredProcedure, .CommandTimeout = DefaultTimeout}
		End Sub

		Public ReadOnly Property Parameters As SqlParameterCollection
			Get
				Return SQLCommand.Parameters
			End Get
		End Property

		Public Sub Prepare()
			SQLCommand.Prepare()
		End Sub

#Region "Synchronous"

		''' <summary>
		''' Создает и открывает новое соединение по умолчанию
		''' </summary>
		Public Shared Function NewConnection() As SqlConnection
			Return NewConnection(DefaultConnection)
		End Function

		''' <summary>
		''' Создает и открывает новое соединение
		''' </summary>
		Public Shared Function NewConnection(str As String) As SqlConnection
			Dim Connection = New SqlConnection(str)
			If Connection.State <> ConnectionState.Open Then Connection.Open()
			Return Connection
		End Function

		Public Function Execute() As T
			Using Connection = NewConnection()
				Return Execute(Connection)
			End Using
		End Function

		Public Function Execute(Transaction As SqlTransaction) As T
			SQLCommand.Transaction = Transaction
			Return Execute(Transaction.Connection)
		End Function

		Public MustOverride Function Execute(Connection As SqlConnection) As T

#End Region

#Region "Asynchronous"

		''' <summary>
		''' Создает и открывает новое соединение по умолчанию
		''' </summary>
		''' <returns></returns>
		Public Shared Function NewConnectionAsync() As Task(Of SqlConnection)
			Return NewConnectionAsync(DefaultConnection)
		End Function

		''' <summary>
		''' Создает и открывает новое соединение
		''' </summary>
		''' <returns></returns>
		Public Shared Async Function NewConnectionAsync(str As String) As Task(Of SqlConnection)
			Dim Connection = New SqlConnection(str)
			If Connection.State <> ConnectionState.Open Then Await Connection.OpenAsync()
			Return Connection
		End Function

		Public Async Function ExecuteAsync() As Task(Of T)
			Using Connection = Await NewConnectionAsync()
				Return Await ExecuteAsync(Connection)
			End Using
		End Function

		Public Function ExecuteAsync(Transaction As SqlTransaction) As Task(Of T)
			SQLCommand.Transaction = Transaction
			Return ExecuteAsync(Transaction.Connection)
		End Function

		Public MustOverride Async Function ExecuteAsync(Connection As SqlConnection) As Task(Of T)

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