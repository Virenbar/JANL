<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTextBox
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
		Me.TB = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.B_OK = New System.Windows.Forms.Button()
		Me.B_Cancel = New System.Windows.Forms.Button()
		Me.L_Select = New System.Windows.Forms.Label()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TB
		'
		Me.TB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB.Location = New System.Drawing.Point(3, 18)
		Me.TB.Multiline = True
		Me.TB.Name = "TB"
		Me.TB.Size = New System.Drawing.Size(354, 115)
		Me.TB.TabIndex = 0
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.TB, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.L_Select, 0, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 3
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(360, 173)
		Me.TableLayoutPanel2.TabIndex = 6
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.B_OK)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Cancel)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(219, 139)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(138, 31)
		Me.FlowLayoutPanel1.TabIndex = 3
		'
		'B_OK
		'
		Me.B_OK.AutoSize = True
		Me.B_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_OK.Image = Global.JANL.My.Resources.icons8.Ok16
		Me.B_OK.Location = New System.Drawing.Point(3, 3)
		Me.B_OK.Name = "B_OK"
		Me.B_OK.Padding = New System.Windows.Forms.Padding(1)
		Me.B_OK.Size = New System.Drawing.Size(50, 25)
		Me.B_OK.TabIndex = 1
		Me.B_OK.Text = "ОК"
		Me.B_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_OK.UseVisualStyleBackColor = True
		'
		'B_Cancel
		'
		Me.B_Cancel.AutoSize = True
		Me.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Cancel.Image = Global.JANL.My.Resources.icons8.Cancel16
		Me.B_Cancel.Location = New System.Drawing.Point(59, 3)
		Me.B_Cancel.Name = "B_Cancel"
		Me.B_Cancel.Padding = New System.Windows.Forms.Padding(1)
		Me.B_Cancel.Size = New System.Drawing.Size(76, 25)
		Me.B_Cancel.TabIndex = 2
		Me.B_Cancel.Text = "Отмена"
		Me.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Cancel.UseVisualStyleBackColor = True
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
		Me.L_Select.Visible = False
		'
		'FormTextBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(360, 173)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.JANL.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.Font = Global.JANL.My.MySettings.Default.Font
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormTextBox"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "TextBox"
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TB As System.Windows.Forms.TextBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents B_OK As Button
	Friend WithEvents B_Cancel As Button
	Friend WithEvents L_Select As Label
End Class
