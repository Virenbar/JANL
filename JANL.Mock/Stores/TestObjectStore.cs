using System;
using System.Data;
using System.Threading.Tasks;

namespace JANL.Stores
{
    public class TestObjectStore
    {
        private readonly static DateTime Date = new DateTime(2000, 1, 1);

        public async Task<DataTable> SelectList()
        {
            var DT = new DataTable();
            DT.Columns.Add("Key", typeof(int));
            DT.Columns.Add("TestInteger", typeof(int));
            DT.Columns.Add("TestString", typeof(string));
            DT.Columns.Add("TestDate", typeof(DateTime));
            DT.Columns.Add("TestDecimal", typeof(Decimal));
            for (int i = 0; i < 100; i++)
            {
                var R = DT.NewRow();
                R["Key"] = i;
                R["TestInteger"] = i;
                R["TestString"] = $"String {i}";
                R["TestDate"] = DateTime.Today.AddDays(i);
                R["TestDecimal"] = new decimal(i);
                DT.Rows.Add(R);
            }
            await Task.Delay(500);
            return DT;
        }
    }
}