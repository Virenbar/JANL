using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JANL.SQL
{
    /// <summary>
    /// Класс для работы с SQL командами
    /// (ﾉಥ益ಥ）ﾉ彡ɐɯǝɥɔSllᴉℲ
    /// </summary>
    public static class SQLHelper
    {
        #region Converters

        public static Type GetCRLType(SqlDbType type)
        {
            switch (type)
            {
                case SqlDbType.BigInt:
                    return typeof(long);

                case SqlDbType.Image:
                case SqlDbType.Binary:
                    return typeof(byte[]);

                case SqlDbType.Bit:
                    return typeof(bool);

                case SqlDbType.SmallDateTime:
                case SqlDbType.DateTime:
                case SqlDbType.Date:
                case SqlDbType.DateTime2:
                    return typeof(DateTime);

                case SqlDbType.Float:
                    return typeof(double);

                case SqlDbType.Int:
                    return typeof(int);

                case SqlDbType.Decimal:
                case SqlDbType.SmallMoney:
                case SqlDbType.Money:
                    return typeof(decimal);

                case SqlDbType.VarChar:
                case SqlDbType.Char:
                case SqlDbType.NChar:
                case SqlDbType.Text:
                case SqlDbType.NText:
                case SqlDbType.NVarChar:
                    return typeof(string);

                case SqlDbType.Real:
                    return typeof(float);

                case SqlDbType.UniqueIdentifier:
                    return typeof(Guid);

                case SqlDbType.SmallInt:
                    return typeof(short);

                case SqlDbType.Timestamp:
                    return typeof(byte[]);

                case SqlDbType.TinyInt:
                    return typeof(byte);

                case SqlDbType.VarBinary:
                    return typeof(byte[]);

                case SqlDbType.Time:
                    return typeof(TimeSpan);

                case SqlDbType.DateTimeOffset:
                    return typeof(DateTimeOffset);

                default:
                    throw new ArgumentException($"Unsupported type: {type}");
            }
        }

        public static SqlDbType GetDBType(Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            switch (type)
            {
                case Type _ when type == typeof(bool):
                    return SqlDbType.Bit;

                case Type _ when type == typeof(int):
                    return SqlDbType.Int;

                case Type _ when type == typeof(long):
                    return SqlDbType.BigInt;

                case Type _ when type == typeof(decimal):
                    return SqlDbType.Money;

                case Type _ when type == typeof(string):
                    return SqlDbType.VarChar;

                case Type _ when type == typeof(TimeSpan):
                    return SqlDbType.Time;

                case Type _ when type == typeof(DateTime):
                    return SqlDbType.DateTime;

                case Type _ when type == typeof(DateTimeOffset):
                    return SqlDbType.DateTimeOffset;

                case Type _ when type == typeof(Guid):
                    return SqlDbType.UniqueIdentifier;

                default:
                    throw new ArgumentException($"Unsupported type: {type.Name}");
            }
        }

        #endregion Converters

        /// <summary>
        /// Создает и открывает новое соединение по умолчанию
        /// </summary>
        /// <returns></returns>
        public static SqlConnection NewConnection() => NewConnection(JANL.Defaults.Connection);

        /// <summary>
        /// Создает и открывает новое соединение
        /// </summary>
        /// <param name="constr"></param>
        /// <returns></returns>
        public static SqlConnection NewConnection(string constr)
        {
            var Connection = new SqlConnection(constr);
            if (Connection.State != ConnectionState.Open) { Connection.Open(); }
            return Connection;
        }

        /// <summary>
        /// Создает и открывает новое соединение по умолчанию
        /// </summary>
        /// <returns></returns>
        public static Task<SqlConnection> NewConnectionAsync() => NewConnectionAsync(JANL.Defaults.Connection);

        /// <summary>
        /// Создает и открывает новое соединение
        /// </summary>
        /// <param name="constr"></param>
        /// <returns></returns>
        public async static Task<SqlConnection> NewConnectionAsync(string constr)
        {
            var Connection = new SqlConnection(constr);
            if (Connection.State != ConnectionState.Open) { await Connection.OpenAsync(); }
            return Connection;
        }

        /// <summary>
        /// Начинает транзакцию используя соединение по умолчанию
        /// </summary>
        public static SqlTransaction NewTransaction() => NewTransaction(JANL.Defaults.Connection);

        /// <summary>
        /// Начинает транзакцию используя соединение
        /// </summary>
        public static SqlTransaction NewTransaction(string constr) => NewTransaction(constr, IsolationLevel.ReadCommitted);

        /// <summary>
        /// Начинает транзакцию используя соединение по умолчанию и указанное поведение блокировки
        /// </summary>
        public static SqlTransaction NewTransaction(IsolationLevel IL) => NewTransaction(JANL.Defaults.Connection, IsolationLevel.ReadCommitted);

        /// <summary>
        /// Начинает транзакцию используя соединение и указанное поведение блокировки
        /// </summary>
        public static SqlTransaction NewTransaction(string constr, IsolationLevel IL)
        {
            var Connection = NewConnection(constr);
            return Connection.BeginTransaction(IL);
        }
    }
}