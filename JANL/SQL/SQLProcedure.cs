using System.Data;

namespace JANL.SQL
{   /// <summary>
    /// Процедура возвращающая <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
    public abstract class SQLProcedure<T> : BaseSQLCommand<T>
    {
        private string _schema;

        public string Schema
        {
            get => _schema;
            set
            {
                if (!string.IsNullOrWhiteSpace(_schema)) { SQLCommand.CommandText = SQLCommand.CommandText.Replace($"{_schema}.", ""); }
                if (!SQLCommand.CommandText.StartsWith($"{value}.")) { SQLCommand.CommandText = $"{value}.{SQLCommand.CommandText}"; }
                _schema = value;
            }
        }

        /// <summary>
        /// Создаёт новую процедуру с именем вызывающего метода
        /// </summary>
        protected SQLProcedure(string Name) : base(Name, CommandType.StoredProcedure) { }
    }
}