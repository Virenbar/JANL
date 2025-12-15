using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace JANL.Extensions
{
    public static class SQLExtensions
    {
        private static string DefaultConnection => Defaults.Connection;

        #region NonQuery

        public static void ExecuteNonQuery(this SqlCommand command) => ExecuteNonQuery(command, DefaultConnection);

        public static void ExecuteNonQuery(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                command.Connection = Connection;
                command.ExecuteNonQuery();
            }
        }

        public static void ExecuteNonQuery(this SqlCommand command, SqlConnection connection)
        {
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        #endregion NonQuery

        #region Scalar

        public static object ExecuteScalar(this SqlCommand command) => ExecuteScalar(command, DefaultConnection);

        public static T ExecuteScalar<T>(this SqlCommand command) => ExecuteScalar<T>(command, DefaultConnection);

        public static object ExecuteScalar(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                command.Connection = Connection;
                return command.ExecuteScalar();
            }
        }

        public static T ExecuteScalar<T>(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                command.Connection = Connection;
                return (T)command.ExecuteScalar();
            }
        }

        #endregion Scalar

        #region Select

        public static DataTable ExecuteSelect(this SqlCommand command) => ExecuteSelect(command, DefaultConnection);

        public static DataTable ExecuteSelect(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return command.ExecuteSelect(Connection);
            }
        }

        public static DataTable ExecuteSelect(this SqlCommand command, SqlConnection connection)
        {
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            command.Connection = connection;
            using (var Reader = command.ExecuteReader())
            {
                Result.Load(Reader);
            }
            return Result;
        }

        #endregion Select

        #region SelectRow

        public static DataRow ExecuteSelectRow(this SqlCommand command) => ExecuteSelectRow(command, DefaultConnection);

        public static DataRow ExecuteSelectRow(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return command.ExecuteSelectRow(Connection);
            }
        }

        public static DataRow ExecuteSelectRow(this SqlCommand command, SqlConnection connection)
        {
            var Result = new DataTable { Locale = CultureInfo.CurrentCulture };
            command.Connection = connection;
            using (var Reader = command.ExecuteReader())
            {
                Result.Load(Reader);
            }
            return Result.Rows.Count > 0 ? Result.Rows[0] : null;
        }

        #endregion SelectRow

        public static SqlParameter AddParameter(this SqlCommand command, string name, SqlDbType type, object value)
        {
            return command.Parameters.Add(new SqlParameter(name, type) { Value = value });
        }

        public static SqlParameter AddParameter(this SqlCommand command, string name, object value) => command.Parameters.AddWithValue(name, value);

        public static SqlCommand SetSchema(this SqlCommand command, string schema)
        {
            var name = command.CommandText.Split('.').Last();
            command.CommandText = $"{schema}.{name}";
            return command;
        }
    }
}