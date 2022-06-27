using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JANL.SQL
{
    public class ScalarFunction<T> : BaseSQLCommand<T>
    {
        protected readonly SqlParameter ReturnParameter;

        public ScalarFunction([CallerMemberName] string name = null) : base(name, CommandType.StoredProcedure)
        {
            var DBType = SQLHelper.GetDBType(typeof(T));
            ReturnParameter = Command.Parameters.Add(new SqlParameter("@Result", DBType) { Direction = ParameterDirection.ReturnValue });
        }

        public SqlParameter AddParameter<TP>(string name, TP value)
        {
            return Command.Parameters.Add(new SqlParameter(name, value));
        }

        public override T Execute(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = Command.ExecuteNonQuery();
            if (ReturnParameter.Value == DBNull.Value) { return default; }
            return (T)ReturnParameter.Value;
        }

        public async override Task<T> ExecuteAsync(SqlConnection Connection)
        {
            Command.Connection = Connection;
            var Result = await Command.ExecuteNonQueryAsync();
            if (ReturnParameter.Value == DBNull.Value) { return default; }
            return (T)ReturnParameter.Value;
        }
    }
}