using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;

namespace JANL.Word
{
    /// <summary>
    /// Базовый класс шаблона документа
    /// </summary>
    public abstract class TemplateDocument : IDisposable
    {
        /// <summary>
        /// Шаблон документа в виде байт
        /// </summary>
        protected byte[] _buffer;

        /// <summary>
        /// Файл для сохранения
        /// </summary>
        protected FileInfo _file;

        private Stream _stream;
        private WordprocessingDocument _template;

        /// <summary>
        /// Создает пустой шаблон
        /// </summary>
        protected TemplateDocument()
        {
            _file = new FileInfo(Path.GetTempFileName().Replace("tmp", "docx"));
        }

        /// <summary>
        /// Создает шаблон на основе потока
        /// </summary>
        /// <param name="stream"></param>
        protected TemplateDocument(Stream stream) : this()
        {
            _stream = stream;
        }

        /// <summary>
        /// Создает шаблон на основе буфера
        /// </summary>
        /// <param name="buffer"></param>
        protected TemplateDocument(byte[] buffer) : this()
        {
            _buffer = buffer;
        }

        /// <summary>
        /// Формирует документ и сохраняет во временный файл
        /// </summary>
        public FileInfo Print()
        {
            Print(_file);
            return _file;
        }

        /// <summary>
        /// Формирует документ и сохраняет его по пути <paramref name="fileName"/>
        /// </summary>
        /// <param name="fileName">Путь для сохранения</param>
        public FileInfo Print(string fileName)
        {
            _file = new FileInfo(fileName);
            Print(_file);
            return _file;
        }

        /// <summary>
        /// Формирует документ и сохраняет в файл <paramref name="file"/>
        /// </summary>
        /// <param name="file">Файл для сохранения</param>
        public void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            _template = CreateDocumentTemplate();
            using (var document = _template.Clone(file.FullName, true))
            {
                PrintDocument(document);
                document.Save();
            }
        }

        /// <summary>
        /// Создает шаблон на основе буфера или потока
        /// </summary>
        protected virtual WordprocessingDocument CreateDocumentTemplate()
        {
            if (_stream is null)
            {
                _stream = new MemoryStream(_buffer);
            }
            return WordprocessingDocument.Open(_stream, false);
        }

        /// <summary>
        /// Метод заполнения документа
        /// </summary>
        /// <param name="document">Шаблон документа</param>
        protected abstract void PrintDocument(WordprocessingDocument document);

        /// <summary>
        /// Задает шаблон документа
        /// </summary>
        /// <param name="buffer"></param>
        protected void SetTemplate(byte[] buffer)
        {
            _buffer = buffer;
        }

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