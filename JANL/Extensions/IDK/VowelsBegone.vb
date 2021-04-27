Imports System.Runtime.CompilerServices

Namespace Extensions.IDK
	Module VowelsBegone
		Private ReadOnly Txt As New HashSet(Of Type) From {GetType(Button), GetType(Label), GetType(GroupBox), GetType(TabPage), GetType(ToolStripMenuItem), GetType(ToolStripDropDownButton), GetType(CheckBox)}
		Private ReadOnly Vowels() As Char = VowelsHalf.Concat(VowelsHalf.AsEnumerable.Select(Function(x) Char.ToLowerInvariant(x))).ToArray
		Private ReadOnly VowelsHalf() As Char = {"У"c, "Е"c, "Ы"c, "А"c, "О"c, "Э"c, "Я"c, "И"c, "Ю"c}

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
	End Module
End Namespace