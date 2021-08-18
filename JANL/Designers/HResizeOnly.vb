Imports System.Windows.Forms.Design

Public Class HResizeOnly
	Inherits ControlDesigner

	Public Sub New()
		AutoResizeHandles = True
	End Sub

	Public Overrides ReadOnly Property SelectionRules() As SelectionRules
		Get
			Return CType(SelectionRules.LeftSizeable + SelectionRules.RightSizeable + SelectionRules.Moveable, SelectionRules)
		End Get
	End Property

End Class