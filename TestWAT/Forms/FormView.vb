Public Class FormView

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		LV_Test.SetList(New TestLinks(0))
	End Sub

	Private Sub FormView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LV_Test.RefreshView()
	End Sub

End Class