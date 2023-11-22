using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Data;
using System.Drawing;

namespace JANL.Excel
{
    public class AutoReport : Report
    {
        private readonly IDataReader _reader;

        public AutoReport(IDataReader reader)
        {
            _reader = reader;
        }

        public AutoReport(DataTable table) : this(table.CreateDataReader()) { }

        protected override void PrintReport(ExcelPackage package)
        {
            if (_reader.IsClosed) { return; }

            var contex = new WorksheetContext(package.Workbook.Worksheets.Add(WorksheetName), _reader, 1);

            var Range = contex.Worksheet.SelectedRange[contex.RowIndexFirst, contex.ColumnIndexFirst].LoadFromDataReader(_reader, true);
            Range.AutoFitColumns();
            if (Font != null) { Range.Style.Font.SetFromFont(Font); }
            // Форматирование диапазона как таблицы
            var Table = contex.Worksheet.Tables.Add(Range, WorksheetName.Replace(' ', '_'));
            Table.TableStyle = TableStyle;
            Table.ShowRowStripes = true;
            Table.ShowFilter = ShowFilter;

            //Worksheet.InsertColumn(1,1,)
        }

        #region Properties
        public Font Font { get; set; } = OfficeDefaults.Font;
        public bool ShowFilter { get; set; } = true;
        public TableStyles TableStyle { get; set; } = OfficeDefaults.TableStyle;
        public string WorksheetName { get; set; } = "AutoReport";
        #endregion Properties
    }
}