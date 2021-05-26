Imports System.ComponentModel
Imports System.Drawing

Public Class TextBoxEx
	Inherits TextBox
	Private Const LabelPrefix = ChrW(8203) + ChrW(8203)
	Private LabelStr As String

	Public Sub New()
		MyBase.New()
		MyBase.Text = LabelPrefix
		ForeColor = Color.Black
		LabelColor = Color.SlateGray
		Label = ""
	End Sub

#Region "Properties"

#Region "Designer"

	<Browsable(True), Category("Appearance"), DefaultValue(GetType(Color), "0x000000")>
	Public Shadows Property ForeColor As Color

	<Browsable(True), Category("Appearance"), DefaultValue(""), Description("Заголовок")>
	Public Property Label As String
		Get
			Return LabelStr.Substring(2)
		End Get
		Set(value As String)
			LabelStr = LabelPrefix + value
			If IsLabel() Then MyBase.Text = LabelStr
			UpdateColor()
		End Set
	End Property

	<Browsable(True), Category("Appearance"), DefaultValue(GetType(Color), "0x708090"), Description("Цвет заголовка")>
	Public Property LabelColor As Color

	<Browsable(True), Category("Appearance"), DefaultValue("")>
	Public Shadows Property Text As String
		Get
			Return If(IsLabel(), "", MyBase.Text)
		End Get
		Set(value As String)
			'TextStr = value
			MyBase.Text = If(value?.Length = 0, LabelStr, value)
			UpdateColor()
		End Set
	End Property

#End Region

	<Browsable(False)>
	Public ReadOnly Property IsLabel As Boolean
		Get
			Return MyBase.Text.Length >= 2 AndAlso MyBase.Text.Substring(0, 2) = LabelPrefix
		End Get
	End Property

#End Region

#Region "Overrides"

	Protected Overrides Sub OnGotFocus(e As EventArgs)
		If IsLabel Then Clear()
		MyBase.OnGotFocus(e)
	End Sub

	Protected Overrides Sub OnLostFocus(e As EventArgs)
		If MyBase.Text.Length = 0 Then MyBase.Text = LabelStr
		MyBase.OnLostFocus(e)
	End Sub

	Protected Overrides Sub OnTextChanged(e As EventArgs)
		UpdateColor()
		MyBase.OnTextChanged(e)
	End Sub

#End Region

	Private Sub UpdateColor()
		MyBase.ForeColor = If(IsLabel, LabelColor, ForeColor)
	End Sub

End Class