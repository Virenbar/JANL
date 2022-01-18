using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
	/// <summary>
	/// Процедура возвращающая количество задействованных строк
	/// </summary>
	public class NonQueryProcedure : SQLProcedure<int>
	{
		/// <summary>
		/// Создаёт новую процедуру именем вызывающего метода
		/// </summary>
		public NonQueryProcedure([CallerMemberName] string Name = null) : base(Name) { }

		/// <summary>
		/// Выполнить с указанным соединением
		/// </summary>
		public override int Execute(SqlConnection Connection)
		{
			SQLCommand.Connection = Connection;
			var Result = SQLCommand.ExecuteNonQuery();
			return Result;
		}

		/// <summary>
		/// Асинхронно выполнить с указанным соединением
		/// </summary>
		public override async Task<int> ExecuteAsync(SqlConnection Connection)
		{
			SQLCommand.Connection = Connection;
			var Result = await SQLCommand.ExecuteNonQueryAsync();
			return Result;
		}
	}
}