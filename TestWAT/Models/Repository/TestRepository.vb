Public Class TestRepository
	Inherits JANL.BaseRepository

	Public Sub New()
		MyBase.New("Values", "Key", "Value", {"Value", "OtherValue"})
	End Sub

	Public Overrides Function GetList() As Task(Of DataTable)
		Dim DT = New DataTable()
		DT.Columns.Add("Key", GetType(Integer))
		DT.Columns.Add("Value", GetType(String))
		DT.Columns.Add("OtherValue", GetType(String))
		DT.Columns.Add("Type", GetType(String))

		For i = 1 To 150
			Dim R = DT.NewRow()
			R("Key") = i
			R("Value") = $"Value {i}"
			R("OtherValue") = $"OtherValue {i}"
			R("Type") = If(i Mod 2 = 0, "Even", "Odd")
			DT.Rows.Add(R)
		Next

		Return Task.FromResult(DT)
	End Function

	Public Shared Function GetValue(Key As Integer) As String
		Return $"Value {Key}"
	End Function

End Class