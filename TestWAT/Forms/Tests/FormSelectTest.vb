Imports JANL.Forms

Public Class FormSelectTest

    Private Sub FormSelectTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_FTB_Empty_Click(sender As Object, e As EventArgs)
        Dim F = New FormTextBox("Empty")
        If F.ShowDialog() = DialogResult.OK Then
            L_Result.Text = F.Text
        End If
    End Sub

    Private Sub B_FTB_Text_Click(sender As Object, e As EventArgs) Handles B_FTB_Text.Click
        Dim F = New FormTextBox("Empty", "Text")
        If F.ShowDialog() = DialogResult.OK Then
            L_Result.Text = F.Text
        End If
    End Sub

#Region "ItemSelector"

    Private Sub B_LVDate_Click(sender As Object, e As EventArgs) Handles B_LVDate.Click
        Dim dates = New List(Of Date)
        For index = 1 To 10
            dates.Add(Today.AddDays(-1 - 3 * index))
        Next
        Dim items = dates.Select(Function(D) New DateLVI(D)).ToList()

        Using F = New FormItemSelector With {.Items = items, .ItemsPerPage = 20}
            If F.ShowDialog() = DialogResult.OK Then
                L_Result.Text = F.Selected(Of DateLVI).FirstOrDefault()?.Text
            End If
        End Using
    End Sub

#End Region

#Region "SelectBox"

    Private Sub B_Date_Click(sender As Object, e As EventArgs) Handles B_Date.Click
        Dim SB = New SelectBox() With {
            .Header = "Выберите дату",
            .Items = {New Date(2000, 1, 1), New Date(2010, 1, 1), New Date(2020, 1, 1)}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of Date)
            L_Result.Text = I.ToString()
        End If
    End Sub

    Private Sub B_String_Click(sender As Object, e As EventArgs) Handles B_String.Click
        Dim SB = New SelectBox With {
            .Header = "Выберите строку",
            .Items = {"(ﾉಥ益ಥ）ﾉ彡┻━┻", "¯\_(ツ)_/¯", "( ͡° ͜ʖ ͡°)"}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of String)
            L_Result.Text = I
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
            L_Result.Text = $"{I} - {I.MyDate}"
        End If
    End Sub

    Private Sub B_Enum_Click(sender As Object, e As EventArgs) Handles B_Enum.Click
        Dim SB = New SelectBox() With {
            .Header = "Выберите значение",
            .Items = {TestEnum.K1, TestEnum.K3}
        }
        If SB.ShowDialog(Me) = DialogResult.OK Then
            Dim I = SB.Item(Of TestEnum)
            L_Result.Text = $"{I} - {CInt(I)}"
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

#End Region

End Class