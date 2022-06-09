<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnimation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CB_Direction = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TB_FPS = New System.Windows.Forms.TrackBar()
        Me.BS_Animator = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUD_FPS = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Duration = New System.Windows.Forms.NumericUpDown()
        Me.TB_Duration = New System.Windows.Forms.TrackBar()
        Me.NUD_Scale = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.B_Start = New System.Windows.Forms.Button()
        Me.B_Stop = New System.Windows.Forms.Button()
        Me.B_Reset = New System.Windows.Forms.Button()
        Me.APB_Image = New JANL.ExtendedControls.AnimatedPictureBox()
        Me.AnimatedPictureBox1 = New JANL.ExtendedControls.AnimatedPictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TB_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Animator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.APB_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimatedPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 197)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.CB_Direction)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 125)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(113, 23)
        Me.FlowLayoutPanel3.TabIndex = 9
        '
        'CB_Direction
        '
        Me.CB_Direction.AutoSize = True
        Me.CB_Direction.Location = New System.Drawing.Point(3, 3)
        Me.CB_Direction.Name = "CB_Direction"
        Me.CB_Direction.Size = New System.Drawing.Size(107, 17)
        Me.CB_Direction.TabIndex = 0
        Me.CB_Direction.Text = "Против часовой"
        Me.CB_Direction.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TB_FPS, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NUD_FPS, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NUD_Duration, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TB_Duration, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(836, 102)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TB_FPS
        '
        Me.TB_FPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_FPS.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Framerate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TB_FPS.Location = New System.Drawing.Point(80, 3)
        Me.TB_FPS.Maximum = 120
        Me.TB_FPS.Minimum = 15
        Me.TB_FPS.Name = "TB_FPS"
        Me.TB_FPS.Size = New System.Drawing.Size(753, 45)
        Me.TB_FPS.TabIndex = 9
        Me.TB_FPS.TickFrequency = 5
        Me.TB_FPS.Value = 15
        '
        'BS_Animator
        '
        Me.BS_Animator.DataSource = GetType(JANL.Interfaces.IAnimator)
        '
        'NUD_FPS
        '
        Me.NUD_FPS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NUD_FPS.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Framerate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NUD_FPS.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NUD_FPS.Location = New System.Drawing.Point(3, 15)
        Me.NUD_FPS.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.NUD_FPS.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NUD_FPS.Name = "NUD_FPS"
        Me.NUD_FPS.Size = New System.Drawing.Size(71, 20)
        Me.NUD_FPS.TabIndex = 10
        Me.NUD_FPS.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'NUD_Duration
        '
        Me.NUD_Duration.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NUD_Duration.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Duration", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NUD_Duration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NUD_Duration.Location = New System.Drawing.Point(3, 66)
        Me.NUD_Duration.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Duration.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NUD_Duration.Name = "NUD_Duration"
        Me.NUD_Duration.Size = New System.Drawing.Size(71, 20)
        Me.NUD_Duration.TabIndex = 10
        Me.NUD_Duration.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'TB_Duration
        '
        Me.TB_Duration.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Duration.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Duration", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TB_Duration.LargeChange = 1000
        Me.TB_Duration.Location = New System.Drawing.Point(80, 54)
        Me.TB_Duration.Maximum = 10000
        Me.TB_Duration.Minimum = 100
        Me.TB_Duration.Name = "TB_Duration"
        Me.TB_Duration.Size = New System.Drawing.Size(753, 45)
        Me.TB_Duration.SmallChange = 100
        Me.TB_Duration.TabIndex = 10
        Me.TB_Duration.TickFrequency = 100
        Me.TB_Duration.Value = 100
        '
        'NUD_Scale
        '
        Me.NUD_Scale.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NUD_Scale.DecimalPlaces = 2
        Me.NUD_Scale.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_Scale.Location = New System.Drawing.Point(3, 3)
        Me.NUD_Scale.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Scale.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_Scale.Name = "NUD_Scale"
        Me.NUD_Scale.Size = New System.Drawing.Size(71, 20)
        Me.NUD_Scale.TabIndex = 10
        Me.NUD_Scale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Start)
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Stop)
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Reset)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 165)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(836, 29)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'B_Start
        '
        Me.B_Start.Location = New System.Drawing.Point(3, 3)
        Me.B_Start.Name = "B_Start"
        Me.B_Start.Size = New System.Drawing.Size(75, 23)
        Me.B_Start.TabIndex = 11
        Me.B_Start.Text = "Start"
        Me.B_Start.UseVisualStyleBackColor = True
        '
        'B_Stop
        '
        Me.B_Stop.Location = New System.Drawing.Point(84, 3)
        Me.B_Stop.Name = "B_Stop"
        Me.B_Stop.Size = New System.Drawing.Size(75, 23)
        Me.B_Stop.TabIndex = 11
        Me.B_Stop.Text = "Stop"
        Me.B_Stop.UseVisualStyleBackColor = True
        '
        'B_Reset
        '
        Me.B_Reset.Location = New System.Drawing.Point(165, 3)
        Me.B_Reset.Name = "B_Reset"
        Me.B_Reset.Size = New System.Drawing.Size(75, 23)
        Me.B_Reset.TabIndex = 11
        Me.B_Reset.Text = "Reset"
        Me.B_Reset.UseVisualStyleBackColor = True
        '
        'APB_Image
        '
        Me.APB_Image.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.APB_Image.Animator = Nothing
        Me.APB_Image.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.APB_Image.Image = Global.TestWAT.My.Resources.Resources.partner64
        Me.APB_Image.Location = New System.Drawing.Point(151, 3)
        Me.APB_Image.Name = "APB_Image"
        Me.APB_Image.Size = New System.Drawing.Size(119, 116)
        Me.APB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.APB_Image.TabIndex = 7
        Me.APB_Image.TabStop = False
        '
        'AnimatedPictureBox1
        '
        Me.AnimatedPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnimatedPictureBox1.Animator = Nothing
        Me.AnimatedPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AnimatedPictureBox1.Image = Global.TestWAT.My.Resources.Resources.partner64
        Me.AnimatedPictureBox1.Location = New System.Drawing.Point(572, 3)
        Me.AnimatedPictureBox1.Name = "AnimatedPictureBox1"
        Me.AnimatedPictureBox1.Size = New System.Drawing.Size(119, 116)
        Me.AnimatedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AnimatedPictureBox1.TabIndex = 7
        Me.AnimatedPictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.APB_Image, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AnimatedPictureBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(842, 154)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.NUD_Scale)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(593, 125)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(77, 26)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'FormAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 510)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAnimation"
        Me.Text = "FormAnimation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TB_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Animator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.APB_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimatedPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents APB_Image As JANL.ExtendedControls.AnimatedPictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_FPS As TrackBar
    Friend WithEvents TB_Duration As TrackBar
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents B_Start As Button
    Friend WithEvents B_Stop As Button
    Friend WithEvents B_Reset As Button
    Friend WithEvents BS_Animator As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NUD_FPS As NumericUpDown
    Friend WithEvents NUD_Duration As NumericUpDown
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents CB_Direction As CheckBox
    Friend WithEvents NUD_Scale As NumericUpDown
    Friend WithEvents AnimatedPictureBox1 As JANL.ExtendedControls.AnimatedPictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
