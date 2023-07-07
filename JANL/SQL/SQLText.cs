using System.Data;

namespace JANL.SQL
{
    /// <summary>
    /// SQL запрос возвращающий <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип значения возвращаемого запросом</typeparam>
    public abstract class SQLText<T> : BaseSQLCommand<T>
    {
        protected SQLText() : this("") { }

        protected SQLText(string text) : base(text, CommandType.Text) { }

        /// <summary>
        /// Текст команды
        /// </summary>
        public string Text => Command.CommandText;
    }
}