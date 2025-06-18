using OfficeOpenXml;
using System;
using System.IO;

namespace JANL.Excel
{
    public abstract class TemplateReport : Report, IDisposable
    {
        private readonly Stream _stream;
        private readonly ExcelPackage _template;

        protected TemplateReport(string file) : this(new FileInfo(file)) { }

        protected TemplateReport(byte[] buffer)
        {
            _stream = new MemoryStream(buffer);
            _template = new ExcelPackage(_stream);
        }

        protected TemplateReport(FileInfo file) : this(new ExcelPackage(file)) { }

        protected TemplateReport(ExcelPackage package)
        {
            _template = package;
        }

        public override void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            _template.SaveAs(file);
            base.Print(file);
        }

        protected abstract override void PrintReport(ExcelPackage package);

        #region Dispose

        public void Dispose()
        {
            _template?.Dispose();
            _stream?.Dispose();
        }

        #endregion Dispose
    }
}