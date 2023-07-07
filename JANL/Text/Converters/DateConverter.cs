using System;

namespace JANL.Text.Converters
{
    public static class DateConverter
    {
        /// <summary>
        /// Преобразует дату в текст
        /// </summary>
        public static string DateToText(DateTime date) => $"{date:MMMM yyyy}г.";

        /// <summary>
        /// Преобразует дату в текст
        /// </summary>
        public static string DateToText(DateTime begin, DateTime end) => $"с {begin:MMMM yyyy}г. по {end:MMMM yyyy}г.";

        /// <summary>
        /// Преобразует период в текст
        /// </summary>
        public static string PeriodToText(DateTime begin, DateTime end)
        {
            return begin.Month == end.Month && begin.Year == end.Year
                ? DateToText(begin)
                : $"период {DateToText(begin, end)}";
        }
    }
}