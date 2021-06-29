Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace SQL
	Public Class SelectCommand
		Implements ISelectCommand

		Public Sub New(comm As SqlCommand)
			Command = comm
		End Sub

		Public ReadOnly Property Command As SqlCommand Implements ISelectCommand.Command

		Public Function Execute() As DataTable Implements ISelectCommand.Execute
			Return SQLHelper.ExecuteSelect(Command)
		End Function

		Public Function Execute(tr As SqlTransaction) As DataTable Implements ISelectCommand.Execute
			Return SQLHelper.ExecuteSelect(Command, tr)
		End Function

		Public Function Execute(conn As SqlConnection) As DataTable Implements ISelectCommand.Execute
			Return SQLHelper.ExecuteSelect(Command, conn)
		End Function

		Public Function ExecuteAsync() As Task(Of DataTable) Implements ISelectCommand.ExecuteAsync
			Return SQLHelper.ExecuteSelectAsync(Command)
		End Function

		Public Function ExecuteAsync(tr As SqlTransaction) As Task(Of DataTable) Implements ISelectCommand.ExecuteAsync
			Return SQLHelper.ExecuteSelectAsync(Command, tr)
		End Function

		Public Function ExecuteAsync(conn As SqlConnection) As Task(Of DataTable) Implements ISelectCommand.ExecuteAsync
			Return SQLHelper.ExecuteSelectAsync(Command, conn)
		End Function

	End Class

End Namespace