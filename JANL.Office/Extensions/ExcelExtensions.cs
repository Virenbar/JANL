using JANL.Excel;
using JANL.Helpers;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Data;

namespace JANL.Extensions
{
    public static class ExcelExtensions
    {
        public static WorksheetContext FillSheet(this ExcelPackage package, WorksheetContext context) => ExcelHelper.FillSheet(package, context);

        public static WorksheetContext FillSheet(this ExcelPackage package, int position, IDataReader data) => ExcelHelper.FillSheet(package, position, data);

        public static WorksheetContext FillSheet(this ExcelPackage package, IDataReader data) => ExcelHelper.FillSheet(package, data);

        public static WorksheetContext FillSheet(this ExcelWorksheet worksheet, IDataReader data) => ExcelHelper.FillSheet(worksheet, data);

        public static void MergeRows(this ExcelWorksheet sheet, int first, int last, params List<string>[] collumns) => ExcelHelper.MergeRows(sheet, first, last, collumns);

        public static void MergeCollumns(this ExcelWorksheet sheet, string cells, string value) => ExcelHelper.MergeCollumns(sheet, cells, value);
    }
}