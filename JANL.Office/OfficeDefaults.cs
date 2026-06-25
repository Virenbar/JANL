using JANL.Excel;
using OfficeOpenXml.Table;
using System.Collections.Generic;
using System.Drawing;

namespace JANL
{
    /// <summary>
    /// Параметры для документов по умолчанию
    /// </summary>
    public static class OfficeDefaults
    {
        /// <summary>
        /// Шрифт для документов по умолчанию
        /// </summary>
        public static Font Font { get; set; }

        /// <summary>
        /// Стили колонок для отчётов по умолчанию
        /// </summary>
        public static Dictionary<string, ReportColumn> ReportColumns { get; }

        /// <summary>
        /// Стили для таблиц по умолчанию
        /// </summary>
        public static TableStyles TableStyle { get; set; } = TableStyles.Medium2;
    }
}