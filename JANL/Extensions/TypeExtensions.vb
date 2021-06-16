Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace Extensions
	Module TypeExtensions
		Private ReadOnly Rnd As New Random(Today.Millisecond)

		''' <summary>
		''' Помечает все строки на удаление
		''' </summary>
		''' <param name="dt"></param>
		<Extension>
		Public Sub DeleteAll(dt As DataTable)
			Dim RemoveRowsTable = dt
			Dim i = 0
			'Remove All
			While i < RemoveRowsTable.Rows.Count
				Dim currentRow = RemoveRowsTable.Rows(i)
				If (currentRow.RowState <> DataRowState.Deleted) Then
					currentRow.Delete()
				Else
					i += 1
				End If
			End While
		End Sub

		<Extension>
		Public Function PickRandom(Of T)(L As IEnumerable(Of T)) As T
			If L.Count = 0 Then Return Nothing
			Return L(Rnd.Next(L.Count))
		End Function

		<Extension>
		Public Function Truncate(value As String, maxLength As Integer) As String
			If (String.IsNullOrEmpty(value)) Then Return value
			Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
		End Function

		<Extension>
		Public Function PreINC(ByRef x As Integer) As Integer
			Return Interlocked.Increment(x)
		End Function

		<Extension>
		Public Function PostINC(ByRef x As Integer) As Integer
			Dim tmp = x
			Interlocked.Increment(x)
			Return tmp
		End Function

		<Extension>
		Public Function PreDEC(ByRef x As Integer) As Integer
			Return Interlocked.Decrement(x)
		End Function

		<Extension>
		Public Function PostDEC(ByRef x As Integer) As Integer
			Dim tmp = x
			Interlocked.Decrement(x)
			Return tmp
		End Function

	End Module
End Namespace