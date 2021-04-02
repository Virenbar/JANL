﻿Imports System.ComponentModel

Public Class DateTimePickerEx
	Inherits DateTimePicker

	Public Sub New()
		MyBase.New()
		MyBase.ShowCheckBox = True
	End Sub

	<Bindable(True), RefreshProperties(RefreshProperties.All)>
	Public Shadows Property Value As Date?
		Get
			Return If(Checked, New Date?(MyBase.Value), Nothing)
		End Get
		Set(value As Date?)
			MyBase.Value = If(value, Now)
			Checked = value.HasValue

		End Set
	End Property

	Protected Overrides Sub OnValidated(e As EventArgs)
		MyBase.OnValidated(e)
	End Sub

	Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
		MyBase.OnValueChanged(eventargs)
	End Sub

	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Shadows ReadOnly Property ShowCheckBox As Boolean
		Get
			Return MyBase.ShowCheckBox
		End Get
	End Property

End Class