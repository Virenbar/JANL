using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Interfaces
{
    public interface IDTSource
    {
        Task<DataTable> GetDataTable();

        IEnumerable<string> FilterColumns { get; }
        string KeyName { get; }
        string ValueName { get; }
    }
}