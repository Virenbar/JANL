using System;
using System.Collections.Generic;
using System.Numerics;

namespace JANL.Extensions
{
    public static class BetweenExtensions
    {
        public static bool IsBetween(this int value, int first, int second)
        {
            return value >= Math.Min(first, second) && value <= Math.Max(first, second);
        }

        public static bool IsBetween(this BigInteger value, BigInteger first, BigInteger second)
        {
            return value >= BigInteger.Min(first, second) && value <= BigInteger.Max(first, second);
        }

        public static bool IsBetween(this decimal value, decimal first, decimal second)
        {
            return value >= Math.Min(first, second) && value <= Math.Max(first, second);
        }

        public static bool IsBetween(this double value, double first, double second)
        {
            return value >= Math.Min(first, second) && value <= Math.Max(first, second);
        }

        /// <summary>
        /// Generic IsBetween
        /// </summary>
        public static bool IsBetween<T>(this T value, T first, T second)
        {
            if (EqualityComparer<T>.Default.Equals(first, second))
            {
                return EqualityComparer<T>.Default.Equals(value, first);
            }
            return Comparer<T>.Default.Compare(value, first) <= 0 != Comparer<T>.Default.Compare(value, second) <= 0;
        }
    }
}