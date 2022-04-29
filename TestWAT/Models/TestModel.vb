Imports JANL.Types

Namespace Models

    Public Class TestModel
        Inherits ObservableObject
        Private Data As TestModelData

        Public Sub New()
            Data = New TestModelData()
        End Sub

#Region "Properties"

        Public Property TestDate As Date?
            Get
                Return Data.TestDate
            End Get
            Set
                If Data.TestDate = Value Then Return
                Data.TestDate = Value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Property TestString As String
            Get
                Return Data.TestString
            End Get
            Set
                If Data.TestString = Value Then Return
                Data.TestString = Value
                NotifyPropertyChanged()
            End Set
        End Property

#End Region

    End Class

    Public Class TestModelData
        Public Property TestDate As Date?
        Public Property TestString As String
    End Class
End Namespace