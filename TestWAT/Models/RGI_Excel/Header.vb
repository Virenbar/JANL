Namespace RGI_Excel

    <Serializable>
    Public Class Header
        Public Property Rows() As Row()

        <Xml.Serialization.XmlIgnore>
        Public Property PeriodsText As String
        Public Property PeriodsRowIndex As UInteger
        Public Property PeriodsCellIndex As UInteger
    End Class

End Namespace
