using OfficeOpenXml;
using System.IO;

namespace JANL.Excel
{
    public abstract class Report
    {
        protected FileInfo File;

        protected Report()
        {
            File = new FileInfo(Path.GetTempFileName().Replace("tmp", "xlsx"));
        }

        public FileInfo Print()
        {
            Print(File);
            return File;
        }

        public FileInfo Print(string FileName)
        {
            File = new FileInfo(FileName);
            Print(File);
            return File;
        }

        public virtual void Print(FileInfo file)
        {
            if (!file.Directory.Exists) { file.Directory.Create(); }
            using (var package = new ExcelPackage(file))
            {
                PrintReport(package);
                package.Save();
            }
        }

        protected abstract void PrintReport(ExcelPackage package);
    }
}