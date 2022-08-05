Public Class DGVTEdit

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().

    End Sub

    Private Sub DGVTEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVT.SetTemplate(New JANL.Types.DGVTemplate())
    End Sub

End Class