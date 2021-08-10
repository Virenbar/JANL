<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVTemplateEditor
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGVTemplateEditor))
		Me.BS_Columns = New System.Windows.Forms.BindingSource(Me.components)
		Me.BS_Design = New System.Windows.Forms.BindingSource(Me.components)
		Me.DGV_Template = New System.Windows.Forms.DataGridView()
		Me.BN_Columns = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.PG_Column = New System.Windows.Forms.PropertyGrid()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TB_XML = New System.Windows.Forms.TextBox()
		Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.B_Import = New System.Windows.Forms.Button()
		Me.B_Export = New System.Windows.Forms.Button()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		CType(Me.BS_Columns, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_Design, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DGV_Template, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BN_Columns, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BN_Columns.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.flowLayoutPanel2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'BS_Columns
		'
		Me.BS_Columns.DataSource = GetType(JANL.Types.DesignColumn)
		'
		'BS_Design
		'
		Me.BS_Design.DataSource = GetType(JANL.Types.Design)
		'
		'DGV_Template
		'
		Me.DGV_Template.AllowUserToAddRows = False
		Me.DGV_Template.AllowUserToDeleteRows = False
		Me.DGV_Template.AllowUserToOrderColumns = True
		Me.DGV_Template.AllowUserToResizeColumns = False
		Me.DGV_Template.AllowUserToResizeRows = False
		Me.DGV_Template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_Template.Dock = System.Windows.Forms.DockStyle.Top
		Me.DGV_Template.Location = New System.Drawing.Point(0, 0)
		Me.DGV_Template.MultiSelect = False
		Me.DGV_Template.Name = "DGV_Template"
		Me.DGV_Template.ReadOnly = True
		Me.DGV_Template.RowHeadersVisible = False
		Me.DGV_Template.Size = New System.Drawing.Size(1194, 88)
		Me.DGV_Template.TabIndex = 102
		'
		'BN_Columns
		'
		Me.BN_Columns.AddNewItem = Me.bindingNavigatorAddNewItem
		Me.BN_Columns.BindingSource = Me.BS_Columns
		Me.BN_Columns.CountItem = Me.bindingNavigatorCountItem
		Me.BN_Columns.DeleteItem = Me.bindingNavigatorDeleteItem
		Me.BN_Columns.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem})
		Me.BN_Columns.Location = New System.Drawing.Point(3, 16)
		Me.BN_Columns.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
		Me.BN_Columns.MoveLastItem = Me.bindingNavigatorMoveLastItem
		Me.BN_Columns.MoveNextItem = Me.bindingNavigatorMoveNextItem
		Me.BN_Columns.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
		Me.BN_Columns.Name = "BN_Columns"
		Me.BN_Columns.PositionItem = Me.bindingNavigatorPositionItem
		Me.BN_Columns.Size = New System.Drawing.Size(424, 25)
		Me.BN_Columns.TabIndex = 103
		Me.BN_Columns.Text = "bindingNavigator1"
		'
		'bindingNavigatorAddNewItem
		'
		Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
		Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorAddNewItem.Text = "Add"
		'
		'bindingNavigatorCountItem
		'
		Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
		Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
		Me.bindingNavigatorCountItem.Text = "для {0}"
		Me.bindingNavigatorCountItem.ToolTipText = "Общее число элементов"
		'
		'bindingNavigatorDeleteItem
		'
		Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
		Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorDeleteItem.Text = "Delete"
		'
		'bindingNavigatorMoveFirstItem
		'
		Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
		Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorMoveFirstItem.Text = "Переместить в начало"
		'
		'bindingNavigatorMovePreviousItem
		'
		Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
		Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorMovePreviousItem.Text = "Переместить назад"
		'
		'bindingNavigatorSeparator
		'
		Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
		Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		'
		'bindingNavigatorPositionItem
		'
		Me.bindingNavigatorPositionItem.AccessibleName = "Положение"
		Me.bindingNavigatorPositionItem.AutoSize = False
		Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
		Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		Me.bindingNavigatorPositionItem.Text = "0"
		Me.bindingNavigatorPositionItem.ToolTipText = "Текущее положение"
		'
		'bindingNavigatorSeparator1
		'
		Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
		Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'bindingNavigatorMoveNextItem
		'
		Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
		Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorMoveNextItem.Text = "Переместить вперед"
		'
		'bindingNavigatorMoveLastItem
		'
		Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
		Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
		Me.bindingNavigatorMoveLastItem.Text = "Переместить в конец"
		'
		'bindingNavigatorSeparator2
		'
		Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
		Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.PG_Column)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox2.Location = New System.Drawing.Point(439, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(315, 571)
		Me.GroupBox2.TabIndex = 101
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Свойства столбца"
		'
		'PG_Column
		'
		Me.PG_Column.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PG_Column.Location = New System.Drawing.Point(3, 16)
		Me.PG_Column.Name = "PG_Column"
		Me.PG_Column.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
		Me.PG_Column.Size = New System.Drawing.Size(309, 552)
		Me.PG_Column.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TB_XML)
		Me.GroupBox1.Controls.Add(Me.flowLayoutPanel2)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(760, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(431, 571)
		Me.GroupBox1.TabIndex = 100
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "XML"
		'
		'TB_XML
		'
		Me.TB_XML.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_XML.Location = New System.Drawing.Point(3, 45)
		Me.TB_XML.Margin = New System.Windows.Forms.Padding(10)
		Me.TB_XML.Multiline = True
		Me.TB_XML.Name = "TB_XML"
		Me.TB_XML.Size = New System.Drawing.Size(425, 523)
		Me.TB_XML.TabIndex = 0
		'
		'flowLayoutPanel2
		'
		Me.flowLayoutPanel2.AutoSize = True
		Me.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.flowLayoutPanel2.Controls.Add(Me.B_Import)
		Me.flowLayoutPanel2.Controls.Add(Me.B_Export)
		Me.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.flowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
		Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
		Me.flowLayoutPanel2.Size = New System.Drawing.Size(425, 29)
		Me.flowLayoutPanel2.TabIndex = 9
		'
		'B_Import
		'
		Me.B_Import.AutoSize = True
		Me.B_Import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Import.Image = CType(resources.GetObject("B_Import.Image"), System.Drawing.Image)
		Me.B_Import.Location = New System.Drawing.Point(3, 3)
		Me.B_Import.Name = "B_Import"
		Me.B_Import.Size = New System.Drawing.Size(72, 23)
		Me.B_Import.TabIndex = 2
		Me.B_Import.Text = "Импорт"
		Me.B_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Import.UseVisualStyleBackColor = True
		'
		'B_Export
		'
		Me.B_Export.AutoSize = True
		Me.B_Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Export.Image = CType(resources.GetObject("B_Export.Image"), System.Drawing.Image)
		Me.B_Export.Location = New System.Drawing.Point(81, 3)
		Me.B_Export.Name = "B_Export"
		Me.B_Export.Size = New System.Drawing.Size(75, 23)
		Me.B_Export.TabIndex = 3
		Me.B_Export.Text = "Экспорт"
		Me.B_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Export.UseVisualStyleBackColor = True
		'
		'ListBox1
		'
		Me.ListBox1.DataSource = Me.BS_Columns
		Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(3, 41)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(424, 527)
		Me.ListBox1.TabIndex = 104
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.ListBox1)
		Me.GroupBox3.Controls.Add(Me.BN_Columns)
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(430, 571)
		Me.GroupBox3.TabIndex = 105
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Столбцы"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 88)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1194, 577)
		Me.TableLayoutPanel1.TabIndex = 106
		'
		'DGVTemplateEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.DGV_Template)
		Me.Name = "DGVTemplateEditor"
		Me.Size = New System.Drawing.Size(1194, 665)
		CType(Me.BS_Columns, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_Design, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DGV_Template, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BN_Columns, System.ComponentModel.ISupportInitialize).EndInit()
		Me.BN_Columns.ResumeLayout(False)
		Me.BN_Columns.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.flowLayoutPanel2.ResumeLayout(False)
		Me.flowLayoutPanel2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents BS_Columns As BindingSource
	Private WithEvents BS_Design As BindingSource
	Private WithEvents DGV_Template As DataGridView
	Private WithEvents BN_Columns As BindingNavigator
	Private WithEvents bindingNavigatorAddNewItem As ToolStripButton
	Private WithEvents bindingNavigatorCountItem As ToolStripLabel
	Private WithEvents bindingNavigatorDeleteItem As ToolStripButton
	Private WithEvents bindingNavigatorMoveFirstItem As ToolStripButton
	Private WithEvents bindingNavigatorMovePreviousItem As ToolStripButton
	Private WithEvents bindingNavigatorSeparator As ToolStripSeparator
	Private WithEvents bindingNavigatorPositionItem As ToolStripTextBox
	Private WithEvents bindingNavigatorSeparator1 As ToolStripSeparator
	Private WithEvents bindingNavigatorMoveNextItem As ToolStripButton
	Private WithEvents bindingNavigatorMoveLastItem As ToolStripButton
	Private WithEvents bindingNavigatorSeparator2 As ToolStripSeparator
	Private WithEvents GroupBox2 As GroupBox
	Private WithEvents PG_Column As PropertyGrid
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TB_XML As TextBox
	Private WithEvents flowLayoutPanel2 As FlowLayoutPanel
	Private WithEvents B_Import As Button
	Private WithEvents B_Export As Button
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
