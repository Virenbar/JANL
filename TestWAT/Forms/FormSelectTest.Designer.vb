<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectTest
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
		Me.B_Date = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TSSL_Result = New System.Windows.Forms.ToolStripStatusLabel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.B_String = New System.Windows.Forms.Button()
		Me.B_Object = New System.Windows.Forms.Button()
		Me.B_Enum = New System.Windows.Forms.Button()
		Me.B_FormSelect = New System.Windows.Forms.Button()
		Me.ItemSelector1 = New JANL.ItemSelector()
		Me.AutoTextBox1 = New JANL.AutoTextBox()
		Me.StatusStrip1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'B_Date
		'
		Me.B_Date.Location = New System.Drawing.Point(3, 3)
		Me.B_Date.Name = "B_Date"
		Me.B_Date.Size = New System.Drawing.Size(75, 23)
		Me.B_Date.TabIndex = 0
		Me.B_Date.Text = "Date"
		Me.B_Date.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_Result})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(592, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'TSSL_Result
		'
		Me.TSSL_Result.Name = "TSSL_Result"
		Me.TSSL_Result.Size = New System.Drawing.Size(12, 17)
		Me.TSSL_Result.Text = "-"
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Date)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_String)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Object)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Enum)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(592, 29)
		Me.FlowLayoutPanel1.TabIndex = 2
		'
		'B_String
		'
		Me.B_String.Location = New System.Drawing.Point(84, 3)
		Me.B_String.Name = "B_String"
		Me.B_String.Size = New System.Drawing.Size(75, 23)
		Me.B_String.TabIndex = 1
		Me.B_String.Text = "String"
		Me.B_String.UseVisualStyleBackColor = True
		'
		'B_Object
		'
		Me.B_Object.Location = New System.Drawing.Point(165, 3)
		Me.B_Object.Name = "B_Object"
		Me.B_Object.Size = New System.Drawing.Size(75, 23)
		Me.B_Object.TabIndex = 2
		Me.B_Object.Text = "Object"
		Me.B_Object.UseVisualStyleBackColor = True
		'
		'B_Enum
		'
		Me.B_Enum.Location = New System.Drawing.Point(246, 3)
		Me.B_Enum.Name = "B_Enum"
		Me.B_Enum.Size = New System.Drawing.Size(75, 23)
		Me.B_Enum.TabIndex = 3
		Me.B_Enum.Text = "Enum"
		Me.B_Enum.UseVisualStyleBackColor = True
		'
		'B_FormSelect
		'
		Me.B_FormSelect.Location = New System.Drawing.Point(124, 64)
		Me.B_FormSelect.Name = "B_FormSelect"
		Me.B_FormSelect.Size = New System.Drawing.Size(75, 23)
		Me.B_FormSelect.TabIndex = 3
		Me.B_FormSelect.Text = "Button1"
		Me.B_FormSelect.UseVisualStyleBackColor = True
		'
		'ItemSelector1
		'
		Me.ItemSelector1.Key = 2
		Me.ItemSelector1.Location = New System.Drawing.Point(3, 35)
		Me.ItemSelector1.Name = "ItemSelector1"
		Me.ItemSelector1.Size = New System.Drawing.Size(196, 23)
		Me.ItemSelector1.TabIndex = 4
		'
		'AutoTextBox1
		'
		Me.AutoTextBox1.Key = 2
		Me.AutoTextBox1.Location = New System.Drawing.Point(3, 64)
		Me.AutoTextBox1.Name = "AutoTextBox1"
		Me.AutoTextBox1.Size = New System.Drawing.Size(100, 20)
		Me.AutoTextBox1.TabIndex = 5
		'
		'FormSelectTest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(592, 327)
		Me.Controls.Add(Me.AutoTextBox1)
		Me.Controls.Add(Me.ItemSelector1)
		Me.Controls.Add(Me.B_FormSelect)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "FormSelectTest"
		Me.Text = "FormSelectTest"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents B_Date As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents TSSL_Result As ToolStripStatusLabel
	Friend WithEvents B_String As Button
	Friend WithEvents B_Object As Button
	Friend WithEvents B_Enum As Button
	Friend WithEvents B_FormSelect As Button
	Friend WithEvents ItemSelector1 As JANL.ItemSelector
	Friend WithEvents AutoTextBox1 As JANL.AutoTextBox
End Class
