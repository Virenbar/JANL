using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            Command.Connection = Connection;
            //TODO Replace with Reader (Blocked by RGI)
            using (var A = new SqlDataAdapter(Command))
            {
                A.Fill(Result);
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

        /// <summary>
        /// Создать Reader
        /// </summary>
        public SqlDataReader ExecuteReader()
        {
            var Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            Command.Connection = Connection;
            return Command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Создать Reader
        /// </summary>
        public async Task<SqlDataReader> ExecuteReaderAsync()
        {
            var Connection = new SqlConnection(ConnectionString);
            await Connection.OpenAsync();
            Command.Connection = Connection;
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}