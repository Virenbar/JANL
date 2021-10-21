﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkView
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
		Me.DGV_Links = New System.Windows.Forms.DataGridView()
		Me.BS_Links = New System.Windows.Forms.BindingSource(Me.components)
		Me.TLP_Footer = New System.Windows.Forms.TableLayoutPanel()
		Me.B_Refresh = New System.Windows.Forms.Button()
		Me.B_Edit = New System.Windows.Forms.Button()
		CType(Me.DGV_Links, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_Links, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TLP_Footer.SuspendLayout()
		Me.SuspendLayout()
		'
		'DGV_Links
		'
		Me.DGV_Links.AllowUserToAddRows = False
		Me.DGV_Links.AllowUserToDeleteRows = False
		Me.DGV_Links.AllowUserToResizeRows = False
		Me.DGV_Links.AutoGenerateColumns = False
		Me.DGV_Links.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.DGV_Links.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGV_Links.DataSource = Me.BS_Links
		Me.DGV_Links.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGV_Links.Location = New System.Drawing.Point(0, 0)
		Me.DGV_Links.MultiSelect = False
		Me.DGV_Links.Name = "DGV_Links"
		Me.DGV_Links.ReadOnly = True
		Me.DGV_Links.RowHeadersVisible = False
		Me.DGV_Links.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DGV_Links.Size = New System.Drawing.Size(605, 374)
		Me.DGV_Links.TabIndex = 0
		'
		'BS_Links
		'
		'
		'TLP_Footer
		'
		Me.TLP_Footer.AutoSize = True
		Me.TLP_Footer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TLP_Footer.ColumnCount = 2
		Me.TLP_Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TLP_Footer.Controls.Add(Me.B_Refresh, 0, 0)
		Me.TLP_Footer.Controls.Add(Me.B_Edit, 1, 0)
		Me.TLP_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TLP_Footer.Location = New System.Drawing.Point(0, 374)
		Me.TLP_Footer.Name = "TLP_Footer"
		Me.TLP_Footer.RowCount = 1
		Me.TLP_Footer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Footer.Size = New System.Drawing.Size(605, 31)
		Me.TLP_Footer.TabIndex = 2
		'
		'B_Refresh
		'
		Me.B_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.B_Refresh.AutoSize = True
		Me.B_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Refresh.Image = Global.JANL.My.Resources.icons8.Synchronize16
		Me.B_Refresh.Location = New System.Drawing.Point(3, 3)
		Me.B_Refresh.Name = "B_Refresh"
		Me.B_Refresh.Padding = New System.Windows.Forms.Padding(1)
		Me.B_Refresh.Size = New System.Drawing.Size(24, 24)
		Me.B_Refresh.TabIndex = 2
		'
		'B_Edit
		'
		Me.B_Edit.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.B_Edit.AutoSize = True
		Me.B_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Edit.Image = Global.JANL.My.Resources.icons8.PencilDrawing16
		Me.B_Edit.Location = New System.Drawing.Point(490, 3)
		Me.B_Edit.Name = "B_Edit"
		Me.B_Edit.Padding = New System.Windows.Forms.Padding(1)
		Me.B_Edit.Size = New System.Drawing.Size(112, 25)
		Me.B_Edit.TabIndex = 1
		Me.B_Edit.Text = "Редактировать"
		Me.B_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		'
		'LinkView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.DGV_Links)
		Me.Controls.Add(Me.TLP_Footer)
		Me.Name = "LinkView"
		Me.Size = New System.Drawing.Size(605, 405)
		CType(Me.DGV_Links, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_Links, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TLP_Footer.ResumeLayout(False)
		Me.TLP_Footer.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DGV_Links As DataGridView
	Friend WithEvents B_Edit As Button
	Friend WithEvents TLP_Footer As TableLayoutPanel
	Friend WithEvents BS_Links As BindingSource
	Friend WithEvents B_Refresh As Button
End Class