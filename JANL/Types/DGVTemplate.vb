Imports System.IO
Imports System.Xml.Serialization

Namespace Types

	Public Class DGVTemplate

		Public Sub New()
			Columns = New List(Of DGVTemplateColumn)
		End Sub

		Public Property Columns As List(Of DGVTemplateColumn)

		Public Shared Function FromXML(XML As String) As DGVTemplate
			Dim XS As New XmlSerializer(GetType(DGVTemplate))
			Using SR = New StringReader(XML)
				Dim T = DirectCast(XS.Deserialize(SR), DGVTemplate)
				Return T
			End Using
		End Function

		Public Shared Function ToXML(T As DGVTemplate) As String
			Dim XS = New XmlSerializer(GetType(DGVTemplate))
			Using SW = New StringWriter()
				XS.Serialize(SW, T)
				Return SW.ToString()
			End Using
		End Function

	End Class
End Namespace