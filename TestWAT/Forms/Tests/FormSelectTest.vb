Imports JANL
Imports JANL.Forms
Imports JANL.Models

Public Class FormSelectTest

    Private Sub FormSelectTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Owner?.Icon
    End Sub

#Region "ItemSelector"

    Private Sub B_LVDate_Click(sender As Object, e As EventArgs) Handles B_LVDate.Click
        Dim dates = New List(Of Date)
        For index = 1 To 50
            dates.Add(Today.AddDays(-1 - 3 * index))
        Next
        Dim items = dates.Select(Function(D) New DateLVI(D)).ToList()

        Using F = New FormItemSelector With {.Items = items, .ItemsPerPage = 20}
            If F.ShowDialog(Me) = DialogResult.OK Then
                Dim item = F.Selected(Of DateLVI).FirstOrDefault()
                L_Result.Text = item?.Text
            End If
        End Using
    End Sub

    Private Sub B_LVObject_Click(sender As Object, e As EventArgs) Handles B_LVObject.Click
        Dim items = Decade.GetDecades().Select(Function(D) New DecadeLVI(D)).ToList()

        Using F = New FormItemSelector With {.Items = items, .ItemsPerPage = 20}
            If F.ShowDialog(Me) = DialogResult.OK Then
                Dim item = F.Selected(Of DecadeLVI).FirstOrDefault()
                L_Result.Text = item?.Text
            End If
        End Using
    End Sub

#End Region

#Region "SelectBox"

    Private Sub B_Date_Click(sender As Object, e As EventArgs) Handles B_Date.Click
        Using SB = New SelectBox() With {
            .Header = "Выберите дату",
            .Items = {New Date(2000, 1, 1), New Date(2010, 1, 1), New Date(2020, 1, 1)}}

            If SB.ShowDialog(Me) = DialogResult.OK Then
                Dim I = SB.Item(Of Date)
                L_Result.Text = I.ToString()
            End If
        End Using
    End Sub

    Private Sub B_Enum_Click(sender As Object, e As EventArgs) Handles B_Enum.Click
        Using SB = New SelectBox() With {
            .Header = "Выберите значение",
            .Items = {TestEnum.K1, TestEnum.K3}}

            If SB.ShowDialog(Me) = DialogResult.OK Then
                Dim I = SB.Item(Of TestEnum)
                L_Result.Text = $"{I} - {CInt(I)}"
            End If
        End Using
    End Sub

    Private Sub B_Object_Click(sender As Object, e As EventArgs) Handles B_Object.Click
        Using SB = New SelectBox() With {
            .Header = "Выберите период",
            .DisplayMember = "MyDate",
            .Items = Decade.GetDecades()}

            If SB.ShowDialog(Me) = DialogResult.OK Then
                Dim I = SB.Item(Of Decade)
                L_Result.Text = $"{I} - {I.Date}"
            End If
        End Using
    End Sub

    Private Sub B_String_Click(sender As Object, e As EventArgs) Handles B_String.Click
        Using SB = New SelectBox With {
            .Header = "Выберите строку",
            .Items = {"(ﾉಥ益ಥ）ﾉ彡┻━┻", "¯\_(ツ)_/¯", "( ͡° ͜ʖ ͡°)"}}

            If SB.ShowDialog(Me) = DialogResult.OK Then
                Dim I = SB.Item(Of String)
                L_Result.Text = I
            End If
        End Using
    End Sub

#End Region

#Region "FormTextBox"

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

#End Region

End Class