<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemSelector
	Inherits System.Windows.Forms.UserControl

	'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemSelector))
		Me.TB_Value = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.B_Select = New System.Windows.Forms.Button()
		Me.TT_Value = New System.Windows.Forms.ToolTip(Me.components)
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TB_Value
		'
		Me.TB_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TB_Value.Location = New System.Drawing.Point(0, 1)
		Me.TB_Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.TB_Value.Name = "TB_Value"
		Me.TB_Value.ReadOnly = True
		Me.TB_Value.Size = New System.Drawing.Size(116, 20)
		Me.TB_Value.TabIndex = 0
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.B_Select, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TB_Value, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 23)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'B_Select
		'
		Me.B_Select.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.B_Select.AutoSize = True
		Me.B_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Select.Image = CType(resources.GetObject("B_Select.Image"), System.Drawing.Image)
		Me.B_Select.Location = New System.Drawing.Point(119, 0)
		Me.B_Select.Margin = New System.Windows.Forms.Padding(0)
		Me.B_Select.Name = "B_Select"
		Me.B_Select.Size = New System.Drawing.Size(77, 23)
		Me.B_Select.TabIndex = 1
		Me.B_Select.Text = "Выбрать"
		Me.B_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Select.UseVisualStyleBackColor = True
		'
		'ItemSelector
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "ItemSelector"
		Me.Size = New System.Drawing.Size(196, 23)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TB_Value As TextBox
	Friend WithEvents B_Select As Button
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TT_Value As ToolTip
End Class
