Imports System.Threading.Tasks

Public Class LinkView
	Private LinkList As BaseLinkList
	Private LinkKey As Integer?

	Public Sub SetList(LinkList As BaseLinkList)
		Me.LinkList = LinkList
		If LinkList.DGVTemplate IsNot Nothing Then DGVManager.ApplyTemplate(DGV_Childs, LinkList.DGVTemplate)
		BState()
	End Sub

	Public Function RefreshView() As Task
		Return RefreshData()
	End Function

	Private Async Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
		Await RefreshData()
	End Sub

	Private WriteOnly Property UIState As Boolean
		Set(value As Boolean)
			TLP_Footer.Enabled = value
		End Set
	End Property

	Private Sub B_Edit_Click(sender As Object, e As EventArgs) Handles B_Edit.Click
		Dim P = ParentForm
		Dim F = LinkList.EditItem(LinkKey.Value)
		If P.Modal Then
			F.ShowDialog(P)
		Else
			F.MdiParent = P.MdiParent
			F.Show()
		End If
		AddHandler F.FormClosed, AddressOf CloseHandler
	End Sub

	Public Async Function RefreshData() As Task
		Try
			UIState = False

			Dim DT = Await LinkList.GetList()
			BS_Child.DataSource = DT
		Catch ex As Exception
			Msgs.ShowError(ex)
		Finally
			UIState = True
		End Try
	End Function

	Private Sub BS_Child_CurrentChanged(sender As Object, e As EventArgs) Handles BS_Child.CurrentChanged
		BState()
		Dim R = DirectCast(BS_Child.Current, DataRowView)?.Row
		LinkKey = R?.Field(Of Integer)(LinkList.KeyName)
	End Sub

	Private Sub BState()
		Dim State = BS_Child.Current IsNot Nothing
		B_Edit.Enabled = State AndAlso LinkList.CanEdit
	End Sub

	Private Async Sub CloseHandler(sender As Object, e As EventArgs)
		If IsDisposed Then Exit Sub
		Await RefreshData()
	End Sub

End Class