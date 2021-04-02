Imports System.ComponentModel

Public Class ToggleButton
	Inherits Button
	Private _toggled As Boolean = False

	Private TextOff As String
	Private ImageOff As Image

	<Localizable(True), Category("Appearance")>
	Public Property ImageOn As Image

	<Localizable(True), Category("Appearance")>
	Public Property TextOn As String

	<Browsable(True), Category("Behavior"), DefaultValue(False)>
	Public Property Toggled As Boolean
		Get
			Return _toggled
		End Get
		Set(value As Boolean)
			If value <> _toggled Then
				If value Then ToggleOn() Else ToggleOff()
			End If
		End Set
	End Property

	Protected Overrides Sub OnClick(e As EventArgs)
		Toggled = Not Toggled
		MyBase.OnClick(e)
		If Toggled Then OnToggleOn(e) Else OnToggleOff(e)
	End Sub

	Private Sub ToggleOn()
		_toggled = True
		TextOff = Text
		ImageOff = Image
		Text = TextOn
		Image = ImageOn
		'OnToggleOn(EventArgs.Empty)
	End Sub

	Private Sub ToggleOff()
		_toggled = False
		Text = TextOff
		Image = ImageOff
		'OnToggleOff(EventArgs.Empty)
	End Sub

#Region "Events"

	Protected Sub OnToggleOn(e As EventArgs)
		RaiseEvent ToggledOn(Me, e)
	End Sub

	Protected Sub OnToggleOff(e As EventArgs)
		RaiseEvent ToggledOff(Me, e)
	End Sub

	<Browsable(True), Category("Action")>
	Public Event ToggledOn(sender As Object, e As EventArgs)

	<Browsable(True), Category("Action")>
	Public Event ToggledOff(sender As Object, e As EventArgs)

#End Region

End Class