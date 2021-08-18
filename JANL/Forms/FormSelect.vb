Option Strict On

Imports System.Threading.Tasks
Imports JANL.Extensions

''' <summary>
''' One form to rule them all
''' </summary>
Public Class FormSelect
	Private ReadOnly Repository As BaseRepository
	Private FilterControl As UserControl

	Public Sub New(BR As BaseRepository)
		InitializeComponent()
		Repository = BR
		Name = Repository.GetType.Name + "Form"
		Icon = Repository.Icon
		'Добавление фильтра если он есть
		If Repository.HasFilter Then
			FilterControl = Repository.GetFilter()
			TLP_Filter.Controls.Add(FilterControl, 0, 0)
			FilterControl.Dock = DockStyle.Fill
			TLP_Filter.Visible = True
		End If
		If Repository.HasMenu Then
			For Each MI In Repository.GetMenu
				CMS_Select.Items.Add(MI.Text, MI.Image, Sub() MI.Action()(CurrentKey))
			Next
		End If

		BNB_New.Enabled = Repository.CanCreate
		BNB_Edit.Enabled = Repository.CanEdit
		BNB_Delete.Enabled = Repository.CanDelete
	End Sub

	Private WriteOnly Property UIState As Boolean
		Set(value As Boolean)
			TLP_Filter.Enabled = value
			BN_Select.Enabled = value
			DGV_Select.Enabled = value
			TLP_Select.Enabled = value
		End Set
	End Property

	Public Async Function RefreshData() As Task
		Try
			UIState = False
			Dim NDT = Await Repository.GetList()
			DGV_Select.SetDataSource(NDT)
			If Key > 0 Then
				BS_Select.Position = BS_Select.Find(Repository.KeyName, Key)
			End If
		Catch ex As Exception
			Msgs.ShowError(ex)
		Finally
			UIState = True
		End Try
	End Function

	Private Async Sub CloseHandler(sender As Object, e As EventArgs)
		If IsDisposed Then Exit Sub
		Await RefreshData()
		Activate()
	End Sub

#Region "Form Events"

	Private Async Sub BNB_Delete_Click(sender As Object, e As EventArgs) Handles BNB_Delete.Click
		If Msgs.AskYesNo($"Удалить {CurrentValue}({CurrentKey})?") = DialogResult.Yes Then
			Repository.DeleteItem(Key)
			Await RefreshData()
		End If
	End Sub

	Private Sub BNB_Edit_Click(sender As Object, e As EventArgs) Handles BNB_Edit.Click
		Dim F = Repository.EditItem(CurrentKey)
		If Modal Then
			F.ShowDialog(Me)
		Else
			F.MdiParent = MdiParent
			F.Show()
		End If
		AddHandler F.FormClosed, AddressOf CloseHandler
	End Sub

	Private Sub BNB_New_Click(sender As Object, e As EventArgs) Handles BNB_New.Click
		Dim F = Repository.CreateItem()
		If Modal Then
			F.ShowDialog(Me)
		Else
			F.MdiParent = MdiParent
			F.Show()
		End If
		AddHandler F.FormClosed, AddressOf CloseHandler
	End Sub

	Private Async Sub BNB_Refresh_Click(sender As Object, e As EventArgs) Handles BNB_Refresh.Click
		Await RefreshData()
	End Sub

	Private Sub BS_Select_PositionChanged(sender As Object, e As EventArgs) Handles BS_Select.PositionChanged
		Dim R = DirectCast(BS_Select.Current, DataRowView)
		If R Is Nothing Then Exit Sub
		CurrentKey = CInt(R(Repository.KeyName))
		CurrentValue = CStr(R(Repository.ValueName))
	End Sub

	Private Sub DGV_Select_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles DGV_Select.CellContextMenuStripNeeded
		DGV_Select.ClearSelection()
		Dim rowSelected = e.RowIndex
		If (e.RowIndex > 0) Then
			BS_Select.Position = rowSelected
			DGV_Select.Rows(rowSelected).Selected = True
		End If
		e.ContextMenuStrip = CMS_Select
	End Sub

	Private Sub DGV_Select_DoubleClick(sender As Object, e As EventArgs) Handles DGV_Select.DoubleClick
		If Modal Then
			B_Select.PerformClick()
		Else
			If BNB_Edit.Enabled Then BNB_Edit.PerformClick()
		End If
	End Sub

	Private Sub FormSelect_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.F5 Then
			BNB_Refresh.PerformClick()
			e.Handled = True
		End If
	End Sub

	Private Async Sub FormSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
		Try
			UIState = False
			DGV_Select.DoubleBuffered()
			DGV_Filter.Init(DGV_Select, Repository.DGVFilter)
			DGVManager.ApplyTemplate(DGV_Select, Repository.DGVTemplate)

			Text = $"{If(Modal, "Выбор", "Список")} - {Repository.Name}"
			TLP_Select.Visible = Modal

			DGV_Select.DataSource = BS_Select
			If AutoLoad Then Await RefreshData()
			UIState = True
		Catch ex As Exception
			Msgs.ShowError(ex)
		End Try
	End Sub

	Private Async Sub TSMI_Refresh_Click(sender As Object, e As EventArgs) Handles TSMI_Refresh.Click
		Await RefreshData()
	End Sub

#Region "Modal Only"

	Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub B_Reset_Click(sender As Object, e As EventArgs) Handles B_Reset.Click
		Key = 0
		Value = ""
		DialogResult = DialogResult.OK
		Close()
	End Sub

	Private Sub B_Select_Click(sender As Object, e As EventArgs) Handles B_Select.Click
		Try
			If BS_Select.Current Is Nothing Then
				Msgs.ShowInfo("Выберите строку")
				Exit Sub
			End If

			Key = CurrentKey
			Value = CurrentValue

			DialogResult = DialogResult.OK
			Close()
		Catch ex As Exception
			Msgs.ShowError(ex)
		End Try
	End Sub

#End Region

#End Region

#Region "Properties"
	Private _value As String

	Public Property AutoLoad As Boolean
	Public Property Key As Integer

	Public Property Value As String
		Get
			Return _value
		End Get
		Private Set(value As String)
			_value = value
		End Set
	End Property

	Private Property CurrentKey As Integer

	Private Property CurrentValue As String

#End Region

#Region "Shared"

	Public Shared Function IsOpen(Of T As BaseRepository)() As Boolean
		Return IsOpen(Of T)(True)
	End Function

	Public Shared Function IsOpen(Of T As BaseRepository)(Activate As Boolean) As Boolean
		Dim Name = GetType(T).Name + "Form"
		Dim Forms = Application.OpenForms.OfType(Of FormSelect).Where(Function(F) F.Name = Name)
		If Activate AndAlso Forms.Count > 0 Then
			Forms.First.Activate()
		End If
		Return Forms.Count > 0
	End Function

#End Region

End Class