using JANL.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace JANL.Extensions
{
    public static class TypeExtensions
    {
        private static readonly Random rnd = new Random();

        /// <summary>
        /// Первый день месяца
        /// </summary>
        public static DateTime FirstDay(this DateTime date) => new DateTime(date.Year, date.Month, 1);

        /// <summary>
        /// Последний день месяца
        /// </summary>
        public static DateTime LastDay(this DateTime date) => new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);

        /// <summary>
        /// Случайный элемент из перечисления
        /// </summary>
        public static T PickRandom<T>(this IEnumerable<T> list) => list.Count() == 0 ? default : list.ElementAt(rnd.Next(list.Count()));

        /// <summary>
        /// Получить тип SQL
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static SqlDbType GetSQLType(this Type type) => SQLHelper.GetDBType(type);

        /// <summary>
        /// Получить тип CRL
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetCRLType(this SqlDbType type) => SQLHelper.GetCRLType(type);

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