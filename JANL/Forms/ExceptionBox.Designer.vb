<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExceptionBox
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExceptionBox))
		Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Узел1")
		Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Узел0", New System.Windows.Forms.TreeNode() {TreeNode1})
		Me.B_Copy = New System.Windows.Forms.Button()
		Me.B_MailTo = New System.Windows.Forms.Button()
		Me.L_Message = New System.Windows.Forms.Label()
		Me.TB_Message = New System.Windows.Forms.TextBox()
		Me.TB_Name = New System.Windows.Forms.TextBox()
		Me.L_Method = New System.Windows.Forms.Label()
		Me.TV_Exceptions = New System.Windows.Forms.TreeView()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.B_Ignore = New System.Windows.Forms.Button()
		Me.B_Exit = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TB_StackTrace = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.L_Type = New System.Windows.Forms.Label()
		Me.TB_Type = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.L_Description = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.L_Text = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'B_Copy
		'
		Me.B_Copy.AutoSize = True
		Me.B_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Copy.Image = CType(resources.GetObject("B_Copy.Image"), System.Drawing.Image)
		Me.B_Copy.Location = New System.Drawing.Point(2, 4)
		Me.B_Copy.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.B_Copy.Name = "B_Copy"
		Me.B_Copy.Size = New System.Drawing.Size(98, 25)
		Me.B_Copy.TabIndex = 1
		Me.B_Copy.Text = "Копировать"
		Me.B_Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Copy.UseVisualStyleBackColor = True
		'
		'B_MailTo
		'
		Me.B_MailTo.AutoSize = True
		Me.B_MailTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_MailTo.Image = CType(resources.GetObject("B_MailTo.Image"), System.Drawing.Image)
		Me.B_MailTo.Location = New System.Drawing.Point(104, 4)
		Me.B_MailTo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.B_MailTo.Name = "B_MailTo"
		Me.B_MailTo.Size = New System.Drawing.Size(143, 25)
		Me.B_MailTo.TabIndex = 2
		Me.B_MailTo.Text = "Отправить по почте"
		Me.B_MailTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_MailTo.UseVisualStyleBackColor = True
		'
		'L_Message
		'
		Me.L_Message.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.L_Message.AutoSize = True
		Me.L_Message.Location = New System.Drawing.Point(3, 223)
		Me.L_Message.Name = "L_Message"
		Me.L_Message.Size = New System.Drawing.Size(73, 15)
		Me.L_Message.TabIndex = 3
		Me.L_Message.Text = "Сообщение"
		'
		'TB_Message
		'
		Me.TB_Message.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_Message.Location = New System.Drawing.Point(82, 226)
		Me.TB_Message.Multiline = True
		Me.TB_Message.Name = "TB_Message"
		Me.TB_Message.ReadOnly = True
		Me.TB_Message.Size = New System.Drawing.Size(267, 160)
		Me.TB_Message.TabIndex = 4
		'
		'TB_Name
		'
		Me.TB_Name.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_Name.Location = New System.Drawing.Point(82, 197)
		Me.TB_Name.Name = "TB_Name"
		Me.TB_Name.ReadOnly = True
		Me.TB_Name.Size = New System.Drawing.Size(267, 23)
		Me.TB_Name.TabIndex = 6
		'
		'L_Method
		'
		Me.L_Method.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.L_Method.AutoSize = True
		Me.L_Method.Location = New System.Drawing.Point(34, 201)
		Me.L_Method.Name = "L_Method"
		Me.L_Method.Size = New System.Drawing.Size(42, 15)
		Me.L_Method.TabIndex = 5
		Me.L_Method.Text = "Метод"
		'
		'TV_Exceptions
		'
		Me.TableLayoutPanel3.SetColumnSpan(Me.TV_Exceptions, 2)
		Me.TV_Exceptions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TV_Exceptions.Location = New System.Drawing.Point(3, 3)
		Me.TV_Exceptions.Name = "TV_Exceptions"
		TreeNode1.Name = "Узел1"
		TreeNode1.Text = "Узел1"
		TreeNode2.Name = "Узел0"
		TreeNode2.Text = "Узел0"
		Me.TV_Exceptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
		Me.TV_Exceptions.Size = New System.Drawing.Size(346, 159)
		Me.TV_Exceptions.TabIndex = 7
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 435)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(867, 33)
		Me.TableLayoutPanel1.TabIndex = 10
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Controls.Add(Me.B_Copy)
		Me.FlowLayoutPanel2.Controls.Add(Me.B_MailTo)
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(249, 33)
		Me.FlowLayoutPanel2.TabIndex = 14
		Me.FlowLayoutPanel2.WrapContents = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Ignore)
		Me.FlowLayoutPanel1.Controls.Add(Me.B_Exit)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(705, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(162, 33)
		Me.FlowLayoutPanel1.TabIndex = 14
		Me.FlowLayoutPanel1.WrapContents = False
		'
		'B_Ignore
		'
		Me.B_Ignore.AutoSize = True
		Me.B_Ignore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Ignore.Location = New System.Drawing.Point(2, 4)
		Me.B_Ignore.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.B_Ignore.Name = "B_Ignore"
		Me.B_Ignore.Size = New System.Drawing.Size(87, 25)
		Me.B_Ignore.TabIndex = 4
		Me.B_Ignore.Text = "Продолжить"
		Me.B_Ignore.UseVisualStyleBackColor = True
		'
		'B_Exit
		'
		Me.B_Exit.AutoSize = True
		Me.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Exit.Image = CType(resources.GetObject("B_Exit.Image"), System.Drawing.Image)
		Me.B_Exit.Location = New System.Drawing.Point(93, 4)
		Me.B_Exit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.B_Exit.Name = "B_Exit"
		Me.B_Exit.Size = New System.Drawing.Size(67, 25)
		Me.B_Exit.TabIndex = 3
		Me.B_Exit.Text = "Выход"
		Me.B_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.B_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.B_Exit.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(358, 31)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 15)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "StackTrace"
		'
		'TB_StackTrace
		'
		Me.TB_StackTrace.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_StackTrace.Location = New System.Drawing.Point(358, 49)
		Me.TB_StackTrace.Multiline = True
		Me.TB_StackTrace.Name = "TB_StackTrace"
		Me.TB_StackTrace.ReadOnly = True
		Me.TB_StackTrace.Size = New System.Drawing.Size(501, 383)
		Me.TB_StackTrace.TabIndex = 9
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.L_Message, 0, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.TB_Message, 1, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.TB_Name, 1, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.L_Method, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.TV_Exceptions, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.L_Type, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.TB_Type, 1, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 46)
		Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 4
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(350, 389)
		Me.TableLayoutPanel3.TabIndex = 12
		'
		'L_Type
		'
		Me.L_Type.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.L_Type.AutoSize = True
		Me.L_Type.Location = New System.Drawing.Point(48, 172)
		Me.L_Type.Name = "L_Type"
		Me.L_Type.Size = New System.Drawing.Size(28, 15)
		Me.L_Type.TabIndex = 5
		Me.L_Type.Text = "Тип"
		'
		'TB_Type
		'
		Me.TB_Type.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TB_Type.Location = New System.Drawing.Point(82, 168)
		Me.TB_Type.Name = "TB_Type"
		Me.TB_Type.ReadOnly = True
		Me.TB_Type.Size = New System.Drawing.Size(267, 23)
		Me.TB_Type.TabIndex = 6
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 2
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.Label3, 1, 1)
		Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel3, 0, 2)
		Me.TableLayoutPanel4.Controls.Add(Me.TB_StackTrace, 1, 2)
		Me.TableLayoutPanel4.Controls.Add(Me.L_Description, 0, 1)
		Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
		Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(5, 7, 5, 0)
		Me.TableLayoutPanel4.RowCount = 3
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(867, 435)
		Me.TableLayoutPanel4.TabIndex = 13
		'
		'L_Description
		'
		Me.L_Description.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.L_Description.AutoSize = True
		Me.L_Description.Location = New System.Drawing.Point(8, 31)
		Me.L_Description.Name = "L_Description"
		Me.L_Description.Size = New System.Drawing.Size(110, 15)
		Me.L_Description.TabIndex = 13
		Me.L_Description.Text = "Описание ошибки"
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel4.SetColumnSpan(Me.FlowLayoutPanel3, 2)
		Me.FlowLayoutPanel3.Controls.Add(Me.L_Text)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(8, 10)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(851, 18)
		Me.FlowLayoutPanel3.TabIndex = 15
		'
		'L_Text
		'
		Me.L_Text.AutoSize = True
		Me.L_Text.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.L_Text.Location = New System.Drawing.Point(3, 0)
		Me.L_Text.Name = "L_Text"
		Me.L_Text.Size = New System.Drawing.Size(574, 18)
		Me.L_Text.TabIndex = 14
		Me.L_Text.Text = "Произошла непредвиденная ошибка. Стабильная работа приложения не гарантируется."
		'
		'ExceptionBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.ClientSize = New System.Drawing.Size(867, 468)
		Me.Controls.Add(Me.TableLayoutPanel4)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.MinimumSize = New System.Drawing.Size(800, 440)
		Me.Name = "ExceptionBox"
		Me.Text = "Необработанная ошибка"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents B_Copy As Button
	Friend WithEvents B_MailTo As Button
	Friend WithEvents L_Message As Label
	Friend WithEvents TB_Message As TextBox
	Friend WithEvents TB_Name As TextBox
	Friend WithEvents L_Method As Label
	Friend WithEvents TV_Exceptions As TreeView
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents TB_StackTrace As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents B_Exit As Button
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents B_Ignore As Button
	Friend WithEvents L_Type As Label
	Friend WithEvents TB_Type As TextBox
	Friend WithEvents L_Description As Label
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents L_Text As Label
End Class
