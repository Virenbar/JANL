Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class RegexTextBox
	Inherits TextBox

	Public Sub New()
		MyBase.New()
		BackColor = Color.White
		ValidColor = Colors.Common.Good
		RequiredColor = Colors.Common.Unknown
		InvalidColor = Colors.Common.Bad
		Validate()
	End Sub

	Protected Overrides Sub OnTextChanged(e As EventArgs)
		IsValid = Validate()
		MyBase.OnTextChanged(e)
	End Sub

	Protected Overrides Sub OnValidated(e As EventArgs)
		MyBase.OnValidated(e)
	End Sub

	Protected Overrides Sub OnValidating(e As CancelEventArgs)
		IsValid = Validate()
		If Not IsValid AndAlso Message.Length > 0 AndAlso Text.Length > 0 Then
			e.Cancel = True
			Msgs.ShowWarning(Message)
		End If

		MyBase.OnValidating(e)
	End Sub

	Private Function Validate() As Boolean
		If Pattern.Length = 0 Then Return True
		If Text.Length = 0 Then
			MyBase.BackColor = If(Required, RequiredColor, BackColor)
			Return Not Required
		End If

		Dim R = Regex.IsMatch(Text, Pattern)
		MyBase.BackColor = If(R, ValidColor, InvalidColor)
		Return R
	End Function

#Region "Properties"
	Private _IsValid As Boolean
	Private _Pattern As String = ""
	Private _Required As Boolean

	<Browsable(False)>
	Public Property IsValid() As Boolean
		Get
			Return _IsValid
		End Get
		Private Set
			_IsValid = Value
		End Set
	End Property

	<Browsable(True), Category("RegexTextBox"), DefaultValue("")>
	Public Property Message As String = ""

	<Browsable(True), Category("RegexTextBox"), DefaultValue("")>
	Public Property Pattern As String
		Get
			Return _Pattern
		End Get
		Set
			_Pattern = Value
			Validate()
		End Set
	End Property

	<Browsable(True), Category("RegexTextBox"), DefaultValue(False)>
	Public Property Required As Boolean
		Get
			Return _Required
		End Get
		Set
			_Required = Value
			Validate()
		End Set
	End Property

#Region "Colors"

	<Browsable(True), Category("RegexTextBox"), DefaultValue(GetType(Color), "0xFFFFFF")>
	Public Shadows Property BackColor As Color

	<Browsable(True), Category("RegexTextBox"), DefaultValue(GetType(Color), "0xFFE4E1")>
	Public Property InvalidColor As Color

	<Browsable(True), Category("RegexTextBox"), DefaultValue(GetType(Color), "0xFFFFE0")>
	Public Property RequiredColor As Color

	<Browsable(True), Category("RegexTextBox"), DefaultValue(GetType(Color), "0x90EE90")>
	Public Property ValidColor As Color

#End Region

#End Region

End Class