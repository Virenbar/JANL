Public Class PerfomanceTests

	Public Shared Sub HashVSList()
		Dim SW = New Stopwatch()
		Dim H = New HashSet(Of Integer)
		Dim L = New List(Of Integer)
		For i = 1 To 100000
			H.Add(i)
			L.Add(i)
		Next

		Dim R = New Random(123)
		SW.Restart()
		For i = 1 To 100000
			H.Contains(R.Next)
		Next
		SW.Stop()
		Dim HR = SW.Elapsed.ToString

		R = New Random(123)
		SW.Restart()
		For i = 1 To 100000
			L.Contains(R.Next)
		Next
		SW.Stop()
		Dim LR = SW.Elapsed.ToString

		Console.WriteLine($"HashSet: {HR}")
		Console.WriteLine($"List: {LR}")
	End Sub

End Class