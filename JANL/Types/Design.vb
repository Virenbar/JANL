Namespace Types

	Friend Class Design

		Public Sub New()
		End Sub

		Public Sub New(T As DGVTemplate)
			Columns = T.Columns.Select(Function(c) New DesignColumn(c)).ToList()
		End Sub

		Public Columns As List(Of DesignColumn)

		'<Description("Ширина столбца")>
		'Public Font Font { Get; Set; }

		Public Shared Function FromTemplate(T As DGVTemplate) As Design
			Return New Design(T)
		End Function

		Public Function ToTemplate() As DGVTemplate
			Return New DGVTemplate With {.Columns = Columns.Select(Function(c) c.ToTemplate()).ToList()}
		End Function

	End Class
End Namespace