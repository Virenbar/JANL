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
            ReturnParameter = SQLCommand.Parameters.Add(new SqlParameter("@Result", DBType) { Direction = ParameterDirection.ReturnValue });
        }

        public SqlParameter AddParameter<TP>(string name, TP value)
        {
            return SQLCommand.Parameters.Add(new SqlParameter(name, value));
        }

        public override T Execute(SqlConnection Connection)
        {
            SQLCommand.Connection = Connection;
            var Result = SQLCommand.ExecuteNonQuery();
            if (ReturnParameter.Value == DBNull.Value) { return default; }
            return (T)ReturnParameter.Value;
        }

        public async override Task<T> ExecuteAsync(SqlConnection Connection)
        {
            SQLCommand.Connection = Connection;
            var Result = await SQLCommand.ExecuteNonQueryAsync();
            if (ReturnParameter.Value == DBNull.Value) { return default; }
            return (T)ReturnParameter.Value;
        }
    }
}