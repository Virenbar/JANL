using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Команда без выходных данных
    /// </summary>
    internal class NonQueryText : SQLText<int>
    {
        /// <summary>
        /// Создаёт новую команду с указанным текстом
        /// </summary>
        public NonQueryText(string text) : base(text) { }

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