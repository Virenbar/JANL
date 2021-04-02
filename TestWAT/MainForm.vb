Public Class MainForm

	Private Sub НаселениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НаселениеToolStripMenuItem.Click
		MakeGood("D:\Мои документы\Рабочий стол\Население Тагил\население 2019-1")
	End Sub

	Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
		MakeGood1()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		PlayMary()
	End Sub

	Private Sub DaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaDataToolStripMenuItem.Click
		FormAddressSuggest.Show()
	End Sub

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub ПочтаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПочтаToolStripMenuItem.Click
		FormPochta.Show()
	End Sub

	Private Sub HashVSListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HashVSListToolStripMenuItem.Click
		PerfomanceTests.HashVSList()
	End Sub

	Private Sub FormAsyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormAsyncToolStripMenuItem.Click
		Dim F = New FormAsync()
		F.Show()
	End Sub

	Private Sub TestFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFormToolStripMenuItem.Click
		Dim F = New FormTest()
		F.ShowDialog(Me)
	End Sub

End Class