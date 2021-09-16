<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthPicker
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
		Me.CB_Month = New System.Windows.Forms.ComboBox()
		Me.CB_Year = New System.Windows.Forms.ComboBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'CB_Month
		'
		Me.CB_Month.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CB_Month.FormattingEnabled = True
		Me.CB_Month.Location = New System.Drawing.Point(0, 3)
		Me.CB_Month.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.CB_Month.MaxDropDownItems = 12
		Me.CB_Month.Name = "CB_Month"
		Me.CB_Month.Size = New System.Drawing.Size(102, 21)
		Me.CB_Month.TabIndex = 0
		'
		'CB_Year
		'
		Me.CB_Year.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CB_Year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.CB_Year.FormattingEnabled = True
		Me.CB_Year.Location = New System.Drawing.Point(108, 3)
		Me.CB_Year.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CB_Year.Name = "CB_Year"
		Me.CB_Year.Size = New System.Drawing.Size(47, 21)
		Me.CB_Year.TabIndex = 1
		Me.CB_Year.Text = "0000"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.CB_Year, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.CB_Month, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(155, 27)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'UC_MonthPicker
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "UC_MonthPicker"
		Me.Size = New System.Drawing.Size(155, 27)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CB_Month As ComboBox
	Friend WithEvents CB_Year As ComboBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
