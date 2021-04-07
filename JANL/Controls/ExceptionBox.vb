Imports System.Drawing

''' <summary>
''' Окно для отображения ошибки
''' </summary>
''' <remarks>
''' Для показа номеров строк необходимо наличие pdb в сборке.
''' StackTrace различается между Debug и Release из-за встраивания(Inlining) методов
''' </remarks>
Public Class ExceptionBox
	Private Shared Rnd As New Random()
	Private Shared Comments As New List(Of String)

	Private Exception As Exception
	Private Selected As Exception

	Public Sub New(ex As Exception)
		' Этот вызов является обязательным для конструктора.
		InitializeComponent()
		' Добавить код инициализации после вызова InitializeComponent().
		Icon = SystemIcons.Error
		If MainText IsNot Nothing Then L_Text.Text = MainText
		If WittyComments Then Text += $" - {GetComment()}"
		StartPosition = FormStartPosition.CenterScreen

		Exception = ex
		Selected = ex
		B_MailTo.Visible = MailTo IsNot Nothing
		UpdateTree()
	End Sub

	''' <summary>
	'''
	''' </summary>
	Public Shared Property MainText As String = Nothing

	''' <summary>
	''' Тема письма
	''' </summary>
	Public Shared Property MailSubject As String = "Ошибка"

	''' <summary>
	'''	Получатели письма через ;
	''' </summary>
	Public Shared Property MailTo As String = Nothing

	''' <summary>
	''' Остроумные комментарии
	''' </summary>
	Public Shared Property WittyComments As Boolean = True

	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		If e.CloseReason <> CloseReason.None Then DialogResult = DialogResult.Ignore
		MyBase.OnFormClosing(e)
	End Sub

	Private Shared Function EXtoString(ex As Exception) As String
		Dim L = New List(Of String) From {
			$"Тип: {ex.GetType}",
			$"Метод: {ex.TargetSite.DeclaringType.FullName}.{ex.TargetSite.Name}",
			$"Сообщение: {ex.Message}",
			"StackTrace:",
			ex.StackTrace
		}
		If ex.InnerException IsNot Nothing Then
			L.Add("")
			L.Add("C внутренней ошибкой:")
			L.Add(EXtoString(ex.InnerException))
		End If
		Return String.Join(vbNewLine, L)
	End Function

	Private Shared Function GetComment() As String
		If Comments.Count = 0 Then
			Comments.AddRange({
				"Ух... Это сделал я?",
				"Упсс",
				"Прости, Дейв.",
				"Почему оно ломается? :(",
				"Но оно работает на моём компьютере.",
				"Я просто незнаю что пошло не так.",
				"Простите :(",
				"Я подвёл тебя. Прости :("})
		End If
		Dim i = Rnd.Next(Comments.Count)
		Dim Comment = Comments(i)
		Comments.RemoveAt(i)
		Return Comment
	End Function

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
		Dim Body = GetText()
		Dim Mail = $"mailto:{MailTo}?subject={MailSubject}&body={Body.Replace(vbNewLine, "%0A")}"
		Process.Start(Mail)
	End Sub

	Private Function GetText() As String
		Dim L = New List(Of String) From {
			"Примечание:",
			"<Место для примечания>",
			"",
			$"Ошибк{If(Exception.InnerException Is Nothing, "а", "и")}:",
			EXtoString(Exception)}
		Return String.Join(vbNewLine, L)
	End Function

	Private Sub TV_Exceptions_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Exceptions.AfterSelect
		If TV_Exceptions.SelectedNode IsNot Nothing Then
			Selected = DirectCast(TV_Exceptions.SelectedNode.Tag, Exception)
			TB_Type.Text = Selected.GetType.ToString()
			TB_Name.Text = Selected.TargetSite.DeclaringType.FullName + "." + Selected.TargetSite.Name
			TB_Message.Text = Selected.Message
			TB_StackTrace.Text = Selected.StackTrace
		End If
	End Sub

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

End Class