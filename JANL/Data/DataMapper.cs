using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace JANL.Data
{
    public class DataMapper<T> where T : class, new()
    {
        public List<PropertyInfo> Properties { get; }

        public DataMapper()
        {
            Properties = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
        }

        /// <summary>
        /// Преобразует DataTable в <see cref="List{T}"/>
        /// </summary>
        /// <param name="table"></param>
        public List<T> ToObject(DataTable table)
        {
            var items = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                items.Add(ToObject(row));
            }
            return items;
        }

        /// <summary>
        /// Преобразует DataRow в объект типа <see cref="T"/>
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public T ToObject(DataRow row) => FillObject(new T(), row);

        /// <summary>
        /// Преобразует DataRow в объект типа <see cref="T"/>
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public T FillObject(T item, DataRow row)
        {
            var data = row.Table.Columns.Cast<DataColumn>().ToDictionary(k => k.ColumnName.ToLower(), v => row[v]);
            foreach (var prop in Properties)
            {
                var name = prop.Name.ToLower();
                if (!data.ContainsKey(name)) { continue; }
                prop.SetValue(item, data[name]);
            }
            return item;
        }
    }
}