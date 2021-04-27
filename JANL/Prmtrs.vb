Imports System.Drawing

Public Class Prmtrs
	Public Shared Property AppName As String = Application.ProductName
	Public Shared Property KeyUser As Integer = 0
	Public Shared ReadOnly Property Isdebug As Boolean = Debugger.IsAttached

	Public Structure Colors
		Public Shared Property White As Color = Color.White
		Public Shared Property Red As Color = Color.MistyRose
		Public Shared Property Yellow As Color = Color.LightYellow
		Public Shared Property Green As Color = Color.LightGreen

		Public Shared Property Bad As Color = Color.MistyRose
		Public Shared Property Unknown As Color = Color.LightYellow
		Public Shared Property Good As Color = Color.LightGreen
	End Structure

End Class