Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class RegexTextBox
	Inherits TextBox
	Private ColorEmpty As Color
	Private ColorInvalid As Color
	Private ColorValid As Color

	Public Sub New()
		MyBase.New()
		ColorEmpty = Colors.Common.Yellow
		ColorValid = Colors.Common.Good
		ColorInvalid = Colors.Common.Bad
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
			BackColor = If(Required, ColorEmpty, Color.White)
			Return Not Required
		End If

		Dim R = Regex.IsMatch(Text, Pattern)
		BackColor = If(R, ColorValid, ColorInvalid)
		Return R
	End Function

#Region "Properties"
	Private _IsValid As Boolean

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
	Public Property Pattern As String = ""

	<Browsable(True), Category("RegexTextBox"), DefaultValue(False)>
	Public Property Required As Boolean

#End Region

End Class