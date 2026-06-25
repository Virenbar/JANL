<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_DragDrop
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
        Me.TB = New System.Windows.Forms.TextBox()
        Me.LB = New System.Windows.Forms.ListBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB
        '
        Me.TB.Dock = System.Windows.Forms.DockStyle.Top
        Me.TB.Location = New System.Drawing.Point(3, 16)
        Me.TB.Name = "TB"
        Me.TB.ReadOnly = True
        Me.TB.Size = New System.Drawing.Size(539, 20)
        Me.TB.TabIndex = 0
        '
        'LB
        '
        Me.LB.Dock = System.Windows.Forms.DockStyle.Top
        Me.LB.FormattingEnabled = True
        Me.LB.Location = New System.Drawing.Point(3, 36)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(539, 95)
        Me.LB.TabIndex = 1
        '
        'GB
        '
        Me.GB.AutoSize = True
        Me.GB.Controls.Add(Me.LB)
        Me.GB.Controls.Add(Me.TB)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Top
        Me.GB.Location = New System.Drawing.Point(0, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(545, 134)
        Me.GB.TabIndex = 2
        Me.GB.TabStop = False
        Me.GB.Text = "DragDrop"
        '
        'Test_DragDrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GB)
        Me.Name = "Test_DragDrop"
        Me.Size = New System.Drawing.Size(545, 332)
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB As TextBox
    Friend WithEvents LB As ListBox
    Friend WithEvents GB As GroupBox
End Class
