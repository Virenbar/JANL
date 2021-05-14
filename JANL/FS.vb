Imports System.IO

Public Class FS

	''' <summary>
	''' Creates and opens folder
	''' </summary>
	''' <param name="path"></param>
	Public Shared Sub OpenFolder(path As String)
		If Not Directory.Exists(path) Then
			Directory.CreateDirectory(path)
		End If
		Process.Start(path)
	End Sub

	''' <summary>
	''' Opens folder and selects file
	''' </summary>
	''' <param name="file"></param>
	Public Shared Sub OpenFolderSelect(file As String)
		Process.Start("explorer.exe", "/select,""" + file + """")
	End Sub

	Public Shared Sub OpenFolderSelect(file As FileInfo)
		Process.Start("explorer.exe", "/select,""" + file.FullName + """")
	End Sub

End Class