<Obsolete("Use SelectBox")>
Public Class SelectionBox(Of T)
    Private _Item As T = Nothing
    Private _Value As Object = Nothing

    Public Sub New()
        InitializeComponent()
        Text = "Окно выбора"
    End Sub

#Region "Properties"

    Public Property DisplayMember As String
        Get
            Return LB_Items.DisplayMember
        End Get
        Set(value As String)
            LB_Items.DisplayMember = value
        End Set
    End Property

    Public Property Items As IList(Of T) = New List(Of T)

    Public Property ListHeader As String
        Get
            Return L_Select.Text
        End Get
        Set(value As String)
            L_Select.Text = value
        End Set
    End Property

    Public Property SelectedItem As T
        Get
            Return _Item
        End Get
        Private Set(value As T)
            _Item = value
        End Set
    End Property

    Public Property SelectedValue As Object
        Get
            Return _Value
        End Get
        Private Set(value As Object)
            _Value = value
        End Set
    End Property

    Public Property ValueMember As String
        Get
            Return LB_Items.ValueMember
        End Get
        Set(value As String)
            Dim DM = LB_Items.DisplayMember 'Keep DM if its empty
            LB_Items.ValueMember = value
            LB_Items.DisplayMember = DM
        End Set
    End Property

#End Region

    Public Overloads Function ShowDialog(List As IList(Of T)) As DialogResult
        Items = List
        Return ShowDialog()
    End Function

    Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub B_Select_Click(sender As Object, e As EventArgs) Handles B_Select.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub LB_Items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Items.SelectedIndexChanged
        SelectedItem = DirectCast(LB_Items.SelectedItem, T)
        SelectedValue = LB_Items.SelectedValue
    End Sub

    Private Sub SelectionBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_Items.DataSource = Items
        B_Select.Enabled = Items.Count > 0
    End Sub

    Private Shadows Sub Show()
    End Sub

End Class