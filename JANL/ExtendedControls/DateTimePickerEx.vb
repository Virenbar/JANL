Imports System.ComponentModel

Public Class DateTimePickerEx
	Inherits DateTimePicker

	Public Sub New()
		MyBase.New()
		MyBase.ShowCheckBox = True
		Format = DateTimePickerFormat.Short
	End Sub

	<Bindable(True), RefreshProperties(RefreshProperties.All)>
	Public Shadows Property Value As Date?
		Get
			Return If(Checked, New Date?(MyBase.Value), Nothing)
		End Get
		Set(value As Date?)
			MyBase.Value = If(value, Date.Now)
			Checked = value.HasValue
		End Set
	End Property

	Protected Overrides Sub OnValidated(e As EventArgs)
		MyBase.OnValidated(e)
	End Sub

	Protected Overrides Sub OnLostFocus(e As EventArgs)
		MyBase.OnLostFocus(e)
		If Not Checked Then ForceWrite()
	End Sub

	Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
		MyBase.OnValueChanged(eventargs)
	End Sub

	Private Sub ForceWrite()
		For Each B As Binding In DataBindings
			B.WriteValue()
		Next
	End Sub

	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Shadows ReadOnly Property ShowCheckBox As Boolean
		Get
			Return MyBase.ShowCheckBox
		End Get
	End Property

End Class