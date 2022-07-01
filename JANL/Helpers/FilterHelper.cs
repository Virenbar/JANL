using JANL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JANL.Helpers
{
    /// <summary>
    /// Filter helper for BindingSource
    /// </summary>
    public static class FilterHelper
    {
        /// <summary>
        /// Convert column to string
        /// </summary>
        /// <param name="collumn">Name</param>
        public static string AsString(string column) => $"Convert({column},'System.String')";

        /// <summary>
        ///  Создает выражения для поиска по каждому столбцу по отдельности
        /// </summary>
        public static string RowFilterByColumns(IEnumerable<string> columns, string filter) => RowFilterByColumns(columns, filter, ' ');

        /// <summary>
        ///  Создает выражения для поиска по каждому столбцу по отдельности
        /// </summary>
        public static string RowFilterByColumns(IEnumerable<string> columns, string filter, char splitChar)
        {
            var Filter = filter.Trim().RemoveSpecialCharacters();
            if (string.IsNullOrWhiteSpace(Filter) || columns.Count() == 0) { return ""; }

            var Terms = Filter.Split(new[] { splitChar }, StringSplitOptions.RemoveEmptyEntries);
            var CollumnsFilters = columns.Select(C => $"({string.Join(" AND ", Terms.Select(T => $"{AsString(C)} LIKE '%{T}%'"))})");
            return string.Join(" OR ", CollumnsFilters);
        }

        /// <summary>
        /// Создает выражения для поиска по всем столбцам
        /// </summary>
        public static string RowFilterByRow(IEnumerable<string> columns, string filter) => RowFilterByRow(columns, filter, ' ');

        /// <summary>
        /// Создает выражения для поиска по всем столбцам
        /// </summary>
        public static string RowFilterByRow(IEnumerable<string> columns, string filter, char splitChar)
        {
            var Filter = filter.Trim().RemoveSpecialCharacters();
            if (string.IsNullOrWhiteSpace(Filter) || columns.Count() == 0) { return ""; }

            var MergedRow = string.Join("+' '+", columns.Select(AsString));
            var Terms = Filter.Split(new[] { splitChar }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" AND ", Terms.Select(T => $"{MergedRow} LIKE '%{T}%'"));
        }

        private static string RowFilter(IEnumerable<string> columns, string filter, bool MergeRow) => MergeRow ? RowFilterByRow(columns, filter) : RowFilterByColumns(columns, filter);
    }
}