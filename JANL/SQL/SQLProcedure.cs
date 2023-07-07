using System.Data;

namespace JANL.SQL
{
    /// <summary>
    /// Процедура возвращающая <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
    public abstract class SQLProcedure<T> : BaseSQLCommand<T>
    {
        private string _schema;

        /// <summary>
        /// Создаёт новую процедуру
        /// </summary>
        protected SQLProcedure(string Name) : base(Name, CommandType.StoredProcedure)
        {
            if (Name.Contains("."))
            {
                var S = Name.Split(new[] { '.' }, 2, System.StringSplitOptions.RemoveEmptyEntries);
                Schema = S[0];
            }
        }

        /// <summary>
        /// Схема процедуры
        /// </summary>
        public string Schema
        {
            get => _schema;
            set
            {
                _schema = value;
                if (Command.CommandText.Contains("."))
                {
                    var S = Command.CommandText.Split(new[] { '.' }, 2);
                    Command.CommandText = S[1];
                }
                if (string.IsNullOrWhiteSpace(value)) { return; }
                Command.CommandText = $"{value}.{Command.CommandText}";
            }
        }
    }
}