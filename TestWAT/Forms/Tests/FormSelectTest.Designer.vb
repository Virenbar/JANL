<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectTest
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
        Dim B_FTB_Empty As System.Windows.Forms.Button
        Me.B_Date = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.L_Result = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_String = New System.Windows.Forms.Button()
        Me.B_Object = New System.Windows.Forms.Button()
        Me.B_Enum = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.B_FTB_Text = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_LVDate = New System.Windows.Forms.Button()
        B_FTB_Empty = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_FTB_Empty
        '
        B_FTB_Empty.AutoSize = True
        B_FTB_Empty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        B_FTB_Empty.Location = New System.Drawing.Point(3, 3)
        B_FTB_Empty.Name = "B_FTB_Empty"
        B_FTB_Empty.Size = New System.Drawing.Size(69, 23)
        B_FTB_Empty.TabIndex = 6
        B_FTB_Empty.Text = "FTB Empty"
        B_FTB_Empty.UseVisualStyleBackColor = True
        AddHandler B_FTB_Empty.Click, AddressOf Me.B_FTB_Empty_Click
        '
        'B_Date
        '
        Me.B_Date.Location = New System.Drawing.Point(64, 3)
        Me.B_Date.Name = "B_Date"
        Me.B_Date.Size = New System.Drawing.Size(75, 23)
        Me.B_Date.TabIndex = 0
        Me.B_Date.Text = "Date"
        Me.B_Date.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L_Result})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(592, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'L_Result
        '
        Me.L_Result.Name = "L_Result"
        Me.L_Result.Size = New System.Drawing.Size(12, 17)
        Me.L_Result.Text = "-"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Date)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_String)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Object)
        Me.FlowLayoutPanel1.Controls.Add(Me.B_Enum)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 29)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(592, 29)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SelectBox"
        '
        'B_String
        '
        Me.B_String.Location = New System.Drawing.Point(145, 3)
        Me.B_String.Name = "B_String"
        Me.B_String.Size = New System.Drawing.Size(75, 23)
        Me.B_String.TabIndex = 1
        Me.B_String.Text = "String"
        Me.B_String.UseVisualStyleBackColor = True
        '
        'B_Object
        '
        Me.B_Object.Location = New System.Drawing.Point(226, 3)
        Me.B_Object.Name = "B_Object"
        Me.B_Object.Size = New System.Drawing.Size(75, 23)
        Me.B_Object.TabIndex = 2
        Me.B_Object.Text = "Object"
        Me.B_Object.UseVisualStyleBackColor = True
        '
        'B_Enum
        '
        Me.B_Enum.Location = New System.Drawing.Point(307, 3)
        Me.B_Enum.Name = "B_Enum"
        Me.B_Enum.Size = New System.Drawing.Size(75, 23)
        Me.B_Enum.TabIndex = 3
        Me.B_Enum.Text = "Enum"
        Me.B_Enum.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(B_FTB_Empty)
        Me.FlowLayoutPanel2.Controls.Add(Me.B_FTB_Text)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 276)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(592, 29)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'B_FTB_Text
        '
        Me.B_FTB_Text.AutoSize = True
        Me.B_FTB_Text.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_FTB_Text.Location = New System.Drawing.Point(78, 3)
        Me.B_FTB_Text.Name = "B_FTB_Text"
        Me.B_FTB_Text.Size = New System.Drawing.Size(61, 23)
        Me.B_FTB_Text.TabIndex = 7
        Me.B_FTB_Text.Text = "FTB Text"
        Me.B_FTB_Text.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.B_LVDate)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(592, 29)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ItemSelector"
        '
        'B_LVDate
        '
        Me.B_LVDate.Location = New System.Drawing.Point(75, 3)
        Me.B_LVDate.Name = "B_LVDate"
        Me.B_LVDate.Size = New System.Drawing.Size(75, 23)
        Me.B_LVDate.TabIndex = 0
        Me.B_LVDate.Text = "Date"
        Me.B_LVDate.UseVisualStyleBackColor = True
        '
        'FormSelectTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 327)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FormSelectTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormSelectTest"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Date As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents L_Result As ToolStripStatusLabel
    Friend WithEvents B_String As Button
    Friend WithEvents B_Object As Button
    Friend WithEvents B_Enum As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents B_FTB_Text As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents B_LVDate As Button
End Class
