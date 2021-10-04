Public Class FormMDI

	Private Sub FormSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormSelectToolStripMenuItem.Click
		Dim F = New JANL.FormSelect(New TestRepository()) With {.MdiParent = Me}
		F.Show()
	End Sub

	Private Sub FormViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormViewToolStripMenuItem.Click
		Dim F = New FormView() With {.MdiParent = Me}
		F.Show()
	End Sub

End Class