﻿using System.Data.SqlClient;
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
        /// Создаёт новую процедуру с именем вызывающего метода
        /// </summary>
        public NonQueryProcedure([CallerMemberName] string Name = null) : base(Name) { }

        /// <summary>
        /// Выполнить с указанным соединением
        /// </summary>
        public override int Execute(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = Command.ExecuteNonQuery();
            return Result;
        }

        /// <summary>
        /// Асинхронно выполнить с указанным соединением
        /// </summary>
        public override async Task<int> ExecuteAsync(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = await Command.ExecuteNonQueryAsync();
            return Result;
        }
    }
}