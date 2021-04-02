Imports System.IO

Public Class IO

	Public Shared Sub OpenFolder(path As String)
		If Not Directory.Exists(path) Then
			Directory.CreateDirectory(path)
		End If
		Process.Start(path)
	End Sub

	Public Shared Sub OpenFolderSelect(file As String)
		Process.Start("explorer.exe", "/select,""" + file + """")
	End Sub

End Class