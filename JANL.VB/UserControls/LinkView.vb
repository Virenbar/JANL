Imports System.Threading.Tasks
Imports JANL.Extensions

Public Class LinkView
	Private LinkKey As Integer?
	Private LinkList As BaseLinkList

	Public Sub New()
		InitializeComponent()
		DGV_Links.AutoGenerateColumns = True
		DGV_Links.DoubleBuffered()
	End Sub

	Private WriteOnly Property UIState As Boolean
		Set
			TLP_Footer.Enabled = Value
		End Set
	End Property

	Public Function RefreshView() As Task
		Return RefreshData()
	End Function

	Public Sub SetList(LinkList As BaseLinkList)
		Me.LinkList = LinkList
		If LinkList.DGVTemplate IsNot Nothing Then DGVManager.ApplyTemplate(DGV_Links, LinkList.DGVTemplate)
		RefreshUI()
	End Sub

	Private Async Sub CloseHandler(sender As Object, e As EventArgs)
		If IsDisposed Then Exit Sub
		Await RefreshData()
	End Sub

	Private Async Function RefreshData() As Task
		Try
			UIState = False

			Dim DT = Await LinkList.GetList()
			BS_Links.DataSource = DT
		Catch ex As Exception
			Msgs.ShowError(ex)
		Finally
			UIState = True
		End Try
	End Function

	Private Sub RefreshUI()
		Dim State = BS_Links.Current IsNot Nothing
		B_Edit.Enabled = State AndAlso LinkList.CanEdit
	End Sub

#Region "UIEvents"

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

	Private Async Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
		Await RefreshData()
	End Sub

	Private Sub BS_Links_CurrentChanged(sender As Object, e As EventArgs) Handles BS_Links.CurrentChanged
		RefreshUI()
		Dim R = DirectCast(BS_Links.Current, DataRowView)?.Row
		LinkKey = R?.Field(Of Integer)(LinkList.KeyName)
	End Sub

#End Region

End Class