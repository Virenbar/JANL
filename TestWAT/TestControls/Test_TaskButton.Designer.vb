<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test_TaskButton
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TB_Start = New JANL.Controls.TaskButton()
        Me.L_Count = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TaskButton"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_Start)
        Me.FlowLayoutPanel1.Controls.Add(Me.L_Count)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(143, 31)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'TB_Start
        '
        Me.TB_Start.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TB_Start.AutoSize = True
        Me.TB_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TB_Start.Image = Global.TestWAT.My.Resources.icons8.icons8_Ok16
        Me.TB_Start.ImageCancel = Global.TestWAT.My.Resources.icons8.icons8_Cancel16
        Me.TB_Start.Location = New System.Drawing.Point(3, 3)
        Me.TB_Start.Name = "TB_Start"
        Me.TB_Start.Padding = New System.Windows.Forms.Padding(1)
        Me.TB_Start.Size = New System.Drawing.Size(84, 25)
        Me.TB_Start.TabIndex = 0
        Me.TB_Start.Text = "Start Task"
        Me.TB_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TB_Start.UseVisualStyleBackColor = True
        '
        'L_Count
        '
        Me.L_Count.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.L_Count.AutoSize = True
        Me.L_Count.Location = New System.Drawing.Point(93, 9)
        Me.L_Count.Name = "L_Count"
        Me.L_Count.Size = New System.Drawing.Size(47, 13)
        Me.L_Count.TabIndex = 1
        Me.L_Count.Text = "Count: 0"
        '
        'Test_TaskButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Test_TaskButton"
        Me.Size = New System.Drawing.Size(158, 72)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Start As JANL.Controls.TaskButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents L_Count As Label
End Class
