using System.Collections.Generic;
using JANL.Helpers;
using OfficeOpenXml;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="ExcelWorksheet"/>
    /// </summary>
    public static class ExcelExtensions
    {

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