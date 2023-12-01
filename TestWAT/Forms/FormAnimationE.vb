Imports JANL.Animators
Imports JANL.Controls
Imports JANL.Extensions
Imports JANL.Interfaces

Public Class FormAnimationE

    'Private Animator As IAnimator
    Private Animators As UnionAnimator

    Private Breather As New Breather(My.Resources.partner64, 0.5F)
    Private Rotator As New Rotator(My.Resources.partner64)

    Protected Overrides Sub OnLoad(e As EventArgs)
        Animators = New UnionAnimator(New List(Of IAnimator)({Rotator, Breather}))
        BS_Animator.DataSource = DirectCast(Animators, IAnimator)

        For index = 1 To 500
            FLP_Pictures.Controls.Add(New AnimatedPictureBox() With {
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Size = New Size(32, 32),
                .Animator = Animators.Items.PickRandom()
            })
        Next

        Animators.StartAnimation()
        MyBase.OnLoad(e)
    End Sub

    Private Sub B_Reset_Click(sender As Object, e As EventArgs) Handles B_Reset.Click
        Animators.ResetAnimation()
    End Sub

    Private Sub B_Start_Click(sender As Object, e As EventArgs) Handles B_Start.Click
        Animators.StartAnimation()
    End Sub

    Private Sub B_Stop_Click(sender As Object, e As EventArgs) Handles B_Stop.Click
        Animators.StopAnimation()
    End Sub

End Class