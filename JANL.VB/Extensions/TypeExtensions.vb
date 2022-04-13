Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace Extensions
    Public Module TypeExtensions
        Private ReadOnly Rnd As New Random(Date.Now.Millisecond)

        ''' <summary>
        ''' Помечает все строки на удаление
        ''' </summary>
        ''' <param name="dt"></param>
        <Extension>
        Public Sub DeleteAll(dt As DataTable)
            Dim RemoveRowsTable = dt
            Dim i = 0
            'Remove All
            While i < RemoveRowsTable.Rows.Count
                Dim currentRow = RemoveRowsTable.Rows(i)
                If (currentRow.RowState <> DataRowState.Deleted) Then
                    currentRow.Delete()
                Else
                    i += 1
                End If
            End While
        End Sub

        ''' <summary>
        ''' Первый день месяца
        ''' </summary>
        <Extension>
        Public Function FirstDay(D As Date) As Date
            Return New Date(D.Year, D.Month, 1)
        End Function

        ''' <summary>
        ''' Последний день месяца
        ''' </summary>
        <Extension>
        Public Function LastDay(D As Date) As Date
            Return New Date(D.Year, D.Month, 1).AddMonths(1).AddDays(-1)
        End Function

        ''' <summary>
        ''' Get random item
        ''' </summary>
        <Extension>
        Public Function PickRandom(Of T)(L As IEnumerable(Of T)) As T
            If L.Count = 0 Then Return Nothing
            Return L(Rnd.Next(L.Count))
        End Function

        <Extension>
        Public Function PostDEC(ByRef x As Integer) As Integer
            Dim tmp = x
            Interlocked.Decrement(x)
            Return tmp
        End Function

        <Extension>
        Public Function PostINC(ByRef x As Integer) As Integer
            Dim tmp = x
            Interlocked.Increment(x)
            Return tmp
        End Function

        <Extension>
        Public Function PreDEC(ByRef x As Integer) As Integer
            Return Interlocked.Decrement(x)
        End Function

        <Extension>
        Public Function PreINC(ByRef x As Integer) As Integer
            Return Interlocked.Increment(x)
        End Function

        <Extension>
        Public Function ToIcon(Bitmap As Bitmap) As Icon
            Using I = Icon.FromHandle(Bitmap.GetHicon)
                'Copy icon to change owner
                Dim Icon = DirectCast(I.Clone(), Icon)
                WinAPI.DestroyIcon(I.Handle)
                Return Icon
            End Using
        End Function

        <Extension>
        Public Function Truncate(value As String, maxLength As Integer) As String
            If (String.IsNullOrEmpty(value)) Then Return value
            Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
        End Function

#Region "IsOverride"

        ''' <summary>
        ''' Переопределён ли метод
        ''' </summary>
        <Extension>
        Friend Function IsOverride(MI As MethodInfo) As Boolean
            Return MI.GetBaseDefinition().DeclaringType <> MI.DeclaringType
        End Function

        ''' <summary>
        ''' Переопределёно ли свойство
        ''' </summary>
        <Extension>
        Friend Function IsOverride(PI As PropertyInfo) As Boolean
            Return PI.GetMethod.GetBaseDefinition().DeclaringType <> PI.DeclaringType
        End Function

        ''' <summary>
        ''' Переопределён ли метод или свойство
        ''' </summary>
        ''' <param name="T">Тип</param>
        ''' <param name="Name">Имя метода или свойства</param>
        <Extension>
        Friend Function IsOverride(T As Type, Name As String) As Boolean
            Dim Members = T.GetMember(Name)
            If Members.Count = 0 Then Return False
            Dim M = Members.First
            Select Case M.MemberType
                Case MemberTypes.Method
                    Return IsOverride(DirectCast(M, MethodInfo))
                Case MemberTypes.Property
                    Return IsOverride(DirectCast(M, PropertyInfo))
                Case Else
                    Return False
            End Select
        End Function

#End Region

#Region "Conversion"

        ''' <summary>
        ''' Преобразует DataTable в список объектов типа Т
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="DT"></param>
        Public Function ToObject(Of T As {Class, New})(DT As DataTable) As List(Of T)
            Dim D As Dictionary(Of String, String) = DT.Columns.Cast(Of DataColumn)().ToDictionary(Function(k) k.ColumnName.ToLower, Function(v) v.ColumnName)
            Dim Props = GetType(T).GetProperties(BindingFlags.Instance Or BindingFlags.Public).ToList()

            Dim Items = New List(Of T)()
            For Each R As DataRow In DT.Rows
                Dim item = New T()
                For Each prop In Props
                    If Not D.ContainsKey(prop.Name.ToLower()) Then Continue For
                    Dim Collumn = D(prop.Name.ToLower())
                    If Not R.IsNull(Collumn) Then prop.SetValue(item, R(Collumn), Nothing)
                Next
                Items.Add(item)
            Next

            Return Items
        End Function

        ''' <summary>
        ''' Преобразует DataRow в объект типа <typeparamref name="T"/>
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="R"></param>
        Public Function ToObject(Of T As {Class, New})(R As DataRow) As T
            Dim D As Dictionary(Of String, String) = R.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(k) k.ColumnName.ToLower, Function(v) v.ColumnName)
            Dim Props = GetType(T).GetProperties(BindingFlags.Instance Or BindingFlags.Public).ToList()
            Dim Item = New T()
            For Each prop In Props
                If Not D.ContainsKey(prop.Name.ToLower()) Then Continue For
                Dim Collumn = D(prop.Name.ToLower())
                If Not R.IsNull(Collumn) Then prop.SetValue(Item, R(Collumn), Nothing)
            Next
            Return Item
        End Function

#End Region

    End Module
End Namespace