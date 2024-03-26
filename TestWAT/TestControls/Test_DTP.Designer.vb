<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_DTP
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimeS1 = New JANL.DateTimePickerEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B_DateNull = New System.Windows.Forms.Button()
        Me.B_Date2000 = New System.Windows.Forms.Button()
        Me.DateTimeS2 = New JANL.DateTimePickerEx()
        Me.BS_TestModel = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 106)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TestDate"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimeS1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimeS2, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(173, 87)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'DateTimeS1
        '
        Me.DateTimeS1.CustomFormat = "dd.MM.yyyy g"
        Me.DateTimeS1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True))
        Me.DateTimeS1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeS1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimeS1.Name = "DateTimeS1"
        Me.DateTimeS1.Size = New System.Drawing.Size(167, 20)
        Me.DateTimeS1.TabIndex = 0
        Me.DateTimeS1.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.B_DateNull, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.B_Date2000, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 29)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'B_DateNull
        '
        Me.B_DateNull.Location = New System.Drawing.Point(84, 3)
        Me.B_DateNull.Name = "B_DateNull"
        Me.B_DateNull.Size = New System.Drawing.Size(75, 23)
        Me.B_DateNull.TabIndex = 3
        Me.B_DateNull.Text = "SetNull"
        Me.B_DateNull.UseVisualStyleBackColor = True
        '
        'B_Date2000
        '
        Me.B_Date2000.Location = New System.Drawing.Point(3, 3)
        Me.B_Date2000.Name = "B_Date2000"
        Me.B_Date2000.Size = New System.Drawing.Size(75, 23)
        Me.B_Date2000.TabIndex = 1
        Me.B_Date2000.Text = "Set2000"
        Me.B_Date2000.UseVisualStyleBackColor = True
        '
        'DateTimeS2
        '
        Me.DateTimeS2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_TestModel, "TestDate", True))
        Me.DateTimeS2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeS2.Location = New System.Drawing.Point(3, 64)
        Me.DateTimeS2.Name = "DateTimeS2"
        Me.DateTimeS2.Size = New System.Drawing.Size(167, 20)
        Me.DateTimeS2.TabIndex = 4
        Me.DateTimeS2.Value = New Date(2021, 2, 24, 15, 10, 56, 363)
        '
        'BS_TestModel
        '
        Me.BS_TestModel.DataSource = GetType(JANL.Models.TestObject)
        '
        'Test_DTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Test_DTP"
        Me.Size = New System.Drawing.Size(185, 112)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BS_TestModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DateTimeS1 As JANL.DateTimePickerEx
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents B_DateNull As Button
    Friend WithEvents B_Date2000 As Button
    Friend WithEvents DateTimeS2 As JANL.DateTimePickerEx
    Friend WithEvents BS_TestModel As BindingSource
End Class
