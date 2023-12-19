Imports System.Management
Imports JANL.Animators.Spinner

Public Class MainForm

    Public Sub New()
        InitializeComponent()
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

    Private Sub DGVTEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DGVTEditorToolStripMenuItem.Click
        Dim F = New DGVTEdit()
        F.Show(Me)
    End Sub

    Private Sub FormAsyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormAsyncToolStripMenuItem.Click
        Dim F = New FormAsync()
        F.Show()
    End Sub

    Private Sub FormMDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormMDIToolStripMenuItem.Click
        Dim F = New FormMDI()
        F.Show(Me)
    End Sub

    Private Sub FormOfficeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormOfficeToolStripMenuItem.Click
        Dim F = New FormOffice()
        F.Show(Me)
    End Sub

    Private Sub HashVSListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HashVSListToolStripMenuItem.Click
        PerfomanceTests.HashVSList()
    End Sub

    Private Sub SelectTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTestToolStripMenuItem.Click
        FormSelectTest.Show()
    End Sub

    Private Sub TestFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFormToolStripMenuItem.Click
        Dim F = New FormTest()
        F.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MakeGood1()
    End Sub

    Private Sub TSMI_Address_Click(sender As Object, e As EventArgs) Handles TSMI_Address.Click
        FormAddressSuggest.Show()
    End Sub

    Private Sub TSMI_UL_Click(sender As Object, e As EventArgs) Handles TSMI_UL.Click
        FormULCheck.Show()
    End Sub

    Private Sub НаселениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НаселениеToolStripMenuItem.Click
        MakeGood("D:\Мои документы\Рабочий стол\Население Тагил\население 2019-1")
    End Sub

    Private Sub РосреестрToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РосреестрToolStripMenuItem.Click
        Reestr.Process()
    End Sub

#End Region

    Private Sub B_Animation_E_Click(sender As Object, e As EventArgs) Handles B_Animation_E.Click
        Dim F = New FormAnimationE()
        F.Show(Me)
    End Sub

    Private Sub B_Animations_Click(sender As Object, e As EventArgs) Handles B_Animations.Click
        Dim F = New FormAnimation()
        F.Show(Me)
    End Sub

    Private Sub B_SQL_Click(sender As Object, e As EventArgs) Handles B_SQL.Click
        Dim DT = SQLCommands.UP_PEP_DBList().Execute()
        Dim R = DT.Rows.Count
    End Sub

    Private Sub B_Beep_Click(sender As Object, e As EventArgs) Handles B_Beep.Click
        PlayStillAlive()
    End Sub

    Private Sub TS_Search_InputDone(sender As Object, e As EventArgs) Handles TS_Search.InputDone
        TB_Search.Text = TS_Search.Text
    End Sub

#End Region

End Class