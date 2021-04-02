Imports System.Reflection
Imports System.Runtime.CompilerServices

Module Extensions
	Private ReadOnly CTR As New HashSet(Of Type) From {GetType(Button), GetType(ComboBox), GetType(NumericUpDown), GetType(DateTimePicker), GetType(TextBox)}
	Private ReadOnly Rnd As New Random(Today.Millisecond)

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
	Public Function PickRandom(Of T)(L As IEnumerable(Of T)) As T
		If L.Count = 0 Then Return Nothing
		Return L(Rnd.Next(L.Count))
	End Function

	<Extension>
	Public Function Truncate(value As String, maxLength As Integer) As String
		If (String.IsNullOrEmpty(value)) Then Return value
		Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
	End Function

#Region "Vowels Begone"
	Private ReadOnly Txt As New HashSet(Of Type) From {GetType(Button), GetType(Label), GetType(GroupBox), GetType(TabPage), GetType(ToolStripMenuItem), GetType(ToolStripDropDownButton), GetType(CheckBox)}
	Private ReadOnly VowelsHalf() As Char = {"У"c, "Е"c, "Ы"c, "А"c, "О"c, "Э"c, "Я"c, "И"c, "Ю"c}
	Private ReadOnly Vowels() As Char = VowelsHalf.Concat(VowelsHalf.AsEnumerable.Select(Function(x) Char.ToLowerInvariant(x))).ToArray

	<Extension>
	Public Sub VowelsBegone(cont As Control)
		If Txt.Contains(cont.GetType) Or cont.GetType.IsSubclassOf(GetType(Form)) Or cont.GetType.IsSubclassOf(GetType(ToolStrip)) Then
			cont.Text = String.Join("", cont.Text.Split(Vowels))
		End If
		If cont.GetType.IsSubclassOf(GetType(ToolStrip)) Then
			For Each I As ToolStripItem In DirectCast(cont, ToolStrip).Items
				VowelsBegone(I)
			Next
		End If
		If cont.Controls.Count > 0 Then
			For Each C As Control In cont.Controls
				VowelsBegone(C)
			Next
		End If
	End Sub

	Private Sub VowelsBegone(cont As ToolStripItem)
		cont.Text = String.Join("", cont.Text.Split(Vowels))
		If cont.GetType.IsSubclassOf(GetType(ToolStripDropDownItem)) Then
			For Each I As ToolStripItem In DirectCast(cont, ToolStripDropDownItem).DropDownItems
				VowelsBegone(I)
			Next
		End If
	End Sub

	'Public Sub VowelsBegone(cont As ToolStripDropDownItem)
	'	cont.Text = String.Join("", cont.Text.Split(Vowels))
	'	If cont.DropDownItems.Count > 0 Then
	'		For Each I As ToolStripDropDownItem In cont.DropDownItems
	'			VowelsBegone(I)
	'		Next
	'	End If
	'End Sub

#End Region

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

End Module