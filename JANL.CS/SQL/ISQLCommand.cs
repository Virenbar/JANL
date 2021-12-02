﻿using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
	public interface ISQLCommand<T>
	{
		SqlParameterCollection Parameters { get; }

		int Timeout { get; set; }

		T Execute();

		T Execute(SqlConnection Connection);

		T Execute(string ConnectionString);

		T Execute(SqlTransaction Transaction);

		Task<T> ExecuteAsync();

		Task<T> ExecuteAsync(SqlConnection Connection);

		Task<T> ExecuteAsync(string ConnectionString);

		Task<T> ExecuteAsync(SqlTransaction Transaction);
	}
}