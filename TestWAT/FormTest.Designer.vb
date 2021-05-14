<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTest
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTest))
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DateTimeS1 = New JANL.DateTimePickerEx()
		Me.BS_TestModel = New System.Windows.Forms.BindingSource(Me.components)
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.B_DateNull = New System.Windows.Forms.Button()
		Me.B_Date2000 = New System.Windows.Forms.Button()
		Me.DateTimeS2 = New JANL.DateTimePickerEx()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TB_Test = New JANL.ToggleButton()
		Me.B_Exception = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.CncB_Test = New JANL.CancelableButton()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TSPB_Test = New System.Windows.Forms.ToolStripProgressBar()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.SWL_Test = New JANL.StopWatchLabel()
		Me.CB_SW = New JANL.CancelableButton()
		Me.PBE_Test = New JANL.ProgressBarEx()
		Me.GP_PB = New System.Windows.Forms.GroupBox()
		Me.B_PB = New System.Windows.Forms.Button()
		Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
		Me.GroupBox1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GP_PB.SuspendLayout()
		Me.TableLayoutPanel9.SuspendLayout()
		Me.SuspendLayout()
		'
		'ImageList1
		'
		Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		'
		'GroupBox1
		'
		Me.GroupBox1.AutoSize = True
		Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
		Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(179, 106)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "TestDate"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.DateTimeS1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.DateTimeS2, 0, 2)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 3
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(173, 87)
		Me.TableLayoutPanel2.TabIndex = 4
		'
		'DateTimeS1
		'
		Me.DateTimeS1.CustomFormat = "dd.MM.yyyy g"
		Me.DateTimeS1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DateTimeS1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimeS1.Location = New System.Drawing.Point(3, 3)
		Me.DateTimeS1.Name = "DateTimeS1"
		Me.DateTimeS1.Size = New System.Drawing.Size(167, 20)
		Me.DateTimeS1.TabIndex = 0
		Me.DateTimeS1.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
		'
		'BS_TestModel
		'
		Me.BS_TestModel.DataSource = GetType(TestWAT.Models.TestModel)
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.B_DateNull, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.B_Date2000, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 29)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 29)
		Me.TableLayoutPanel1.TabIndex = 3
		'
		'B_DateNull
		'
		Me.B_DateNull.Location = New System.Drawing.Point(84, 3)
		Me.B_DateNull.Name = "B_DateNull"
		Me.B_DateNull.Size = New System.Drawing.Size(75, 23)
		Me.B_DateNull.TabIndex = 3
		Me.B_DateNull.Text = "SetNull"
		Me.B_DateNull.UseVisualStyleBackColor = True
		'
		'B_Date2000
		'
		Me.B_Date2000.Location = New System.Drawing.Point(3, 3)
		Me.B_Date2000.Name = "B_Date2000"
		Me.B_Date2000.Size = New System.Drawing.Size(75, 23)
		Me.B_Date2000.TabIndex = 1
		Me.B_Date2000.Text = "Set2000"
		Me.B_Date2000.UseVisualStyleBackColor = True
		'
		'DateTimeS2
		'
		Me.DateTimeS2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DateTimeS2.Location = New System.Drawing.Point(3, 64)
		Me.DateTimeS2.Name = "DateTimeS2"
		Me.DateTimeS2.Size = New System.Drawing.Size(167, 20)
		Me.DateTimeS2.TabIndex = 4
		Me.DateTimeS2.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
		'
		'GroupBox2
		'
		Me.GroupBox2.AutoSize = True
		Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox2.Controls.Add(Me.TB_Test)
		Me.GroupBox2.Location = New System.Drawing.Point(350, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(88, 42)
		Me.GroupBox2.TabIndex = 3
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "ToggleButton"
		'
		'TB_Test
		'
		Me.TB_Test.AutoSize = True
		Me.TB_Test.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TB_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_Test.Image = Global.TestWAT.My.Resources.icons8.icons8_Refresh16B
		Me.TB_Test.ImageOn = Global.TestWAT.My.Resources.icons8.icons8_Cancel16
		Me.TB_Test.Location = New System.Drawing.Point(3, 16)
		Me.TB_Test.Name = "TB_Test"
		Me.TB_Test.Size = New System.Drawing.Size(82, 23)
		Me.TB_Test.TabIndex = 1
		Me.TB_Test.Text = "Обновить"
		Me.TB_Test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.TB_Test.TextOn = "Отмена"
		Me.TB_Test.UseVisualStyleBackColor = True
		'
		'B_Exception
		'
		Me.B_Exception.AutoSize = True
		Me.B_Exception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Exception.Location = New System.Drawing.Point(481, 28)
		Me.B_Exception.Name = "B_Exception"
		Me.B_Exception.Size = New System.Drawing.Size(91, 23)
		Me.B_Exception.TabIndex = 4
		Me.B_Exception.Text = "Сделать плохо"
		Me.B_Exception.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.AutoSize = True
		Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox3.Controls.Add(Me.CncB_Test)
		Me.GroupBox3.Location = New System.Drawing.Point(236, 12)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(88, 42)
		Me.GroupBox3.TabIndex = 5
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "CancelableButton"
		'
		'CncB_Test
		'
		Me.CncB_Test.AutoSize = True
		Me.CncB_Test.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CncB_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CncB_Test.Image = Global.TestWAT.My.Resources.icons8.icons8_Refresh16B
		Me.CncB_Test.ImageCancel = Global.TestWAT.My.Resources.icons8.icons8_Cancel16
		Me.CncB_Test.ImageCanceled = Global.TestWAT.My.Resources.icons8.icons8_Cancel16
		Me.CncB_Test.Location = New System.Drawing.Point(3, 16)
		Me.CncB_Test.Name = "CncB_Test"
		Me.CncB_Test.Size = New System.Drawing.Size(82, 23)
		Me.CncB_Test.TabIndex = 6
		Me.CncB_Test.Text = "Обновить"
		Me.CncB_Test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.CncB_Test.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSPB_Test})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 330)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(647, 22)
		Me.StatusStrip1.TabIndex = 6
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'TSPB_Test
		'
		Me.TSPB_Test.Name = "TSPB_Test"
		Me.TSPB_Test.Size = New System.Drawing.Size(100, 16)
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.SWL_Test)
		Me.GroupBox4.Controls.Add(Me.CB_SW)
		Me.GroupBox4.Location = New System.Drawing.Point(27, 124)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(156, 68)
		Me.GroupBox4.TabIndex = 8
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "StopWatch"
		'
		'SWL_Test
		'
		Me.SWL_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SWL_Test.ImageRunning = CType(resources.GetObject("SWL_Test.ImageRunning"), System.Drawing.Image)
		Me.SWL_Test.ImageWaiting = CType(resources.GetObject("SWL_Test.ImageWaiting"), System.Drawing.Image)
		Me.SWL_Test.Location = New System.Drawing.Point(3, 39)
		Me.SWL_Test.Name = "SWL_Test"
		Me.SWL_Test.Size = New System.Drawing.Size(150, 26)
		Me.SWL_Test.TabIndex = 7
		'
		'CB_SW
		'
		Me.CB_SW.Dock = System.Windows.Forms.DockStyle.Top
		Me.CB_SW.ImageCancel = Nothing
		Me.CB_SW.ImageCanceled = Nothing
		Me.CB_SW.Location = New System.Drawing.Point(3, 16)
		Me.CB_SW.Name = "CB_SW"
		Me.CB_SW.Size = New System.Drawing.Size(150, 23)
		Me.CB_SW.TabIndex = 8
		Me.CB_SW.Text = "Start"
		Me.CB_SW.TextCancel = "Stop"
		Me.CB_SW.TextCanceled = Nothing
		Me.CB_SW.UseVisualStyleBackColor = True
		'
		'PBE_Test
		'
		Me.PBE_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PBE_Test.Location = New System.Drawing.Point(3, 39)
		Me.PBE_Test.MinimumSize = New System.Drawing.Size(200, 45)
		Me.PBE_Test.Name = "PBE_Test"
		Me.PBE_Test.Percent = 0
		Me.PBE_Test.Size = New System.Drawing.Size(213, 58)
		Me.PBE_Test.TabIndex = 9
		'
		'GP_PB
		'
		Me.GP_PB.Controls.Add(Me.PBE_Test)
		Me.GP_PB.Controls.Add(Me.B_PB)
		Me.GP_PB.Location = New System.Drawing.Point(353, 92)
		Me.GP_PB.Name = "GP_PB"
		Me.GP_PB.Size = New System.Drawing.Size(219, 100)
		Me.GP_PB.TabIndex = 10
		Me.GP_PB.TabStop = False
		Me.GP_PB.Text = "ProgressBar"
		'
		'B_PB
		'
		Me.B_PB.AutoSize = True
		Me.B_PB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_PB.Dock = System.Windows.Forms.DockStyle.Top
		Me.B_PB.Location = New System.Drawing.Point(3, 16)
		Me.B_PB.Name = "B_PB"
		Me.B_PB.Size = New System.Drawing.Size(213, 23)
		Me.B_PB.TabIndex = 11
		Me.B_PB.Text = "Start"
		Me.B_PB.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel9
		'
		Me.TableLayoutPanel9.ColumnCount = 2
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel9.Controls.Add(Me.FlowLayoutPanel4, 1, 0)
		Me.TableLayoutPanel9.Location = New System.Drawing.Point(365, 216)
		Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
		Me.TableLayoutPanel9.RowCount = 1
		Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel9.Size = New System.Drawing.Size(195, 80)
		Me.TableLayoutPanel9.TabIndex = 13
		'
		'FlowLayoutPanel4
		'
		Me.FlowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.FlowLayoutPanel4.Location = New System.Drawing.Point(108, 11)
		Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
		Me.FlowLayoutPanel4.Size = New System.Drawing.Size(84, 57)
		Me.FlowLayoutPanel4.TabIndex = 11
		'
		'FormTest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(647, 352)
		Me.Controls.Add(Me.TableLayoutPanel9)
		Me.Controls.Add(Me.GP_PB)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.B_Exception)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormTest"
		Me.Text = "FormTest"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GP_PB.ResumeLayout(False)
		Me.GP_PB.PerformLayout()
		Me.TableLayoutPanel9.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DateTimeS1 As JANL.DateTimePickerEx
	Friend WithEvents TB_Test As JANL.ToggleButton
	Friend WithEvents ImageList1 As ImageList
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents B_Date2000 As Button
	Friend WithEvents BS_TestModel As BindingSource
	Friend WithEvents B_DateNull As Button
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents DateTimeS2 As JANL.DateTimePickerEx
	Friend WithEvents B_Exception As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents CncB_Test As JANL.CancelableButton
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents TSPB_Test As ToolStripProgressBar
	Friend WithEvents SWL_Test As JANL.StopWatchLabel
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents CB_SW As JANL.CancelableButton
	Friend WithEvents PBE_Test As JANL.ProgressBarEx
	Friend WithEvents GP_PB As GroupBox
	Friend WithEvents B_PB As Button
	Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
End Class
