Imports System.IO
Imports OfficeOpenXml
Module Tagiiiiiiiiiiiiiiiiiiiiiiiiiiil
    Public Sub MakeGood(_path As String)
        Dim mergedfiles = New List(Of String)
        Dim files = Directory.EnumerateFiles(_path, "*.xls*")
        Dim MyFile = New FileInfo(My.Computer.FileSystem.CombinePath(_path, "FullList.xlsx"))
        If MyFile.Exists Then MyFile.Delete()
        Using FullList As New ExcelPackage(MyFile)
            Dim lastrow = 1
            Dim ws = FullList.Workbook.Worksheets.Add("Все")
            For Each ifile In files
                Try
                    Using infile As New ExcelPackage(New FileInfo(ifile))
                        Dim inws = infile.Workbook.Worksheets.First
                        Dim startrow = (
                            From cell In inws.Cells(1, 1, 12, 1)
                            Where Not IsNothing(cell.Value) AndAlso cell.Value.ToString() = "1"
                            Select cell).First.Start.Row
                        Dim endrow = inws.Dimension.End.Row
                        Dim NewCells = inws.Cells(startrow, 1, endrow, 9)
                        NewCells.Copy(ws.Cells(lastrow, 1))
                        'inws.Cells(1, 1, endrow, 7).Copy(ws.Cells(lastrow, 1, lastrow + endrow - 1, 7))
                        ws.Cells(lastrow, 9, ws.Dimension.End.Row, 9).Value = Path.GetFileName(ifile)
                        lastrow = ws.Dimension.End.Row + 1
                        mergedfiles.Add(ifile)
                    End Using
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    File.Move(ifile, Path.Combine(_path, "Ошибка", Path.GetFileName(ifile)))
                End Try
            Next
            FullList.SaveAs(MyFile)
        End Using
    End Sub
End Module
