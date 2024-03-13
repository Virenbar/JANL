using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JANL.Excel
{
    public class WorksheetWriter
    {
        public WorksheetWriter(ExcelPackage package, int position) : this(package.Workbook.Worksheets[position])
        {
            Worksheet = package.Workbook.Worksheets[position];
        }

        public WorksheetWriter(ExcelPackage package) : this(package.Workbook.Worksheets.First()) { }

        public WorksheetWriter(ExcelWorksheet worksheet)
        {
            Worksheet = worksheet;
        }

        /// <summary>
        /// Индекс первого столбца
        /// </summary>
        public int ColumnIndexFirst { get; set; }

        /// <summary>
        /// Индекс последнего столбца
        /// </summary>
        public int ColumnIndexLast { get; set; }

        /// <summary>
        /// Справочник имён столбцов отчёта
        /// </summary>
        public Dictionary<int, string> Columns { get; } = new Dictionary<int, string>();

        /// <summary>
        /// Справочник с данными текущей строки
        /// </summary>
        public Dictionary<string, object> CurrentRowData { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Индекс текущей строки
        /// </summary>
        public int CurrentRowIndex { get; protected set; }

        /// <summary>
        /// Номер текущей строки
        /// </summary>
        public int CurrentRowNumber { get; protected set; }

        /// <summary>
        /// Индекс первой строки
        /// </summary>
        public int RowIndexFirst { get; protected set; }

        /// <summary>
        /// Индекс последней строки
        /// </summary>
        public int RowIndexLast { get; set; }

        /// <summary>
        /// Текущая страница
        /// </summary>
        public ExcelWorksheet Worksheet { get; }

        public void IncrementRow()
        {
            CurrentRowIndex++;
            CurrentRowNumber++;
        }

        public void Write(IDataReader reader) => Write(reader, 2);

        public void Write(IDataReader reader, int rowFirst)
        {
            RowIndexFirst = rowFirst;
            RowIndexLast = RowIndexFirst;

            ColumnIndexFirst = 1;
            ColumnIndexLast = Worksheet.Dimension?.End?.Column ?? 1;

            CurrentRowNumber = 1;
            CurrentRowIndex = RowIndexFirst;

            WriteToSheet(reader);
        }

        private void InsertRow()
        {
            // Создать копию оригинальной строки для сохранения стиля
            Worksheet.InsertRow(CurrentRowIndex + 1, 1, CurrentRowIndex);
            foreach (var Column in Columns)
            {
                var Name = Column.Value.ToLowerInvariant();
                // Если есть данные для столбца
                if (CurrentRowData.ContainsKey(Name))
                {
                    // Взять значение
                    var Value = CurrentRowData[Name];
                    if (Value is string str && DateTime.TryParse(str, out var Date))
                    {
                        Worksheet.Cells[CurrentRowIndex, Column.Key].Value = Date;
                    }
                    else
                    {
                        Worksheet.Cells[CurrentRowIndex, Column.Key].Value = Value;
                    }
                }
                else
                {
                    // Если для столбца нет данных, попробовать скопировать формулу
                    var Formula = Worksheet.Cells[RowIndexFirst, Column.Key].FormulaR1C1;
                    if (!string.IsNullOrWhiteSpace(Formula))
                    {
                        Worksheet.Cells[CurrentRowIndex, Column.Key].FormulaR1C1 = Formula;
                    }
                }
            }
            RowIndexLast = CurrentRowIndex;
        }

        private void WriteToSheet(IDataReader reader)
        {
            if (reader.IsClosed) { return; }
            // Заполняем справочник столбцов шаблона
            Columns.Clear();
            for (int i = ColumnIndexFirst; i <= ColumnIndexLast; i++)
            {
                Columns[i] = Worksheet.Cells[RowIndexFirst, i].Value.ToString();
            }
            while (reader.Read())
            {
                // Заполняем справочник данных
                CurrentRowData.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    CurrentRowData[reader.GetName(i).ToLowerInvariant()] = reader[i];
                }
                // Вставка строки
                InsertRow();
                IncrementRow();
            }
            Worksheet.DeleteRow(CurrentRowIndex);
        }
    }
}