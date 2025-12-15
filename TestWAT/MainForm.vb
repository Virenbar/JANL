Imports System.Management
Imports JANL.Animators.Spinner
Imports JANL.Extensions

Public Class MainForm

    Public Sub New()
        InitializeComponent()
        Icon = My.Resources.shrek
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        TS_Spinner.Spinner = Predefined.Dots4
        TS_Spinner.Start()

        TS_Stopwatch.Start()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Q = "SELECT * FROM Win32_PnPEntity"
        Dim R = New ManagementObjectSearcher(Q).Get()
        Dim R1 = R.Cast(Of ManagementObject)().ToList()
        Dim R2 = R1.Select(Function(P) P.Properties("Name").Value.ToString()).ToList()
        Console.WriteLine(String.Join(vbNewLine, R2))
    End Sub

#Region "UIEvents"

#Region "Menu"

#Region "Forms"

    Private Sub MI_Animation_1_Click(sender As Object, e As EventArgs) Handles MI_Animation_1.Click
        Dim F = New FormAnimation()
        F.Show(Me)
    End Sub

    Private Sub MI_Animation_2_Click(sender As Object, e As EventArgs) Handles MI_Animation_2.Click
        Dim F = New FormAnimationE()
        F.Show(Me)
    End Sub

    Private Sub MI_Controls_Click(sender As Object, e As EventArgs) Handles MI_Controls.Click
        Dim F = New FormTest()
        F.ShowDialog(Me)
    End Sub

    Private Sub MI_FormOffice_Click(sender As Object, e As EventArgs) Handles MI_FormOffice.Click
        Dim F = New FormOffice()
        F.Show(Me)
    End Sub

    Private Sub MI_MDI_Click(sender As Object, e As EventArgs) Handles MI_MDI.Click
        Dim F = New FormMDI()
        F.Show(Me)
    End Sub

    Private Sub MI_Colors_Click(sender As Object, e As EventArgs) Handles MI_Colors.Click
        Dim F = New FormColors()
        F.Show(Me)
    End Sub

#End Region

#Region "Performance"

    Private Sub ArrayVSRegexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MI_ArrayVSRegex.Click
        PerfomanceTests.RegexVSArray()
    End Sub

    Private Sub HashVSListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MI_HashVSList.Click
        PerfomanceTests.HashVSList()
    End Sub

#End Region

#Region "Excel"

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MakeGood1()
    End Sub

    Private Sub НаселениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НаселениеToolStripMenuItem.Click
        MakeGood("D:\Мои документы\Рабочий стол\Население Тагил\население 2019-1")
    End Sub

    Private Sub РосреестрToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РосреестрToolStripMenuItem.Click
        Reestr.Process()
    End Sub

#End Region

#Region "Other"

    Private Sub DGVTEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DGVTEditorToolStripMenuItem.Click
        Dim F = New DGVTEdit()
        F.Show(Me)
    End Sub

    Private Sub FormAsyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormAsyncToolStripMenuItem.Click
        Dim F = New FormAsync()
        F.Show()
    End Sub

    Private Sub SelectTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTestToolStripMenuItem.Click
        FormSelectTest.Show()
    End Sub

#End Region

    Private Sub TSMI_Address_Click(sender As Object, e As EventArgs) Handles TSMI_Address.Click
        FormAddressSuggest.Show()
    End Sub

    Private Sub TSMI_UL_Click(sender As Object, e As EventArgs) Handles TSMI_UL.Click
        FormULCheck.Show()
    End Sub

#End Region

    Private Sub B_Beep_Click(sender As Object, e As EventArgs) Handles B_Beep.Click
        PlayStillAlive()
    End Sub

    Private Sub B_SQL_Click(sender As Object, e As EventArgs) Handles B_SQL.Click
        Dim DT = SQLCommands.UP_PEP_DBList().Execute()
        Dim R = DT.Rows.Count
    End Sub

    Private Sub B_Vowels_Click(sender As Object, e As EventArgs) Handles B_Vowels.Click
        VowelsBegone()
    End Sub

    Private Sub TS_Search_InputDone(sender As Object, e As EventArgs) Handles TS_Search.InputDone
        TB_Search.Text = TS_Search.Text
    End Sub

#End Region

End Class