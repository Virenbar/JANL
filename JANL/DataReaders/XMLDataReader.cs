using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace JANL.DataReaders
{
    /// <summary>
    /// Читатель XML файла
    /// </summary>
    public class XMLDataReader : IDataReader
    {
        /// <summary>
        /// Список атрибутов для чтения
        /// </summary>
        protected readonly List<string> AttributeNames;

        /// <summary>
        /// Значения атрибутов в текущей строке
        /// </summary>
        protected readonly Dictionary<string, string> CurrentAttributes = new Dictionary<string, string>();

        /// <summary>
        /// Сопоставления имён атрибутов и их индексов
        /// </summary>
        protected readonly Dictionary<string, int> Mapping;

        /// <summary>
        /// XML файл
        /// </summary>
        protected readonly XmlReader XML;

        /// <summary>
        /// Создаёт читатель XML файла
        /// </summary>
        /// <param name="File">Путь файла</param>
        protected XMLDataReader(string File)
        {
            XML = XmlReader.Create("file:////" + File);
        }

        /// <summary>
        /// Создаёт читатель XML файла
        /// </summary>
        /// <param name="File">Путь файла</param>
        /// <param name="AttributeNames">Список атрибутов</param>
        public XMLDataReader(string File, IEnumerable<string> AttributeNames) : this(File)
        {
            this.AttributeNames = AttributeNames.ToList();
            var index = 0;
            Mapping = AttributeNames.ToDictionary(K => K, V => index++);
        }

        /// <summary>
        /// Возвращает количество атрибутов в текущей строке
        /// </summary>
        public int FieldCount => AttributeNames.Count;

        /// <summary>
        /// Получает атрибут, расположенный по указанному индексу
        /// </summary>
        /// <param name="i">Индекс (отсчет с нуля) получаемого атрибута</param>
        public object this[int i] => CurrentAttributes[AttributeNames[i]];

        /// <summary>
        /// Получает атрибут с указанным именем
        /// </summary>
        /// <param name="name">Имя атрибута</param>
        public object this[string name] => CurrentAttributes[name];

        /// <summary>
        /// Возвращает индекс атрибута
        /// </summary>
        /// <param name="name">Имя атрибута</param>
        public int GetOrdinal(string name) => Mapping[name];

        /// <summary>
        /// Возвращает значение указанного атрибута
        /// </summary>
        /// <param name="i">Индекс атрибута</param>
        public object GetValue(int i) => this[i];

        /// <summary>
        /// Возвращает сообщение о том, имеет ли указанное поле значение null
        /// </summary>
        /// <param name="i">Индекс атрибута</param>
        public bool IsDBNull(int i) => this[i] == null;

        /// <summary>
        /// Перемещает <see cref="IDataReader"/> к следующей записи
        /// </summary>
        /// <returns><see cref="bool.TrueString"/>, если остались еще строки; в обратном случае — <see cref="bool.FalseString"/></returns>
        public bool Read()
        {
            while (XML.Read())
            {
                if (IsValidRow())
                {
                    CurrentAttributes.Clear();
                    foreach (var Name in AttributeNames)
                    {
                        CurrentAttributes[Name] = GetAttribute(Name);
                    }
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Возвращает значение указанного атрибута
        /// </summary>
        /// <param name="name">Имя атрибута</param>
        protected virtual string GetAttribute(string name)
        {
            return XML.GetAttribute(name);
        }

        /// <summary>
        /// Является ли текущая строка корректной (Имеет любой из атрибутов)
        /// </summary>
        protected virtual bool IsValidRow()
        {
            return XML.HasAttributes && AttributeNames.Any((name) => XML.GetAttribute(name) != null);
        }

        #region IDisposable Support
        private bool _disposed;

        /// <summary>
        /// Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="XMLDataReader"/>
        /// </summary>
        public void Dispose() => Dispose(true);

        /// <summary>
        /// Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="XMLDataReader"/>
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    AttributeNames.Clear();
                    CurrentAttributes.Clear();
                    Mapping.Clear();
                    XML.Dispose();
                }
                _disposed = true;
            }
        }

        #endregion IDisposable Support

        #region NotImplemented
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public int Depth => throw new InvalidOperationException();

        public bool IsClosed => throw new InvalidOperationException();

        public int RecordsAffected => throw new InvalidOperationException();

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

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

        #endregion NotImplemented
    }
}