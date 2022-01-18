Public Class Strings

	Public Shared Function GetPeriod(DateBegin As Date, DateEnd As Date) As String
		Return If(DateBegin.Month = DateEnd.Month And DateBegin.Year = DateEnd.Year, $"за {DateBegin:MMMM yyyy}г.", $"за период с {DateBegin:MMMM yyyy}г. по {DateEnd:MMMM yyyy}г.")
	End Function

End Class