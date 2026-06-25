Public Class Test_TextBoxLabel

    Private Sub TBL_TextChanged(sender As Object, e As EventArgs) Handles TBL.TextChanged
        TB.Text = TBL.Text
    End Sub

    Private Sub B_LabelColor_Click(sender As Object, e As EventArgs) Handles B_LabelColor.Click
        CD.Color = TBL.LabelColor
        If CD.ShowDialog(ParentForm) = DialogResult.OK Then
            TBL.LabelColor = CD.Color
        End If
    End Sub

    Private Sub B_ForeColor_Click(sender As Object, e As EventArgs) Handles B_ForeColor.Click
        CD.Color = TBL.ForeColor
        If CD.ShowDialog(ParentForm) = DialogResult.OK Then
            TBL.ForeColor = CD.Color
        End If
    End Sub

End Class