Imports Microsoft.VisualBasic

Namespace Helpers
	Public Class XLS

		''' <summary>
		''' Переводит строковый индекс в числовой
		''' </summary>
		''' <param name="index">Строковый индекс</param>
		Public Shared Function ToNumber(index As String) As Integer
			Return index.ToUpper().Aggregate(0, Function(column, letter) 26 * column + Asc(letter) - Asc("A"c) + 1)
		End Function

		''' <summary>
		''' Переводит числовой индекс в строковый
		''' </summary>
		''' <param name="index">Числовой индекс</param>
		Public Shared Function ToLetter(index As Integer) As String
			Dim c As Byte
			Dim s As String = ""
			Do
				c = CByte((index - 1) Mod 26)
				s = Chr(c + Asc("A"c)) + s
				index = (index - c) \ 26
			Loop While index > 0
			Return s
		End Function

		''' <summary>
		''' Переводит числовой адрес в строковый
		''' </summary>
		''' <param name="row">Индекс строки</param>
		''' <param name="col">Индекс столбца</param>
		Public Shared Function ToLetter(row As Integer, col As Integer) As String
			Return ToLetter(col) + row.ToString
		End Function

		''' <summary>
		''' Создаёт список строковых индексов
		''' </summary>
		''' <param name="first">Начальный строковый индекс</param>
		''' <param name="last">Конечный строковый индекс</param>
		''' <returns></returns>
		Public Shared Function LetterRange(first As String, last As String) As List(Of String)
			Dim min = ToNumber(first) + 1, max = ToNumber(last) - 1
			If Not (min <= max) Then Return New List(Of String) From {first, last}
			Dim Items As New List(Of String) From {first}
			For i = min To max
				Items.Add(ToLetter(i))
			Next
			Items.Add(last)
			Return Items
		End Function

		''' <summary>
		'''	Перевод ширины столбца Excel в OOXML
		''' </summary>
		''' <param name="d"></param>
		''' <returns></returns>
		Public Function ToOOXMLWidth(d As Double) As Double
			Return d + 0.7109375
		End Function

	End Class
End Namespace