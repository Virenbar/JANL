using System;
using System.Collections.Generic;
using System.Linq;

namespace JANL.Helpers
{
    public static class ExcelMiniHelper
    {
        /// <summary>
        /// Создаёт список строковых индексов
        /// </summary>
        /// <param name="first">Начальный строковый индекс</param>
        /// <param name="last">Конечный строковый индекс</param>
        /// <returns></returns>
        public static List<string> LetterRange(string first, string last)
        {
            var min = ToNumber(first) + 1;
            var max = ToNumber(last) - 1;

            if (min > max) { return new List<string> { first, last }; }

            List<string> Items = new List<string> { first };
            for (var i = min; i <= max; i++)
            {
                Items.Add(ToLetter(i));
            }
            Items.Add(last);
            return Items;
        }

        /// <summary>
        /// Переводит числовой индекс в строковый
        /// </summary>
        /// <param name="index">Числовой индекс</param>
        public static string ToLetter(int index)
        {
            byte c;
            string s = "";
            do
            {
                c = Convert.ToByte((index - 1) % 26);
                s = (char)(c + 'A') + s;
                index = (index - c) / 26;
            }
            while (index > 0);
            return s;
        }

        /// <summary>
        /// Переводит числовой адрес в строковый
        /// </summary>
        /// <param name="row">Индекс строки</param>
        /// <param name="col">Индекс столбца</param>
        public static string ToLetter(int row, int col) => $"{ToLetter(col)}{row}";

        /// <summary>
        /// Переводит строковый индекс в числовой
        /// </summary>
        /// <param name="index">Строковый индекс</param>
        public static int ToNumber(string index)
        {
            return index.ToUpperInvariant().Aggregate(0, (column, letter) => 26 * column + letter - 'A' + 1);
        }

        /// <summary>
        /// Перевод ширины столбца Excel в OOXML
        /// </summary>
        /// <param name="width">Ширина столбца в Excel</param>
        /// <returns>Ширина столбца в OOXML</returns>
        public static double ToOOXMLWidth(double width) => width + 0.7109375;
    }
}