Imports JANL.Types

Namespace Models

	Public Class TestModel
		Inherits ObservableObject
		Private Data As Data.TestModelData

		Public Sub New()

		End Sub

#Region "Properties"

		Public Property TestDate As Date?
			Get
				Return Data.TestDate
			End Get
			Set(value As Date?)
				Data.TestDate = value
				NotifyPropertyChanged()
			End Set
		End Property

		Public Property TestString As String
			Get
				Return Data.TestString
			End Get
			Set(value As String)
				Data.TestString = value
				NotifyPropertyChanged()
			End Set
		End Property

#End Region

	End Class
End Namespace