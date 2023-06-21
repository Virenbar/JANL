using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Табличная SQL команда
    /// </summary>
    public class SelectText : SQLText<DataTable>
    {
        /// <summary>
        /// Создаёт новую команду с указанным текстом
        /// </summary>
        public SelectText(string text) : base(text) { }

        /// <summary>
        /// Выполнить с указанным соединением
        /// </summary>
        public override DataTable Execute(SqlConnection Connection)
        {
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            Command.Connection = Connection;
            using (var R = Command.ExecuteReader())
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
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            Command.Connection = Connection;
            using (var R = await Command.ExecuteReaderAsync().ConfigureAwait(false))
            {
                await Task.Run(() => Result.Load(R)).ConfigureAwait(false);
            }
            return Result;
        }
    }
}