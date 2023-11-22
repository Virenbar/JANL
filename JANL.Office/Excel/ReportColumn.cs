using OfficeOpenXml.Style;

namespace JANL.Excel
{
    public class ReportColumn
    {
        public ExcelFont Font { get; set; }
        public string Header { get; set; }
        public ExcelNumberFormat Format { get; set; }
        public double Width { get; set; }
    }
}