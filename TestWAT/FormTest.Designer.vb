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
        Me.DateTimeS1 = New JANL.DateTimePickerEx()
        Me.BS_TestModel = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B_DateNull = New System.Windows.Forms.Button()
        Me.B_Date2000 = New System.Windows.Forms.Button()
        Me.DateTimeS2 = New JANL.DateTimePickerEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_Test = New JANL.Controls.ToggleButton()
        Me.B_Exception = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CncB_Test = New JANL.Controls.CancelableButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSPB_Test = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SWL_Test = New JANL.UserControls.StopWatchLabel()
        Me.CB_SW = New JANL.Controls.CancelableButton()
        Me.GP_PB = New System.Windows.Forms.GroupBox()
        Me.PBE_Test = New JANL.UserControls.ProgressBarEx()
        Me.B_PB = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxEx1 = New JANL.Controls.TextBoxEx()
        Me.TextBoxLabel1 = New JANL.Controls.TextBoxLabel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RegexTextBox1 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox2 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox3 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox4 = New JANL.Controls.RegexTextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MonthPicker1 = New JANL.UserControls.MonthPicker()
        Me.TB_Number = New System.Windows.Forms.TextBox()
        Me.TB_NumberText = New System.Windows.Forms.TextBox()
        Me.TB_Numberaga = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.B_EditFile = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Test_ProgressTrackerBar1 = New TestWAT.Test_ProgressTrackerBar()
        Me.Test_TaskButton1 = New TestWAT.Test_TaskButton()
        Me.Test_DataMapper1 = New TestWAT.Test_DataMapper()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(179, 112)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(173, 91)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'DateTimeS1
        '
        Me.DateTimeS1.CustomFormat = "dd.MM.yyyy g"
        Me.DateTimeS1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimeS1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeS1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimeS1.Name = "DateTimeS1"
        Me.DateTimeS1.Size = New System.Drawing.Size(167, 22)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 31)
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
        Me.DateTimeS2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeS2.Location = New System.Drawing.Point(3, 66)
        Me.DateTimeS2.Name = "DateTimeS2"
        Me.DateTimeS2.Size = New System.Drawing.Size(167, 22)
        Me.DateTimeS2.TabIndex = 4
        Me.DateTimeS2.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TB_Test)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 44)
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
        Me.TB_Test.Location = New System.Drawing.Point(3, 18)
        Me.TB_Test.Name = "TB_Test"
        Me.TB_Test.Size = New System.Drawing.Size(87, 23)
        Me.TB_Test.TabIndex = 1
        Me.TB_Test.Text = "Обновить"
        Me.TB_Test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TB_Test.TextOn = "Отмена"
        Me.TB_Test.UseVisualStyleBackColor = True
        '
        'B_Exception
        '
        Me.B_Exception.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Exception.AutoSize = True
        Me.B_Exception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Exception.Location = New System.Drawing.Point(105, 3)
        Me.B_Exception.Name = "B_Exception"
        Me.B_Exception.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Exception.Size = New System.Drawing.Size(84, 25)
        Me.B_Exception.TabIndex = 4
        Me.B_Exception.Text = "Сломать всё"
        Me.B_Exception.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.CncB_Test)
        Me.GroupBox3.Location = New System.Drawing.Point(102, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 44)
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
        Me.CncB_Test.Location = New System.Drawing.Point(3, 18)
        Me.CncB_Test.Name = "CncB_Test"
        Me.CncB_Test.Size = New System.Drawing.Size(87, 23)
        Me.CncB_Test.TabIndex = 6
        Me.CncB_Test.Text = "Обновить"
        Me.CncB_Test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CncB_Test.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSPB_Test})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1000, 22)
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
        'SWL_Test
        '
        Me.SWL_Test.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SWL_Test.ImageRunning = CType(resources.GetObject("SWL_Test.ImageRunning"), System.Drawing.Image)
        Me.SWL_Test.ImageWaiting = CType(resources.GetObject("SWL_Test.ImageWaiting"), System.Drawing.Image)
        Me.SWL_Test.Location = New System.Drawing.Point(3, 41)
        Me.SWL_Test.Name = "SWL_Test"
        Me.SWL_Test.ShowImage = False
        Me.SWL_Test.Size = New System.Drawing.Size(185, 24)
        Me.SWL_Test.TabIndex = 7
        '
        'CB_SW
        '
        Me.CB_SW.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_SW.ImageCancel = Nothing
        Me.CB_SW.ImageCanceled = Nothing
        Me.CB_SW.Location = New System.Drawing.Point(3, 18)
        Me.CB_SW.Name = "CB_SW"
        Me.CB_SW.Size = New System.Drawing.Size(185, 23)
        Me.CB_SW.TabIndex = 8
        Me.CB_SW.Text = "Start"
        Me.CB_SW.TextCancel = "Stop"
        Me.CB_SW.TextCanceled = Nothing
        Me.CB_SW.UseVisualStyleBackColor = True
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
        'PBE_Test
        '
        Me.PBE_Test.AutoSize = True
        Me.PBE_Test.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBE_Test.Location = New System.Drawing.Point(3, 41)
        Me.PBE_Test.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PBE_Test.Name = "PBE_Test"
        Me.PBE_Test.Percent = 0R
        Me.PBE_Test.Size = New System.Drawing.Size(213, 56)
        Me.PBE_Test.TabIndex = 9
        '
        'B_PB
        '
        Me.B_PB.AutoSize = True
        Me.B_PB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_PB.Dock = System.Windows.Forms.DockStyle.Top
        Me.B_PB.Location = New System.Drawing.Point(3, 18)
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
        Me.TextBox1.Size = New System.Drawing.Size(122, 22)
        Me.TextBox1.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxEx1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxLabel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(128, 84)
        Me.FlowLayoutPanel1.TabIndex = 16
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'TextBoxEx1
        '
        Me.TextBoxEx1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_TestModel, "TestString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxEx1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxEx1.Label = "TestString"
        Me.TextBoxEx1.Location = New System.Drawing.Point(3, 31)
        Me.TextBoxEx1.Name = "TextBoxEx1"
        Me.TextBoxEx1.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxEx1.TabIndex = 14
        Me.TextBoxEx1.Text = "​​TestString"
        '
        'TextBoxLabel1
        '
        Me.TextBoxLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_TestModel, "TestString", True))
        Me.TextBoxLabel1.Label = "TT"
        Me.TextBoxLabel1.Location = New System.Drawing.Point(3, 59)
        Me.TextBoxLabel1.Name = "TextBoxLabel1"
        Me.TextBoxLabel1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxLabel1.TabIndex = 11
        Me.TextBoxLabel1.Text = "111"
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(134, 105)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TextBoxEx"
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 232)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(140, 133)
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
        Me.FlowLayoutPanel2.Controls.Add(Me.RegexTextBox4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(134, 112)
        Me.FlowLayoutPanel2.TabIndex = 0
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'RegexTextBox1
        '
        Me.RegexTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RegexTextBox1.Message = Nothing
        Me.RegexTextBox1.Name = "RegexTextBox1"
        Me.RegexTextBox1.Pattern = "^4\d{9}$"
        Me.RegexTextBox1.Size = New System.Drawing.Size(128, 22)
        Me.RegexTextBox1.TabIndex = 18
        '
        'RegexTextBox2
        '
        Me.RegexTextBox2.Location = New System.Drawing.Point(3, 31)
        Me.RegexTextBox2.Message = Nothing
        Me.RegexTextBox2.Name = "RegexTextBox2"
        Me.RegexTextBox2.Pattern = "^4\d{9}$"
        Me.RegexTextBox2.Required = True
        Me.RegexTextBox2.Size = New System.Drawing.Size(128, 22)
        Me.RegexTextBox2.TabIndex = 19
        '
        'RegexTextBox3
        '
        Me.RegexTextBox3.Location = New System.Drawing.Point(3, 59)
        Me.RegexTextBox3.Message = Nothing
        Me.RegexTextBox3.Name = "RegexTextBox3"
        Me.RegexTextBox3.Pattern = "^\d{1,10}$"
        Me.RegexTextBox3.Required = True
        Me.RegexTextBox3.Size = New System.Drawing.Size(128, 22)
        Me.RegexTextBox3.TabIndex = 20
        '
        'RegexTextBox4
        '
        Me.RegexTextBox4.Location = New System.Drawing.Point(3, 87)
        Me.RegexTextBox4.Message = Nothing
        Me.RegexTextBox4.Name = "RegexTextBox4"
        Me.RegexTextBox4.Size = New System.Drawing.Size(128, 22)
        Me.RegexTextBox4.TabIndex = 21
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.GP_PB)
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 34)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(237, 420)
        Me.FlowLayoutPanel3.TabIndex = 20
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox5)
        Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox6)
        Me.FlowLayoutPanel4.Controls.Add(Me.MonthPicker1)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(240, 34)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(205, 420)
        Me.FlowLayoutPanel4.TabIndex = 21
        '
        'MonthPicker1
        '
        Me.MonthPicker1.AutoSize = True
        Me.MonthPicker1.Location = New System.Drawing.Point(3, 371)
        Me.MonthPicker1.MinYear = 2000
        Me.MonthPicker1.Name = "MonthPicker1"
        Me.MonthPicker1.Size = New System.Drawing.Size(158, 21)
        Me.MonthPicker1.TabIndex = 11
        '
        'TB_Number
        '
        Me.TB_Number.Dock = System.Windows.Forms.DockStyle.Top
        Me.TB_Number.Location = New System.Drawing.Point(3, 18)
        Me.TB_Number.Name = "TB_Number"
        Me.TB_Number.Size = New System.Drawing.Size(980, 22)
        Me.TB_Number.TabIndex = 22
        '
        'TB_NumberText
        '
        Me.TB_NumberText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_NumberText.Location = New System.Drawing.Point(3, 40)
        Me.TB_NumberText.Multiline = True
        Me.TB_NumberText.Name = "TB_NumberText"
        Me.TB_NumberText.ReadOnly = True
        Me.TB_NumberText.Size = New System.Drawing.Size(980, 197)
        Me.TB_NumberText.TabIndex = 23
        '
        'TB_Numberaga
        '
        Me.TB_Numberaga.Controls.Add(Me.TB_NumberText)
        Me.TB_Numberaga.Controls.Add(Me.TB_Number)
        Me.TB_Numberaga.Dock = System.Windows.Forms.DockStyle.Top
        Me.TB_Numberaga.Location = New System.Drawing.Point(3, 3)
        Me.TB_Numberaga.Name = "TB_Numberaga"
        Me.TB_Numberaga.Size = New System.Drawing.Size(986, 240)
        Me.TB_Numberaga.TabIndex = 24
        Me.TB_Numberaga.TabStop = False
        Me.TB_Numberaga.Text = "NumberToText"
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.Controls.Add(Me.B_EditFile)
        Me.FlowLayoutPanel5.Controls.Add(Me.B_Exception)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(986, 31)
        Me.FlowLayoutPanel5.TabIndex = 25
        '
        'B_EditFile
        '
        Me.B_EditFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_EditFile.AutoSize = True
        Me.B_EditFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_EditFile.Location = New System.Drawing.Point(3, 3)
        Me.B_EditFile.Name = "B_EditFile"
        Me.B_EditFile.Padding = New System.Windows.Forms.Padding(1)
        Me.B_EditFile.Size = New System.Drawing.Size(96, 25)
        Me.B_EditFile.TabIndex = 4
        Me.B_EditFile.Text = "Открыть файл"
        Me.B_EditFile.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 483)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.TestWAT.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage1.Font = Global.TestWAT.My.MySettings.Default.Font
        Me.TabPage1.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(992, 457)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Page 1"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Test_ProgressTrackerBar1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Test_TaskButton1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Test_DataMapper1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(986, 325)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Test_ProgressTrackerBar1
        '
        Me.Test_ProgressTrackerBar1.AutoSize = True
        Me.Test_ProgressTrackerBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Test_ProgressTrackerBar1.Location = New System.Drawing.Point(3, 3)
        Me.Test_ProgressTrackerBar1.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Test_ProgressTrackerBar1.Name = "Test_ProgressTrackerBar1"
        Me.Test_ProgressTrackerBar1.Size = New System.Drawing.Size(329, 144)
        Me.Test_ProgressTrackerBar1.TabIndex = 0
        '
        'Test_TaskButton1
        '
        Me.Test_TaskButton1.AutoSize = True
        Me.Test_TaskButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Test_TaskButton1.Location = New System.Drawing.Point(338, 3)
        Me.Test_TaskButton1.Name = "Test_TaskButton1"
        Me.Test_TaskButton1.Size = New System.Drawing.Size(206, 56)
        Me.Test_TaskButton1.TabIndex = 1
        '
        'Test_DataMapper1
        '
        Me.Test_DataMapper1.AutoSize = True
        Me.Test_DataMapper1.Location = New System.Drawing.Point(3, 153)
        Me.Test_DataMapper1.Name = "Test_DataMapper1"
        Me.Test_DataMapper1.Size = New System.Drawing.Size(187, 66)
        Me.Test_DataMapper1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel4)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel3)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel5)
        Me.TabPage2.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.TestWAT.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage2.Font = Global.TestWAT.My.MySettings.Default.Font
        Me.TabPage2.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(992, 457)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Page ClusterFuck"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.TabPage3.Controls.Add(Me.TB_Numberaga)
        Me.TabPage3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage3.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(992, 457)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Page NumberToText"
        '
        'FormTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.ClientSize = New System.Drawing.Size(1000, 597)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.TestWAT.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.TestWAT.My.MySettings.Default.Font
        Me.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
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
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimeS1 As JANL.DateTimePickerEx
    Friend WithEvents TB_Test As JANL.Controls.ToggleButton
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
    Friend WithEvents CncB_Test As JANL.Controls.CancelableButton
    Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents TSPB_Test As ToolStripProgressBar
    Friend WithEvents SWL_Test As JANL.UserControls.StopWatchLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CB_SW As JANL.Controls.CancelableButton
    Friend WithEvents PBE_Test As JANL.UserControls.ProgressBarEx
    Friend WithEvents GP_PB As GroupBox
	Friend WithEvents B_PB As Button
    Friend WithEvents TextBoxEx1 As JANL.Controls.TextBoxEx
    Friend WithEvents TextBox1 As TextBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RegexTextBox1 As JANL.Controls.RegexTextBox
    Friend WithEvents GroupBox6 As GroupBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents RegexTextBox2 As JANL.Controls.RegexTextBox
    Friend WithEvents RegexTextBox3 As JANL.Controls.RegexTextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
	Friend WithEvents TB_Number As TextBox
	Friend WithEvents TB_NumberText As TextBox
	Friend WithEvents TB_Numberaga As GroupBox
    Friend WithEvents RegexTextBox4 As JANL.Controls.RegexTextBox
    Friend WithEvents MonthPicker1 As JANL.UserControls.MonthPicker
    Friend WithEvents TextBoxLabel1 As JANL.Controls.TextBoxLabel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents B_EditFile As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Test_ProgressTrackerBar1 As Test_ProgressTrackerBar
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Test_TaskButton1 As Test_TaskButton
    Friend WithEvents Test_DataMapper1 As Test_DataMapper
End Class
