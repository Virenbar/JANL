<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMDI
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
		Me.MS_MDI = New System.Windows.Forms.MenuStrip()
		Me.FormSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FormViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MS_MDI.SuspendLayout()
		Me.SuspendLayout()
		'
		'MS_MDI
		'
		Me.MS_MDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormSelectToolStripMenuItem, Me.FormViewToolStripMenuItem})
		Me.MS_MDI.Location = New System.Drawing.Point(0, 0)
		Me.MS_MDI.Name = "MS_MDI"
		Me.MS_MDI.Size = New System.Drawing.Size(800, 24)
		Me.MS_MDI.TabIndex = 1
		Me.MS_MDI.Text = "MenuStrip1"
		'
		'FormSelectToolStripMenuItem
		'
		Me.FormSelectToolStripMenuItem.Name = "FormSelectToolStripMenuItem"
		Me.FormSelectToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
		Me.FormSelectToolStripMenuItem.Text = "FormSelect"
		'
		'FormViewToolStripMenuItem
		'
		Me.FormViewToolStripMenuItem.Name = "FormViewToolStripMenuItem"
		Me.FormViewToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
		Me.FormViewToolStripMenuItem.Text = "FormView"
		'
		'FormMDI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.MS_MDI)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MS_MDI
		Me.Name = "FormMDI"
		Me.Text = "FormMDI"
		Me.MS_MDI.ResumeLayout(False)
		Me.MS_MDI.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MS_MDI As MenuStrip
	Friend WithEvents FormSelectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FormViewToolStripMenuItem As ToolStripMenuItem
End Class
