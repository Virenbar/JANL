using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Interfaces
{
    public interface IDTSource
    {
        Task<DataTable> GetDataTable();

        IEnumerable<string> FilterCollumns { get; }
        string KeyName { get; }
        string ValueName { get; }
    }
}