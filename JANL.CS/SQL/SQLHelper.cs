using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANL.SQL
{
	/// <summary>
	/// Класс для работы с SQL командами
	/// (ﾉಥ益ಥ）ﾉ彡ɐɯǝɥɔSllᴉℲ
	/// </summary>
	public static class SQLHelper
	{
		/// <summary>
		/// Создает и открывает новое соединение по умолчанию
		/// </summary>
		/// <returns></returns>
		public static SqlConnection NewConnection() => NewConnection(Defaults.DefaultConnection);

		/// <summary>
		/// Создает и открывает новое соединение
		/// </summary>
		/// <param name="constr"></param>
		/// <returns></returns>
		public static SqlConnection NewConnection(string constr)
		{
			var Connection = new SqlConnection(constr);
			if (Connection.State != ConnectionState.Open) { Connection.Open(); }
			return Connection;
		}

		/// <summary>
		/// Создает и открывает новое соединение по умолчанию
		/// </summary>
		/// <returns></returns>
		public static Task<SqlConnection> NewConnectionAsync() => NewConnectionAsync(Defaults.DefaultConnection);

		/// <summary>
		/// Создает и открывает новое соединение
		/// </summary>
		/// <param name="constr"></param>
		/// <returns></returns>
		public async static Task<SqlConnection> NewConnectionAsync(string constr)
		{
			var Connection = new SqlConnection(constr);
			if (Connection.State != ConnectionState.Open) { await Connection.OpenAsync(); }
			return Connection;
		}

		/// <summary>
		/// Начинает транзакцию используя соединение по умолчанию
		/// </summary>
		public static SqlTransaction NewTransaction() => NewTransaction(Defaults.DefaultConnection);

		/// <summary>
		/// Начинает транзакцию используя соединение
		/// </summary>
		public static SqlTransaction NewTransaction(string constr) => NewTransaction(constr, IsolationLevel.ReadCommitted);

		/// <summary>
		/// Начинает транзакцию используя соединение по умолчанию и указанное поведение блокировки
		/// </summary>
		public static SqlTransaction NewTransaction(IsolationLevel IL) => NewTransaction(Defaults.DefaultConnection, IsolationLevel.ReadCommitted);

		/// <summary>
		/// Начинает транзакцию используя соединение и указанное поведение блокировки
		/// </summary>
		public static SqlTransaction NewTransaction(string constr, IsolationLevel IL)
		{
			var Connection = NewConnection(constr);
			return Connection.BeginTransaction(IL);
		}
	}
}