using System.Collections.Generic;
using System.Linq;
using OfficeOpenXml;

namespace JANL.Helpers
{
    /// <summary>
    /// Вспомогательные методы работы с <see cref="ExcelPackage"/>
    /// </summary>
    public static partial class ExcelHelper
    {

        /// <summary>
        /// Объединить ячейки
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="cells">Диапазон ячеек</param>
        public static void MergeCells(ExcelWorksheet sheet, string cells)
        {
            sheet.Cells[cells].Merge = true;
        }

        /// <summary>
        /// Объединить ячейки и записать значение
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="cells">Диапазон ячеек</param>
        /// <param name="value"></param>
        public static void MergeCells(ExcelWorksheet sheet, string cells, string value)
        {
            sheet.Cells[cells].Merge = true;
            sheet.Cells[cells].Value = value;
        }

        /// <summary>
        /// Объединить строки в указанных столбцах
        /// </summary>
        /// <param name="sheet">Страница Excel</param>
        /// <param name="first">Номер первой строки</param>
        /// <param name="last">Номер последней строки</param>
        /// <param name="columns">Столбцы</param>
        public static void MergeRows(ExcelWorksheet sheet, int first, int last, params List<string>[] columns)
        {
            foreach (var column in columns.SelectMany(C => C))
            {
                if (string.IsNullOrEmpty(sheet.Cells[$"{column}{first}"].Value?.ToString()))
                {
                    sheet.Cells[$"{column}{first}"].Value = sheet.Cells[$"{column}{last}"].Value;
                }
                sheet.Cells[$"{column}{first}:{column}{last}"].Merge = true;
            }
        }

    }
}