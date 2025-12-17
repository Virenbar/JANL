using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JANL.DataReaders
{
    /// <summary>
    /// Объединяет несколько <see cref="IDataReader"/> в один
    /// </summary>
    public class UnionDataReader : IDataReader
    {
        private readonly Queue<IDataReader> Readers;
        private IDataReader Current;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

        public UnionDataReader(IEnumerable<IDataReader> readers)

        {
            FieldCount = readers.First().FieldCount;
            if (!readers.All(R => R.FieldCount == FieldCount)) { throw new ArgumentException("FieldCounts differ", nameof(readers)); }
            RecordsAffected = readers.First().RecordsAffected == -1 ? -1 : readers.Where(R => R.RecordsAffected >= 0).Sum(R => R.RecordsAffected);

            Readers = new Queue<IDataReader>(readers);
            Current = Readers.Dequeue();
        }

        public int FieldCount { get; private set; }

        public bool IsClosed { get; private set; }

        public int RecordsAffected { get; private set; }

        public void Close()
        {
            if (IsClosed) { return; }
            Current?.Close();
            while (Readers.Any()) { Readers.Dequeue().Close(); }
            IsClosed = true;
        }

        public void Dispose()
        {
            Current?.Dispose();
            while (Readers.Any()) { Readers.Dequeue().Dispose(); }
        }

        public bool NextResult()
        {
            if (Current == null) { return false; }
            if (Current.NextResult()) { return true; }

            Current?.Dispose();
            var HasNext = Readers.Any();
            if (HasNext) { Current = Readers.Dequeue(); }
            return HasNext;
        }

        public bool Read()
        {
            if (Current.Read()) { return true; }
            return NextResult();
        }

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

        #region CurrentDataReader
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public int Depth => Current.Depth;
        public object this[int i] => Current[i];

        public object this[string name] => Current[name];

        public bool GetBoolean(int i) => Current.GetBoolean(i);

        public byte GetByte(int i) => Current.GetByte(i);

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) => Current.GetBytes(i, fieldOffset, buffer, bufferoffset, length);

        public char GetChar(int i) => Current.GetChar(i);

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => Current.GetChars(i, fieldoffset, buffer, bufferoffset, length);

        public IDataReader GetData(int i) => Current.GetData(i);

        public string GetDataTypeName(int i) => Current.GetDataTypeName(i);

        public DateTime GetDateTime(int i) => Current.GetDateTime(i);

        public decimal GetDecimal(int i) => Current.GetDecimal(i);

        public double GetDouble(int i) => Current.GetDouble(i);

        public Type GetFieldType(int i) => Current.GetFieldType(i);

        public float GetFloat(int i) => Current.GetFloat(i);

        public Guid GetGuid(int i) => Current.GetGuid(i);

        public short GetInt16(int i) => Current.GetInt16(i);

        public int GetInt32(int i) => Current.GetInt32(i);

        public long GetInt64(int i) => Current.GetInt64(i);

        public string GetName(int i) => Current.GetName(i);

        public int GetOrdinal(string name) => Current.GetOrdinal(name);

        public DataTable GetSchemaTable() => Current.GetSchemaTable();

        public string GetString(int i) => Current.GetString(i);

        public object GetValue(int i) => Current.GetGuid(i);

        public int GetValues(object[] values) => Current.GetValues(values);

        public bool IsDBNull(int i) => Current.IsDBNull(i);

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        #endregion CurrentDataReader
    }
}