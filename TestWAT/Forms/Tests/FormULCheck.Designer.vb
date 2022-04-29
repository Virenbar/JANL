<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormULCheck
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
		Me.TB_INN = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'TB_INN
		'
		Me.TB_INN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TB_INN.Location = New System.Drawing.Point(12, 12)
		Me.TB_INN.Name = "TB_INN"
		Me.TB_INN.Size = New System.Drawing.Size(508, 20)
		Me.TB_INN.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TextBox2.Location = New System.Drawing.Point(0, 44)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(613, 192)
		Me.TextBox2.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.Location = New System.Drawing.Point(526, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'FormULCheck
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(613, 236)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TB_INN)
		Me.Name = "FormULCheck"
		Me.Text = "FormULCheck"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TB_INN As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button1 As Button
End Class
