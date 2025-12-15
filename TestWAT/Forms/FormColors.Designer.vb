<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormColors
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLP_Dark = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLP_Light = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AstroStatusPanel2 = New JANL.Controls.AstroStatusPanel()
        Me.FLP_Dark.SuspendLayout()
        Me.FLP_Light.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 50)
        Me.Panel1.TabIndex = 0
        '
        'FLP_Dark
        '
        Me.FLP_Dark.AutoSize = True
        Me.FLP_Dark.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FLP_Dark.Controls.Add(Me.Panel1)
        Me.FLP_Dark.Controls.Add(Me.AstroStatusPanel2)
        Me.FLP_Dark.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_Dark.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Dark.Name = "FLP_Dark"
        Me.FLP_Dark.Padding = New System.Windows.Forms.Padding(10)
        Me.FLP_Dark.Size = New System.Drawing.Size(176, 450)
        Me.FLP_Dark.TabIndex = 1
        '
        'FLP_Light
        '
        Me.FLP_Light.AutoSize = True
        Me.FLP_Light.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FLP_Light.Controls.Add(Me.Panel3)
        Me.FLP_Light.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_Light.Location = New System.Drawing.Point(176, 0)
        Me.FLP_Light.Name = "FLP_Light"
        Me.FLP_Light.Padding = New System.Windows.Forms.Padding(10)
        Me.FLP_Light.Size = New System.Drawing.Size(176, 450)
        Me.FLP_Light.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(13, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(150, 50)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 46)
        Me.Panel2.TabIndex = 1
        '
        'AstroStatusPanel2
        '
        Me.AstroStatusPanel2.Location = New System.Drawing.Point(13, 69)
        Me.AstroStatusPanel2.Name = "AstroStatusPanel2"
        Me.AstroStatusPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.AstroStatusPanel2.Size = New System.Drawing.Size(150, 50)
        Me.AstroStatusPanel2.TabIndex = 2
        '
        'FormColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 450)
        Me.Controls.Add(Me.FLP_Light)
        Me.Controls.Add(Me.FLP_Dark)
        Me.Name = "FormColors"
        Me.Text = "FormColors"
        Me.FLP_Dark.ResumeLayout(False)
        Me.FLP_Light.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FLP_Dark As FlowLayoutPanel
    Friend WithEvents FLP_Light As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AstroStatusPanel2 As JANL.Controls.AstroStatusPanel
End Class
