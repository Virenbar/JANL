using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace JANL.Data
{
    public static class SQLDataMapper
    {
        public static void ReadFromObject(SqlParameterCollection parameters, object data)
        {
            var properties = data.GetType().GetProperties();
            foreach (var prop in properties)
            {
                if (!prop.CanRead) { continue; }
                var attribute = (SQLDataAttribute)prop.GetCustomAttributes(typeof(SQLDataAttribute), false).FirstOrDefault();
                if (attribute is null || attribute.WriteOnly) { continue; }

                var name = attribute.MemberName;
                var value = prop.GetValue(data);

                //if (value == DBNull.Value) { continue; }
                parameters.AddWithValue($"@{name}", value);
            }
        }

        /// <summary>
        /// Преобразует DataTable в список объектов типа Т
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="DT"></param>
        public static List<T> ToObject<T>(DataTable DT) where T : class, new()
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
                    prop.SetValue(item, R.IsNull(Collumn) ? null : R[Collumn], null);
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
        /// <returns></returns>
        public static T ToObject<T>(DataRow R) where T : class, new()
        {
            Dictionary<string, string> D = R.Table.Columns.Cast<DataColumn>().ToDictionary(k => k.ColumnName.ToLower(), v => v.ColumnName);
            var Props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
            var Item = new T();
            foreach (var prop in Props)
            {
                var Collumn = D[prop.Name.ToLower()];
                prop.SetValue(Item, R.IsNull(Collumn) ? null : R[Collumn], null);
            }
            return Item;
        }

        public static void WriteToObject(object data, DataRow row)
        {
            var properties = data.GetType().GetProperties();
            foreach (var prop in properties)
            {
                if (!prop.CanWrite) { continue; }
                var attribute = (SQLDataAttribute)prop.GetCustomAttributes(typeof(SQLDataAttribute), false).FirstOrDefault();
                if (attribute is null || attribute.ReadOnly) { continue; }

                var name = attribute.MemberName;
                var value = row[name];

                //if (Nullable.GetUnderlyingType(prop.PropertyType) is null) { }
                if (value == DBNull.Value) { continue; }
                prop.SetValue(data, value);
            }
        }
    }
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SQLDataAttribute : Attribute
    {
        public SQLDataAttribute([CallerMemberName] string memberName = null)
        {
            MemberName = memberName;
        }

        public string MemberName { get; }
        public bool ReadOnly { get; set; }
        public bool WriteOnly { get; set; }
    }
}