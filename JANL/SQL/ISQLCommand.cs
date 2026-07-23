using System.Data.SqlClient;
using System.Threading.Tasks;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
namespace JANL.SQL
{
    public interface ISQLCommand<T> : ISQLCommand
    {
        T Execute();

        T Execute(SqlConnection Connection);

        T Execute(string ConnectionString);

        T Execute(SqlTransaction Transaction);

        Task<T> ExecuteAsync();

        Task<T> ExecuteAsync(SqlConnection Connection);

        Task<T> ExecuteAsync(string ConnectionString);

        Task<T> ExecuteAsync(SqlTransaction Transaction);
    }

    public interface ISQLCommand
    {
        SqlParameterCollection Parameters { get; }

        int Timeout { get; set; }
    }
}