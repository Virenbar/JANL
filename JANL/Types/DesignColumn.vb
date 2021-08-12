Imports System.ComponentModel
Imports System.Drawing

Namespace Types

	Friend Class DesignColumn
		Inherits ObservableObject
		Private Shared Count As Integer = 0

		Public Sub New()
			Name = $"Column{Count}"
			Header = Name
			Width = 100
			AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
			Visible = True
			ForeColor = Color.Black
			Count += 1
		End Sub

		Public Sub New(C As DGVTemplateColumn)
			Name = C.Name
			Header = C.Header
			Width = C.Width
			AutoSizeMode = C.AutoSizeMode
			Visible = C.Visible
			ForeColor = ColorTranslator.FromHtml(C.ForeColor)
		End Sub

		Public Function ToTemplate() As DGVTemplateColumn
			Return New DGVTemplateColumn() With {
				.Name = Name,
				.Header = Header,
				.Width = Width,
				.AutoSizeMode = AutoSizeMode,
				.Visible = Visible,
				.ForeColor = ColorTranslator.ToHtml(ForeColor)
			}
		End Function

		<Description("Имя столбца")>
		Public Property Name As String

		<Description("Заголовок столбца")>
		Public Property Header As String

		<Description("Ширина столбца"), DefaultValue(100)>
		Public Property Width As Integer

		<Description("Способ регулирования ширины столбца"), DefaultValue(GetType(DataGridViewAutoSizeColumnMode), "NotSet")>
		Public Property AutoSizeMode As DataGridViewAutoSizeColumnMode

		<Description("Видимость столбца"), DefaultValue(True)>
		Public Property Visible As Boolean

		<Description("Цвет текста"), DefaultValue(GetType(Color), "0x000000")>
		Public Property ForeColor As Color

		'<Description("Шрифт текста"), DefaultValue(GetType(Color), "0x000000"), Category("У")>
		'Public Property Font As Font
		Public Overrides Function ToString() As String
			Return $"{Name}({Header}, {Width})"
		End Function

	End Class

End Namespace