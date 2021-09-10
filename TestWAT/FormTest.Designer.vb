<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTest
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTest))
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.B_DateNull = New System.Windows.Forms.Button()
		Me.B_Date2000 = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.B_Exception = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TSPB_Test = New System.Windows.Forms.ToolStripProgressBar()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.GP_PB = New System.Windows.Forms.GroupBox()
		Me.B_PB = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
		Me.TB_Number = New System.Windows.Forms.TextBox()
		Me.TB_NumberText = New System.Windows.Forms.TextBox()
		Me.TB_Numberaga = New System.Windows.Forms.GroupBox()
		Me.PBE_Test = New JANL.ProgressBarEx()
		Me.SWL_Test = New JANL.StopWatchLabel()
		Me.CB_SW = New JANL.CancelableButton()
		Me.TB_Test = New JANL.ToggleButton()
		Me.CncB_Test = New JANL.CancelableButton()
		Me.DateTimeS1 = New JANL.DateTimePickerEx()
		Me.BS_TestModel = New System.Windows.Forms.BindingSource(Me.components)
		Me.DateTimeS2 = New JANL.DateTimePickerEx()
		Me.TextBoxEx1 = New JANL.TextBoxEx()
		Me.RegexTextBox1 = New JANL.RegexTextBox()
		Me.RegexTextBox2 = New JANL.RegexTextBox()
		Me.RegexTextBox3 = New JANL.RegexTextBox()
		Me.GroupBox1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GP_PB.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.FlowLayoutPanel4.SuspendLayout()
		Me.TB_Numberaga.SuspendLayout()
		CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
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
		'GroupBox2
		'
		Me.GroupBox2.AutoSize = True
		Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox2.Controls.Add(Me.TB_Test)
		Me.GroupBox2.Location = New System.Drawing.Point(3, 183)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(88, 42)
		Me.GroupBox2.TabIndex = 3
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "ToggleButton"
		'
		'B_Exception
		'
		Me.B_Exception.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.B_Exception.AutoSize = True
		Me.B_Exception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Exception.Location = New System.Drawing.Point(740, 426)
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
		Me.GroupBox3.Location = New System.Drawing.Point(97, 183)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(88, 42)
		Me.GroupBox3.TabIndex = 5
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "CancelableButton"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSPB_Test})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(831, 22)
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
		Me.GroupBox4.Location = New System.Drawing.Point(3, 109)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(191, 68)
		Me.GroupBox4.TabIndex = 8
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "StopWatch"
		'
		'GP_PB
		'
		Me.GP_PB.Controls.Add(Me.PBE_Test)
		Me.GP_PB.Controls.Add(Me.B_PB)
		Me.GP_PB.Location = New System.Drawing.Point(3, 3)
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
		'TextBox1
		'
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_TestModel, "TestString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.TextBox1.Location = New System.Drawing.Point(3, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(122, 20)
		Me.TextBox1.TabIndex = 15
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxEx1)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(128, 52)
		Me.FlowLayoutPanel1.TabIndex = 16
		Me.FlowLayoutPanel1.WrapContents = False
		'
		'GroupBox5
		'
		Me.GroupBox5.AutoSize = True
		Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel1)
		Me.GroupBox5.Location = New System.Drawing.Point(3, 115)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(134, 71)
		Me.GroupBox5.TabIndex = 17
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "TextBoxEx"
		'
		'GroupBox6
		'
		Me.GroupBox6.AutoSize = True
		Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox6.Controls.Add(Me.FlowLayoutPanel2)
		Me.GroupBox6.Location = New System.Drawing.Point(3, 192)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(140, 97)
		Me.GroupBox6.TabIndex = 19
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "RegexTextBox"
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Controls.Add(Me.RegexTextBox1)
		Me.FlowLayoutPanel2.Controls.Add(Me.RegexTextBox2)
		Me.FlowLayoutPanel2.Controls.Add(Me.RegexTextBox3)
		Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(134, 78)
		Me.FlowLayoutPanel2.TabIndex = 0
		Me.FlowLayoutPanel2.WrapContents = False
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.Controls.Add(Me.GP_PB)
		Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox4)
		Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox2)
		Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox3)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(205, 0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(237, 452)
		Me.FlowLayoutPanel3.TabIndex = 20
		'
		'FlowLayoutPanel4
		'
		Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox1)
		Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox5)
		Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox6)
		Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left
		Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
		Me.FlowLayoutPanel4.Size = New System.Drawing.Size(205, 452)
		Me.FlowLayoutPanel4.TabIndex = 21
		'
		'TB_Number
		'
		Me.TB_Number.Dock = System.Windows.Forms.DockStyle.Top
		Me.TB_Number.Location = New System.Drawing.Point(3, 16)
		Me.TB_Number.Name = "TB_Number"
		Me.TB_Number.Size = New System.Drawing.Size(259, 20)
		Me.TB_Number.TabIndex = 22
		'
		'TB_NumberText
		'
		Me.TB_NumberText.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_NumberText.Location = New System.Drawing.Point(3, 36)
		Me.TB_NumberText.Multiline = True
		Me.TB_NumberText.Name = "TB_NumberText"
		Me.TB_NumberText.ReadOnly = True
		Me.TB_NumberText.Size = New System.Drawing.Size(259, 378)
		Me.TB_NumberText.TabIndex = 23
		'
		'TB_Numberaga
		'
		Me.TB_Numberaga.Controls.Add(Me.TB_NumberText)
		Me.TB_Numberaga.Controls.Add(Me.TB_Number)
		Me.TB_Numberaga.Location = New System.Drawing.Point(566, 3)
		Me.TB_Numberaga.Name = "TB_Numberaga"
		Me.TB_Numberaga.Size = New System.Drawing.Size(265, 417)
		Me.TB_Numberaga.TabIndex = 24
		Me.TB_Numberaga.TabStop = False
		Me.TB_Numberaga.Text = "NumberToText"
		'
		'PBE_Test
		'
		Me.PBE_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PBE_Test.Location = New System.Drawing.Point(3, 39)
		Me.PBE_Test.MinimumSize = New System.Drawing.Size(200, 45)
		Me.PBE_Test.Name = "PBE_Test"
		Me.PBE_Test.Percent = 0R
		Me.PBE_Test.Size = New System.Drawing.Size(213, 58)
		Me.PBE_Test.TabIndex = 9
		'
		'SWL_Test
		'
		Me.SWL_Test.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SWL_Test.ImageRunning = CType(resources.GetObject("SWL_Test.ImageRunning"), System.Drawing.Image)
		Me.SWL_Test.ImageWaiting = CType(resources.GetObject("SWL_Test.ImageWaiting"), System.Drawing.Image)
		Me.SWL_Test.Location = New System.Drawing.Point(3, 39)
		Me.SWL_Test.Name = "SWL_Test"
		Me.SWL_Test.Size = New System.Drawing.Size(185, 26)
		Me.SWL_Test.TabIndex = 7
		'
		'CB_SW
		'
		Me.CB_SW.Dock = System.Windows.Forms.DockStyle.Top
		Me.CB_SW.ImageCancel = Nothing
		Me.CB_SW.ImageCanceled = Nothing
		Me.CB_SW.Location = New System.Drawing.Point(3, 16)
		Me.CB_SW.Name = "CB_SW"
		Me.CB_SW.Size = New System.Drawing.Size(185, 23)
		Me.CB_SW.TabIndex = 8
		Me.CB_SW.Text = "Start"
		Me.CB_SW.TextCancel = "Stop"
		Me.CB_SW.TextCanceled = Nothing
		Me.CB_SW.UseVisualStyleBackColor = True
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
		'DateTimeS2
		'
		Me.DateTimeS2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DateTimeS2.Location = New System.Drawing.Point(3, 64)
		Me.DateTimeS2.Name = "DateTimeS2"
		Me.DateTimeS2.Size = New System.Drawing.Size(167, 20)
		Me.DateTimeS2.TabIndex = 4
		Me.DateTimeS2.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
		'
		'TextBoxEx1
		'
		Me.TextBoxEx1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_TestModel, "TestString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.TextBoxEx1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TextBoxEx1.Label = "TestString"
		Me.TextBoxEx1.Location = New System.Drawing.Point(3, 29)
		Me.TextBoxEx1.Name = "TextBoxEx1"
		Me.TextBoxEx1.Size = New System.Drawing.Size(122, 20)
		Me.TextBoxEx1.TabIndex = 14
		Me.TextBoxEx1.Text = "123"
		'
		'RegexTextBox1
		'
		Me.RegexTextBox1.Location = New System.Drawing.Point(3, 3)
		Me.RegexTextBox1.Message = "Формат 4#########"
		Me.RegexTextBox1.Name = "RegexTextBox1"
		Me.RegexTextBox1.Pattern = "^4\d{9}$"
		Me.RegexTextBox1.Size = New System.Drawing.Size(128, 20)
		Me.RegexTextBox1.TabIndex = 18
		'
		'RegexTextBox2
		'
		Me.RegexTextBox2.Location = New System.Drawing.Point(3, 29)
		Me.RegexTextBox2.Message = "Формат 4#########"
		Me.RegexTextBox2.Name = "RegexTextBox2"
		Me.RegexTextBox2.Pattern = "^4\d{9}$"
		Me.RegexTextBox2.Required = True
		Me.RegexTextBox2.Size = New System.Drawing.Size(128, 20)
		Me.RegexTextBox2.TabIndex = 19
		'
		'RegexTextBox3
		'
		Me.RegexTextBox3.Location = New System.Drawing.Point(3, 55)
		Me.RegexTextBox3.Name = "RegexTextBox3"
		Me.RegexTextBox3.Size = New System.Drawing.Size(128, 20)
		Me.RegexTextBox3.TabIndex = 20
		'
		'FormTest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(831, 474)
		Me.Controls.Add(Me.TB_Numberaga)
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Controls.Add(Me.FlowLayoutPanel4)
		Me.Controls.Add(Me.B_Exception)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "FormTest"
		Me.Text = "FormTest"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
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
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox6.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.FlowLayoutPanel4.ResumeLayout(False)
		Me.FlowLayoutPanel4.PerformLayout()
		Me.TB_Numberaga.ResumeLayout(False)
		Me.TB_Numberaga.PerformLayout()
		CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents TextBoxEx1 As JANL.TextBoxEx
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents RegexTextBox1 As JANL.RegexTextBox
	Friend WithEvents GroupBox6 As GroupBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents RegexTextBox2 As JANL.RegexTextBox
	Friend WithEvents RegexTextBox3 As JANL.RegexTextBox
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
	Friend WithEvents TB_Number As TextBox
	Friend WithEvents TB_NumberText As TextBox
	Friend WithEvents TB_Numberaga As GroupBox
End Class
