using System.Data;

namespace JANL.SQL
{
    public abstract class SQLText<T> : BaseSQLCommand<T>
    {
        protected SQLText() : this("") { }

        protected SQLText(string text) : base(text, CommandType.Text) { }

        public string Text => Command.CommandText;
    }
}