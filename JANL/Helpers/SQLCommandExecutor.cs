using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace JANL.Helpers
{
    /// <summary>
    /// Класс для выполнения SQL команд
    /// </summary>
    public class SQLCommandExecutor
    {
        /// <summary>
        /// Создает новый экземпляр с соединением по умолчанию
        /// </summary>
        /// <param name="command">Команда</param>
        public SQLCommandExecutor(SqlCommand command) : this(command, Defaults.Connection)
        {
            Command = command;
        }

        /// <summary>
        /// Создает новый экземпляр с указанным соединением
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="connection">Соединение</param>
        public SQLCommandExecutor(SqlCommand command, string connection)
        {
            Command = command;
            Connection = connection;
        }

        /// <summary>
        /// Команда
        /// </summary>
        public SqlCommand Command { get; }

        /// <summary>
        /// Соединение по умолчанию
        /// </summary>
        public string Connection { get; set; }

        #region NonQuery

        /// <summary>
        /// Выполнить команду без запроса
        /// </summary>
        public int NonQuery() => NonQuery(Connection);

        /// <summary>
        /// Выполнить команду без запроса с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public int NonQuery(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return Command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Выполнить команду без запроса асинхронно
        /// </summary>
        /// <param name="token">Токен отмены</param>
        public async Task<int> NonQueryAsync(CancellationToken token) => await NonQueryAsync(Connection, token);

        /// <summary>
        /// Выполнить команду без запроса асинхронно
        /// </summary>
        public async Task<int> NonQueryAsync() => await NonQueryAsync(Connection);

        /// <summary>
        /// Выполнить команду без запроса асинхронно с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        /// <param name="token">Токен отмены</param>
        public async Task<int> NonQueryAsync(string connection, CancellationToken token)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return await Command.ExecuteNonQueryAsync(token);
            }
        }

        /// <summary>
        /// Выполнить команду без запроса асинхронно с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public async Task<int> NonQueryAsync(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return await Command.ExecuteNonQueryAsync();
            }
        }

        #endregion NonQuery

        #region Select

        /// <summary>
        /// Выполнить запрос
        /// </summary>
        public DataTable Select() => Select(Connection);

        /// <summary>
        /// Выполнить запрос с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public DataTable Select(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return Select(Connection);
            }
        }

        /// <summary>
        /// Выполнить запрос асинхронно
        /// </summary>
        public Task<DataTable> SelectAsync() => SelectAsync(Connection);

        /// <summary>
        /// Выполнить запрос асинхронно с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public async Task<DataTable> SelectAsync(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return await SelectAsync(Connection);
            }
        }

        private DataTable Select(SqlConnection connection)
        {
            var result = new DataTable { Locale = CultureInfo.CurrentCulture };
            Command.Connection = connection;
            using (var reader = Command.ExecuteReader())
            {
                result.Load(reader);
            }
            return result;
        }

        private async Task<DataTable> SelectAsync(SqlConnection connection)
        {
            var result = new DataTable { Locale = CultureInfo.CurrentCulture };
            Command.Connection = connection;
            using (var reader = await Command.ExecuteReaderAsync())
            {
                await Task.Run(() => result.Load(reader));
            }
            return result;
        }

        #endregion Select

        #region Select<T>

        /// <summary>
        /// Выполнить запрос
        /// </summary>
        public T Select<T>() where T : DataTable, new() => Select<T>(Connection);

        /// <summary>
        /// Выполнить запрос с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public T Select<T>(string connection) where T : DataTable, new()
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return Select<T>(Connection);
            }
        }

        /// <summary>
        /// Выполнить запрос асинхронно
        /// </summary>
        public Task<T> SelectAsync<T>() where T : DataTable, new() => SelectAsync<T>(Connection);

        /// <summary>
        /// Выполнить запрос асинхронно с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public async Task<T> SelectAsync<T>(string connection) where T : DataTable, new()
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return await SelectAsync<T>(Connection);
            }
        }

        private T Select<T>(SqlConnection connection) where T : DataTable, new()
        {
            var result = new T { Locale = CultureInfo.CurrentCulture };
            Command.Connection = connection;
            using (var reader = Command.ExecuteReader())
            {
                result.Load(reader);
            }
            return result;
        }

        private async Task<T> SelectAsync<T>(SqlConnection connection) where T : DataTable, new()
        {
            var result = new T { Locale = CultureInfo.CurrentCulture };
            Command.Connection = connection;
            using (var reader = await Command.ExecuteReaderAsync())
            {
                await Task.Run(() => result.Load(reader));
            }
            return result;
        }

        #endregion Select<T>

        #region SelectRow

        /// <summary>
        /// Выполнить запрос с возвратом первой строки либо <see langword="null"/>
        /// </summary>
        public DataRow SelectRow() => SelectRow(Connection);

        /// <summary>
        /// Выполнить запрос с возвратом первой строки либо <see langword="null"/> с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public DataRow SelectRow(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                var result = Select(Connection);
                return result.Rows.Count > 0 ? result.Rows[0] : null;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        private TResult SelectRow<TResult>(Func<DataRow, TResult> selector, SqlConnection connection)
        {
            using (var result = Select(connection))
            {
                var row = result.Rows.Count > 0 ? result.Rows[0] : null;
                return selector(row);
            }
        }

        #endregion SelectRow

        #region SelectaSet

        /// <summary>
        /// Выполнить с несколькими запросами
        /// </summary>
        public DataSet SelectSet() => SelectSet(Connection);

        /// <summary>
        /// Выполнить с несколькими запросами с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public DataSet SelectSet(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                return SelectSet(Connection);
            }
        }

        private DataSet SelectSet(SqlConnection connection)
        {

            var result = new DataSet { Locale = CultureInfo.CurrentCulture };
            Command.Connection = connection;
            using (var SDA = new SqlDataAdapter())
            {
                SDA.SelectCommand = Command;
                SDA.Fill(result);
            }
            return result;
        }

        #endregion SelectaSet

        #region Scalar

        /// <summary>
        /// Выполнить скалярный запрос
        /// </summary>
        public object Scalar() => Scalar(Connection);

        /// <summary>
        /// Выполнить скалярный запрос с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public object Scalar(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return Command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Выполнить скалярный запрос
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        public T Scalar<T>() => Scalar<T>(Connection);

        /// <summary>
        /// Выполнить скалярный запрос с указанным соединением
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <param name="connection">Соединение</param>
        public T Scalar<T>(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return (T)Command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Выполнить скалярный запрос асинхронно
        /// </summary>
        public Task<object> ScalarAsync() => ScalarAsync(Connection);

        /// <summary>
        /// Выполнить скалярный запрос асинхронно с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public async Task<object> ScalarAsync(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return await Command.ExecuteScalarAsync();
            }
        }

        /// <summary>
        /// Выполнить скалярный запрос асинхронно
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        public Task<T> ScalarAsync<T>() => ScalarAsync<T>(Connection);

        /// <summary>
        /// Выполнить скалярный запрос асинхронно с указанным соединением
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <param name="connection">Соединение</param>
        public async Task<T> ScalarAsync<T>(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                return (T)await Command.ExecuteScalarAsync();
            }
        }

        #endregion Scalar

        #region ScalarFunction

        /// <summary>
        /// Выполнить скалярную функцию
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        public T ScalarFunction<T>() => ScalarFunction<T>(Connection);

        /// <summary>
        /// Выполнить скалярную функцию с указанным соединением
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <param name="connection">Соединение</param>
        public T ScalarFunction<T>(string connection)
        {
            using (var Connection = new SqlConnection(connection))
            {
                Connection.Open();
                Command.Connection = Connection;
                var result = Command.Parameters.Add(new SqlParameter("@Result", default(T)) { Direction = ParameterDirection.ReturnValue });
                Command.ExecuteNonQuery();
                if (result.Value == DBNull.Value) { return default; }
                return (T)result.Value;
            }
        }

        #endregion ScalarFunction

        #region Reader

        /// <summary>
        /// Создать <see cref="SqlDataReader"/>
        /// </summary>
        /// <returns></returns>
        public SqlDataReader Reader() => Reader(Connection);

        /// <summary>
        /// Создать <see cref="SqlDataReader"/> с указанным соединением
        /// </summary>
        /// <param name="connection">Соединение</param>
        public SqlDataReader Reader(string connection)
        {
            var Connection = new SqlConnection(connection);
            Connection.Open();
            Command.Connection = Connection;
            return Command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        #endregion Reader
    }
}