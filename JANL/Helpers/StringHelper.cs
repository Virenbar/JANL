using System;

namespace JANL.Helpers
{
    public static partial class StringHelper
    {
        public static string GetPeriod(DateTime DateBegin, DateTime DateEnd)
        {
            return DateBegin.Month == DateEnd.Month && DateBegin.Year == DateEnd.Year
                ? $"за {DateBegin:MMMM yyyy}г."
                : $"за период с {DateBegin:MMMM yyyy}г. по {DateEnd:MMMM yyyy}г.";
        }
    }
}