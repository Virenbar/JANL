using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace JANL.Extensions
{
    public static class SQLExtensions
    {
        public static void ExecuteNonQuery(this SqlCommand command) => ExecuteNonQuery(command, Defaults.Connection);

        public static void ExecuteNonQuery(this SqlCommand command, string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                ExecuteNonQuery(command, Connection);
            }
        }

        public static void ExecuteNonQuery(this SqlCommand command, SqlConnection connection)
        {
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

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

        public static SqlParameter AddParameter(this SqlCommand command, string name, object value) => command.Parameters.AddWithValue(name, value);
    }
}