Public Class Prmtrs

	Public Shared ReadOnly Property AppName As String
		Get
			Return Application.ProductName
		End Get
	End Property

	Public Shared ReadOnly Property IsDebug As Boolean
		Get
			Return Debugger.IsAttached
		End Get
	End Property

End Class