<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_ProgressTrackerBar
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
        Me.B_StartA = New System.Windows.Forms.Button()
        Me.PTB = New JANL.UserControls.ProgressTrackerBar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.B_StartM = New System.Windows.Forms.Button()
        Me.B_Increment = New System.Windows.Forms.Button()
        Me.B_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_StartA
        '
        Me.B_StartA.AutoSize = True
        Me.B_StartA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_StartA.Location = New System.Drawing.Point(3, 34)
        Me.B_StartA.Name = "B_StartA"
        Me.B_StartA.Padding = New System.Windows.Forms.Padding(1)
        Me.B_StartA.Size = New System.Drawing.Size(72, 25)
        Me.B_StartA.TabIndex = 0
        Me.B_StartA.Text = "Start - Auto"
        Me.B_StartA.UseVisualStyleBackColor = True
        '
        'PTB
        '
        Me.PTB.AutoSize = True
        Me.PTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PTB.Location = New System.Drawing.Point(3, 16)
        Me.PTB.Maximum = 100
        Me.PTB.Name = "PTB"
        Me.PTB.Size = New System.Drawing.Size(317, 55)
        Me.PTB.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.B_StartM)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Increment)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_StartA)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 71)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(317, 62)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'B_StartM
        '
        Me.B_StartM.AutoSize = True
        Me.B_StartM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_StartM.Location = New System.Drawing.Point(3, 3)
        Me.B_StartM.Name = "B_StartM"
        Me.B_StartM.Padding = New System.Windows.Forms.Padding(1)
        Me.B_StartM.Size = New System.Drawing.Size(85, 25)
        Me.B_StartM.TabIndex = 0
        Me.B_StartM.Text = "Start - Manual"
        Me.B_StartM.UseVisualStyleBackColor = True
        '
        'B_Increment
        '
        Me.B_Increment.AutoSize = True
        Me.B_Increment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.SetFlowBreak(Me.B_Increment, True)
        Me.B_Increment.Location = New System.Drawing.Point(94, 3)
        Me.B_Increment.Name = "B_Increment"
        Me.B_Increment.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Increment.Size = New System.Drawing.Size(66, 25)
        Me.B_Increment.TabIndex = 0
        Me.B_Increment.Text = "Increment"
        Me.B_Increment.UseVisualStyleBackColor = True
        '
        'B_Cancel
        '
        Me.B_Cancel.AutoSize = True
        Me.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Cancel.Location = New System.Drawing.Point(81, 34)
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Cancel.Size = New System.Drawing.Size(52, 25)
        Me.B_Cancel.TabIndex = 0
        Me.B_Cancel.Text = "Cancel"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.PTB)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(300, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ProgressTrackerBar"
        '
        'Test_ProgressTrackerBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(310, 0)
        Me.Name = "Test_ProgressTrackerBar"
        Me.Size = New System.Drawing.Size(329, 142)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_StartA As Button
    Friend WithEvents PTB As JANL.UserControls.ProgressTrackerBar
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents B_Cancel As Button
    Friend WithEvents B_StartM As Button
    Friend WithEvents B_Increment As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
