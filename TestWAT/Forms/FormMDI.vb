Public Class FormMDI

	Private Sub FormSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormSelectToolStripMenuItem.Click
		Dim F = New JANL.FormSelect(New TestRepository()) With {.MdiParent = Me}
		F.Show()
	End Sub

End Class