<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectionBox(Of T)
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.LB_Items = New System.Windows.Forms.ListBox()
		Me.B_Select = New System.Windows.Forms.Button()
		Me.B_Cancel = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.L_Select = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'LB_Items
		'
		Me.LB_Items.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB_Items.FormattingEnabled = True
		Me.LB_Items.Location = New System.Drawing.Point(5, 20)
		Me.LB_Items.Margin = New System.Windows.Forms.Padding(5)
		Me.LB_Items.Name = "LB_Items"
		Me.LB_Items.Size = New System.Drawing.Size(319, 110)
		Me.LB_Items.TabIndex = 0
		'
		'B_Select
		'
		Me.B_Select.Location = New System.Drawing.Point(3, 3)
		Me.B_Select.Name = "B_Select"
		Me.B_Select.Size = New System.Drawing.Size(75, 23)
		Me.B_Select.TabIndex = 1
		Me.B_Select.Text = "Выбрать"
		Me.B_Select.UseVisualStyleBackColor = True
		'
		'B_Cancel
		'
		Me.B_Cancel.Location = New System.Drawing.Point(84, 3)
		Me.B_Cancel.Name = "B_Cancel"
		Me.B_Cancel.Size = New System.Drawing.Size(75, 23)
		Me.B_Cancel.TabIndex = 2
		Me.B_Cancel.Text = "Отмена"
		Me.B_Cancel.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Select)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Cancel)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(164, 138)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(162, 29)
		Me.FlowLayoutPanel1.TabIndex = 3
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.L_Select, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.LB_Items, 0, 1)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 3
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(329, 170)
		Me.TableLayoutPanel2.TabIndex = 5
		'
		'L_Select
		'
		Me.L_Select.AutoSize = True
		Me.L_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.L_Select.Location = New System.Drawing.Point(3, 0)
		Me.L_Select.Name = "L_Select"
		Me.L_Select.Size = New System.Drawing.Size(78, 15)
		Me.L_Select.TabIndex = 6
		Me.L_Select.Text = "Выберите "
		'
		'SelectionBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(339, 180)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(250, 170)
		Me.Name = "SelectionBox"
		Me.Padding = New System.Windows.Forms.Padding(5)
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SelectionBox"
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents LB_Items As ListBox
	Friend WithEvents B_Select As Button
	Friend WithEvents B_Cancel As Button
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents L_Select As Label
End Class
