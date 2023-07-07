<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnimationE
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
        Me.B_Start = New System.Windows.Forms.Button()
        Me.TB_Duration = New System.Windows.Forms.TrackBar()
        Me.BS_Animator = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_Stop = New System.Windows.Forms.Button()
        Me.B_Reset = New System.Windows.Forms.Button()
        Me.NUD_FPS = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Duration = New System.Windows.Forms.NumericUpDown()
        Me.TB_FPS = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FLP_Pictures = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.TB_Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Animator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'TB_Duration
        '
        Me.TB_Duration.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Duration.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Duration", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TB_Duration.LargeChange = 1000
        Me.TB_Duration.Location = New System.Drawing.Point(80, 54)
        Me.TB_Duration.Maximum = 10000
        Me.TB_Duration.Minimum = 100
        Me.TB_Duration.Name = "TB_Duration"
        Me.TB_Duration.Size = New System.Drawing.Size(711, 45)
        Me.TB_Duration.SmallChange = 100
        Me.TB_Duration.TabIndex = 10
        Me.TB_Duration.TickFrequency = 100
        Me.TB_Duration.Value = 100
        '
        'BS_Animator
        '
        Me.BS_Animator.DataSource = GetType(JANL.Interfaces.IAnimator)
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
        'TB_FPS
        '
        Me.TB_FPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_FPS.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Animator, "Framerate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TB_FPS.Location = New System.Drawing.Point(80, 3)
        Me.TB_FPS.Maximum = 120
        Me.TB_FPS.Minimum = 15
        Me.TB_FPS.Name = "TB_FPS"
        Me.TB_FPS.Size = New System.Drawing.Size(711, 45)
        Me.TB_FPS.TabIndex = 9
        Me.TB_FPS.TickFrequency = 5
        Me.TB_FPS.Value = 15
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 102)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Start)
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Stop)
        Me.FlowLayoutPanel2.Controls.Add(Me.B_Reset)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 118)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(794, 29)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'FLP_Pictures
        '
        Me.FLP_Pictures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Pictures.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Pictures.Name = "FLP_Pictures"
        Me.FLP_Pictures.Size = New System.Drawing.Size(800, 300)
        Me.FLP_Pictures.TabIndex = 11
        '
        'FormAnimationTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FLP_Pictures)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAnimationTest"
        Me.Text = "FormAnimationTest"
        CType(Me.TB_Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Animator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Start As Button
    Friend WithEvents TB_Duration As TrackBar
    Friend WithEvents BS_Animator As BindingSource
    Friend WithEvents B_Stop As Button
    Friend WithEvents B_Reset As Button
    Friend WithEvents NUD_FPS As NumericUpDown
    Friend WithEvents NUD_Duration As NumericUpDown
    Friend WithEvents TB_FPS As TrackBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FLP_Pictures As FlowLayoutPanel
End Class
