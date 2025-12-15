Imports System.Text.RegularExpressions

Public Class PerfomanceTests

    Public Shared Sub HashVSList()
        Dim H = New HashSet(Of Integer)
        Dim L = New List(Of Integer)
        For i = 1 To 100000
            H.Add(i)
            L.Add(i)
        Next

        Dim R = New Random(123)
        Dim HR = Run(Sub() H.Contains(R.Next))
        R = New Random(123)
        Dim LR = Run(Sub() L.Contains(R.Next))

        Console.WriteLine($"HashSet: {HR}")
        Console.WriteLine($"List: {LR}")
    End Sub

    Public Shared Sub RegexVSArray()
        Dim S = "тешщтуцшетцущнтшщуцнтуцшнтрктмнуткнумкнТДУЖТЕШТУНЛТУШНТУШЦТУЩШЕ"

        Dim VowelsLower() As Char = {"у"c, "е"c, "ы"c, "а"c, "о"c, "э"c, "я"c, "и"c, "ю"c}
        Dim Vowels = VowelsLower.Concat(VowelsLower.AsEnumerable().Select(Function(x) Char.ToUpperInvariant(x))).ToArray()
        Dim V = New Regex("[уеыаоэяиюУЕЫАОЭЯИЮ]", RegexOptions.Compiled)

        Dim Array = Run(Sub() String.Join("", S.Split(Vowels)))
        Dim Regex = Run(Sub() V.Replace(S, ""))

        Console.WriteLine($"Array: {Array}")
        Console.WriteLine($"Regex: {Regex}")
    End Sub

    Private Shared Function Run(Action As Action) As TimeSpan
        Return Run(Action, 100000)
    End Function

    Private Shared Function Run(Action As Action, Count As Integer) As TimeSpan
        Dim SW = New Stopwatch()
        SW.Restart()
        For i = 1 To Count
            Action()
        Next
        SW.Stop()
        Return SW.Elapsed
    End Function

End Class