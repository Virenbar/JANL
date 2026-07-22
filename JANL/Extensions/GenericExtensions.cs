using System;
using System.Collections.Generic;
using System.Linq;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для базовых типов
    /// </summary>
    public static class GenericExtensions
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
    }
}