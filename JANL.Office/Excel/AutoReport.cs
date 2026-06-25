using System.Data;
using System.Drawing;
using OfficeOpenXml;
using OfficeOpenXml.Table;

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

            var sheet = package.Workbook.Worksheets.Add(WorksheetName);
            var range = sheet.SelectedRange[1, 1].LoadFromDataReader(_reader, true);
            range.AutoFitColumns();
            if (Font != null) { range.Style.Font.SetFromFont(Font); }
            // Форматирование диапазона как таблицы
            var table = sheet.Tables.Add(range, WorksheetName.Replace(' ', '_'));
            table.TableStyle = TableStyle;
            table.ShowRowStripes = true;
            table.ShowFilter = ShowFilter;

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