using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JANL
{
	public class DataTableStreamer : IDisposable
	{
		private readonly SqlBulkCopy SBC;
		private readonly SqlConnection Source;
		private readonly string Table;
		private readonly SqlConnection Target;

		public DataTableStreamer(string source, string target, string table)
		{
			Source = SQL.SQLHelper.NewConnection(source);
			Target = SQL.SQLHelper.NewConnection(target);
			Table = table;
			SBC = new SqlBulkCopy(target, SqlBulkCopyOptions.KeepIdentity)
			{
				EnableStreaming = true
			};
		}

		public void Copy()
		{
			var SDR = GetReader(Source, Table);
			SBC.WriteToServer(SDR);
		}

		private static SqlDataReader GetReader(SqlConnection connection, string table)
		{
			var C = new SqlCommand($"SELECT * FROM {table}") { CommandType = CommandType.Text };
			C.Connection = connection;
			return C.ExecuteReader();
		}

		#region IDisposable Support
		private bool disposedValue = false; // Для определения избыточных вызовов

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