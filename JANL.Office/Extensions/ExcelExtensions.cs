using JANL.Excel;
using JANL.Helpers;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="ExcelWorksheet"/>
    /// </summary>
    public static class ExcelExtensions
    {
        [Obsolete("Use WorksheetWriter")]
        public static WorksheetContext FillSheet(this ExcelPackage package, WorksheetContext context) => ExcelHelper.FillSheet(package, context);

        [Obsolete("Use WorksheetWriter")]
        public static WorksheetContext FillSheet(this ExcelPackage package, int position, IDataReader data) => ExcelHelper.FillSheet(package, position, data);

        [Obsolete("Use WorksheetWriter")]
        public static WorksheetContext FillSheet(this ExcelPackage package, IDataReader data) => ExcelHelper.FillSheet(package, data);

        [Obsolete("Use WorksheetWriter")]
        public static WorksheetContext FillSheet(this ExcelWorksheet worksheet, IDataReader data) => ExcelHelper.FillSheet(worksheet, data);

        /// <summary>
        /// Объединить ячейки
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="cells">Диапазон ячеек</param>
        public static void MergeCells(this ExcelWorksheet sheet, string cells) => ExcelHelper.MergeCells(sheet, cells);

        /// <summary>
        /// Объединить ячейки и записать значение
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="cells">Диапазон ячеек</param>
        /// <param name="value"></param>
        public static void MergeCells(this ExcelWorksheet sheet, string cells, string value) => ExcelHelper.MergeCells(sheet, cells, value);

        [Obsolete]
        public static void MergeCollumns(this ExcelWorksheet sheet, string cells, string value) => ExcelHelper.MergeCells(sheet, cells, value);

        /// <summary>
        /// Объединить строки в указанных столбцах
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="first">Номер первой строки</param>
        /// <param name="last">Номер последней строки</param>
        /// <param name="columns">Столбцы</param>
        public static void MergeRows(this ExcelWorksheet sheet, int first, int last, params List<string>[] columns) => ExcelHelper.MergeRows(sheet, first, last, columns);
    }
}