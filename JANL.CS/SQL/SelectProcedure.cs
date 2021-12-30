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
	/// <summary>
	/// Процедура возвращающая <see cref="T"/>
	/// </summary>
	public abstract class SelectProcedure<T> : SQLProcedure<T>
	{
		/// <summary>
		/// Создаёт новую процедуру именем вызывающего метода
		/// </summary>
		public SelectProcedure(string Name) : base(Name) { }

		/// <summary>
		/// Выполнить с указанным соединением
		/// </summary>
		public override T Execute(SqlConnection Connection)
		{
			var Result = new DataTable() { Locale = System.Globalization.CultureInfo.CurrentCulture };
			SQLCommand.Connection = Connection;
			using (var R = SQLCommand.ExecuteReader())
			{
				Result.Load(R);
			}
			return Cast(Result);
		}

		/// <summary>
		/// Асинхронно выполнить с указанным соединением
		/// </summary>
		public override async Task<T> ExecuteAsync(SqlConnection Connection)
		{
			var Result = new DataTable() { Locale = System.Globalization.CultureInfo.CurrentCulture };
			SQLCommand.Connection = Connection;
			using (var R = await SQLCommand.ExecuteReaderAsync())
			{
				await Task.Run(() => Result.Load(R));
			}
			return Cast(Result);
		}

		protected abstract T Cast(DataTable DT);
	}

	internal class SSS : SelectProcedure<TTT>
	{
		public SSS() : base(nameof(SSS)) { }

		protected override TTT Cast(DataTable DT)
		{
			throw new System.NotImplementedException();
		}
	}
	internal class TTT { }

	public class AAA
	{
		public static void A()
		{
			var P = new SSS();
		}
	}
}