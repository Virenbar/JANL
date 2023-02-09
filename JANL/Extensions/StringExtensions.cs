using System.Collections.Generic;
using System.Linq;

namespace JANL.Extensions
{
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
    }
}