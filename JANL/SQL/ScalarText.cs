using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// SQL код <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
    public class ScalarText<T> : SQLText<T>
    {
        /// <summary>
        /// Создаёт новую процедуру именем вызывающего метода
        /// </summary>
        public ScalarText(string Text) : base(Text) { }

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