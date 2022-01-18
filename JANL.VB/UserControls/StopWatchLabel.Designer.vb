<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopWatchLabel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StopWatchLabel))
		Me.PB_Image = New System.Windows.Forms.PictureBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.L_Prefix = New System.Windows.Forms.Label()
		Me.L_Time = New System.Windows.Forms.Label()
		CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PB_Image
		'
		Me.PB_Image.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.PB_Image.BackColor = System.Drawing.Color.Transparent
		Me.PB_Image.Image = CType(resources.GetObject("PB_Image.Image"), System.Drawing.Image)
		Me.PB_Image.InitialImage = CType(resources.GetObject("PB_Image.InitialImage"), System.Drawing.Image)
		Me.PB_Image.Location = New System.Drawing.Point(0, 35)
		Me.PB_Image.Margin = New System.Windows.Forms.Padding(0)
		Me.PB_Image.MaximumSize = New System.Drawing.Size(32, 32)
		Me.PB_Image.Name = "PB_Image"
		Me.PB_Image.Size = New System.Drawing.Size(32, 32)
		Me.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PB_Image.TabIndex = 0
		Me.PB_Image.TabStop = False
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.PB_Image, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(501, 103)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.L_Prefix)
		Me.FlowLayoutPanel1.Controls.Add(Me.L_Time)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(32, 45)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(66, 13)
		Me.FlowLayoutPanel1.TabIndex = 2
		'
		'L_Prefix
		'
		Me.L_Prefix.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.L_Prefix.AutoSize = True
		Me.L_Prefix.Location = New System.Drawing.Point(0, 0)
		Me.L_Prefix.Margin = New System.Windows.Forms.Padding(0)
		Me.L_Prefix.Name = "L_Prefix"
		Me.L_Prefix.Size = New System.Drawing.Size(36, 13)
		Me.L_Prefix.TabIndex = 2
		Me.L_Prefix.Text = "Prefix:"
		'
		'L_Time
		'
		Me.L_Time.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.L_Time.AutoSize = True
		Me.L_Time.Location = New System.Drawing.Point(36, 0)
		Me.L_Time.Margin = New System.Windows.Forms.Padding(0)
		Me.L_Time.Name = "L_Time"
		Me.L_Time.Size = New System.Drawing.Size(30, 13)
		Me.L_Time.TabIndex = 1
		Me.L_Time.Text = "Time"
		'
		'StopWatchLabel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "StopWatchLabel"
		Me.Size = New System.Drawing.Size(501, 103)
		CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PB_Image As PictureBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents L_Time As Label
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents L_Prefix As Label
End Class
