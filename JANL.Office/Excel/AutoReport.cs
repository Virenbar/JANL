using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Data;
using System.Drawing;

namespace JANL.Excel
{
    /// <summary>
    /// Авто-отчёт
    /// </summary>
    public class AutoReport : Report
    {
        private readonly IDataReader _reader;

        /// <summary>
        /// Создает авто-отчёт на основе <see cref="IDataReader"/>
        /// </summary>
        /// <param name="reader"></param>
        public AutoReport(IDataReader reader)
        {
            _reader = reader;
        }

        /// <summary>
        /// Создает авто-отчёт на основе <see cref="DataTable"/>
        /// </summary>
        /// <param name="table"></param>
        public AutoReport(DataTable table) : this(table.CreateDataReader()) { }

        /// <summary>
        /// Выводит данные в указанный документ
        /// </summary>
        /// <param name="package"></param>
        protected override void PrintReport(ExcelPackage package)
        {
            if (_reader.IsClosed) { return; }

            var context = new WorksheetContext(package.Workbook.Worksheets.Add(WorksheetName), _reader, 1);

            var Range = context.Worksheet.SelectedRange[context.RowIndexFirst, context.ColumnIndexFirst].LoadFromDataReader(_reader, true);
            Range.AutoFitColumns();
            if (Font != null) { Range.Style.Font.SetFromFont(Font); }
            // Форматирование диапазона как таблицы
            var Table = context.Worksheet.Tables.Add(Range, WorksheetName.Replace(' ', '_'));
            Table.TableStyle = TableStyle;
            Table.ShowRowStripes = true;
            Table.ShowFilter = ShowFilter;

            //Worksheet.InsertColumn(1,1,)
        }

        #region Properties

        /// <summary>
        /// Шрифт отчёта
        /// </summary>
        public Font Font { get; set; } = OfficeDefaults.Font;

        /// <summary>
        /// Показать фильтр таблицы
        /// </summary>
        public bool ShowFilter { get; set; } = true;

        /// <summary>
        /// Стиль таблицы
        /// </summary>
        public TableStyles TableStyle { get; set; } = OfficeDefaults.TableStyle;

        /// <summary>
        /// Имя страницы
        /// </summary>
        public string WorksheetName { get; set; } = "AutoReport";

        #endregion Properties
    }
}