Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports OfficeOpenXml

Public Class Reestr
	Private Shared ReadOnly PathI As String = "D:\Data\Выгрузка из Росреестра\v2\Перечень Ирбитский ГО.xlsx"
	Private Shared ReadOnly PathN As String = "D:\Data\Выгрузка из Росреестра\v2\Перечень Нижнесерьгинский район.xlsx"

	Private Shared ReadOnly PathT As String = "D:\Data\Выгрузка из Росреестра\v2\Перечень Туринский ГО.xlsx"

	Private Shared R As New Regex("(?<V>[а-яА-Я. ]*?),(?<S>.?(улица |ул |ул\. |пер\. |пер ).*?),(?<D>.*)")

	Public Shared Sub Process()
		Dim MyFile = New FileInfo(PathT)

		Using Excel As New ExcelPackage(MyFile)
			Dim WS = Excel.Workbook.Worksheets.First()
			Dim Cells = WS.Cells
			Dim Max = WS.Cells.End.Row

			For Row = 2 To Cells.End.Row
				Dim A = If(Cells.Item($"N{Row}").Value?.ToString, "")
				Dim M = R.Match(A)
				If M.Success Then
					Dim V = M.Groups.Item("V").Value.Trim
					Dim S = FixStreet(M.Groups.Item("S").Value)
					Dim D = FixBuilding(M.Groups.Item("D").Value)
					Dim Other = D.Split(","c)

					Cells.Item($"O{Row}").Value = $"{V},{S},{D}"
					Cells.Item($"AK{Row}").Value = V
					Cells.Item($"AL{Row}").Value = S
					Cells.Item($"AM{Row}").Value = Other(0)
					Cells.Item($"AN{Row}").Value = String.Join(" ", Other.Skip(1))
				End If
			Next
			Excel.Save()
		End Using
	End Sub

	Private Shared Function FixStreet(S As String) As String
		Dim SB = New StringBuilder(S)
		SB.Replace("ул. ", "ул.")
		SB.Replace("ул ", "ул.")
		SB.Replace("улица ", "ул.")
		SB.Replace("пер. ", "пер.")
		SB.Replace("пер ", "пер.")
		SB.Replace("переулок ", "пер.")
		Return SB.ToString().Trim
	End Function

	Private Shared Function FixBuilding(B As String) As String
		Dim SB = New StringBuilder(B)
		SB.Replace("№", "д.")
		SB.Replace("д. ", "д.")
		SB.Replace("д ", "д.")
		SB.Replace("дом ", "д.")
		SB.Replace("д.", "")
		Return SB.ToString().Trim
	End Function

End Class