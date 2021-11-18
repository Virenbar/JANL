Namespace SQL

	Public Class Defaults

		''' <summary>
		''' Соединение по умолчанию
		''' </summary>
		Public Shared Property DefaultConnection As String

		''' <summary>
		''' Время ожидания выполнения команды (в секундах) по умолчанию.
		''' По умолчанию используется значение 30 секунд.
		''' </summary>
		Public Shared Property DefaultTimeout As Integer = 30

	End Class
End Namespace