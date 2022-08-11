using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Select from View
    /// </summary>
    public class SelectView : BaseSQLCommand<DataTable>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="name">Name of View</param>
        public SelectView([CallerMemberName] string name = null) : base($"SELECT * FROM {name}", CommandType.Text) { }

        /// <summary>
        /// Execute sync with connection
        /// </summary>
        public override DataTable Execute(SqlConnection Connection)
        {
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            SQLCommand.Connection = Connection;
            using (var R = SQLCommand.ExecuteReader())
                Result.Load(R);

            return Result;
        }

        /// <summary>
        /// Execute sync with connection
        /// </summary>
        public override async Task<DataTable> ExecuteAsync(SqlConnection Connection)
        {
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            SQLCommand.Connection = Connection;
            using (var R = await SQLCommand.ExecuteReaderAsync())
                await Task.Run(() => Result.Load(R));

            return Result;
        }
    }
}