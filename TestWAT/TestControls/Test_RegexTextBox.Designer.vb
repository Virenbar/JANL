<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_RegexTextBox
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RegexTextBox1 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox2 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox3 = New JANL.Controls.RegexTextBox()
        Me.RegexTextBox4 = New JANL.Controls.RegexTextBox()
        Me.GroupBox6.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(140, 123)
        Me.GroupBox6.TabIndex = 20
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
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(134, 104)
        Me.FlowLayoutPanel2.TabIndex = 0
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'RegexTextBox1
        '
        Me.RegexTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RegexTextBox1.Message = Nothing
        Me.RegexTextBox1.Name = "RegexTextBox1"
        Me.RegexTextBox1.Pattern = "^4\d{9}$"
        Me.RegexTextBox1.Size = New System.Drawing.Size(128, 20)
        Me.RegexTextBox1.TabIndex = 18
        '
        'RegexTextBox2
        '
        Me.RegexTextBox2.Location = New System.Drawing.Point(3, 29)
        Me.RegexTextBox2.Message = Nothing
        Me.RegexTextBox2.Name = "RegexTextBox2"
        Me.RegexTextBox2.Pattern = "^4\d{9}$"
        Me.RegexTextBox2.Required = True
        Me.RegexTextBox2.Size = New System.Drawing.Size(128, 20)
        Me.RegexTextBox2.TabIndex = 19
        '
        'RegexTextBox3
        '
        Me.RegexTextBox3.Location = New System.Drawing.Point(3, 55)
        Me.RegexTextBox3.Message = Nothing
        Me.RegexTextBox3.Name = "RegexTextBox3"
        Me.RegexTextBox3.Pattern = "^\d{1,10}$"
        Me.RegexTextBox3.Required = True
        Me.RegexTextBox3.Size = New System.Drawing.Size(128, 20)
        Me.RegexTextBox3.TabIndex = 20
        '
        'RegexTextBox4
        '
        Me.RegexTextBox4.Location = New System.Drawing.Point(3, 81)
        Me.RegexTextBox4.Message = Nothing
        Me.RegexTextBox4.Name = "RegexTextBox4"
        Me.RegexTextBox4.Size = New System.Drawing.Size(128, 20)
        Me.RegexTextBox4.TabIndex = 21
        '
        'Test_RegexTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "Test_RegexTextBox"
        Me.Size = New System.Drawing.Size(146, 129)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents RegexTextBox1 As JANL.Controls.RegexTextBox
    Friend WithEvents RegexTextBox2 As JANL.Controls.RegexTextBox
    Friend WithEvents RegexTextBox3 As JANL.Controls.RegexTextBox
    Friend WithEvents RegexTextBox4 As JANL.Controls.RegexTextBox
End Class
