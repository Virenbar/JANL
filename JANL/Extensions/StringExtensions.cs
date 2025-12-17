using System.Collections.Generic;
using System.Linq;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="string"/>
    /// </summary>
    public static class StringExtensions

    {
        private readonly static bool[] ValidChars;

        static StringExtensions()
        {
            ValidChars = new bool[65536];
            for (char c = '0'; c <= '9'; c++) { ValidChars[c] = true; }
            for (char c = 'A'; c <= 'Z'; c++) { ValidChars[c] = true; }
            for (char c = 'a'; c <= 'z'; c++) { ValidChars[c] = true; }
            for (char c = 'А'; c <= 'Я'; c++) { ValidChars[c] = true; }
            for (char c = 'а'; c <= 'я'; c++) { ValidChars[c] = true; }
            ValidChars['ё'] = true;
            ValidChars['Ё'] = true;
            ValidChars[' '] = true;
            ValidChars['.'] = true;
            ValidChars['_'] = true;
        }

        /// <summary>
        /// Join string with separator
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinStrings(this IEnumerable<string> strings, string separator)
        {
            return string.Join(separator, strings.Where(S => !string.IsNullOrWhiteSpace(S)));
        }

        /// <summary>
        /// Join string with ", "
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public static string JoinStrings(this IEnumerable<string> strings) => JoinStrings(strings, ", ");

        /// <summary>
        /// Возвращает null если указанная строка является пустой строкой
        /// </summary>
        public static string NullIfEmpty(this string s) => string.IsNullOrEmpty(s) ? null : s;

        /// <summary>
        /// Возвращает null если указанная строка является пустой строкой или строкой, состоящей только из пробельных символов
        /// </summary>
        public static string NullIfWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s) ? null : s;

        /// <summary>
        /// Удаляет все символы кроме [0-9a-zA-Zа-яА-ЯёЁ _.]
        /// </summary>
        public static string RemoveSpecialCharacters(this string str)
        {
            char[] buffer = new char[str.Length];
            int index = 0;
            foreach (char c in str)
            {
                if (ValidChars[c])
                {
                    buffer[index] = c;
                    index++;
                }
            }
            return new string(buffer, 0, index);
        }

        /// <summary>
        /// Обрезает строку до указанной длины
        /// </summary>
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) { return value; }
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}