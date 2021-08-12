<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVTEdit
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
		Me.DGVT = New JANL.DGVTemplateEditor()
		Me.SuspendLayout()
		'
		'DGVT
		'
		Me.DGVT.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGVT.Location = New System.Drawing.Point(0, 0)
		Me.DGVT.Name = "DGVT"
		Me.DGVT.Size = New System.Drawing.Size(988, 450)
		Me.DGVT.TabIndex = 0
		'
		'DGVTEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(988, 450)
		Me.Controls.Add(Me.DGVT)
		Me.Name = "DGVTEdit"
		Me.Text = "DGVTEdit"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DGVT As JANL.DGVTemplateEditor
End Class
