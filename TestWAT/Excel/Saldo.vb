Imports System.IO.Compression
Imports System.IO
Imports OfficeOpenXml
Imports Microsoft.Office.Interop.Excel

Module Saldo
	Dim path As String = "D:\Saldo\Saldo"

	Public Sub MakeGood1()
		Dim MyFile = New FileInfo(My.Computer.FileSystem.CombinePath(path, "FullList.xlsx"))
		If MyFile.Exists Then MyFile.Delete()

		Dim files = Directory.EnumerateFiles(path, "*.xlsx", SearchOption.AllDirectories)
		Using FullList As New ExcelPackage(MyFile)
			Dim lastrow = 1
			Dim ws = FullList.Workbook.Worksheets.Add("Все")
			For Each ifile In files
				Try
					Using infile As New ExcelPackage(New FileInfo(ifile))
						Dim inws = infile.Workbook.Worksheets.First
						Dim startrow = (
									From cell In inws.Cells(10, 1, 25, 1)
									Where Not IsNothing(cell.Value) AndAlso cell.Value.ToString() = "Всего"
									Select cell).First.Start.Row + 1
						'Dim endrow = (
						'            From cell In inws.Cells(startrow, 1, 35, 1)
						'            Where Not IsNothing(cell.Value) AndAlso cell.Value.ToString() = "Пени"
						'            Select cell).First.Start.Row
						Dim endrow = (
									From cell In inws.Cells(startrow, 1, 35, 1)
									Where Not IsNothing(cell.Value) AndAlso cell.Value.ToString().StartsWith("Общество")
									Select cell).First.Start.Row - 1
						Dim Adress = inws.Cells(4, 10).Value.ToString
						Dim Param = inws.Cells(6, 1).Value.ToString

						Dim Uslugi = inws.Cells(startrow, 1, endrow, 1)
						Dim InSaldo = inws.Cells(startrow, 4, endrow, 4)
						Dim OutSaldo = inws.Cells(startrow, 17, endrow, 17)

						Uslugi.Copy(ws.Cells(lastrow, 1))
						InSaldo.Copy(ws.Cells(lastrow, 2))
						OutSaldo.Copy(ws.Cells(lastrow, 3))
						'Adress.Copy(ws.Cells(lastrow, 3, lastrow + Uslugi.Rows, 3))
						'Param.Copy(ws.Cells(lastrow, 4, lastrow + Uslugi.Rows, 4))
						ws.Cells(lastrow, 4, lastrow + Uslugi.Rows - 1, 4).Value = Adress
						ws.Cells(lastrow, 5, lastrow + Uslugi.Rows - 1, 5).Value = Param
						ws.Cells(lastrow, 6, lastrow + Uslugi.Rows - 1, 6).Value = ifile
						'inws.Cells(1, 1, endrow, 7).Copy(ws.Cells(lastrow, 1, lastrow + endrow - 1, 7))
						'ws.Cells(lastrow, 9, ws.Dimension.End.Row, 9).Value = path.GetFileName(ifile)
						lastrow += Uslugi.Rows

					End Using
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try

			Next
			FullList.SaveAs(MyFile)
		End Using
	End Sub

End Module