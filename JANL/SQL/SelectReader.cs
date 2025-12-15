using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Процедура возвращающая <see cref="SqlDataReader"/>
    /// </summary>
    [Obsolete("WIP")]
    public class SelectReader : SQLProcedure<SqlDataReader>
    {
        /// <summary>
        /// Создаёт новую процедуру именем вызывающего метода
        /// </summary>
        public SelectReader([CallerMemberName] string Name = null) : base(Name)
        {
            AutoClose = false;
        }

        /// <summary>
        /// Выполнить с указанным соединением
        /// </summary>
        public override SqlDataReader Execute(SqlConnection Connection)
        {
            Command.Connection = Connection;
            return Command.ExecuteReader();
        }

        /// <summary>
        /// Асинхронно выполнить с указанным соединением
        /// </summary>
        public override Task<SqlDataReader> ExecuteAsync(SqlConnection Connection)
        {
            Command.Connection = Connection;
            return Command.ExecuteReaderAsync();
        }
    }
}