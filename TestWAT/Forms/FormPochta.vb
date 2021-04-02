Public Class FormPochta
	Private Shared po As New Pochta.OperationHistory12Client
	Private Shared Header As New Pochta.AuthorizationHeader() With {.login = Config.Current.PochtaLogin, .password = Config.Current.PochtaPassword}

	Private Async Sub B_Check_Click(sender As Object, e As EventArgs) Handles B_Check.Click
		Dim resp = Await po.getOperationHistoryAsync(New Pochta.OperationHistoryRequest() With {.Barcode = TB_Track.Text, .MessageType = 0}, Header)
		Dim r = resp.OperationHistoryData
	End Sub

End Class