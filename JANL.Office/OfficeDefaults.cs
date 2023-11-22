using JANL.Excel;
using OfficeOpenXml.Table;
using System.Collections.Generic;
using System.Drawing;

namespace JANL
{
    public static class OfficeDefaults
    {
        public static Dictionary<string, ReportColumn> ReportColumns { get; }
        public static Font Font { get; set; }
        public static TableStyles TableStyle { get; set; } = TableStyles.Medium2;
    }
}