<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOffice
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
        Me.B_Auto_1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_Auto_1
        '
        Me.B_Auto_1.AutoSize = True
        Me.B_Auto_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Auto_1.Location = New System.Drawing.Point(12, 12)
        Me.B_Auto_1.Name = "B_Auto_1"
        Me.B_Auto_1.Padding = New System.Windows.Forms.Padding(1)
        Me.B_Auto_1.Size = New System.Drawing.Size(98, 25)
        Me.B_Auto_1.TabIndex = 0
        Me.B_Auto_1.Text = "Auto Report #1"
        Me.B_Auto_1.UseVisualStyleBackColor = True
        '
        'FormOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TestWAT.My.MySettings.Default.BackColor
        Me.ClientSize = New System.Drawing.Size(380, 172)
        Me.Controls.Add(Me.B_Auto_1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TestWAT.My.MySettings.Default, "ForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.TestWAT.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TestWAT.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.TestWAT.My.MySettings.Default.Font
        Me.ForeColor = Global.TestWAT.My.MySettings.Default.ForeColor
        Me.Name = "FormOffice"
        Me.Text = "FormOffice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Auto_1 As Button
End Class
