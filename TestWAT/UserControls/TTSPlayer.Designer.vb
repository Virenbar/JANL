<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TTSPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TTSPlayer))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B_Play = New System.Windows.Forms.Button()
        Me.TB_Rate = New System.Windows.Forms.TrackBar()
        Me.B_Pause = New System.Windows.Forms.Button()
        Me.B_Stop = New System.Windows.Forms.Button()
        Me.L_Progress = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.TB_Rate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tableLayoutPanel1.Controls.Add(Me.B_Play, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.TB_Rate, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.B_Pause, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.B_Stop, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.L_Progress, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(250, 100)
        Me.tableLayoutPanel1.TabIndex = 3
        '
        'B_Play
        '
        Me.B_Play.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.B_Play.AutoSize = True
        Me.B_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Play.Image = CType(resources.GetObject("B_Play.Image"), System.Drawing.Image)
        Me.B_Play.Location = New System.Drawing.Point(14, 3)
        Me.B_Play.Name = "B_Play"
        Me.B_Play.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Play.Size = New System.Drawing.Size(55, 25)
        Me.B_Play.TabIndex = 0
        Me.B_Play.Text = "Play"
        Me.B_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Play.UseVisualStyleBackColor = True
        '
        'TB_Rate
        '
        Me.TB_Rate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayoutPanel1.SetColumnSpan(Me.TB_Rate, 3)
        Me.TB_Rate.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.TB_Rate.Location = New System.Drawing.Point(3, 34)
        Me.TB_Rate.Minimum = -10
        Me.TB_Rate.Name = "TB_Rate"
        Me.TB_Rate.Size = New System.Drawing.Size(244, 45)
        Me.TB_Rate.TabIndex = 1
        Me.TB_Rate.TickFrequency = 2
        Me.TB_Rate.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TB_Rate.Value = 2
        '
        'B_Pause
        '
        Me.B_Pause.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.B_Pause.AutoSize = True
        Me.B_Pause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Pause.Image = CType(resources.GetObject("B_Pause.Image"), System.Drawing.Image)
        Me.B_Pause.Location = New System.Drawing.Point(92, 3)
        Me.B_Pause.Name = "B_Pause"
        Me.B_Pause.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Pause.Size = New System.Drawing.Size(65, 25)
        Me.B_Pause.TabIndex = 0
        Me.B_Pause.Text = "Pause"
        Me.B_Pause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Pause.UseVisualStyleBackColor = True
        '
        'B_Stop
        '
        Me.B_Stop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.B_Stop.AutoSize = True
        Me.B_Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Stop.Image = CType(resources.GetObject("B_Stop.Image"), System.Drawing.Image)
        Me.B_Stop.Location = New System.Drawing.Point(179, 3)
        Me.B_Stop.Name = "B_Stop"
        Me.B_Stop.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Stop.Size = New System.Drawing.Size(57, 25)
        Me.B_Stop.TabIndex = 0
        Me.B_Stop.Text = "Stop"
        Me.B_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Stop.UseVisualStyleBackColor = True
        '
        'L_Progress
        '
        Me.L_Progress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.L_Progress.AutoSize = True
        Me.L_Progress.Location = New System.Drawing.Point(3, 83)
        Me.L_Progress.Name = "L_Progress"
        Me.L_Progress.Padding = New System.Windows.Forms.Padding(1)
        Me.L_Progress.Size = New System.Drawing.Size(23, 15)
        Me.L_Progress.TabIndex = 2
        Me.L_Progress.Text = "0%"
        '
        'TTSPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(250, 0)
        Me.Name = "TTSPlayer"
        Me.Size = New System.Drawing.Size(250, 100)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        CType(Me.TB_Rate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents B_Play As Button
    Private WithEvents TB_Rate As TrackBar
    Private WithEvents B_Pause As Button
    Private WithEvents B_Stop As Button
    Private WithEvents L_Progress As Label
End Class
