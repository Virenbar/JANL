Imports System.Runtime.InteropServices

Friend Class WinAPI

	<DllImport("user32.dll")>
	Public Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
	End Function

End Class