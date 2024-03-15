Imports System.IO
Imports Newtonsoft.Json

Public Class Config
    Public Shared Property Current As Config
    Public Property DaDataToken As String
    Public Property ExceptionMail As String
    Public Property PochtaLogin As String
    Public Property PochtaPassword As String

    Public Shared Sub Load()
        Current = JsonConvert.DeserializeObject(Of Config)(File.ReadAllText("Config.json"))
    End Sub

End Class