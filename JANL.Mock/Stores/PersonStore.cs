using JANL.Models.Filters;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Stores
{
    public class PersonStore
    {
        public PersonStore()
        {
            KeyName = "Key";
            ValueName = "Value";
        }

        public string KeyName { get; }
        public string ValueName { get; }

        public Task<DataTable> SelectList() => SelectList(default);

        public async Task<DataTable> SelectList(PersonFilter filter)
        {
            var DT = new DataTable();
            DT.Columns.Add("Key", typeof(int));
            DT.Columns.Add("Value", typeof(string));
            DT.Columns.Add("Type", typeof(int));
            DT.Columns.Add("TypeString", typeof(string));
            for (int i = 0; i < 150; i++)
            {
                var Type = (PersonType)(i % 3) + 1;
                if (filter.Type.HasValue && Type != filter.Type) { continue; }

                var R = DT.NewRow();
                R["Key"] = i;
                R["Value"] = $"Person {i}";
                R["Type"] = (int)Type;
                R["TypeString"] = Type.ToString();
                DT.Rows.Add(R);
            }
            await Task.Delay(1000);
            return DT;
        }
    }
}