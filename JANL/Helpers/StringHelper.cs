using System;
using System.Numerics;
using JANL.Text.Converters;
using JANL.Text;

namespace JANL.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Перевод периода в строку
        /// </summary>
        public static string DateToPeriod(DateTime date1, DateTime date2)
        {
            return date1.Month == date2.Month && date1.Year == date2.Year ? $"за {date1:MMMM yyyy}г." : $"за период с {date1:MMMM yyyy}г. по {date2:MMMM yyyy}г.";
        }

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        public static string NumberToText(BigInteger number, NounKind kind) => NumberConverter.NumberToText(number, kind);

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        public static string NumberToText(BigInteger number, Noun noun) => NumberConverter.NumberToText(number, noun);

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        public static string NumberToText(BigInteger number) => NumberConverter.NumberToText(number, NounKind.Male);

        /// <summary>
        /// Преобразует период в строку
        /// </summary>
        public static string PeriodToText(DateTime begin, DateTime end) => DateConverter.PeriodToText(begin, end);

        public static string RubleToText(decimal number) => NumberConverter.RubleToText(number);

        public static string RubleToText(BigInteger number) => NumberConverter.RubleToText(number);
    }
}