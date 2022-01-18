Option Strict On

Imports System.Drawing

''' <summary>
''' Фильтр для DataGridView
''' </summary>
Public Class DGVFilter
	Inherits ToolStripTextBox
	Private WithEvents DGV As DataGridView
	Private WithEvents Timer As New Timer() With {.Interval = 1000}
	Private ReadOnly OffColor As Color = Color.Gray
	Private ReadOnly OffText As String = "Фильтр"
	Private Collumns As IEnumerable(Of String)

	Public Sub New()
		DefaultLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("ru-RU"))
	End Sub

	''' <summary>
	''' Инициализация
	''' </summary>
	''' <param name="DGV">Таблица для поиска</param>
	''' <param name="Collumns">Столбцы для поиска</param>
	Public Sub Init(DGV As DataGridView, Collumns As IEnumerable(Of String))
		Me.DGV = DGV
		Me.Collumns = Collumns
		With DGV.FindForm
			.KeyPreview = True
			AddHandler .KeyDown, AddressOf DGV_Search_F
		End With
		ForeColor = OffColor
		Text = OffText
	End Sub

	Public Sub SetFilter(str As String)
		ForeColor = If(String.IsNullOrWhiteSpace(str), OffColor, Color.Empty)
		Text = str
		ApplyFilter()
	End Sub

	Protected Overrides Function ProcessCmdkey(ByRef msg As Message, keyData As Keys) As Boolean
		Select Case keyData
			Case Keys.Escape
				Text = ""
				ApplyFilter()
				Return True
			Case Keys.Enter
				ApplyFilter()
				Return True
			Case Else
				Return MyBase.ProcessCmdKey(msg, keyData)
		End Select
	End Function

	Private Sub ApplyFilter()
		Timer.Stop()
		Dim BS = CType(DGV.DataSource, BindingSource)
		If Text = "" Then
			BS.Filter = Nothing
			Exit Sub
		End If
		Dim LF = Collumns.Select(Function(c) String.Format("({0} Like '%" + Text.Trim.Replace(" ", "%' AND {0} Like '%") + "%')", c))
		BS.Filter = String.Join(" OR ", LF)
		OnFilterApplied()
	End Sub

#Region "Properties"
	Public Property DefaultLanguage As InputLanguage
#End Region

#Region "UI Events"

	Private Sub DGV_Search_F(sender As Object, e As KeyEventArgs) Handles DGV.KeyDown
		If e.Control AndAlso e.KeyCode = Keys.F Then
			Focus()
			e.Handled = True
		End If
	End Sub

	Private Sub DGV_Search_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
		If ForeColor = OffColor Then
			ForeColor = Color.Empty
			Text = ""
		End If
		InputLanguage.CurrentInputLanguage = DefaultLanguage
	End Sub

	Private Sub DGV_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		Timer.Stop()
		Timer.Start()
	End Sub

	Private Sub DGV_Search_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
		If Text.Length = 0 Then
			ApplyFilter()
			ForeColor = OffColor
			Text = OffText
		End If
	End Sub

#End Region

	'Private Sub DGV_Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
	'	If e.KeyCode = Keys.Back Then isBack = False  Filter Applied
	'End Sub
	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		ApplyFilter()
	End Sub

#Region "Events"

	Protected Sub OnFilterApplied()
		RaiseEvent FilterApplied()
	End Sub

	Public Event FilterApplied()

#End Region

End Class