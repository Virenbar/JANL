<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_YearPicker
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.YearPicker1 = New JANL.UserControls.YearPicker()
        Me.BS_TestObject = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearPicker2 = New JANL.UserControls.YearPicker()
        Me.B_Null = New System.Windows.Forms.Button()
        Me.B_2020 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BS_TestObject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "YearPicker"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.YearPicker1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.YearPicker2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.B_Null, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.B_2020, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(137, 58)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'YearPicker1
        '
        Me.YearPicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.YearPicker1.AutoSize = True
        Me.YearPicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestObject, "TestInteger", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.YearPicker1.Location = New System.Drawing.Point(69, 4)
        Me.YearPicker1.MinimumSize = New System.Drawing.Size(65, 0)
        Me.YearPicker1.Name = "YearPicker1"
        Me.YearPicker1.Size = New System.Drawing.Size(65, 20)
        Me.YearPicker1.TabIndex = 0
        '
        'BS_TestObject
        '
        Me.BS_TestObject.DataSource = GetType(JANL.Models.TestObject)
        '
        'YearPicker2
        '
        Me.YearPicker2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.YearPicker2.AutoSize = True
        Me.YearPicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestObject, "TestInteger", True))
        Me.YearPicker2.Location = New System.Drawing.Point(69, 33)
        Me.YearPicker2.MinimumSize = New System.Drawing.Size(65, 0)
        Me.YearPicker2.Name = "YearPicker2"
        Me.YearPicker2.Size = New System.Drawing.Size(65, 20)
        Me.YearPicker2.TabIndex = 0
        '
        'B_Null
        '
        Me.B_Null.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Null.AutoSize = True
        Me.B_Null.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_Null.Location = New System.Drawing.Point(3, 3)
        Me.B_Null.Name = "B_Null"
        Me.B_Null.Size = New System.Drawing.Size(60, 23)
        Me.B_Null.TabIndex = 1
        Me.B_Null.Text = "Set Null"
        Me.B_Null.UseVisualStyleBackColor = True
        '
        'B_2020
        '
        Me.B_2020.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_2020.AutoSize = True
        Me.B_2020.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_2020.Location = New System.Drawing.Point(3, 32)
        Me.B_2020.Name = "B_2020"
        Me.B_2020.Size = New System.Drawing.Size(60, 23)
        Me.B_2020.TabIndex = 1
        Me.B_2020.Text = "Set 2020"
        Me.B_2020.UseVisualStyleBackColor = True
        '
        'Test_YearPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Test_YearPicker"
        Me.Size = New System.Drawing.Size(143, 77)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BS_TestObject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents YearPicker1 As JANL.UserControls.YearPicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents YearPicker2 As JANL.UserControls.YearPicker
    Friend WithEvents BS_TestObject As BindingSource
    Friend WithEvents B_Null As Button
    Friend WithEvents B_2020 As Button
End Class
