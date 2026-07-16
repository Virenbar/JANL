Imports JANL.Animators

Public Class TestSpinner
    Inherits Spinner

    Public Overrides ReadOnly Property Frames As IReadOnlyList(Of String)
        Get
            Return New List(Of String) From {"-", "=", "≡"}
        End Get
    End Property

    Public Overrides ReadOnly Property Interval As TimeSpan
        Get
            Return TimeSpan.FromMilliseconds(80)
        End Get
    End Property

End Class