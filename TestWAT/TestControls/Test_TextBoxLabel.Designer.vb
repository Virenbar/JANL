<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_TextBoxLabel
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B_LabelColor = New System.Windows.Forms.Button()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.TBL = New JANL.Controls.TextBoxLabel()
        Me.B_ForeColor = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CD = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.B_LabelColor, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TBL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.B_ForeColor, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(165, 58)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'B_LabelColor
        '
        Me.B_LabelColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_LabelColor.AutoSize = True
        Me.B_LabelColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_LabelColor.Location = New System.Drawing.Point(119, 3)
        Me.B_LabelColor.Name = "B_LabelColor"
        Me.B_LabelColor.Size = New System.Drawing.Size(43, 23)
        Me.B_LabelColor.TabIndex = 1
        Me.B_LabelColor.Text = "Label"
        Me.B_LabelColor.UseVisualStyleBackColor = True
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(3, 32)
        Me.TB.Name = "TB"
        Me.TB.ReadOnly = True
        Me.TB.Size = New System.Drawing.Size(110, 20)
        Me.TB.TabIndex = 2
        '
        'TBL
        '
        Me.TBL.Label = "Заголовок"
        Me.TBL.Location = New System.Drawing.Point(3, 3)
        Me.TBL.Name = "TBL"
        Me.TBL.Size = New System.Drawing.Size(110, 20)
        Me.TBL.TabIndex = 1
        '
        'B_ForeColor
        '
        Me.B_ForeColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_ForeColor.AutoSize = True
        Me.B_ForeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_ForeColor.Location = New System.Drawing.Point(119, 32)
        Me.B_ForeColor.Name = "B_ForeColor"
        Me.B_ForeColor.Size = New System.Drawing.Size(43, 23)
        Me.B_ForeColor.TabIndex = 1
        Me.B_ForeColor.Text = "Fore"
        Me.B_ForeColor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TextBoxLabel"
        '
        'Test_TextBoxLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Test_TextBoxLabel"
        Me.Size = New System.Drawing.Size(174, 80)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB As TextBox
    Friend WithEvents TBL As JANL.Controls.TextBoxLabel
    Friend WithEvents B_LabelColor As Button
    Friend WithEvents CD As ColorDialog
    Friend WithEvents B_ForeColor As Button
End Class
