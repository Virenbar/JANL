Imports System.Drawing

''' <summary>
''' Окно для отображения ошибки
''' </summary>
''' <remarks>
''' Для показа номеров строк необходимо наличие pdb в сборке.
''' StackTrace различается между Debug и Release из-за встраивания(Inlining) методов
''' </remarks>
Public Class ExceptionBox
	Private Shared Comments As New List(Of String)
	Private Shared Rnd As New Random()
	Private Exception As Exception
	Private Selected As Exception

	Public Sub New(ex As Exception)
		InitializeComponent()

		Text = My.Resources.EB_Strings.EB_Header
		'Buttons
		B_Ignore.Text = My.Resources.EB_Strings.EB_Continue
		B_Exit.Text = My.Resources.EB_Strings.EB_Exit
		B_MailTo.Text = My.Resources.EB_Strings.EB_Mail
		B_Copy.Text = My.Resources.EB_Strings.EB_Copy
		'Labels
		L_Text.Text = My.Resources.EB_Strings.EB_Text
		L_Description.Text = My.Resources.EB_Strings.EB_ErrDesc
		L_Message.Text = My.Resources.EB_Strings.EB_Message
		L_Method.Text = My.Resources.EB_Strings.EB_Method
		L_Type.Text = My.Resources.EB_Strings.EB_Type

		Icon = SystemIcons.Error
		If DefaultText IsNot Nothing Then L_Text.Text = DefaultText
		If WittyComments IsNot Nothing Then Text += $" - {GetComment()}"
		StartPosition = FormStartPosition.CenterScreen

		Exception = ex
		Selected = ex
		B_MailTo.Visible = MailInfo.To.Length > 0
		UpdateTree()
	End Sub

#Region "Shared Properties"

	''' <summary>
	''' Текст по умолчанию
	''' </summary>
	Public Shared Property DefaultText As String = Nothing

	''' <summary>
	'''	Данные для создания письма
	''' </summary>
	Public Shared Property MailInfo As EMail = Nothing

	''' <summary>
	''' Остроумные комментарии
	''' </summary>
	Public Shared Property WittyComments As IEnumerable(Of String)

#End Region

	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		If e.CloseReason <> CloseReason.None Then DialogResult = DialogResult.Ignore
		MyBase.OnFormClosing(e)
	End Sub

	Private Shared Function GetComment() As String
		If Comments.Count = 0 Then Comments.AddRange(WittyComments)
		Dim i = Rnd.Next(Comments.Count)
		Dim Comment = Comments(i)
		Comments.RemoveAt(i)
		Return Comment
	End Function

	Private Function EXtoString(ex As Exception) As String
		Dim L = New List(Of String) From {
			$"{L_Type.Text}: {ex.GetType}",
			$"{L_Method.Text}: {ex.TargetSite.DeclaringType.FullName}.{ex.TargetSite.Name}",
			$"{L_Message.Text}: {ex.Message}",
			"StackTrace:",
			ex.StackTrace
		}
		If ex.InnerException IsNot Nothing Then
			L.Add("")
			L.Add("With internal exception:")
			L.Add(EXtoString(ex.InnerException))
		End If
		Return String.Join(vbNewLine, L)
	End Function

#Region "UIEvents"

	Private Sub B_Copy_Click(sender As Object, e As EventArgs) Handles B_Copy.Click
		Clipboard.SetText(GetText)
	End Sub

	Private Sub B_Exit_Click(sender As Object, e As EventArgs) Handles B_Exit.Click
		DialogResult = DialogResult.Abort
	End Sub

	Private Sub B_Ignore_Click(sender As Object, e As EventArgs) Handles B_Ignore.Click
		DialogResult = DialogResult.Ignore
	End Sub

	Private Sub B_MailTo_Click(sender As Object, e As EventArgs) Handles B_MailTo.Click
		Dim Body = GetMail()
		Dim Mail = $"mailto:{MailInfo.To}?subject={MailInfo.Subject}&body={Body.Replace(vbNewLine, "%0A")}"
		Process.Start(Mail)
	End Sub

	Private Sub TV_Exceptions_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Exceptions.AfterSelect
		If TV_Exceptions.SelectedNode IsNot Nothing Then
			Selected = DirectCast(TV_Exceptions.SelectedNode.Tag, Exception)
			TB_Type.Text = Selected.GetType.ToString()
			TB_Name.Text = Selected.TargetSite.DeclaringType.FullName + "." + Selected.TargetSite.Name
			TB_Message.Text = Selected.Message
			TB_StackTrace.Text = Selected.StackTrace
		End If
	End Sub

#End Region

	Private Function GetMail() As String
		Return $"{MailInfo.Text}{vbNewLine}{vbNewLine}{GetText()}"
	End Function

	Private Function GetText() As String
		Return $"Exception:{vbNewLine}{EXtoString(Exception)}"
	End Function

	Private Sub UpdateTree()
		If Exception Is Nothing Then Exit Sub
		Try
			'TV_Exceptions.BeginUpdate()
			TV_Exceptions.Nodes.Clear()

			Dim EX = Exception
			Dim parentNode As TreeNode = Nothing, childNode As TreeNode = Nothing

			While EX IsNot Nothing
				childNode = New TreeNode(EX.GetType().FullName) With {.Tag = EX}

				If parentNode Is Nothing Then
					TV_Exceptions.Nodes.Add(childNode)
				Else
					parentNode.Nodes.Add(childNode)
				End If

				parentNode = childNode
				EX = EX.InnerException
			End While
			TV_Exceptions.ExpandAll()
			TV_Exceptions.SelectedNode = childNode
			TV_Exceptions.Select()
		Finally
			'TV_Exceptions.EndUpdate()
		End Try
	End Sub

	Public Structure EMail

		''' <summary>
		'''	Получатели письма через ;
		''' </summary>
		Public Property [To] As String

		''' <summary>
		''' Тема письма
		''' </summary>
		Public Property Subject As String

		''' <summary>
		''' Текст письма
		''' </summary>
		Public Property Text As String

	End Structure

End Class