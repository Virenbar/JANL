Imports JANL.Helpers

Public Class Test_ColorHash
    Private Hash As New ColorHash(AddressOf ColorHash.BKDRHash)

    Private Sub TB_Input_TextChanged(sender As Object, e As EventArgs) Handles TB_Input.TextChanged
        UpdateColor()
    End Sub

    Private Sub Test_ColorHash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateColor()
    End Sub

    Private Sub UpdateColor()
        Dim Color = Hash.Compute(TB_Input.Text)
        P_Color.BackColor = Color
    End Sub

End Class