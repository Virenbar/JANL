using JANL.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Types
{
    public abstract class BaseDTSource : IDTSource
    {
        public BaseDTSource(string keyName) : this(keyName, keyName, new[] { keyName }) { }

        public BaseDTSource(string keyName, string valueName) : this(keyName, valueName, new[] { keyName, valueName }) { }

        public BaseDTSource(string keyName, string valueName, IEnumerable<string> collumns)
        {
            KeyName = keyName;
            ValueName = valueName;
            FilterCollumns = collumns;
        }

        public IEnumerable<string> FilterCollumns { get; protected set; }

        public string KeyName { get; private set; }

        public string ValueName { get; private set; }

        public abstract Task<DataTable> GetDataTable();
    }
}