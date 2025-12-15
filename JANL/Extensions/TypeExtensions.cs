using JANL.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для базовых типов
    /// </summary>
    public static class TypeExtensions
    {
        private static readonly Random rnd = new Random();

        /// <summary>
        /// Ограничивает значение диапазоном
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min">Минимум</param>
        /// <param name="max">Максимум</param>
        public static T Clamp<T>(this T value, T min, T max) where T : struct, IComparable<T>
        {
            if (value.CompareTo(min) < 0) { return min; }
            if (value.CompareTo(max) > 0) { return max; }
            return value;
        }

        /// <summary>
        /// Случайный элемент из перечисления
        /// </summary>
        public static T PickRandom<T>(this IEnumerable<T> list) => list.Count() == 0 ? default : list.ElementAt(rnd.Next(list.Count()));

        /// <summary>
        /// Случайный элемент из коллекции
        /// </summary>
        public static T PickRandom<T>(this ICollection<T> collection) => PickRandom<T>(collection, false);

        /// <summary>
        /// Случайный элемент из коллекции
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="remove">Удалить элемент из коллекции</param>
        public static T PickRandom<T>(this ICollection<T> collection, bool remove)
        {
            if (collection.Count == 0) { return default; }
            var element = collection.ElementAt(rnd.Next(collection.Count));
            if (remove) { collection.Remove(element); }
            return element;
        }

        #region SQL

        /// <summary>
        /// Получить тип CRL
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetCRLType(this SqlDbType type) => SQLHelper.GetCRLType(type);

        /// <summary>
        /// Получить тип SQL
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static SqlDbType GetSQLType(this Type type) => SQLHelper.GetDBType(type);

        #endregion SQL

        #region IsOverride

        /// <summary>
        /// Переопределён ли метод
        /// </summary>
        /// <param name="MI"></param>
        /// <returns></returns>
        public static bool IsOverride(this MethodInfo MI) => MI.GetBaseDefinition().DeclaringType != MI.DeclaringType;

        /// <summary>
        /// Переопределёно ли свойство
        /// </summary>
        /// <param name="PI"></param>
        /// <returns></returns>
        public static bool IsOverride(this PropertyInfo PI) => PI.GetMethod.GetBaseDefinition().DeclaringType != PI.DeclaringType;

        /// <summary>
        /// Переопределён ли метод или свойство
        /// </summary>
        /// <param name="T">Тип</param>
        /// <param name="Name">Имя метода или свойства</param>
        /// <returns></returns>
        public static bool IsOverride(this Type T, string Name)
        {
            var Members = T.GetMember(Name);
            if (Members.Count() == 0) { return false; }
            var M = Members.First();
            switch (M.MemberType)
            {
                case MemberTypes.Method:
                    return IsOverride((MethodInfo)M);

                case MemberTypes.Property:
                    return IsOverride((PropertyInfo)M);

                default:
                    return false;
            }
        }

        #endregion IsOverride
    }
}