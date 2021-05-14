Public Class Prmtrs
	Public Shared ReadOnly Property AppName As String = Application.ProductName
	Public Shared ReadOnly Property Isdebug As Boolean = Debugger.IsAttached

End Class