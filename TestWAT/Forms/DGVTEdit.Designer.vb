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
		Me.DgvTemplateEditor1 = New JANL.DGVTemplateEditor()
		Me.SuspendLayout()
		'
		'DgvTemplateEditor1
		'
		Me.DgvTemplateEditor1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DgvTemplateEditor1.Location = New System.Drawing.Point(0, 0)
		Me.DgvTemplateEditor1.Name = "DgvTemplateEditor1"
		Me.DgvTemplateEditor1.Size = New System.Drawing.Size(988, 450)
		Me.DgvTemplateEditor1.TabIndex = 0
		'
		'DGVTEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(988, 450)
		Me.Controls.Add(Me.DgvTemplateEditor1)
		Me.Name = "DGVTEdit"
		Me.Text = "DGVTEdit"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DgvTemplateEditor1 As JANL.DGVTemplateEditor
End Class
