using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;

namespace JANL.Excel
{
    [Obsolete("Use WorksheetWriter")]
    public class WorksheetContext
    {
        public WorksheetContext(ExcelWorksheet worksheet, IDataReader reader, int rowFirst)
        {
            Worksheet = worksheet;
            Reader = reader;
            RowIndexFirst = rowFirst;
            RowIndexLast = RowIndexFirst;

            ColumnIndexFirst = 1;
            ColumnIndexLast = Worksheet.Dimension?.End?.Column ?? 1;

            CurrentRowNumber = 1;
            CurrentRowIndex = RowIndexFirst;
        }

        public WorksheetContext(ExcelWorksheet worksheet, IDataReader reader) : this(worksheet, reader, 2) { }

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

        public IDataReader Reader { get; }

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
    }
}