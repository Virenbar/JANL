using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Скалярная SQL команда
    /// </summary>
    /// <typeparam name="T">Тип значения возвращаемого командой</typeparam>
    public class ScalarText<T> : SQLText<T>
    {
        /// <summary>
        /// Создаёт новую команду с указанным текстом
        /// </summary>
        public ScalarText(string text) : base(text) { }

        /// <summary>
        /// Выполнить с указанным соединением
        /// </summary>
        public override T Execute(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = (T)Command.ExecuteScalar();
            return Result;
        }

        /// <summary>
        /// Асинхронно выполнить с указанным соединением
        /// </summary>
        public override async Task<T> ExecuteAsync(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = (T)await Command.ExecuteScalarAsync();
            return Result;
        }
    }
}