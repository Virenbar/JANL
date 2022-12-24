Imports JANL.Animators
Imports JANL.Interfaces

Public Class FormAnimation

    'Private Animator As IAnimator
    Private Animators As UnionAnimator

    Private Breather As New Breather(0.1F)
    Private Rotator As New Rotator()

    Protected Overrides Sub OnLoad(e As EventArgs)
        Animators = New UnionAnimator(New List(Of IAnimator)({Rotator, Breather}))
        BS_Animator.DataSource = DirectCast(Animators, IAnimator)

        APB_1.Animator = Rotator
        APB_2.Animator = Breather

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

    Private Sub CB_Direction_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Direction.CheckedChanged
        Rotator.Direction = If(CB_Direction.Checked, Rotator.DirectionType.Counterclockwise, Rotator.DirectionType.Clockwise)
    End Sub

    Private Sub NUD_Scale_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Scale.ValueChanged
        Breather.MinimalScale = NUD_Scale.Value
    End Sub

    Private Sub BS_Animator_CurrentItemChanged(sender As Object, e As EventArgs) Handles BS_Animator.CurrentItemChanged

    End Sub

    Private Class Animation
        Public Property Framerate As Integer
        Public Property Duration As Integer

    End Class

End Class