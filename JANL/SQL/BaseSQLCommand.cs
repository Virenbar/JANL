using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    public abstract class BaseSQLCommand<T> : ISQLCommand<T>, IDisposable
    {
        protected readonly SqlCommand SQLCommand;

        protected BaseSQLCommand(string CommandText, CommandType Type)
        {
            SQLCommand = new SqlCommand(CommandText) { CommandType = Type, CommandTimeout = JANL.Defaults.Timeout };
            ConnectionString = JANL.Defaults.Connection;
        }

        public void Prepare() => SQLCommand.Prepare();

        #region Properties

        /// <summary>
        /// Соединение для команды
        /// <para>По умолчанию используется значение <see cref="DefaultConnection"/></para>
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Параметры команды
        /// </summary>
        public SqlParameterCollection Parameters => SQLCommand.Parameters;

        /// <summary>
        /// Время ожидания выполнения команды (в секундах)
        /// <para>По умолчанию используется значение <see cref="DefaultTimeout"/></para>
        /// </summary>
        public int Timeout
        {
            get => SQLCommand.CommandTimeout;
            set => SQLCommand.CommandTimeout = value;
        }

        #endregion Properties

        #region Synchronous

        /// <summary>
        /// Выполняет команду с соединением по умолчанию
        /// </summary>
        public T Execute()
        {
            using (var Connection = NewConnection(ConnectionString))
            { return Execute(Connection); }
        }

        /// <summary>
        /// Выполняет команду в указанной транзакции
        /// </summary>
        public T Execute(SqlTransaction Transaction)
        {
            SQLCommand.Transaction = Transaction;
            return Execute(Transaction.Connection);
        }

        /// <summary>
        /// Выполняет команду с указанным соединением
        /// </summary>
        public T Execute(string ConnectionString)
        {
            using (var Connection = NewConnection(ConnectionString))
            {
                return Execute(Connection);
            }
        }

        /// <summary>
        /// Выполняет команду с указанным соединением
        /// </summary>
        public abstract T Execute(SqlConnection Connection);

        /// <summary>
        /// Создает и открывает новое соединение
        /// </summary>
        protected static SqlConnection NewConnection(string ConnectionString)
        {
            var Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) { Connection.Open(); }
            return Connection;
        }

        #endregion Synchronous

        #region Asynchronous

        /// <summary>
        /// Асинхронно выполняет команду с соединением по умолчанию
        /// </summary>
        public async Task<T> ExecuteAsync()
        {
            using (var Connection = await NewConnectionAsync(ConnectionString).ConfigureAwait(false))
            {
                return await ExecuteAsync(Connection).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Асинхронно выполняет команду в указанной транзакции
        /// </summary>
        public Task<T> ExecuteAsync(SqlTransaction Transaction)
        {
            SQLCommand.Transaction = Transaction;
            return ExecuteAsync(Transaction.Connection);
        }

        /// <summary>
        /// Асинхронно выполняет команду с указанным соединением
        /// </summary>
        public async Task<T> ExecuteAsync(string ConnectionString)
        {
            using (var Connection = await NewConnectionAsync(ConnectionString).ConfigureAwait(false))
            {
                return await ExecuteAsync(Connection).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Асинхронно выполняет команду с указанным соединением
        /// </summary>
        public abstract Task<T> ExecuteAsync(SqlConnection Connection);

        /// <summary>
        /// Создает и открывает новое соединение
        /// </summary>
        protected static async Task<SqlConnection> NewConnectionAsync(string ConnectionString)
        {
            var Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) { await Connection.OpenAsync(); }
            return Connection;
        }

        #endregion Asynchronous

        #region IDisposable Support
        private bool disposedValue;

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing) { SQLCommand.Dispose(); }
                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}