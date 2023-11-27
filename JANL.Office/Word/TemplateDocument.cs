using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;

namespace JANL.Word
{
    public abstract class TemplateDocument : IDisposable
    {
        protected FileInfo _file;
        private readonly Stream _stream;
        private readonly WordprocessingDocument _template;

        protected TemplateDocument()
        {
            _file = new FileInfo(Path.GetTempFileName().Replace("tmp", "docx"));
        }

        protected TemplateDocument(Stream Stream) : this()
        {
            _template = WordprocessingDocument.Open(Stream, false);
        }

        protected TemplateDocument(byte[] Buffer) : this()
        {
            _stream = new MemoryStream(Buffer);
            _template = WordprocessingDocument.Open(_stream, false);
        }

        public FileInfo Print()
        {
            Print(_file);
            return _file;
        }

        public FileInfo Print(string FileName)
        {
            _file = new FileInfo(FileName);
            Print(_file);
            return _file;
        }

        public void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            using (var document = (WordprocessingDocument)_template.Clone(file.FullName, true))
            {
                PrintDocument(document);
                document.Save();
            }
        }

        protected abstract void PrintDocument(WordprocessingDocument document);

        #region Dispose

        public void Dispose()
        {
            _template.Dispose();
            _stream?.Dispose();
        }

        #endregion Dispose
    }
}