using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
	/// <summary>
	/// Процедура возвращающая <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
	public class ScalarProcedure<T> : SQLProcedure<T>
	{
		/// <summary>
		/// Создаёт новую процедуру именем вызывающего метода
		/// </summary>
		public ScalarProcedure([CallerMemberName] string Name = null) : base(Name) { }

		/// <summary>
		/// Выполнить с указанным соединением
		/// </summary>
		public override T Execute(SqlConnection Connection)
		{
			SQLCommand.Connection = Connection;
			var Result = (T)SQLCommand.ExecuteScalar();
			return Result;
		}

		/// <summary>
		/// Асинхронно выполнить с указанным соединением
		/// </summary>
		public override async Task<T> ExecuteAsync(SqlConnection Connection)
		{
			SQLCommand.Connection = Connection;
			var Result = (T)await SQLCommand.ExecuteScalarAsync();
			return Result;
		}
	}
}