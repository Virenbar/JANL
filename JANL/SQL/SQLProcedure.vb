Namespace SQL
	''' <summary>
	''' Процедура возвращающая <typeparamref name="T"/>
	''' </summary>
	''' <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
	Public MustInherit Class SQLProcedure(Of T)
		Inherits BaseSQLCommand(Of T)

		''' <summary>
		''' Создаёт новую процедуру с именем вызывающего метода
		''' </summary>
		Public Sub New(Name As String)
			MyBase.New(Name, CommandType.StoredProcedure)
		End Sub

	End Class
End Namespace