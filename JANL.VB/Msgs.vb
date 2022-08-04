Imports System.Runtime.CompilerServices
Imports System.Environment

Friend Class Msgs

    Shared Sub New()
        DefaultHeader = Application.ProductName
    End Sub

    Public Shared Property DefaultHeader As String

    ''' <summary>
    ''' Отображает вопрос с Да Нет
    ''' </summary>
    ''' <param name="Text">Текст вопроса</param>
    Public Shared Function AskYesNo(Text As String) As DialogResult
        Return MessageBox.Show(Text, DefaultHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    ''' <summary>
    ''' Отображает ошибку
    ''' </summary>
    ''' <param name="Text">Текст ошибки</param>
    Public Shared Sub ShowError(Text As String)
        ShowMessage(Text, DefaultHeader, MessageBoxIcon.Error)
    End Sub

    ''' <summary>
    ''' Отображает ошибку
    ''' </summary>
    ''' <param name="Text">Текст ошибки</param>
    ''' <param name="Header">Заголовок окна</param>
    Public Shared Sub ShowError(Text As String, Header As String)
        ShowMessage(Text, Header, MessageBoxIcon.Error)
    End Sub

    ''' <summary>
    ''' Отображает ошибку, имя метода и стёк вызова
    ''' </summary>
    ''' <param name="ex">Объект ошибки</param>
    ''' <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
    Public Shared Sub ShowError(ex As Exception, <CallerMemberName()> Optional prefix As String = Nothing)
        MessageBox.Show($"{prefix}: {ex.Message}{NewLine}StackTrace:{NewLine}{ex.StackTrace}", DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    <Obsolete>
    Public Shared Sub ShowErrorInner(prefix As String, ex As Exception)
        MessageBox.Show(prefix.Trim + " " + ExRecursive(ex), DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    <Obsolete>
    Public Shared Sub ShowErrorInner(ex As Exception)
        MessageBox.Show(ExRecursive(ex), DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ''' <summary>
    ''' Отображает сообщение
    ''' </summary>
    ''' <param name="Text">Текст сообщения</param>
    Public Shared Sub ShowInfo(Text As String)
        ShowMessage(Text, DefaultHeader, MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Отображает сообщение
    ''' </summary>
    ''' <param name="Text">Текст сообщения</param>
    ''' <param name="Header">Заголовок окна</param>
    Public Shared Sub ShowInfo(Text As String, Header As String)
        ShowMessage(Text, Header, MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Отображает предупреждение
    ''' </summary>
    ''' <param name="Text">Текст предупреждения</param>
    ''' <param name="Header">Заголовок окна</param>
    ''' <param name="MBI">Icon</param>
    Public Shared Sub ShowMessage(Text As String, Header As String, MBI As MessageBoxIcon)
        MessageBox.Show(Text, Header, MessageBoxButtons.OK, MBI)
    End Sub

    ''' <summary>
    ''' Отображает предупреждение
    ''' </summary>
    ''' <param name="Text">Текст предупреждения</param>
    Public Shared Sub ShowWarning(Text As String)
        ShowMessage(Text, DefaultHeader, MessageBoxIcon.Exclamation)
    End Sub

    ''' <summary>
    ''' Отображает предупреждение
    ''' </summary>
    ''' <param name="Text">Текст предупреждения</param>
    ''' <param name="Header">Заголовок окна</param>
    Public Shared Sub ShowWarning(Text As String, Header As String)
        ShowMessage(Text, Header, MessageBoxIcon.Exclamation)
    End Sub

    Private Shared Function ExRecursive(ex As Exception, Optional lvl As Integer = 0) As String
        If ex.InnerException Is Nothing Then
            Return lvl.ToString + ":" + ex.Message
        Else
            Return lvl.ToString + ":" + ex.Message + NewLine + ExRecursive(ex.InnerException, lvl + 1)
        End If
    End Function

End Class