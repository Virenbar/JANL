Public Class DateLVI
    Inherits ListViewItem

    Public Sub New()
        Me.New(Today)
    End Sub

    Public Sub New([date] As Date)
        Me.Date = [date]
        Text = $"{Me.Date:yyyy.MM.dd}"
        SubItems.Add($"{Me.Date:yyyy}")
    End Sub

    Public Property [Date] As Date

End Class