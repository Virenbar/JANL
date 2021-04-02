Imports System.Runtime.CompilerServices

Public Class Msgs
	Private Shared ReadOnly AppName As String

	Shared Sub New()
		AppName = Application.ProductName
	End Sub

	''' <summary>
	''' Отображает сообщение
	''' </summary>
	''' <param name="text">Текст сообщения</param>
	Public Shared Sub ShowInfo(text As String)
		MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	''' <summary>
	''' Отображает предупреждение
	''' </summary>
	''' <param name="text">Текст предупреждения</param>
	Public Shared Sub ShowWarning(text As String)
		MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	''' <summary>
	''' Отображает ошибку
	''' </summary>
	''' <param name="text">Текст ошибки</param>
	Public Shared Sub ShowError(text As String)
		MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	''' <summary>
	''' Отображает ошибку, имя метода и стёк вызова
	''' </summary>
	''' <param name="ex">Объект ошибки</param>
	''' <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
	Public Shared Sub ShowError(ex As Exception, <CallerMemberName()> Optional prefix As String = Nothing)
		MessageBox.Show(prefix + ": " + ex.Message + vbNewLine + ex.StackTrace, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	''' <summary>
	''' Отображает вопрос с Да Нет
	''' </summary>
	''' <param name="text">Текст вопроса</param>
	Public Shared Function AskYesNo(text As String) As DialogResult
		Return MessageBox.Show(text, AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
	End Function

	Public Shared Sub ShowErrorInner(prefix As String, ex As Exception)
		MessageBox.Show(prefix.Trim + " " + ExRecursive(ex), AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	Public Shared Sub ShowErrorInner(ex As Exception)
		MessageBox.Show(ExRecursive(ex), AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	Private Shared Function ExRecursive(ex As Exception, Optional lvl As Integer = 0) As String
		If IsNothing(ex.InnerException) Then
			Return lvl.ToString + ":" + ex.Message
		Else
			Return lvl.ToString + ":" + ex.Message + vbNewLine + ExRecursive(ex.InnerException, lvl + 1)
		End If
	End Function

End Class