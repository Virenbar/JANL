<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim DefaultSpinner1 As JANL.Animators.Spinner.DefaultSpinner = New JANL.Animators.Spinner.DefaultSpinner()
        Me.MS_Main = New System.Windows.Forms.MenuStrip()
        Me.ФормыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Controls = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_MDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_FormOffice = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Animation_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Animation_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_HashVSList = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_ArrayVSRegex = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Address = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_UL = New System.Windows.Forms.ToolStripMenuItem()
        Me.НижнийТагилToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НаселениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.РосреестрToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РазноеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormAsyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVTEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Beep = New System.Windows.Forms.Button()
        Me.B_SQL = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.B_Vowels = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.TS_Spinner = New JANL.Controls.ToolStripSpinner()
        Me.TS_Stopwatch = New JANL.Controls.ToolStripStopwatch()
        Me.TS_Search = New JANL.Controls.ToolStripTextBoxLabel()
        Me.TB_Search = New System.Windows.Forms.TextBox()
        Me.MI_Colors = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Main.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_Main
        '
        Me.MS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФормыToolStripMenuItem, Me.PerfTestsToolStripMenuItem, Me.DaDataToolStripMenuItem, Me.НижнийТагилToolStripMenuItem, Me.ToolStripMenuItem1, Me.РазноеToolStripMenuItem})
        Me.MS_Main.Location = New System.Drawing.Point(0, 0)
        Me.MS_Main.Name = "MS_Main"
        Me.MS_Main.Size = New System.Drawing.Size(685, 24)
        Me.MS_Main.TabIndex = 0
        Me.MS_Main.Text = "MenuStrip1"
        '
        'ФормыToolStripMenuItem
        '
        Me.ФормыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Controls, Me.MI_MDI, Me.MI_FormOffice, Me.MI_Animation_1, Me.MI_Animation_2, Me.MI_Colors})
        Me.ФормыToolStripMenuItem.Name = "ФормыToolStripMenuItem"
        Me.ФормыToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ФормыToolStripMenuItem.Text = "Формы"
        '
        'MI_Controls
        '
        Me.MI_Controls.Name = "MI_Controls"
        Me.MI_Controls.Size = New System.Drawing.Size(198, 22)
        Me.MI_Controls.Text = "Элементы управления"
        '
        'MI_MDI
        '
        Me.MI_MDI.Name = "MI_MDI"
        Me.MI_MDI.Size = New System.Drawing.Size(198, 22)
        Me.MI_MDI.Text = "MDI форма"
        '
        'MI_FormOffice
        '
        Me.MI_FormOffice.Name = "MI_FormOffice"
        Me.MI_FormOffice.Size = New System.Drawing.Size(198, 22)
        Me.MI_FormOffice.Text = "Офис"
        '
        'MI_Animation_1
        '
        Me.MI_Animation_1.Name = "MI_Animation_1"
        Me.MI_Animation_1.Size = New System.Drawing.Size(198, 22)
        Me.MI_Animation_1.Text = "Анимация 1"
        '
        'MI_Animation_2
        '
        Me.MI_Animation_2.Name = "MI_Animation_2"
        Me.MI_Animation_2.Size = New System.Drawing.Size(198, 22)
        Me.MI_Animation_2.Text = "Анимация 2"
        '
        'PerfTestsToolStripMenuItem
        '
        Me.PerfTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_HashVSList, Me.MI_ArrayVSRegex})
        Me.PerfTestsToolStripMenuItem.Name = "PerfTestsToolStripMenuItem"
        Me.PerfTestsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PerfTestsToolStripMenuItem.Text = "PerfTests"
        '
        'MI_HashVSList
        '
        Me.MI_HashVSList.Name = "MI_HashVSList"
        Me.MI_HashVSList.Size = New System.Drawing.Size(146, 22)
        Me.MI_HashVSList.Text = "HashVSList"
        '
        'MI_ArrayVSRegex
        '
        Me.MI_ArrayVSRegex.Name = "MI_ArrayVSRegex"
        Me.MI_ArrayVSRegex.Size = New System.Drawing.Size(146, 22)
        Me.MI_ArrayVSRegex.Text = "ArrayVSRegex"
        '
        'DaDataToolStripMenuItem
        '
        Me.DaDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Address, Me.TSMI_UL})
        Me.DaDataToolStripMenuItem.Name = "DaDataToolStripMenuItem"
        Me.DaDataToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DaDataToolStripMenuItem.Text = "DaData"
        '
        'TSMI_Address
        '
        Me.TSMI_Address.Name = "TSMI_Address"
        Me.TSMI_Address.Size = New System.Drawing.Size(180, 22)
        Me.TSMI_Address.Text = "Адрес"
        '
        'TSMI_UL
        '
        Me.TSMI_UL.Name = "TSMI_UL"
        Me.TSMI_UL.Size = New System.Drawing.Size(180, 22)
        Me.TSMI_UL.Text = "ЮЛ"
        '
        'НижнийТагилToolStripMenuItem
        '
        Me.НижнийТагилToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НаселениеToolStripMenuItem})
        Me.НижнийТагилToolStripMenuItem.Name = "НижнийТагилToolStripMenuItem"
        Me.НижнийТагилToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.НижнийТагилToolStripMenuItem.Text = "Нижний Тагил"
        '
        'НаселениеToolStripMenuItem
        '
        Me.НаселениеToolStripMenuItem.Name = "НаселениеToolStripMenuItem"
        Me.НаселениеToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.НаселениеToolStripMenuItem.Text = "Население"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.РосреестрToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripMenuItem1.Text = "Excel"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem3.Text = "Сальдо"
        '
        'РосреестрToolStripMenuItem
        '
        Me.РосреестрToolStripMenuItem.Name = "РосреестрToolStripMenuItem"
        Me.РосреестрToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.РосреестрToolStripMenuItem.Text = "Росреестр"
        '
        'РазноеToolStripMenuItem
        '
        Me.РазноеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormAsyncToolStripMenuItem, Me.SelectTestToolStripMenuItem, Me.DGVTEditorToolStripMenuItem})
        Me.РазноеToolStripMenuItem.Name = "РазноеToolStripMenuItem"
        Me.РазноеToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.РазноеToolStripMenuItem.Text = "Разное"
        '
        'FormAsyncToolStripMenuItem
        '
        Me.FormAsyncToolStripMenuItem.Name = "FormAsyncToolStripMenuItem"
        Me.FormAsyncToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FormAsyncToolStripMenuItem.Text = "FormAsync"
        '
        'SelectTestToolStripMenuItem
        '
        Me.SelectTestToolStripMenuItem.Name = "SelectTestToolStripMenuItem"
        Me.SelectTestToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SelectTestToolStripMenuItem.Text = "SelectTest"
        '
        'DGVTEditorToolStripMenuItem
        '
        Me.DGVTEditorToolStripMenuItem.Name = "DGVTEditorToolStripMenuItem"
        Me.DGVTEditorToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DGVTEditorToolStripMenuItem.Text = "DGVT Editor"
        '
        'B_Beep
        '
        Me.B_Beep.AutoSize = True
        Me.B_Beep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Beep.Location = New System.Drawing.Point(48, 3)
        Me.B_Beep.Name = "B_Beep"
        Me.B_Beep.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Beep.Size = New System.Drawing.Size(45, 25)
        Me.B_Beep.TabIndex = 1
        Me.B_Beep.Text = "Beep"
        Me.B_Beep.UseVisualStyleBackColor = True
        '
        'B_SQL
        '
        Me.B_SQL.AutoSize = True
        Me.B_SQL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_SQL.Location = New System.Drawing.Point(3, 3)
        Me.B_SQL.Name = "B_SQL"
        Me.B_SQL.Padding = New System.Windows.Forms.Padding(1)
        Me.B_SQL.Size = New System.Drawing.Size(39, 25)
        Me.B_SQL.TabIndex = 2
        Me.B_SQL.Text = "SQL"
        Me.B_SQL.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.B_SQL)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Beep)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Vowels)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 360)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(685, 31)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'B_Vowels
        '
        Me.B_Vowels.AutoSize = True
        Me.B_Vowels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Vowels.Location = New System.Drawing.Point(99, 3)
        Me.B_Vowels.Name = "B_Vowels"
        Me.B_Vowels.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Vowels.Size = New System.Drawing.Size(49, 25)
        Me.B_Vowels.TabIndex = 7
        Me.B_Vowels.Text = "Упртс"
        Me.B_Vowels.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.Control
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_Spinner, Me.TS_Stopwatch, Me.TS_Search})
        Me.Status.Location = New System.Drawing.Point(0, 391)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(685, 23)
        Me.Status.TabIndex = 5
        Me.Status.Text = "StatusStrip1"
        '
        'TS_Spinner
        '
        Me.TS_Spinner.Name = "TS_Spinner"
        Me.TS_Spinner.Size = New System.Drawing.Size(12, 21)
        Me.TS_Spinner.Spinner = DefaultSpinner1
        Me.TS_Spinner.Text = "-"
        '
        'TS_Stopwatch
        '
        Me.TS_Stopwatch.Name = "TS_Stopwatch"
        Me.TS_Stopwatch.ShowText = False
        Me.TS_Stopwatch.Size = New System.Drawing.Size(58, 21)
        Me.TS_Stopwatch.Text = "Uptime"
        '
        'TS_Search
        '
        Me.TS_Search.Name = "TS_Search"
        Me.TS_Search.Size = New System.Drawing.Size(100, 23)
        Me.TS_Search.ToolTipText = "Esc - очистить фильтр"
        '
        'TB_Search
        '
        Me.TB_Search.Location = New System.Drawing.Point(274, 264)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.Size = New System.Drawing.Size(143, 22)
        Me.TB_Search.TabIndex = 6
        '
        'MI_Colors
        '
        Me.MI_Colors.Name = "MI_Colors"
        Me.MI_Colors.Size = New System.Drawing.Size(198, 22)
        Me.MI_Colors.Text = "Colors"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.ClientSize = New System.Drawing.Size(685, 414)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MS_Main)
        Me.Controls.Add(Me.Status)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.TestWAT.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.TestWAT.My.MySettings.Default.Font
        Me.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
        Me.MainMenuStrip = Me.MS_Main
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.MS_Main.ResumeLayout(False)
        Me.MS_Main.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MS_Main As MenuStrip
    Friend WithEvents НижнийТагилToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НаселениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents B_Beep As Button
    Friend WithEvents DaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РазноеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfTestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MI_HashVSList As ToolStripMenuItem
    Friend WithEvents FormAsyncToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_Address As ToolStripMenuItem
    Friend WithEvents TSMI_UL As ToolStripMenuItem
    Friend WithEvents SelectTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGVTEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РосреестрToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_SQL As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ФормыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MI_FormOffice As ToolStripMenuItem
    Friend WithEvents Status As StatusStrip
    Friend WithEvents TS_Spinner As JANL.Controls.ToolStripSpinner
    Friend WithEvents TS_Search As JANL.Controls.ToolStripTextBoxLabel
    Friend WithEvents TS_Stopwatch As JANL.Controls.ToolStripStopwatch
    Friend WithEvents TB_Search As TextBox
    Friend WithEvents MI_ArrayVSRegex As ToolStripMenuItem
    Friend WithEvents MI_Animation_1 As ToolStripMenuItem
    Friend WithEvents MI_Animation_2 As ToolStripMenuItem
    Friend WithEvents MI_Controls As ToolStripMenuItem
    Friend WithEvents MI_MDI As ToolStripMenuItem
    Friend WithEvents B_Vowels As Button
    Friend WithEvents MI_Colors As ToolStripMenuItem
End Class
