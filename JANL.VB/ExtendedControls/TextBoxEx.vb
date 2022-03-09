Imports System.ComponentModel
Imports System.Drawing
Imports Microsoft.VisualBasic

''' <summary>
''' TextBox with Label
''' </summary>
Public Class TextBoxEx
    Inherits TextBox
    Private Const LabelPrefix = ChrW(8203) + ChrW(8203)
    Friend WithEvents PB_Clear As PictureBox
    Private LabelStr As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Controls.Add(PB_Clear)
        PB_Clear.Location = New Point(-10, 0) ' = New Point((Height \ 2) - (PB_Clear.Height \ 2), Width - PB_Clear.Width - 2)

        MyBase.Text = LabelPrefix
        ForeColor = Color.Black
        LabelColor = Color.SlateGray
        Label = ""
    End Sub

#Region "Properties"

#Region "Designer"

    <Browsable(True), Category("Appearance"), DefaultValue(GetType(Color), "0x000000")>
    Public Shadows Property ForeColor As Color

    <Browsable(True), Category("Appearance"), DefaultValue(""), Description("Label")>
    Public Property Label As String
        Get
            Return LabelStr.Substring(2)
        End Get
        Set(value As String)
            LabelStr = LabelPrefix + value
            If IsLabel() Then MyBase.Text = LabelStr
            UpdateColor()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), DefaultValue(GetType(Color), "0x708090"), Description("Label color")>
    Public Property LabelColor As Color

    <Browsable(True), Category("Appearance"), DefaultValue("")>
    Public Shadows Property Text As String
        Get
            Return If(IsLabel(), "", MyBase.Text)
        End Get
        Set(value As String)
            'TextStr = value
            MyBase.Text = If(value?.Length = 0, LabelStr, value)
            UpdateColor()
        End Set
    End Property

#End Region

    <Browsable(False)>
    Public ReadOnly Property IsLabel As Boolean
        Get
            Return MyBase.Text.Length >= 2 AndAlso MyBase.Text.Substring(0, 2) = LabelPrefix
        End Get
    End Property

#End Region

#Region "Overrides"

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        If IsLabel Then Clear()
        MyBase.OnGotFocus(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        If MyBase.Text.Length = 0 Then MyBase.Text = LabelStr
        MyBase.OnLostFocus(e)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        UpdateColor()
        MyBase.OnTextChanged(e)
    End Sub

#End Region

    Private Sub UpdateColor()
        MyBase.ForeColor = If(IsLabel, LabelColor, ForeColor)
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextBoxEx))
        Me.PB_Clear = New System.Windows.Forms.PictureBox()
        CType(Me.PB_Clear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Clear
        '
        Me.PB_Clear.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PB_Clear.BackColor = System.Drawing.Color.Transparent
        Me.PB_Clear.Image = CType(resources.GetObject("PB_Clear.Image"), System.Drawing.Image)
        Me.PB_Clear.Location = New System.Drawing.Point(0, 0)
        Me.PB_Clear.Name = "PB_Clear"
        Me.PB_Clear.Size = New System.Drawing.Size(16, 16)
        Me.PB_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Clear.TabIndex = 0
        Me.PB_Clear.TabStop = False
        CType(Me.PB_Clear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

        Controls.Add(PB_Clear)
    End Sub

    Private Sub PB_Clear_Click(sender As Object, e As EventArgs) Handles PB_Clear.Click

    End Sub

End Class