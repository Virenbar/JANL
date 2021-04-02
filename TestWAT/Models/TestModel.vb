Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Models

	Public Class TestModel
		Implements INotifyPropertyChanged
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

#End Region

#Region "Notify"

		Protected Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

	End Class
End Namespace