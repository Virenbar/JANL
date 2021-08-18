Imports System.Drawing
Imports System.Threading.Tasks
Imports JANL.Extensions

Public MustInherit Class BaseRepository

	Protected Sub New(Name As String, KeyName As String, ValueName As String)
		Me.New(Name, KeyName, ValueName, New List(Of String)({ValueName}))
	End Sub

	Protected Sub New(Name As String, KeyName As String, ValueName As String, DGVFilter As IEnumerable(Of String))
		Me.Name = Name
		Me.KeyName = KeyName
		Me.ValueName = ValueName
		Me.DGVFilter = DGVFilter
	End Sub

	''' <summary>
	''' Получить список
	''' </summary>
	Public MustOverride Function GetList() As Task(Of DataTable)

#Region "Properties"

	Private _DGVTemplate As String = ""
	Private _Icon As Icon

	''' <summary>
	''' Столбцы для локального фильтра
	''' </summary>
	Public ReadOnly Property DGVFilter As IEnumerable(Of String)

	Public Property DGVTemplate As String
		Get
			Return _DGVTemplate
		End Get
		Protected Set
			_DGVTemplate = Value
		End Set
	End Property

	Public Property Icon As Icon
		Get
			Return _Icon
		End Get
		Protected Set(value As Icon)
			_Icon = value
		End Set
	End Property

	''' <summary>
	''' Имя поля ключа
	''' </summary>
	Public ReadOnly Property KeyName As String

	''' <summary>
	''' Наименование репозитория
	''' </summary>
	Public ReadOnly Property Name As String

	''' <summary>
	''' Имя поля значения
	''' </summary>
	Public ReadOnly Property ValueName As String

#Region "Reflection"

	Public ReadOnly Property CanCreate As Boolean
		Get
			Return [GetType]().IsOverride(NameOf(CreateItem))
		End Get
	End Property

	Public ReadOnly Property CanDelete As Boolean
		Get
			Return [GetType]().IsOverride(NameOf(DeleteItem))
		End Get
	End Property

	Public ReadOnly Property CanEdit As Boolean
		Get
			Return [GetType]().IsOverride(NameOf(EditItem))
		End Get
	End Property

	Public ReadOnly Property HasFilter As Boolean
		Get
			Return [GetType]().IsOverride(NameOf(GetFilter))
		End Get
	End Property

	Public ReadOnly Property HasMenu As Boolean
		Get
			Return [GetType]().IsOverride(NameOf(GetMenu))
		End Get
	End Property

#End Region

#End Region

#Region "Overridable"

	Private Const RepositoryError = "Некорректная конфигурация репозитория"

	''' <summary>
	''' Получить форму для создания
	''' </summary>
	Public Overridable Function CreateItem() As Form
		Throw New NotImplementedException(RepositoryError)
	End Function

	''' <summary>
	''' Выполнить удаление
	''' </summary>
	Public Overridable Sub DeleteItem(Key As Integer)
		Throw New NotImplementedException(RepositoryError)
	End Sub

	''' <summary>
	''' Получить форму для редактирования
	''' </summary>
	Public Overridable Function EditItem(Key As Integer) As Form
		Throw New NotImplementedException(RepositoryError)
	End Function

	''' <summary>
	''' Получить элемент управления с фильтрами
	''' </summary>
	Public Overridable Function GetFilter() As UserControl
		Throw New NotImplementedException(RepositoryError)
	End Function

	''' <summary>
	''' Получить список
	''' </summary>
	Public Overridable Function GetList(Filter As BaseFilter) As Task(Of DataTable)
		Return GetList()
	End Function

	''' <summary>
	''' Получить пункты меню
	''' </summary>
	''' <returns></returns>
	Public Overridable Function GetMenu() As List(Of MenuItem)
		Throw New NotImplementedException(RepositoryError)
	End Function

#End Region

	Public Class MenuItem
		Public Property Action As Action(Of Integer)
		Public Property Image As Image
		Public Property Text As String
	End Class
End Class