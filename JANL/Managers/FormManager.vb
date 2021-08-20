Public Class FormManager
	Private Shared Root As ToolStripMenuItem
	Private Shared TSMIs As New Dictionary(Of Form, ToolStripMenuItem)

	Public Shared Sub Add(Form As Form)
		If TSMIs.ContainsKey(Form) Then Exit Sub
		Dim TSMI As New ToolStripMenuItem With {
			.Text = Form.Text,
			.Image = Form.Icon.ToBitmap()
		}
		AddHandler TSMI.Click, Sub() Form.Activate()
		AddHandler Form.TextChanged, AddressOf TextChanged
		AddHandler Form.FormClosed, AddressOf FormClosed

		Root.DropDownItems.Add(TSMI)
		Root.Visible = True
		TSMIs.Add(Form, TSMI)
	End Sub

	Public Shared Sub SetMenu(TSMI As ToolStripMenuItem)
		If Root IsNot Nothing Then
			For Each KV In TSMIs
				Root.DropDownItems.Remove(KV.Value)
				TSMI.DropDownItems.Add(KV.Value)
			Next
			ChangeVisibility()
		End If
		Root = TSMI
		ChangeVisibility()
	End Sub

	Private Shared Sub FormClosed(sender As Object, e As EventArgs)
		Dim Form = DirectCast(sender, Form)
		Remove(Form)
	End Sub

	Private Shared Sub Remove(Form As Form)
		If Not TSMIs.ContainsKey(Form) Then Exit Sub
		Dim TSMI = TSMIs(Form)
		RemoveHandler Form.TextChanged, AddressOf TextChanged
		RemoveHandler Form.FormClosed, AddressOf FormClosed

		Root.DropDownItems.Remove(TSMI)
		TSMIs.Remove(Form)
		TSMI.Dispose()
		ChangeVisibility()
	End Sub

	Private Shared Sub ChangeVisibility()
		Root.Visible = Not Root.DropDownItems.Count = 0
	End Sub

	Private Shared Sub TextChanged(sender As Object, e As EventArgs)
		Dim Form = DirectCast(sender, Form)
		TSMIs(Form).Text = Form.Text
	End Sub

End Class