﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.MS_Main = New System.Windows.Forms.MenuStrip()
		Me.НижнийТагилToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.НаселениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.РазноеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ПочтаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImageViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FormAsyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PerfTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HashVSListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TestFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MS_Main.SuspendLayout()
		Me.SuspendLayout()
		'
		'MS_Main
		'
		Me.MS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestFormToolStripMenuItem, Me.PerfTestsToolStripMenuItem, Me.DaDataToolStripMenuItem, Me.НижнийТагилToolStripMenuItem, Me.ToolStripMenuItem1, Me.РазноеToolStripMenuItem})
		Me.MS_Main.Location = New System.Drawing.Point(0, 0)
		Me.MS_Main.Name = "MS_Main"
		Me.MS_Main.Size = New System.Drawing.Size(534, 24)
		Me.MS_Main.TabIndex = 0
		Me.MS_Main.Text = "MenuStrip1"
		'
		'НижнийТагилToolStripMenuItem
		'
		Me.НижнийТагилToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НаселениеToolStripMenuItem})
		Me.НижнийТагилToolStripMenuItem.Name = "НижнийТагилToolStripMenuItem"
		Me.НижнийТагилToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
		Me.НижнийТагилToolStripMenuItem.Text = "Нижний Тагил"
		'
		'НаселениеToolStripMenuItem
		'
		Me.НаселениеToolStripMenuItem.Name = "НаселениеToolStripMenuItem"
		Me.НаселениеToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.НаселениеToolStripMenuItem.Text = "Население"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
		Me.ToolStripMenuItem1.Text = "123"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(92, 22)
		Me.ToolStripMenuItem3.Text = "123"
		'
		'DaDataToolStripMenuItem
		'
		Me.DaDataToolStripMenuItem.Name = "DaDataToolStripMenuItem"
		Me.DaDataToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.DaDataToolStripMenuItem.Text = "DaData"
		'
		'РазноеToolStripMenuItem
		'
		Me.РазноеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПочтаToolStripMenuItem, Me.ImageViewerToolStripMenuItem, Me.FormAsyncToolStripMenuItem})
		Me.РазноеToolStripMenuItem.Name = "РазноеToolStripMenuItem"
		Me.РазноеToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.РазноеToolStripMenuItem.Text = "Разное"
		'
		'ПочтаToolStripMenuItem
		'
		Me.ПочтаToolStripMenuItem.Name = "ПочтаToolStripMenuItem"
		Me.ПочтаToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.ПочтаToolStripMenuItem.Text = "Почта"
		'
		'ImageViewerToolStripMenuItem
		'
		Me.ImageViewerToolStripMenuItem.Name = "ImageViewerToolStripMenuItem"
		Me.ImageViewerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.ImageViewerToolStripMenuItem.Text = "ImageViewer"
		'
		'FormAsyncToolStripMenuItem
		'
		Me.FormAsyncToolStripMenuItem.Name = "FormAsyncToolStripMenuItem"
		Me.FormAsyncToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.FormAsyncToolStripMenuItem.Text = "FormAsync"
		'
		'PerfTestsToolStripMenuItem
		'
		Me.PerfTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HashVSListToolStripMenuItem})
		Me.PerfTestsToolStripMenuItem.Name = "PerfTestsToolStripMenuItem"
		Me.PerfTestsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
		Me.PerfTestsToolStripMenuItem.Text = "PerfTests"
		'
		'HashVSListToolStripMenuItem
		'
		Me.HashVSListToolStripMenuItem.Name = "HashVSListToolStripMenuItem"
		Me.HashVSListToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
		Me.HashVSListToolStripMenuItem.Text = "HashVSList"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(447, 87)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TestFormToolStripMenuItem
		'
		Me.TestFormToolStripMenuItem.Name = "TestFormToolStripMenuItem"
		Me.TestFormToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
		Me.TestFormToolStripMenuItem.Text = "TestForm"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(534, 122)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.MS_Main)
		Me.MainMenuStrip = Me.MS_Main
		Me.Name = "MainForm"
		Me.Text = "Form1"
		Me.MS_Main.ResumeLayout(False)
		Me.MS_Main.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MS_Main As MenuStrip
    Friend WithEvents НижнийТагилToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НаселениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents DaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РазноеToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ПочтаToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImageViewerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PerfTestsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HashVSListToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FormAsyncToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TestFormToolStripMenuItem As ToolStripMenuItem
End Class
