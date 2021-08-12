Public Class DGVTEdit

	Private Sub DGVTEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DGVT.SetTemplate(New JANL.Types.DGVTemplate())
	End Sub

End Class