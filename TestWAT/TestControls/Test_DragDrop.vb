Imports JANL.Controls

Public Class Test_DragDrop

    Private Sub Test_DragDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LBHandler = New FileDropHandler(GB) With {
            .AllowDirectories = True
        }
        LBHandler.AddControl(TB)
        LBHandler.AddControl(LB)
        AddHandler LBHandler.FileDrop, AddressOf FileDrop

    End Sub

    Private Sub FileDrop(sender As Object, e As FileDropEventArgs)
        TB.Text = e.Files.FirstOrDefault()
        LB.Items.Clear()
        For Each F In e.Files
            LB.Items.Add($"Файл: {F}")
        Next
        For Each D In e.Directories
            LB.Items.Add($"Папка: {D}")
        Next
    End Sub

End Class