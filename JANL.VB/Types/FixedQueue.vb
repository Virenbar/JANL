Namespace Types

	Public Class FixedQueue(Of T)
		Inherits Queue(Of T)
		Private Limit As Integer

		Public Sub New(_limit As Integer)
			MyBase.New(_limit)
			Limit = _limit
		End Sub

		Public Overloads Sub Enqueue(item As T)
			While (Count >= Limit)
				Dequeue()
			End While
			MyBase.Enqueue(item)
		End Sub

	End Class
End Namespace