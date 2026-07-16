using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using JANL.Helpers;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для SQL
    /// </summary>
    public static class SQLExtensions
    {
        private static string DefaultConnection => Defaults.Connection;

        /// <summary>
        /// Добавить параметр в команду
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="name">Название</param>
        /// <param name="type">Тип</param>
        /// <param name="value">Значение</param>
        public static SqlParameter AddParameter(this SqlCommand command, string name, SqlDbType type, object value)
        {
            return command.Parameters.Add(new SqlParameter(name, type) { Value = value });
        }

        /// <summary>
        /// Добавляет параметр в команду
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="name">Название</param>
        /// <param name="value">Значение</param>
        public static SqlParameter AddParameter(this SqlCommand command, string name, object value) => command.Parameters.AddWithValue(name, value);

        /// <summary>
        /// Устанавливает схему команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="schema">Схема</param>
        public static SqlCommand SetSchema(this SqlCommand command, string schema)
        {
            var name = command.CommandText.Split('.').Last();
            command.CommandText = $"{schema}.{name}";
            return command;
        }

        #region NonQuery

        /// <summary>
        /// Выполнить с соединением по умолчанию
        /// </summary>
        public static void ExecuteNonQuery(this SqlCommand command) => ExecuteNonQuery(command, DefaultConnection);

        /// <summary>
        /// Выполнить с указанным соединением
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="connection">Соединение</param>
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

        #region SelectDataTable

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

        #endregion SelectDataTable

        #region SelectDataRow

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

        #endregion SelectDataRow

        #region Executor

        /// <summary>
        ///
        /// </summary>
        /// <param name="command">Команда</param>
        public static SQLCommandExecutor Executor(this SqlCommand command) => Executor(command, DefaultConnection);

        /// <summary>
        ///
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="connection">Соединение</param>
        public static SQLCommandExecutor Executor(this SqlCommand command, string connection)
        {
            return new SQLCommandExecutor(command, connection);
        }

        #endregion Executor
    }
}