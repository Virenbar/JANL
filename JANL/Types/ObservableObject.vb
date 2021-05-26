Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Types

	Public Class ObservableObject
		Implements INotifyPropertyChanged

		Protected Sub NotifyPropertyChanged(<CallerMemberName()> Optional propertyName As String = Nothing)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	End Class
End Namespace