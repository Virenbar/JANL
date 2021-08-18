<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelect
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelect))
		Me.B_Cancel = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.B_Reset = New System.Windows.Forms.Button()
		Me.B_Select = New System.Windows.Forms.Button()
		Me.TLP_Select = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.DGV_Filter = New JANL.DGVFilter()
		Me.BNB_Delete = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BN_Select = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BS_Select = New System.Windows.Forms.BindingSource(Me.components)
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BNB_New = New System.Windows.Forms.ToolStripButton()
		Me.BNB_Edit = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BNB_Refresh = New System.Windows.Forms.ToolStripButton()
		Me.DGV_Select = New System.Windows.Forms.DataGridView()
		Me.TLP_Filter = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CMS_Select = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.TSMI_Refresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TLP_Select.SuspendLayout()
		CType(Me.BN_Select, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BN_Select.SuspendLayout()
		CType(Me.BS_Select, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DGV_Select, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TLP_Filter.SuspendLayout()
		Me.CMS_Select.SuspendLayout()
		Me.SuspendLayout()
		'
		'B_Cancel
		'
		Me.B_Cancel.Image = CType(resources.GetObject("B_Cancel.Image"), System.Drawing.Image)
		Me.B_Cancel.Location = New System.Drawing.Point(205, 3)
		Me.B_Cancel.Name = "B_Cancel"
		Me.B_Cancel.Size = New System.Drawing.Size(75, 23)
		Me.B_Cancel.TabIndex = 0
		Me.B_Cancel.Text = "Отмена"
		Me.B_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Cancel.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Reset)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Select)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Cancel)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(492, 5)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(283, 29)
		Me.FlowLayoutPanel1.TabIndex = 3
		Me.FlowLayoutPanel1.WrapContents = False
		'
		'B_Reset
		'
		Me.B_Reset.AutoSize = True
		Me.B_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Reset.Image = CType(resources.GetObject("B_Reset.Image"), System.Drawing.Image)
		Me.B_Reset.Location = New System.Drawing.Point(3, 3)
		Me.B_Reset.Name = "B_Reset"
		Me.B_Reset.Size = New System.Drawing.Size(115, 23)
		Me.B_Reset.TabIndex = 5
		Me.B_Reset.Text = "Очистить выбор"
		Me.B_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.B_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Reset.UseVisualStyleBackColor = True
		'
		'B_Select
		'
		Me.B_Select.Image = CType(resources.GetObject("B_Select.Image"), System.Drawing.Image)
		Me.B_Select.Location = New System.Drawing.Point(124, 3)
		Me.B_Select.Name = "B_Select"
		Me.B_Select.Size = New System.Drawing.Size(75, 23)
		Me.B_Select.TabIndex = 4
		Me.B_Select.Text = "Выбрать"
		Me.B_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Select.UseVisualStyleBackColor = True
		'
		'TLP_Select
		'
		Me.TLP_Select.AutoSize = True
		Me.TLP_Select.ColumnCount = 2
		Me.TLP_Select.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Select.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TLP_Select.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
		Me.TLP_Select.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
		Me.TLP_Select.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TLP_Select.Location = New System.Drawing.Point(0, 411)
		Me.TLP_Select.Name = "TLP_Select"
		Me.TLP_Select.RowCount = 1
		Me.TLP_Select.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Select.Size = New System.Drawing.Size(780, 39)
		Me.TLP_Select.TabIndex = 11
		Me.TLP_Select.Visible = False
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 19)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(0, 0)
		Me.FlowLayoutPanel2.TabIndex = 4
		'
		'DGV_Filter
		'
		Me.DGV_Filter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.DGV_Filter.Name = "DGV_Filter"
		Me.DGV_Filter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
		Me.DGV_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DGV_Filter.Size = New System.Drawing.Size(300, 25)
		'
		'BNB_Delete
		'
		Me.BNB_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BNB_Delete.Enabled = False
		Me.BNB_Delete.Image = CType(resources.GetObject("BNB_Delete.Image"), System.Drawing.Image)
		Me.BNB_Delete.Name = "BNB_Delete"
		Me.BNB_Delete.RightToLeftAutoMirrorImage = True
		Me.BNB_Delete.Size = New System.Drawing.Size(23, 22)
		Me.BNB_Delete.Text = "Удалить"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
		Me.BindingNavigatorCountItem.Text = "для {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
		'
		'BN_Select
		'
		Me.BN_Select.AddNewItem = Nothing
		Me.BN_Select.BindingSource = Me.BS_Select
		Me.BN_Select.CountItem = Me.BindingNavigatorCountItem
		Me.BN_Select.DeleteItem = Nothing
		Me.BN_Select.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.BN_Select.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BNB_New, Me.BNB_Edit, Me.BNB_Delete, Me.DGV_Filter, Me.ToolStripSeparator1, Me.BNB_Refresh})
		Me.BN_Select.Location = New System.Drawing.Point(0, 23)
		Me.BN_Select.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.BN_Select.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.BN_Select.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.BN_Select.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.BN_Select.Name = "BN_Select"
		Me.BN_Select.PositionItem = Me.BindingNavigatorPositionItem
		Me.BN_Select.Size = New System.Drawing.Size(780, 25)
		Me.BN_Select.TabIndex = 10
		Me.BN_Select.Text = "BindingNavigator1"
		'
		'BS_Select
		'
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
		'
		'BNB_New
		'
		Me.BNB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BNB_New.Image = CType(resources.GetObject("BNB_New.Image"), System.Drawing.Image)
		Me.BNB_New.Name = "BNB_New"
		Me.BNB_New.RightToLeftAutoMirrorImage = True
		Me.BNB_New.Size = New System.Drawing.Size(23, 22)
		Me.BNB_New.Text = "Добавить"
		'
		'BNB_Edit
		'
		Me.BNB_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BNB_Edit.Image = CType(resources.GetObject("BNB_Edit.Image"), System.Drawing.Image)
		Me.BNB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.BNB_Edit.Name = "BNB_Edit"
		Me.BNB_Edit.Size = New System.Drawing.Size(23, 22)
		Me.BNB_Edit.Text = "Редактировать"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'BNB_Refresh
		'
		Me.BNB_Refresh.Image = CType(resources.GetObject("BNB_Refresh.Image"), System.Drawing.Image)
		Me.BNB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.BNB_Refresh.Name = "BNB_Refresh"
		Me.BNB_Refresh.Size = New System.Drawing.Size(81, 22)
		Me.BNB_Refresh.Text = "Обновить"
		'
		'DGV_Select
		'
		Me.DGV_Select.AllowUserToAddRows = False
		Me.DGV_Select.AllowUserToDeleteRows = False
		Me.DGV_Select.AllowUserToResizeRows = False
		Me.DGV_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_Select.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGV_Select.Location = New System.Drawing.Point(0, 48)
		Me.DGV_Select.MultiSelect = False
		Me.DGV_Select.Name = "DGV_Select"
		Me.DGV_Select.ReadOnly = True
		Me.DGV_Select.RowHeadersVisible = False
		Me.DGV_Select.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DGV_Select.Size = New System.Drawing.Size(780, 363)
		Me.DGV_Select.TabIndex = 9
		'
		'TLP_Filter
		'
		Me.TLP_Filter.AutoSize = True
		Me.TLP_Filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TLP_Filter.ColumnCount = 2
		Me.TLP_Filter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Filter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TLP_Filter.Controls.Add(Me.Label1, 1, 0)
		Me.TLP_Filter.Dock = System.Windows.Forms.DockStyle.Top
		Me.TLP_Filter.Location = New System.Drawing.Point(0, 0)
		Me.TLP_Filter.Name = "TLP_Filter"
		Me.TLP_Filter.RowCount = 1
		Me.TLP_Filter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Filter.Size = New System.Drawing.Size(780, 23)
		Me.TLP_Filter.TabIndex = 12
		Me.TLP_Filter.Visible = False
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(695, 5)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "<-Place for fliter"
		Me.Label1.Visible = False
		'
		'CMS_Select
		'
		Me.CMS_Select.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Refresh})
		Me.CMS_Select.Name = "CMS_Select"
		Me.CMS_Select.Size = New System.Drawing.Size(129, 26)
		'
		'TSMI_Refresh
		'
		Me.TSMI_Refresh.Image = CType(resources.GetObject("TSMI_Refresh.Image"), System.Drawing.Image)
		Me.TSMI_Refresh.Name = "TSMI_Refresh"
		Me.TSMI_Refresh.Size = New System.Drawing.Size(128, 22)
		Me.TSMI_Refresh.Text = "Обновить"
		'
		'FormSelect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(780, 450)
		Me.Controls.Add(Me.DGV_Select)
		Me.Controls.Add(Me.TLP_Select)
		Me.Controls.Add(Me.BN_Select)
		Me.Controls.Add(Me.TLP_Filter)
		Me.KeyPreview = True
		Me.Name = "FormSelect"
		Me.Text = "FormSelect"
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.TLP_Select.ResumeLayout(False)
		Me.TLP_Select.PerformLayout()
		CType(Me.BN_Select, System.ComponentModel.ISupportInitialize).EndInit()
		Me.BN_Select.ResumeLayout(False)
		Me.BN_Select.PerformLayout()
		CType(Me.BS_Select, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DGV_Select, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TLP_Filter.ResumeLayout(False)
		Me.TLP_Filter.PerformLayout()
		Me.CMS_Select.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents B_Cancel As Button
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents B_Select As Button
	Friend WithEvents TLP_Select As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents B_Reset As Button
	Friend WithEvents DGV_Filter As DGVFilter
	Friend WithEvents BNB_Delete As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BN_Select As BindingNavigator
	Friend WithEvents BS_Select As BindingSource
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BNB_New As ToolStripButton
	Friend WithEvents BNB_Edit As ToolStripButton
	Friend WithEvents DGV_Select As DataGridView
	Friend WithEvents BNB_Refresh As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents TLP_Filter As TableLayoutPanel
	Friend WithEvents CMS_Select As ContextMenuStrip
	Friend WithEvents TSMI_Refresh As ToolStripMenuItem
	Friend WithEvents Label1 As Label
End Class
