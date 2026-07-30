using System.Numerics;

namespace JANL.Text.Converters
{
    static partial class NumberConverter
    {

        /// <summary>
        /// Перевод суммы в текст
        /// </summary>
        public static string RubleToText(BigInteger number)
        {
            return $"{NumberToText(number, GetRubleNoun())}";
        }

        /// <summary>
        /// Перевод суммы в текст
        /// </summary>
        public static string RubleToText(decimal number)
        {
            int kopek = (int)((number % 1) * 100);
            return $"{NumberToText(new BigInteger(number), GetRubleNoun())} {kopek} {CaseForNumber(kopek, GetKopekNoun())}";
        }

        private static Noun GetKopekNoun() => new Noun("копейка", "копейки", "копеек", NounKind.Female);

        private static Noun GetRubleNoun() => new Noun("рубль", "рубля", "рублей");
    }
}