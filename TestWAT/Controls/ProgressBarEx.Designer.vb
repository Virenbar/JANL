<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressBarEx
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
		Me.PB = New System.Windows.Forms.ProgressBar()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.L_Percent = New System.Windows.Forms.Label()
		Me.L_Elapsed = New System.Windows.Forms.Label()
		Me.L_Estimated = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PB
		'
		Me.PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.SetColumnSpan(Me.PB, 3)
		Me.PB.Location = New System.Drawing.Point(3, 3)
		Me.PB.Name = "PB"
		Me.PB.Size = New System.Drawing.Size(194, 23)
		Me.PB.TabIndex = 0
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel1.Controls.Add(Me.L_Estimated, 2, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.PB, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.L_Percent, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.L_Elapsed, 0, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(479, 210)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'L_Percent
		'
		Me.L_Percent.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.L_Percent.AutoSize = True
		Me.L_Percent.Location = New System.Drawing.Point(79, 29)
		Me.L_Percent.Name = "L_Percent"
		Me.L_Percent.Size = New System.Drawing.Size(39, 13)
		Me.L_Percent.TabIndex = 1
		Me.L_Percent.Text = "Label1"
		'
		'L_Elapsed
		'
		Me.L_Elapsed.AutoSize = True
		Me.L_Elapsed.Location = New System.Drawing.Point(3, 29)
		Me.L_Elapsed.Name = "L_Elapsed"
		Me.L_Elapsed.Size = New System.Drawing.Size(39, 13)
		Me.L_Elapsed.TabIndex = 2
		Me.L_Elapsed.Text = "Label2"
		'
		'L_Estimated
		'
		Me.L_Estimated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.L_Estimated.AutoSize = True
		Me.L_Estimated.Location = New System.Drawing.Point(158, 29)
		Me.L_Estimated.Name = "L_Estimated"
		Me.L_Estimated.Size = New System.Drawing.Size(39, 13)
		Me.L_Estimated.TabIndex = 3
		Me.L_Estimated.Text = "Label3"
		'
		'ProgressBarEx
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "ProgressBarEx"
		Me.Size = New System.Drawing.Size(883, 394)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PB As ProgressBar
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents L_Estimated As Label
	Friend WithEvents L_Percent As Label
	Friend WithEvents L_Elapsed As Label
End Class
