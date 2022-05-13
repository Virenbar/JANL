using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Types
{
    [Obsolete]
    public abstract class BaseDTSource : IDTSource
    {
        protected BaseDTSource(string keyName) : this(keyName, keyName, new[] { keyName }) { }

        protected BaseDTSource(string keyName, string valueName) : this(keyName, valueName, new[] { keyName, valueName }) { }

        protected BaseDTSource(string keyName, string valueName, IEnumerable<string> columns)
        {
            KeyName = keyName;
            ValueName = valueName;
            FilterColumns = columns;
        }

        public IEnumerable<string> FilterColumns { get; protected set; }

        public string KeyName { get; private set; }

        public string ValueName { get; private set; }

        public abstract Task<DataTable> GetDataTable();
    }
}