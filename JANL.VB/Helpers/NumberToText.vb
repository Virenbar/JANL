Imports System.Text
Imports System.Numerics

Public NotInheritable Class NumberToText
	Private Const MaxClass = 40

	Public Shared Function NumberToText(Value As BigInteger, Noun As Noun) As String
		Return $"{NumberToText(Value, Noun.Kind)} {CaseForNumber(CInt(Value Mod 1000), Noun)}"
	End Function

	''' <summary>Перевод целого числа в строку</summary>
	''' <param name="Value">Число</param>
	''' <returns>Возвращает строковую запись числа</returns>
	Public Shared Function NumberToText(Value As BigInteger, Kind As Kind) As String
		If Value.IsZero Then Return "Ноль"
		Dim Minus = Value.Sign < 0
		Dim N = BigInteger.Abs(Value)
		If CInt(BigInteger.Log10(N)) \ 3 > MaxClass Then Return N.ToString("E")

		Dim SB = New StringBuilder()
		InsertClass(SB, CInt(N Mod 1000), Kind)
		If N > 999 Then
			Dim ClassIndex = 0
			Dim NumberNouns = GetNumberNouns()
			N /= 1000
			While N <> 0
				Dim Noun = NumberNouns(ClassIndex)
				Dim Part = CInt(N Mod 1000)
				ClassIndex += 1
				N /= 1000

				If Part = 0 Then Continue While
				SB.Insert(0, " " + CaseForNumber(Part, Noun) + " ")
				InsertClass(SB, Part, Noun.Kind)
			End While
		End If

		If Minus Then SB.Insert(0, "минус ")
		Return SB.ToString().Trim(" "c)
	End Function

	''' <summary>
	''' Перевод суммы в текст
	''' </summary>
	''' <param name="Summa">Сумма</param>
	''' <returns>Сумма текстом</returns>
	Public Shared Function RubToText(Summa As Decimal) As String
		Dim kop As Integer = CInt((Summa Mod 1) * 100)
		Return $"{NumberToText(New BigInteger(Summa), Kind.Male)} {CaseForNumber(CInt(Math.Truncate(Summa) Mod 1000), "рубль", "рубля", "рублей")} {kop} {CaseForNumber(kop, "копейка", "копейки", "копеек")}"
	End Function

	''' <summary>
	''' Выбор правильного падежного окончания существительного
	''' </summary>
	''' <param name="Value">Число</param>
	''' <param name="one">Форма существительного в единственном числе</param>
	''' <param name="two">Форма существительного от двух до четырёх</param>
	''' <param name="five">Форма существительного от пяти и больше</param>
	''' <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
	Private Shared Function CaseForNumber(Value As Integer, One As String, Two As String, Five As String) As String
		Dim t As Integer = If(Value Mod 100 > 20, Value Mod 10, Value Mod 20)
		Select Case t
			Case 1 : Return One
			Case 2 To 4 : Return Two
			Case Else : Return Five
		End Select
	End Function

	''' <summary>
	''' Выбор правильного падежного окончания существительного
	''' </summary>
	''' <param name="Value">Число</param>
	''' <param name="Noun">Формы существительного</param>
	''' <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
	Private Shared Function CaseForNumber(Value As Integer, Noun As Noun) As String
		Return CaseForNumber(Value, Noun.One, Noun.Two, Noun.Five)
	End Function

	Private Shared Sub InsertClass(SB As StringBuilder, Value As Integer, Kind As Kind)
		If Value = 0 Then Exit Sub

		Dim C As String
		If Value Mod 100 < 20 Then
			C = GetHundred(Value) + " " + GetFraction20(Value Mod 20, Kind)
		Else
			C = GetHundred(Value) + " " + GetTen(Value) + " " + GetFraction20(Value Mod 10, Kind)
		End If
		SB.Insert(0, C.Trim(" "c))
	End Sub

#Region "Numbers and Nouns"

	Private Shared Function GetFraction20(Value As Integer, Kind As Kind) As String
		If Value = 0 Then Return ""
		If Value < 3 Then
			Select Case Kind
				Case Kind.Male
					Return {"один", "два"}(Value - 1)
				Case Kind.Female
					Return {"одна", "две"}(Value - 1)
				Case Kind.Middle
					Return {"одно", "два"}(Value - 1)
			End Select
		End If
		Return {"три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"}(Value - 3)
	End Function

	''' <summary>
	''' Получить наименование сотни для значения класса
	''' </summary>
	Private Shared Function GetHundred(Value As Integer) As String
		Return {"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"}(Value \ 100)
	End Function

	Private Shared Function GetNumberNouns() As Noun()
		Return {
			New Noun("тысяча", "тысячи", "тысяч", Kind.Female),
			New Noun("миллион", "миллиона", "миллионов"),
			New Noun("миллиард", "миллиарда", "миллиардов"),
			New Noun("триллион", "триллиона", "триллионов"),
			New Noun("квадриллион", "квадриллиона", "квадриллионов"),
			New Noun("квинтиллион", "квинтиллиона", "квинтиллионов"),
			New Noun("секстиллион", "секстиллиона", "секстиллионов"),
			New Noun("септиллион", "септиллиона", "септиллионов"),
			New Noun("октиллион", "октиллиона", "октиллионов"),
			New Noun("нониллион", "нониллиона", "нониллионов"),
			New Noun("дециллион", "дециллиона", "дециллионов"),
			New Noun("ундециллион", "ундециллиона", "ундециллионов"),
			New Noun("дуодециллион", "дуодециллиона", "дуодециллионов"),
			New Noun("тредециллион", "тредециллиона", "тредециллионов"),
			New Noun("квиндециллион", "квиндециллиона", "квиндециллионов"),
			New Noun("сексдециллион", "сексдециллионa", "сексдециллион"),
			New Noun("септдециллион", "септдециллиона", "септдециллионов"),
			New Noun("октодециллион", "октодециллионa", "октодециллионов"),
			New Noun("новемдециллион", "октодециллионa", "октодециллионов"),
			New Noun("вигинтиллион", "вигинтиллиона", "вигинтиллионов"),
			New Noun("унвигинтиллион", "унвигинтиллионa", "унвигинтиллионов"),
			New Noun("дуовигинтиллион", "дуовигинтиллионa", "дуовигинтиллионов"),
			New Noun("тревигинтиллион", "тревигинтиллионa", "тревигинтиллионов"),
			New Noun("кваттуорвигинтиллион", "кваттуорвигинтиллионa", "кваттуорвигинтиллионов"),
			New Noun("квинвигинтиллион", "квинвигинтиллионa", "квинвигинтиллионов"),
			New Noun("сексвигинтиллион", "сексвигинтиллионa", "сексвигинтиллионов"),
			New Noun("септенвигинтиллион", "септенвигинтиллионa", "септенвигинтиллионов"),
			New Noun("октовигинтиллион", "октовигинтиллионa", "октовигинтиллионов"),
			New Noun("новемвигинтиллион", "новемвигинтиллионa", "новемвигинтиллионов"),
			New Noun("тригинтиллион", "тригинтиллионa", "тригинтиллионов"),
			New Noun("унтригинтиллион", "унтригинтиллионa", "унтригинтиллионов"),
			New Noun("дуотригинтиллион", "дуотригинтиллионa", "дуотригинтиллионов"),
			New Noun("третригинтиллион", "третригинтиллионa", "третригинтиллионов"),
			New Noun("кваттуортригинтиллион", "кваттуортригинтиллионa", "кваттуортригинтиллионов"),
			New Noun("квинтригинтиллион", "квинтригинтиллионa", "квинтригинтиллионов"),
			New Noun("секстригинтиллион", "секстригинтиллионa", "секстригинтиллионов"),
			New Noun("септентригинтиллион", "септентригинтиллионa", "септентригинтиллионов"),
			New Noun("октотригинтиллион", "октотригинтиллионa", "октотригинтиллионов"),
			New Noun("новемтригинтиллион", "новемтригинтиллионa", "новемтригинтиллионов"),
			New Noun("квадрагинтиллион", "квадрагинтиллионa", "квадрагинтиллионов")}

#Region "https://ru.wikipedia.org/wiki/Системы_наименования_чисел"
		'⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⣠⣤⣶⣶
		'⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⢰⣿⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣀⣀⣾⣿⣿⣿⣿
		'⣿⣿⣿⣿⣿⡏⠉⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿
		'⣿⣿⣿⣿⣿⣿⠀⠀⠀⠈⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠁⠀⣿
		'⣿⣿⣿⣿⣿⣿⣧⡀⠀⠀⠀⠀⠙⠿⠿⠿⠻⠿⠿⠟⠿⠛⠉⠀⠀⠀⠀⠀⣸⣿
		'⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣴⣿⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀⢰⣹⡆⠀⠀⠀⠀⠀⠀⣭⣷⠀⠀⠀⠸⣿⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠈⠉⠀⠀⠤⠄⠀⠀⠀⠉⠁⠀⠀⠀⠀⢿⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⢾⣿⣷⠀⠀⠀⠀⡠⠤⢄⠀⠀⠀⠠⣿⣿⣷⠀⢸⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⡀⠉⠀⠀⠀⠀⠀⢄⠀⢀⠀⠀⠀⠀⠉⠉⠁⠀⠀⣿⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿
		'⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿
#End Region

	End Function

	''' <summary>
	''' Получить наименование десятка для значения класса
	''' </summary>
	Private Shared Function GetTen(Value As Integer) As String
		Return {"", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"}((Value Mod 100) \ 10)
	End Function

#End Region

#Region "Noun"

	''' <summary>
	''' Существительное
	''' </summary>
	Public Structure Noun

		Public Sub New(One As String, Two As String, Five As String, Kind As Kind)
			Me.New()
			Me.One = One
			Me.Two = Two
			Me.Five = Five
			Me.Kind = Kind
		End Sub

		Public Sub New(One As String, Two As String, Five As String)
			Me.New(One, Two, Five, Kind.Male)
		End Sub

		Public Property Five As String
		Public Property Kind As Kind
		Public Property One As String
		Public Property Two As String
	End Structure

	''' <summary>
	''' Род
	''' </summary>
	Public Enum Kind

		''' <summary>
		''' Мужской род
		''' </summary>
		Male

		''' <summary>
		''' Женский род
		''' </summary>
		Female

		''' <summary>
		''' Средний род
		''' </summary>
		Middle

	End Enum

#End Region

End Class