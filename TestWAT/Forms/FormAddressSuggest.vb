Imports Dadata
Imports Dadata.Model

Public Class FormAddressSuggest
	Private SC1 As New SuggestClientAsync(Config.Current.ADataToken)
	Private Suggests As IList(Of Suggestion(Of Address))
	Private BS_Suggest As New BindingSource()
	Private WithEvents Timer As New Timer() With {.Interval = 1000}
	Private isValid As Boolean = False

	Private Sub InputChanged()
		Timer.Stop()
		Timer.Start()
	End Sub

	Private Async Function GetSuggests() As Task
		Dim resp = Await SC1.SuggestAddress(TB_Address.Text, 10)
		'Dim r = New SuggestAddressRequest("")
		'r.
		'resp.suggestions.First.data.fias_id
		AddressListBindingSource.DataSource = resp.suggestions.ToList.ConvertAll(Function(x) New AddressEntry(x))
	End Function

	Private Async Sub Timer_Tick() Handles Timer.Tick
		Timer.Stop()
		Await GetSuggests()
		'CB_Address.auto
	End Sub

	Public Class AddressEntry
		Private S As Suggestion(Of Address)

		Public Sub New(_s As Suggestion(Of Address))
			S = _s
		End Sub

		Public ReadOnly Property FullAddress As String
			Get
				Return S.value
			End Get
		End Property

		Public ReadOnly Property UnValue As String
			Get
				Return S.unrestricted_value
			End Get
		End Property

		Public ReadOnly Property FIAS As String
			Get
				Return S.data.fias_id
			End Get
		End Property

		Public ReadOnly Property data As Address
			Get
				Return S.data
			End Get
		End Property

	End Class

	Private Sub TB_Address_TextChanged(sender As Object, e As EventArgs) Handles TB_Address.TextChanged
		isValid = False
		InputChanged()
	End Sub

	Private Async Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
		If IsNothing(ListBox1.SelectedValue) Then Exit Sub
		isValid = True
		Dim resp = Await SC1.SuggestAddress(ListBox1.SelectedValue.ToString, 1)
		FullAddres = New AddressEntry(resp.suggestions.Single)
	End Sub

	Private Sub FormAddressSuggest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Public Property FullAddres As AddressEntry
End Class