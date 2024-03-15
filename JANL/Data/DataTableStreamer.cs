using JANL.SQL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JANL.Data
{
    public class DataTableStreamer : IDisposable
    {
        private readonly SqlBulkCopy SBC;
        private readonly SqlConnection Source;
        private readonly SqlConnection Target;

        public DataTableStreamer(string source, string target, string table) : this(source, target, table, table) { }

        public DataTableStreamer(string source, string target, string sourceTable, string targetTable)
        {
            Source = SQLHelper.NewConnection(source);
            Target = SQLHelper.NewConnection(target);
            SourceTable = sourceTable;
            TargetTable = targetTable;
            SBC = new SqlBulkCopy(target, SqlBulkCopyOptions.KeepIdentity)
            {
                DestinationTableName = TargetTable,
                NotifyAfter = 100,
                EnableStreaming = true
            };
        }

        public string SourceTable { get; }
        public string TargetTable { get; }

        public void Copy(IProgress<long> progress)
        {
            SBC.SqlRowsCopied += (object _, SqlRowsCopiedEventArgs e) => progress.Report(e.RowsCopied);
            Copy();
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

        protected virtual void Dispose(bool disposing)
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