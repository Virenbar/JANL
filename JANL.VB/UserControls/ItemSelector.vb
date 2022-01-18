Option Strict On

Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

<Designer(GetType(HResizeOnly))>
Public Class ItemSelector
	Implements INotifyPropertyChanged

	Private Repository As BaseRepository
	Private Source As Func(Of Integer, String) = Function() ""

	Public Sub New()
		InitializeComponent()
		SetStyle(ControlStyles.FixedHeight, True)
	End Sub

	Public Sub Init(Repository As BaseRepository)
		Me.Repository = Repository
		Me.Source = AddressOf Repository.GetValue
	End Sub

	<Obsolete>
	Public Sub Init(Repository As BaseRepository, Source As Func(Of Integer, String))
		Me.Repository = Repository
		Me.Source = Source
	End Sub

	Public Sub RefreshValue()
		If Key.HasValue Then Value = Source(Key.Value)
	End Sub

	<Obsolete>
	Public Async Function RefreshValueAsync() As Task
		If Key.HasValue Then Value = Await Task.Run(Function() Source(Key.Value))
	End Function

	Public Sub SetKey(Key As Integer)
		Me.Key = Key
		RefreshValue()
	End Sub

	Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
		height = 23
		MyBase.SetBoundsCore(x, y, width, height, specified)
	End Sub

	Private Sub B_Select_Click(sender As Object, e As EventArgs) Handles B_Select.Click
		Using FS = New FormSelect(Repository) With {.AutoLoad = True, .Key = If(Key, 0)}
			Dim R = FS.ShowDialog()
			If R = DialogResult.OK Then
				Key = FS.Key
				Value = FS.Value
			End If
		End Using
	End Sub

#Region "Properties"

	Private _Key As Integer?

	<Bindable(True), RefreshProperties(RefreshProperties.All), DefaultValue(GetType(Integer?), Nothing)>
	Public Property Key As Integer?
		Get
			Return _Key
		End Get
		Set
			_Key = Value
			NotifyPropertyChanged()
			OnKeyChanged()
		End Set
	End Property

	Public Property Value As String
		Get
			Return TB_Value.Text
		End Get
		Private Set
			TB_Value.Text = Value
			TT_Value.SetToolTip(TB_Value, Value)
			OnValueChanged()
		End Set
	End Property

#End Region

#Region "Events"

	Protected Sub OnKeyChanged()
		RaiseEvent KeyChanged()
	End Sub

	Protected Sub OnValueChanged()
		RaiseEvent ValueChanged()
	End Sub

	Public Event KeyChanged()

	Public Event ValueChanged()

#End Region

#Region "INotifyPropertyChanged"

	Protected Sub NotifyPropertyChanged(<CallerMemberName()> Optional propertyName As String = Nothing)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	End Sub

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

End Class