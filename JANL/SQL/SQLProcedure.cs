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
                _schema = value;
                if (SQLCommand.CommandText.Contains("."))
                {
                    var S = SQLCommand.CommandText.Split(new char[] { '.' }, 2);
                    SQLCommand.CommandText = S[1];
                }
                if (string.IsNullOrWhiteSpace(value)) { return; }
                SQLCommand.CommandText = $"{value}.{SQLCommand.CommandText}";
            }
        }

        /// <summary>
        /// Создаёт новую процедуру с именем вызывающего метода
        /// </summary>
        protected SQLProcedure(string Name) : base(Name, CommandType.StoredProcedure)
        {
            if (Name.Contains("."))
            {
                var S = Name.Split(new char[] { '.' }, 2, System.StringSplitOptions.RemoveEmptyEntries);
                Schema = S[0];
            }
        }
    }
}