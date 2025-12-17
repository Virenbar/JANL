using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="System.Data"/>
    /// </summary>
    public static class DataExtensions
    {
        /// <summary>
        /// Преобразует DataTable в список объектов типа Т
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="DT"></param>
        public static List<T> ToObject<T>(this DataTable DT) where T : class, new()
        {
            Dictionary<string, string> D = DT.Columns.Cast<DataColumn>().ToDictionary(k => k.ColumnName.ToLower(), v => v.ColumnName);
            var Props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
            var Items = new List<T>();
            foreach (DataRow R in DT.Rows)
            {
                var item = new T();
                foreach (var prop in Props)
                {
                    if (!D.ContainsKey(prop.Name.ToLower())) { continue; }
                    var Collumn = D[prop.Name.ToLower()];
                    if (!R.IsNull(Collumn)) { prop.SetValue(item, R[Collumn], null); }
                }
                Items.Add(item);
            }
            return Items;
        }

        /// <summary>
        /// Преобразует DataRow в объект типа <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="R"></param>
        public static T ToObject<T>(this DataRow R) where T : class, new()
        {
            Dictionary<string, string> D = R.Table.Columns.Cast<DataColumn>().ToDictionary(k => k.ColumnName.ToLower(), v => v.ColumnName);
            var Props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
            var Item = new T();
            foreach (var prop in Props)
            {
                if (!D.ContainsKey(prop.Name.ToLower())) { continue; }
                var Collumn = D[prop.Name.ToLower()];
                if (!R.IsNull(Collumn)) { prop.SetValue(Item, R[Collumn], null); }
            }
            return Item;
        }
    }
}