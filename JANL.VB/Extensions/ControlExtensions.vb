Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic

Namespace Extensions
    ''' <summary>
    ''' Extensions for Types inheriting Control
    ''' </summary>
    Friend Module ControlExtensions

        Private ReadOnly CTR As New HashSet(Of Type) From {GetType(Button), GetType(ComboBox), GetType(NumericUpDown), GetType(DateTimePicker), GetType(TextBox)}

        ''' <summary>
        ''' Включает двойную буферизацию
        ''' </summary>
        <Extension>
        Public Sub DoubleBuffered(Ctrl As Control, Optional setting As Boolean = True)
            Dim CtrlType As Type = Ctrl.GetType()
            Dim propInfo As PropertyInfo = CtrlType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propInfo.SetValue(Ctrl, setting, Nothing)
        End Sub

        ''' <summary>
        ''' Отключает автогенерацию колонок и включает двойную буферизацию
        ''' </summary>
        ''' <param name="dgv"></param>
        <Extension>
        Public Sub FixDGV(dgv As DataGridView)
            dgv.AutoGenerateColumns = False
            DoubleBuffered(dgv, True)
        End Sub

        ''' <summary>
        ''' Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        ''' </summary>
        ''' <param name="CB"></param>
        ''' <returns></returns>
        <Extension>
        Public Function GetString(CB As ComboBox) As String
            Return If(CB.SelectedIndex > 0, CStr(CB.SelectedValue), Nothing)
        End Function

        ''' <summary>
        ''' Если текст больше 0, то возвращает его иначе Nothing
        ''' </summary>
        ''' <param name="TB"></param>
        ''' <returns></returns>
        <Extension>
        Public Function GetString(TB As TextBox) As String
            Return If(TB.Text.Length > 0, TB.Text, Nothing)
        End Function

        ''' <summary>
        ''' Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="CB"></param>
        ''' <returns></returns>
        <Extension>
        Public Function GetValue(Of T As Structure)(CB As ComboBox) As T?
            Return If(CB.SelectedIndex > 0, New T?(DirectCast(CB.SelectedValue, T)), Nothing)
        End Function

        ''' <summary>
        ''' Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="CB"></param>
        ''' <returns></returns>
        <Extension>
        Public Function GetValue(Of T As Structure)(CB As ToolStripComboBox) As T?
            Return If(CB.SelectedIndex > 0, New T?(DirectCast(CB.ComboBox.SelectedValue, T)), Nothing)
        End Function

        ''' <summary>
        ''' Устанавливает DT в качестве источника c сохранением сортировки.
        ''' DGV должен иметь BindingSource.
        ''' </summary>
        <Extension>
        Public Sub SetDataSource(DGV As DataGridView, DT As DataTable)
            Dim SC = DGV.SortedColumn?.Name
            Dim LS = If(DGV.SortOrder = SortOrder.Ascending, ListSortDirection.Ascending, ListSortDirection.Descending)
            Dim BS = DirectCast(DGV.DataSource, BindingSource)
            BS.DataSource = DT
            If SC IsNot Nothing Then DGV.Sort(DGV.Columns(SC), LS)
        End Sub

        Public Sub SetEnableRecursive(cont As Control, state As Boolean)
            SetEnableRecursive(cont, state, {})
        End Sub

        ''' <summary>
        ''' Рекурсивно меняет состояние контролов, кроме исключённых
        ''' </summary>
        ''' <param name="state">Состояние</param>
        ''' <param name="excl">Исключения</param>
        <Extension>
        Public Sub SetEnableRecursive(cont As Control, state As Boolean, excl As Control())
            SetEnableRecursive(cont, state, New HashSet(Of Control)(excl))
        End Sub

        ''' <summary>
        ''' Рекурсивно меняет состояние контролов, кроме исключённых
        ''' </summary>
        ''' <param name="state">Состояние</param>
        ''' <param name="excl">Исключения</param>
        <Extension>
        Public Sub SetEnableRecursive(cont As Control, state As Boolean, excl As HashSet(Of Control))
            For Each C As Control In cont.Controls
                If C.Controls.Count > 0 Then
                    SetEnableRecursive(C, state, excl)
                ElseIf Not excl.Contains(C) And CTR.Contains(C.GetType) Then
                    C.Enabled = state
                End If
            Next
        End Sub

        <Extension>
        Public Sub SetIntegerValue(CB As ComboBox, value As Object, Optional def As Integer = -1)
            If IsDBNull(value) Or value Is Nothing Then
                CB.SelectedValue = def
            Else
                CB.SelectedValue = CInt(value)
            End If
        End Sub

    End Module
End Namespace