Imports JANL.Animators
Imports JANL.Interfaces

Public Class FormAnimation

    Private Animator As IAnimator
    Private Breather As New Breather(0.1F)
    Private Rotator As New Rotator()
    Private Animators As New List(Of IAnimator)({Rotator, Breather})

    Protected Overrides Sub OnLoad(e As EventArgs)
        'Animator = New ImageRotator(100, PB_Image.Image)
        'AddHandler Animator.CurrentImageChanged, Sub() PB_Image.Image = Animator.CurrentImage
        'Animator.StartAnimation()
        'PB_Image.SizeMode = If(PB_Image.Image.Width > PB_Image.Width Or PB_Image.Image.Height > PB_Image.Height, PictureBoxSizeMode.Zoom, PictureBoxSizeMode.CenterImage)

        Animator = Rotator
        APB_Image.Animator = Animator
        APB_Image.StartAnimation()

        BS_Animator.DataSource = Animator
        MyBase.OnLoad(e)
    End Sub

    Private Sub B_Reset_Click(sender As Object, e As EventArgs) Handles B_Reset.Click
        Animator.ResetAnimation()
    End Sub

    Private Sub B_Start_Click(sender As Object, e As EventArgs) Handles B_Start.Click
        Animator.StartAnimation()
    End Sub

    Private Sub B_Stop_Click(sender As Object, e As EventArgs) Handles B_Stop.Click
        Animator.StopAnimation()
    End Sub

    Private Sub CB_Direction_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Direction.CheckedChanged
        If TypeOf Animator Is Rotator Then
            Dim R = DirectCast(Animator, Rotator)
            R.Direction = If(CB_Direction.Checked, Rotator.DirectionType.Counterclockwise, Rotator.DirectionType.Clockwise)
        End If
    End Sub

    Private Sub NUD_Scale_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Scale.ValueChanged
        If TypeOf Animator Is Breather Then
            Dim B = DirectCast(Animator, Breather)
            B.MinimalScale = NUD_Scale.Value
        End If
    End Sub

End Class