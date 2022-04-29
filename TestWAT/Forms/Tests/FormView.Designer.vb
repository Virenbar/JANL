<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormView
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.LV_Test = New JANL.LinkView()
		Me.SuspendLayout()
		'
		'LV_Test
		'
		Me.LV_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LV_Test.Location = New System.Drawing.Point(0, 0)
		Me.LV_Test.Name = "LV_Test"
		Me.LV_Test.Size = New System.Drawing.Size(800, 450)
		Me.LV_Test.TabIndex = 0
		'
		'FormView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.LV_Test)
		Me.Name = "FormView"
		Me.Text = "FormView"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents LV_Test As JANL.LinkView

End Class
