using System;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="DateTime"/>
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Первый день месяца
        /// </summary>
        public static DateTime FirstDay(this DateTime date) => FirstMonthDay(date);

        /// <summary>
        /// Первый день месяца
        /// </summary>
        public static DateTime FirstMonthDay(this DateTime date) => new DateTime(date.Year, date.Month, 1);

        /// <summary>
        /// Первый день года
        /// </summary>
        public static DateTime FirstYearDay(this DateTime date) => new DateTime(date.Year, 1, 1);

        /// <summary>
        /// Последний день месяца
        /// </summary>
        public static DateTime LastDay(this DateTime date) => LastMonthDay(date);

        /// <summary>
        /// Последний день месяца
        /// </summary>
        public static DateTime LastMonthDay(this DateTime date) => new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);

        /// <summary>
        /// Последний день года
        /// </summary>
        public static DateTime LastYearDay(this DateTime date) => new DateTime(date.Year, 12, 1).AddMonths(1).AddDays(-1);
    }
}