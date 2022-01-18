using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace JANL.DataReaders
{
	internal class CSVDataReader : IDataReader
	{
		protected readonly List<string> Columns;
		protected readonly Dictionary<string, string> CurrentValues = new Dictionary<string, string>();
		protected readonly Dictionary<string, int> Mapping;
		protected readonly StreamReader CSV;
		protected readonly char SplitChar = ',';

		public CSVDataReader(string File)
		{
			CSV = new StreamReader(File);
			Columns = CSV.ReadLine().Split(SplitChar).ToList();
		}

		public CSVDataReader(string File, IEnumerable<string> Columns) : this(File)
		{
			CSV = new StreamReader(File);
			this.Columns = Columns.ToList();
			var index = 0;
			Mapping = Columns.ToDictionary(K => K, V => index++);
		}

		public int FieldCount => Columns.Count;

		public object this[int i] => CurrentValues[Columns[i]];

		public object this[string name] => CurrentValues[name];

		public int GetOrdinal(string name) => Mapping[name];

		public object GetValue(int i) => this[i];

		public bool IsDBNull(int i) => this[i] == null;

		public bool Read()
		{
			while (!CSV.EndOfStream)
			{
				CurrentValues.Clear();
				var Row = CSV.ReadLine();
				var Values = Row.Split(SplitChar).ToList();
				foreach (var Name in Columns)
				{
					CurrentValues[Name] = Values[GetOrdinal(Name)];
				}
				return true;
			}
			return false;
		}

		#region IDisposable Support
		private bool disposedValue = false;

		public void Dispose() => Dispose(true);

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					Columns.Clear();
					CurrentValues.Clear();
					Mapping.Clear();
					CSV.Dispose();
				}
				disposedValue = true;
			}
		}

		#endregion IDisposable Support

		#region NotImplemented
		public int Depth => throw new NotImplementedException();

		public bool IsClosed => throw new NotImplementedException();

		public int RecordsAffected => throw new NotImplementedException();

		public void Close() => throw new NotImplementedException();

		public bool GetBoolean(int i) => throw new NotImplementedException();

		public byte GetByte(int i) => throw new NotImplementedException();

		public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) => throw new NotImplementedException();

		public char GetChar(int i) => throw new NotImplementedException();

		public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => throw new NotImplementedException();

		public IDataReader GetData(int i) => throw new NotImplementedException();

		public string GetDataTypeName(int i) => throw new NotImplementedException();

		public DateTime GetDateTime(int i) => throw new NotImplementedException();

		public decimal GetDecimal(int i) => throw new NotImplementedException();

		public double GetDouble(int i) => throw new NotImplementedException();

		public Type GetFieldType(int i) => throw new NotImplementedException();

		public float GetFloat(int i) => throw new NotImplementedException();

		public Guid GetGuid(int i) => throw new NotImplementedException();

		public short GetInt16(int i) => throw new NotImplementedException();

		public int GetInt32(int i) => throw new NotImplementedException();

		public long GetInt64(int i) => throw new NotImplementedException();

		public string GetName(int i) => throw new NotImplementedException();

		public DataTable GetSchemaTable() => throw new NotImplementedException();

		public string GetString(int i) => throw new NotImplementedException();

		public int GetValues(object[] values) => throw new NotImplementedException();

		public bool NextResult() => throw new NotImplementedException();

		#endregion NotImplemented
	}
}