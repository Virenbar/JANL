using System;
using System.Linq;
using System.Reflection;

namespace JANL.Extensions
{
    public static class TypeExtensions
    {
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