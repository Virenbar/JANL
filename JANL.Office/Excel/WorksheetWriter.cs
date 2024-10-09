using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JANL.Excel
{
    /// <summary>
    /// Класс для записи данных в Excel файл
    /// </summary>
    public class WorksheetWriter
    {
        /// <summary>
        /// Создает класс на основе файла и индекса страницы
        /// </summary>
        /// <param name="package">Файл Excel</param>
        /// <param name="position">Индекс страницы</param>
        public WorksheetWriter(ExcelPackage package, int position) : this(package.Workbook.Worksheets[position])
        {
            Worksheet = package.Workbook.Worksheets[position];
        }

        /// <summary>
        /// Создает класс на основе файла и первой страницы
        /// </summary>
        /// <param name="package">Файл Excel</param>
        public WorksheetWriter(ExcelPackage package) : this(package.Workbook.Worksheets.First()) { }

        /// <summary>
        /// Создает класс на основе страницы
        /// </summary>
        /// <param name="worksheet">Страница Excel</param>
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

        /// <summary>
        /// Заполоняет текущую строку данными из справочника CurrentRowData
        /// </summary>
        private void FillCurrentRow()
        {
            // Создать копию строки с шаблоном для сохранения стиля
            Worksheet.InsertRow(CurrentRowIndex + 1, 1, CurrentRowIndex);
            foreach (var Column in Columns)
            {
                var Name = Column.Value.ToLowerInvariant();
                if (CurrentRowData.ContainsKey(Name))
                {
                    // Если есть данные для столбца - вставить значение
                    var Value = CurrentRowData[Name];
                    if (Value is string str && str.Contains(".") && DateTime.TryParse(str, out var Date))
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
                    // Иначе скопировать формулу, если она есть
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
            if (Columns.Count == 0)
            {
                // Заполнить справочник столбцов из начальной строки если он пуст
                for (int i = ColumnIndexFirst; i <= ColumnIndexLast; i++)
                {
                    Columns[i] = Worksheet.Cells[RowIndexFirst, i].Value.ToString();
                }
            }
            while (reader.Read())
            {
                // Заполнить справочник данных
                CurrentRowData.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    CurrentRowData[reader.GetName(i).ToLowerInvariant()] = reader[i];
                }
                // Вставка строки
                FillCurrentRow();
                CurrentRowIndex++;
                CurrentRowNumber++;
            }
            // Удалить строку с шаблоном
            Worksheet.DeleteRow(CurrentRowIndex);
        }
    }
}