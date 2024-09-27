using JANL.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JANL.Helpers
{
    public static partial class ExcelHelper
    {
        public static WorksheetContext FillSheet(ExcelPackage package, int position, IDataReader data)
        {
            var worksheet = package.Workbook.Worksheets[position];
            return FillSheet(worksheet, data);
        }

        public static WorksheetContext FillSheet(ExcelPackage package, IDataReader data)
        {
            var worksheet = package.Workbook.Worksheets.First();
            return FillSheet(worksheet, data);
        }

        public static WorksheetContext FillSheet(ExcelPackage package, WorksheetContext contex)
        {
            FillCurrentSheet(contex);
            return contex;
        }

        /// <summary>
        /// Заполняет указанный
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="data"></param>
        public static WorksheetContext FillSheet(ExcelWorksheet worksheet, IDataReader data)
        {
            var contex = new WorksheetContext(worksheet, data);
            FillCurrentSheet(contex);
            return contex;
        }

        public static void MergeCollumns(ExcelWorksheet sheet, string cells, string value)
        {
            sheet.Cells[cells].Merge = true;
            sheet.Cells[cells].Value = value;
        }

        public static void MergeRows(ExcelWorksheet sheet, int first, int last, params List<string>[] collumns)
        {
            foreach (var C in collumns)
            {
                C.ForEach((x) =>
                {
                    if (string.IsNullOrEmpty(sheet.Cells[$"{x}{first}"].Value.ToString()))
                    {
                        sheet.Cells[$"{x}{first}"].Value = sheet.Cells[$"{x}{last}"].Value;
                    }
                    sheet.Cells[$"{x}{first}:{x}{last}"].Merge = true;
                });
            }
        }

        /// <summary>
        /// Заполняет <see cref="ExcelWorksheet"/>
        /// </summary>
        /// <param name="contex"></param>
        private static void FillCurrentSheet(WorksheetContext contex)
        {
            if (contex.Reader.IsClosed) { return; }
            // Заполняем справочник столбцов шаблона
            contex.Columns.Clear();
            for (int i = contex.ColumnIndexFirst; i <= contex.ColumnIndexLast; i++)
            {
                contex.Columns[i] = contex.Worksheet.Cells[contex.RowIndexFirst, i].Value.ToString();
            }
            while (contex.Reader.Read())
            {
                // Заполняем справочник данных
                contex.CurrentRowData.Clear();
                for (int i = 0; i < contex.Reader.FieldCount; i++)
                {
                    contex.CurrentRowData[contex.Reader.GetName(i).ToLowerInvariant()] = contex.Reader[i];
                }
                // Вставка строки
                InsertRow(contex);
                contex.IncrementRow();
            }
            contex.Worksheet.DeleteRow(contex.CurrentRowIndex);
        }

        private static void InsertRow(WorksheetContext contex)
        {
            // Создать копию оригинальной строки для сохранения стиля
            contex.Worksheet.InsertRow(contex.CurrentRowIndex + 1, 1, contex.CurrentRowIndex);
            foreach (var Column in contex.Columns)
            {
                var Name = Column.Value.ToLowerInvariant();
                // Взять значение
                if (contex.CurrentRowData.ContainsKey(Name))
                {
                    var Value = contex.CurrentRowData[Name];
                    if (Value is string str && DateTime.TryParse(str, out var Date))
                    {
                        contex.Worksheet.Cells[contex.CurrentRowIndex, Column.Key].Value = Date;
                    }
                    else
                    {
                        contex.Worksheet.Cells[contex.CurrentRowIndex, Column.Key].Value = Value;
                    }
                }
                else
                {
                    // Если для столбца нет данных, попробовать скопировать формулу
                    var Formula = contex.Worksheet.Cells[contex.RowIndexFirst, Column.Key].FormulaR1C1;
                    if (!string.IsNullOrWhiteSpace(Formula))
                    {
                        contex.Worksheet.Cells[contex.CurrentRowIndex, Column.Key].FormulaR1C1 = Formula;
                    }
                }
            }
            contex.RowIndexLast = contex.CurrentRowIndex;
        }
    }
}