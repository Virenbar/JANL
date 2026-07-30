using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace JANL.Data
{
    /// <summary>
    /// Класс для заполнения свойств объекта на основе <see cref="DataRow"/> и заполнения параметров <see cref="SqlParameterCollection"/> на основе объекта
    /// </summary>
    public static class SQLDataMapper
    {
        private readonly static ConcurrentDictionary<Type, PropertyInfo[]> Cache = new ConcurrentDictionary<Type, PropertyInfo[]>();

        /// <summary>
        /// Считать свойства объекта в <see cref="SqlParameterCollection"/>
        /// </summary>
        /// <param name="data">Объект</param>
        /// <param name="parameters">Параметры</param>
        public static void ReadFromObject(object data, SqlParameterCollection parameters)
        {
            var type = data.GetType();
            //var t = type.GetCustomAttributes(typeof(SQLObjectAttribute), false).FirstOrDefault();

            //var t = Cache.GetOrAdd(type, type.GetProperties());
            var properties = data.GetType().GetProperties();
            foreach (var prop in properties)
            {
                if (!prop.CanRead) { continue; }
                var name = prop.Name;

                //var key = prop.GetAttribute<PrimaryKeyAttribute>();
                //if (key != null) { continue; }

                var ignore = prop.GetAttribute<MapperIgnoreAttribute>();
                if (ignore != null) { continue; }

                var member = prop.GetAttribute<MapperColumnAttribute>();
                if (member != null)
                {
                    if (member.WriteOnly) { continue; }
                    name = member.MemberName;
                }

                var value = prop.GetValue(data);

                if (value is null) { continue; }

                if (parameters.Contains($"@{name}")) { continue; }
                parameters.AddWithValue($"@{name}", value);
            }
        }

        /// <summary>
        /// Создаёт экземпляр <typeparamref name="T"/> и записывает значения ячеек в свойства объекта
        /// </summary>
        /// <param name="row">Строка</param>
        public static T WriteToObject<T>(DataRow row) where T : new()
        {
            var Object = new T();
            WriteToObject(row, Object);
            return Object;
        }

        /// <summary>
        /// Записать данные строки в объект
        /// </summary>
        /// <param name="row">Строка</param>
        /// <param name="data">Объект</param>
        public static void WriteToObject(DataRow row, object data)
        {
            var properties = data.GetType().GetProperties();
            foreach (var prop in properties)
            {
                if (!prop.CanWrite) { continue; }
                var name = prop.Name;

                var ignore = prop.GetAttribute<MapperIgnoreAttribute>();
                if (ignore != null) { continue; }

                var member = prop.GetAttribute<MapperColumnAttribute>();
                //if (member is null || member.ReadOnly) { continue; }
                if (member != null)
                {
                    if (member.ReadOnly) { continue; }
                    name = member.MemberName;
                }

                var value = row[name];

                //if (Nullable.GetUnderlyingType(prop.PropertyType) is null) { }
                if (value == DBNull.Value) { continue; }
                prop.SetValue(data, value);
            }
        }

        private static T GetAttribute<T>(this PropertyInfo propertie) where T : Attribute
        {
            return (T)propertie.GetCustomAttributes(typeof(T), false).FirstOrDefault();
        }

        #region ToObject

        /// <summary>
        /// Перенесен в <see cref="DataMapper{T}.ToObject(DataTable)"/>
        /// </summary>
        [Obsolete("Use Data.DataMapper<T>.ToObject")]
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
        /// Перенесен в <see cref="DataMapper{T}.ToObject(DataRow)"/>
        /// </summary>
        [Obsolete("Use Data.DataMapper<T>.ToObject")]
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

        #endregion ToObject
    }

    #region Attributes

    /// <summary>
    /// Параметры привязки свойства к столбцу
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class MapperColumnAttribute : Attribute
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="memberName"></param>
        public MapperColumnAttribute([CallerMemberName] string memberName = null)
        {
            MemberName = memberName;
        }

        /// <summary>
        /// Имя столбца
        /// </summary>
        public string MemberName { get; protected set; }

        /// <summary>
        /// Только чтение (Свойство не будет заполнено из строки)
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Только запись (<see cref="SqlParameter"/> не будет создан из свойства)
        /// </summary>
        public bool WriteOnly { get; set; }
    }
    /// <summary>
    /// Игнорировать свойство
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class MapperIgnoreAttribute : Attribute { }
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class MapperObjectAttribute : Attribute
    {
    }
    #endregion Attributes

    /// <summary>
    /// Параметры привязки свойства к столбцу
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    [Obsolete("Use MapperColumnAttribute")]
    public class SQLMemberAttribute : Attribute
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="memberName"></param>
        public SQLMemberAttribute([CallerMemberName] string memberName = null)
        {
            MemberName = memberName;
        }

        /// <summary>
        /// Имя столбца
        /// </summary>
        public string MemberName { get; protected set; }

        /// <summary>
        /// Только чтение (Свойство не будет заполнено из строки)
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Только запись (<see cref="SqlParameter"/> не будет создан из свойства)
        /// </summary>
        public bool WriteOnly { get; set; }
    }

}