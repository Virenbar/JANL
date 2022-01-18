using System.Data;

namespace JANL.SQL
{
	public abstract class SQLText<T> : BaseSQLCommand<T>
	{
		public SQLText() : this("") { }

		public SQLText(string text) : base(text, CommandType.Text) { }

		public string Text => SQLCommand.CommandText;
	}
}