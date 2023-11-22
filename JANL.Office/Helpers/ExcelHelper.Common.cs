using System.Collections.Generic;

namespace JANL.Helpers
{
    public static partial class ExcelHelper
    {
        /// <summary>
        /// Создаёт список строковых индексов
        /// </summary>
        /// <param name="first">Начальный строковый индекс</param>
        /// <param name="last">Конечный строковый индекс</param>
        /// <returns></returns>
        public static List<string> LetterRange(string first, string last) => ExcelMiniHelper.LetterRange(first, last);

        /// <summary>
        /// Переводит числовой индекс в строковый
        /// </summary>
        /// <param name="index">Числовой индекс</param>
        public static string ToLetter(int index) => ExcelMiniHelper.ToLetter(index);

        /// <summary>
        /// Переводит числовой адрес в строковый
        /// </summary>
        /// <param name="row">Индекс строки</param>
        /// <param name="col">Индекс столбца</param>
        public static string ToLetter(int row, int col) => ExcelMiniHelper.ToLetter(row, col);

        /// <summary>
        /// Переводит строковый индекс в числовой
        /// </summary>
        /// <param name="index">Строковый индекс</param>
        public static int ToNumber(string index) => ExcelMiniHelper.ToNumber(index);

        /// <summary>
        /// Перевод ширины столбца Excel в OOXML
        /// </summary>
        /// <param name="width">Ширина столбца в Excel</param>
        /// <returns>Ширина столбца в OOXML</returns>
        public static double ToOOXMLWidth(double width) => ExcelMiniHelper.ToOOXMLWidth(width);
    }
}