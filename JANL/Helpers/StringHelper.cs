using System;
using System.Numerics;
using JANL.Text.Converters;
using JANL.Text;

namespace JANL.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Преобразует период в строку
        /// "за период c [begin]г. по [end]г."
        /// </summary>
        public static string DateToPeriod(DateTime begin, DateTime end) => $"за {DateConverter.PeriodToText(begin, end)}";

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
        /// "период c [begin]г. по [end]г."
        /// </summary>
        public static string PeriodToText(DateTime begin, DateTime end) => DateConverter.PeriodToText(begin, end);

        public static string RubleToText(decimal number) => NumberConverter.RubleToText(number);

        public static string RubleToText(BigInteger number) => NumberConverter.RubleToText(number);
    }
}