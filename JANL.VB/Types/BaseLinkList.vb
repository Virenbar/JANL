Imports System.Drawing
Imports System.Threading.Tasks
Imports JANL.Extensions
Imports JANL.Types

<Obsolete>
Public MustInherit Class BaseLinkList

    Protected Sub New(Parent As Integer, KeyName As String)
        Me.Parent = Parent
        Me.KeyName = KeyName
    End Sub

    ''' <summary>
    ''' Обновить список
    ''' </summary>
    Public MustOverride Function GetList() As Task(Of DataTable)

#Region "Properties"

    Private _DGVTemplate As DGVTemplate

    Public Property DGVTemplate As DGVTemplate
        Get
            Return _DGVTemplate
        End Get
        Protected Set
            _DGVTemplate = Value
        End Set
    End Property

    ''' <summary>
    ''' Имя поля ключа потомка
    ''' </summary>
    Public ReadOnly Property KeyName As String

    ''' <summary>
    ''' Ключ родителя
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Parent As Integer

#Region "Reflection"

    Public ReadOnly Property CanEdit As Boolean
        Get
            Return [GetType]().IsOverride(NameOf(EditItem))
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

    Private Const RepositoryError = "Некорректная конфигурация"

    ''' <summary>
    ''' Получить форму для редактирования
    ''' <remarks>Не вызывать отображение формы!</remarks>
    ''' </summary>
    Public Overridable Function EditItem(Key As Integer) As Form
        Throw New NotImplementedException(RepositoryError)
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