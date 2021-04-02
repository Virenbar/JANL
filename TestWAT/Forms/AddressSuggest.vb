Imports Dadata
Imports Dadata.Model

Public Class AddressSuggest
	Private SC1 As New SuggestClient(Config.Current.ADataToken)
	Private BS_Suggest As New BindingSource()
	Private WithEvents Timer As New Timer() With {.Interval = 1500}

	Private Sub AddressSuggest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DGV_Suggests.AutoGenerateColumns = False
	End Sub

	Private Sub B_Suggest_Click(sender As Object, e As EventArgs) Handles B_Suggest.Click
		GetSuggests()
	End Sub

	Private Sub GetSuggests()
		Dim resp = SC1.SuggestAddress(TB_Address.Text, 10)
		'Dim r = New SuggestAddressRequest("")
		'r.
		AddressBindingSource.DataSource = resp.suggestions
		'resp.suggestions.First.data.fias_id
		BS_Suggest.DataSource = resp.suggestions
		DGV_Suggests.DataSource = BS_Suggest
	End Sub

	Private Sub Grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_Suggests.CellFormatting
		Dim grid = CType(sender, DataGridView)
		Dim row = grid.Rows(e.RowIndex)
		Dim col = grid.Columns(e.ColumnIndex)
		If (Not IsNothing(row.DataBoundItem) And col.DataPropertyName.Contains(".")) Then
			Dim props = col.DataPropertyName.Split("."c)
			Dim propInfo = row.DataBoundItem.GetType().GetProperty(props(0))
			Dim Val = propInfo.GetValue(row.DataBoundItem, Nothing)
			For i = 1 To props.Length - 1
				propInfo = Val.GetType().GetProperty(props(i))
				Val = propInfo.GetValue(Val, Nothing)
			Next
			e.Value = Val
		End If
	End Sub

	Private Sub TB_Address_TextChanged(sender As Object, e As EventArgs) Handles TB_Address.TextChanged
		Timer.Stop()
		Timer.Start()
	End Sub

	Private Sub Timer_Tick() Handles Timer.Tick
		Timer.Stop()
		GetSuggests()
	End Sub

End Class