Imports Dadata

Public Class FormULCheck
	Private SC1 As New SuggestClientAsync(Config.Current.ADataToken)

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim INN = If(TB_INN.Text.Length > 0, TB_INN.Text, "6671375746")
		Dim resp = Await SC1.FindParty(INN)
		Dim data = resp.suggestions.First.data
	End Sub

End Class