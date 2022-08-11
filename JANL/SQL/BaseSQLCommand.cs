﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Базовая оболочка для <see cref="SqlCommand"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseSQLCommand<T> : ISQLCommand<T>, IDisposable
    {
        protected readonly SqlCommand Command;
        protected readonly SqlConnection Connection;
        protected bool AutoClose = true;

        protected BaseSQLCommand(string CommandText, CommandType Type)
        {
            Command = new SqlCommand(CommandText) { CommandType = Type, CommandTimeout = Defaults.Timeout };
            Connection = new SqlConnection(Defaults.Connection);
        }

        public SqlCommand SQLCommand => Command;

        public void Prepare() => Command.Prepare();

        #region Properties

        /// <summary>
        /// Соединение для команды
        /// <para>По умолчанию используется значение <see cref="Defaults.Connection"/></para>
        /// </summary>
        public string ConnectionString
        {
            get => Connection.ConnectionString;
            set => Connection.ConnectionString = value;
        }

        /// <summary>
        /// Параметры команды
        /// </summary>
        public SqlParameterCollection Parameters => Command.Parameters;

        /// <summary>
        /// Время ожидания выполнения команды (в секундах)
        /// <para>По умолчанию используется значение <see cref="Defaults.Timeout"/></para>
        /// </summary>
        public int Timeout
        {
            get => Command.CommandTimeout;
            set => Command.CommandTimeout = value;
        }

        #endregion Properties

        #region Synchronous

        /// <summary>
        /// Выполняет команду с соединением по умолчанию
        /// </summary>
        public T Execute()
        {
            Connection.Open();
            var Result = Execute(Connection);
            if (AutoClose) { Connection.Close(); }
            return Result;
        }

        /// <summary>
        /// Выполняет команду в указанной транзакции
        /// </summary>
        public T Execute(SqlTransaction Transaction)
        {
            Command.Transaction = Transaction;
            return Execute(Transaction.Connection);
        }

        /// <summary>
        /// Выполняет команду с указанным соединением
        /// </summary>
        public T Execute(string ConnectionString)
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                return Execute(Connection);
            }
        }

        /// <summary>
        /// Выполняет команду с указанным соединением
        /// </summary>
        public abstract T Execute(SqlConnection Connection);

        #endregion Synchronous

        #region Asynchronous

        /// <summary>
        /// Асинхронно выполняет команду с соединением по умолчанию
        /// </summary>
        public async Task<T> ExecuteAsync()
        {
            await Connection.OpenAsync();
            var Result = await ExecuteAsync(Connection).ConfigureAwait(false);
            if (AutoClose) { Connection.Close(); }
            return Result;
        }

        /// <summary>
        /// Асинхронно выполняет команду в указанной транзакции
        /// </summary>
        public Task<T> ExecuteAsync(SqlTransaction Transaction)
        {
            Command.Transaction = Transaction;
            return ExecuteAsync(Transaction.Connection);
        }

        /// <summary>
        /// Асинхронно выполняет команду с указанным соединением
        /// </summary>
        public async Task<T> ExecuteAsync(string ConnectionString)
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                await Connection.OpenAsync();
                return await ExecuteAsync(Connection).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Асинхронно выполняет команду с указанным соединением
        /// </summary>
        public abstract Task<T> ExecuteAsync(SqlConnection Connection);

        #endregion Asynchronous

        #region IDisposable Support
        private bool disposedValue;

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Command.Dispose();
                    Connection.Dispose();
                }
                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}