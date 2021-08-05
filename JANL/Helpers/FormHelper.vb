Public Class FormHelper

	''' <summary>
	''' Проверяет есть ли экземпляр формы типа <typeparamref name="T"/>, с возможность её активации
	''' </summary>
	''' <typeparam name="T">Тип формы</typeparam>
	''' <param name="Activate">Активировать ли форму</param>
	''' <returns></returns>
	Public Shared Function IsOpen(Of T As {Form})(Activate As Boolean) As Boolean
		Dim Result = Application.OpenForms.OfType(Of T).Count > 0
		If Activate AndAlso Result Then
			Application.OpenForms.OfType(Of T).First.Activate()
		End If
		Return Result
	End Function

End Class