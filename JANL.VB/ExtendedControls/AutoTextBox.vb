Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

''' <summary>
''' Text
''' </summary>
<Obsolete>
Public Class AutoTextBox
    Inherits TextBox
    Implements INotifyPropertyChanged

    Private Source As Func(Of Integer, String) = Function() ""

    Public Sub New()
        MyBase.New()
        MyBase.[ReadOnly] = True
    End Sub

    Public Sub Init(Source As Func(Of Integer, String))
        Me.Source = Source
    End Sub

    Public Sub RefreshValue()
        If Key.HasValue Then Text = Source(Key.Value)
    End Sub

    Public Async Function RefreshValueAsync() As Task
        If Key.HasValue Then Text = Await Task.Run(Function() Source(Key.Value))
    End Function

    Public Sub SetKey(Key As Integer)
        Me.Key = Key
        RefreshValue()
    End Sub

#Region "Properties"

    Private _Key As Integer?

    Public Shadows ReadOnly Property [ReadOnly] As Boolean
        Get
            Return MyBase.[ReadOnly]
        End Get
    End Property

    <Bindable(True), RefreshProperties(RefreshProperties.All), DefaultValue(GetType(Integer?), Nothing)>
    Public Property Key As Integer?
        Get
            Return _Key
        End Get
        Set
            _Key = Value
            NotifyPropertyChanged()
        End Set
    End Property

#End Region

#Region "Events"

    Protected Sub OnKeyChanged()
        RaiseEvent KeyChanged()
    End Sub

    Public Event KeyChanged()

#End Region

#Region "INotifyPropertyChanged"

    Protected Sub NotifyPropertyChanged(<CallerMemberName()> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

End Class