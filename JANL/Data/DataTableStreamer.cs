using System;
using System.Data;
using System.Data.SqlClient;

namespace JANL.Data
{
    public class DataTableStreamer : IDisposable
    {
        private readonly IProgress<long> Progress;
        private readonly SqlBulkCopy SBC;
        private readonly SqlConnection Source;
        private readonly string SourceTable;
        private readonly SqlConnection Target;
        private readonly string TargetTable;

        public DataTableStreamer(string source, string target, string table, IProgress<long> progress) : this(source, target, table, table) { }

        public DataTableStreamer(string source, string target, string sourceTable, string targetTable, IProgress<long> progress) : this(source, target, sourceTable, targetTable)
        {
            Progress = progress;
            SBC.SqlRowsCopied += (object _, SqlRowsCopiedEventArgs e) => Progress.Report(e.RowsCopied);
        }

        public DataTableStreamer(string source, string target, string table) : this(source, target, table, table) { }

        public DataTableStreamer(string source, string target, string sourceTable, string targetTable)
        {
            Source = SQL.SQLHelper.NewConnection(source);
            Target = SQL.SQLHelper.NewConnection(target);
            SourceTable = sourceTable;
            TargetTable = targetTable;
            SBC = new SqlBulkCopy(target, SqlBulkCopyOptions.KeepIdentity)
            {
                DestinationTableName = TargetTable,
                NotifyAfter = 100,
                EnableStreaming = true
            };
        }

        public void Copy()
        {
            var SDR = GetReader(Source, SourceTable);
            SBC.WriteToServer(SDR);
        }

        private static SqlDataReader GetReader(SqlConnection connection, string table)
        {
            var C = new SqlCommand($"SELECT * FROM {table}") { CommandType = CommandType.Text };
            C.Connection = connection;
            return C.ExecuteReader();
        }

        #region IDisposable Support
        private bool disposedValue;

        void IDisposable.Dispose() => Dispose(true);

        protected void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Source.Dispose();
                    Target.Dispose();
                    SBC.Close();
                }

                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}