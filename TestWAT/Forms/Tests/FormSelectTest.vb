Imports JANL
Imports JANL.Forms

Public Class FormSelectTest

    Private Sub B_Date_Click(sender As Object, e As EventArgs) Handles B_Date.Click
        Dim SB = New SelectBox() With {
            .Header = "Выберите дату",
            .Items = {New Date(2000, 1, 1), New Date(2010, 1, 1), New Date(2020, 1, 1)}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of Date)
            TSSL_Result.Text = I.ToString()
        End If
    End Sub

    Private Sub B_String_Click(sender As Object, e As EventArgs) Handles B_String.Click
        Dim SB = New SelectBox With {
            .Header = "Выберите строку",
            .Items = {"(ﾉಥ益ಥ）ﾉ彡┻━┻", "¯\_(ツ)_/¯", "( ͡° ͜ʖ ͡°)"}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of String)
            TSSL_Result.Text = I
        End If
    End Sub

    Private Sub B_Object_Click(sender As Object, e As EventArgs) Handles B_Object.Click
        Dim SB = New SelectBox() With {
            .Header = "Выберите период",
            .DisplayMember = "MyDate",
            .Items = {
                New TestObject("Нулевые", New Date(2000, 1, 1)),
                New TestObject("Десятые", New Date(2010, 1, 1)),
                New TestObject("Двадцатые", New Date(2020, 1, 1))}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of TestObject)
            TSSL_Result.Text = $"{I} - {I.MyDate}"
        End If
    End Sub

    Private Sub B_Enum_Click(sender As Object, e As EventArgs) Handles B_Enum.Click
        Dim SB = New SelectBox() With {
            .Header = "Выберите значение",
            .Items = {TestEnum.K1, TestEnum.K3}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of TestEnum)
            TSSL_Result.Text = $"{I} - {CInt(I)}"
        End If
    End Sub

    Private Class TestObject

        Public Sub New(_name As String, _date As Date)
            Name = _name
            MyDate = _date
        End Sub

        Public Property Name As String
        Public Property MyDate As Date

        Public Overrides Function ToString() As String
            Return $"{Name} - {MyDate:yyyy}"
        End Function

    End Class

    Private Enum TestEnum
        K1
        K2
        K3
        K4
    End Enum

    Private Sub B_FormSelect_Click(sender As Object, e As EventArgs) Handles B_FormSelect.Click
        'Dim F = New FormSelect(New TestRepository())
        'F.ShowDialog()
    End Sub

    Private Sub FormSelectTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'AutoTextBox1.Init(AddressOf TestRepository.GetValueS)

        'AutoTextBox1.RefreshValue()
    End Sub

    Private Sub B_FTB_Empty_Click(sender As Object, e As EventArgs)
        Dim F = New FormTextBox("Empty")
        If F.ShowDialog() = DialogResult.OK Then
            TSSL_Result.Text = F.Text
        End If
    End Sub

    Private Sub B_FTB_Text_Click(sender As Object, e As EventArgs) Handles B_FTB_Text.Click
        Dim F = New FormTextBox("Empty", "Text")
        If F.ShowDialog() = DialogResult.OK Then
            TSSL_Result.Text = F.Text
        End If
    End Sub

End Class