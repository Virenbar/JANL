Imports JANL.Models

Public Class DecadeLVI
    Inherits ListViewItem

    Public Sub New(decade As Decade)
        Me.Decade = decade

        Text = Me.Decade.Name
        SubItems.Add($"{Me.Decade.Date:yyyy}")
    End Sub

    Public ReadOnly Property [Date] As Date
        Get
            Return Decade.Date
        End Get
    End Property

    Public ReadOnly Property Decade As Decade

    Public Overloads ReadOnly Property Name As String
        Get
            Return Decade.Name
        End Get
    End Property

End Class