using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
	/// <summary>
	/// Процедура возвращающая <see cref="DataTable"/>
	/// </summary>
	public class SelectProcedure : SQLProcedure<DataTable>
	{
		/// <summary>
		/// Создаёт новую процедуру именем вызывающего метода
		/// </summary>
		public SelectProcedure([CallerMemberName] string Name = null) : base(Name) { }

		/// <summary>
		/// Выполнить с указанным соединением
		/// </summary>
		public override DataTable Execute(SqlConnection Connection)
		{
			var Result = new DataTable() { Locale = System.Globalization.CultureInfo.CurrentCulture };
			SQLCommand.Connection = Connection;
			using (var R = SQLCommand.ExecuteReader())
			{
				Result.Load(R);
			}
			return Result;
		}

		/// <summary>
		/// Асинхронно выполнить с указанным соединением
		/// </summary>
		public override async Task<DataTable> ExecuteAsync(SqlConnection Connection)
		{
			var Result = new DataTable() { Locale = System.Globalization.CultureInfo.CurrentCulture };
			SQLCommand.Connection = Connection;
			using (var R = await SQLCommand.ExecuteReaderAsync())
			{
				await Task.Run(() => Result.Load(R));
			}
			return Result;
		}
	}
}