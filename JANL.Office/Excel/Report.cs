using System.IO;
using OfficeOpenXml;

namespace JANL.Excel
{
    /// <summary>
    /// Базовый класс таблицы
    /// </summary>
    public abstract class Report
    {
        /// <summary>
        /// Файл для сохранения
        /// </summary>
        protected FileInfo _file;

        /// <summary>
        ///
        /// </summary>
        protected Report()
        {
            _file = new FileInfo(Path.GetTempFileName().Replace("tmp", "xlsx"));
        }

        /// <summary>
        /// Формирует таблицу и сохраняет во временный файл
        /// </summary>
        public FileInfo Print()
        {
            Print(_file);
            return _file;
        }

        /// <summary>
        /// Формирует таблицу и сохраняет его по пути <paramref name="fileName"/>
        /// </summary>
        /// <param name="fileName">Путь для сохранения</param>
        public FileInfo Print(string fileName)
        {
            _file = new FileInfo(fileName);
            Print(_file);
            return _file;
        }

        /// <summary>
        /// Формирует таблицу и сохраняет в файл <paramref name="file"/>
        /// </summary>
        /// <param name="file">Файл для сохранения</param>
        public virtual void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            using (var package = new ExcelPackage(file))
            {
                PrintReport(package);
                package.Save();
            }
        }

        /// <summary>
        /// Метод заполнения таблицы
        /// </summary>
        /// <param name="package">Таблица</param>
        protected abstract void PrintReport(ExcelPackage package);
    }
}