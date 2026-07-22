using System;
using System.IO;
using OfficeOpenXml;

namespace JANL.Excel
{
    /// <summary>
    /// Базовый класс шаблона таблицы
    /// </summary>
    public abstract class TemplateReport : Report, IDisposable
    {

        /// <summary>
        /// Шаблон таблицы в виде байт
        /// </summary>
        protected byte[] _buffer;

        private Stream _stream;
        private ExcelPackage _template;

        /// <summary>
        /// Создает шаблон на основе файла
        /// </summary>
        protected TemplateReport(string file) : this(new FileInfo(file)) { }

        /// <summary>
        /// Создает шаблон на основе файла
        /// </summary>
        protected TemplateReport(FileInfo file) : this(file.OpenRead()) { }

        /// <summary>
        /// Создает шаблон на основе потока
        /// </summary>
        /// <param name="stream"></param>
        protected TemplateReport(Stream stream) : base()
        {
            _stream = stream;
        }

        /// <summary>
        /// Создает шаблон на основе буфера
        /// </summary>
        /// <param name="buffer"></param>
        protected TemplateReport(byte[] buffer)
        {
            _buffer = buffer;
        }

        /// <summary>
        /// Формирует таблицу и сохраняет в файл <paramref name="file"/>
        /// </summary>
        /// <param name="file">Файл для сохранения</param>
        public override void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            _template = CreateDocumentTemplate();
            _template.SaveAs(file);
            base.Print(file);
        }

        /// <summary>
        /// Создает шаблон на основе буфера или потока
        /// </summary>
        protected virtual ExcelPackage CreateDocumentTemplate()
        {
            if (_stream is null)
            {
                _stream = new MemoryStream(_buffer);
            }
            return new ExcelPackage(_stream);
        }

        /// <summary>
        /// Метод заполнения таблицы
        /// </summary>
        /// <param name="package">Таблица</param>
        protected abstract override void PrintReport(ExcelPackage package);

        #region Dispose

        /// <summary>
        ///
        /// </summary>
        public void Dispose()
        {
            _template?.Dispose();
            _stream?.Dispose();
        }

        #endregion Dispose
    }
}