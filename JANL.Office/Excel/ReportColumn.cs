using OfficeOpenXml.Style;

namespace JANL.Excel
{
    /// <summary>
    /// Стиль колонки
    /// </summary>
    public class ReportColumn
    {
        /// <summary>
        /// Шрифт
        /// </summary>
        public ExcelFont Font { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Формат
        /// </summary>
        public ExcelNumberFormat Format { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; }
    }
}