using JANL.Exceptions;
using JANL.Extensions;
using System;
using System.Numerics;
using System.Text;

namespace JANL.Text.Converters
{
    public static class NumberConverter
    {
        private const int MAX_CLASS = 40;
        private readonly static string[] Dozen;
        private readonly static string[] Hundreds;
        private readonly static Noun Kopek;
        private readonly static Noun Ruble;

        static NumberConverter()
        {
            Dozen = new[] { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            Hundreds = new[] { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            Kopek = new Noun("копейка", "копейки", "копеек", NounKind.Female);
            Ruble = new Noun("рубль", "рубля", "рублей");
        }

        public static string NumberToText(BigInteger number, Noun noun) => $"{NumberToText(number, noun.Kind)} {CaseForNumber((int)(number % 1000), noun)}";

        public static string NumberToText(BigInteger number) => NumberToText(number, NounKind.Male);

        /// <summary>Перевод целого числа в строку</summary>
        /// <param name="number">Число</param>
        /// <param name="kind">Род существительного</param>
        /// <returns>Возвращает строковую запись числа</returns>
        public static string NumberToText(BigInteger number, NounKind kind)
        {
            // https://orfogrammka.ru/грамматика/синтаксическая_несочетаемость_в_числительных/
            if (kind == NounKind.Plural && number > 20 && (number % 10).IsBetween(2, 4)) { throw new SyntacticIncongruityException(); }
            if (number.IsZero) { return "Ноль"; }

            var Minus = number.Sign < 0;
            var N = BigInteger.Abs(number);
            if (BigInteger.Log10(N) / 3 > MAX_CLASS) { return N.ToString("E"); }

            var SB = new StringBuilder();
            InsertClass(SB, (int)(N % 1000), kind);
            if (N > 999)
            {
                var ClassIndex = 0;
                var NumberNouns = GetNumberNouns();
                N /= 1000;
                while (N != 0)
                {
                    var Noun = NumberNouns[ClassIndex];
                    var Part = (int)(N % 1000);
                    ClassIndex++;
                    N /= 1000;

                    if (Part == 0) { continue; }
                    SB.Insert(0, " " + CaseForNumber(Part, Noun) + " ");
                    InsertClass(SB, Part, Noun.Kind);
                }
            }

            if (Minus) { SB.Insert(0, "минус "); }
            return SB.ToString().Trim(' ');
        }

        /// <summary>
        /// Перевод суммы в текст
        /// </summary>
        public static string RubleToText(BigInteger number)
        {
            return $"{NumberToText(number, Ruble)} {CaseForNumber((int)(number % 1000), Ruble)}";
        }

        /// <summary>
        /// Перевод суммы в текст
        /// </summary>
        public static string RubleToText(decimal number)
        {
            int kopek = (int)((number % 1) * 100);
            return $"{NumberToText(new BigInteger(number), Ruble)} {kopek} {CaseForNumber(kopek, Kopek)}";
        }

        /// <summary>
        /// Выбор правильного падежного окончания существительного
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="one">Форма существительного в единственном числе</param>
        /// <param name="few">Форма существительного от двух до четырёх</param>
        /// <param name="many">Форма существительного от пяти и больше</param>
        /// <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
        private static string CaseForNumber(int number, string one, string few, string many)
        {
            int t = number % 100 > 20 ? number % 10 : number % 20;
            switch (t)
            {
                case 1:
                    return one;

                case object _ when 2 <= t && t <= 4:
                    return few;

                default:
                    return many;
            }
        }

        /// <summary>
        /// Выбор правильного падежного окончания существительного
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="noun">Существительное</param>
        /// <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
        private static string CaseForNumber(int number, Noun noun) => CaseForNumber(number, noun.One, noun.Few, noun.Many);

        /// <summary>
        /// Получить наименование десятка для значения класса
        /// </summary>
        private static string GetDozen(int number) => Dozen[number % 100 / 10];

        private static string GetFraction20(int number, NounKind kind)
        {
            if (number == 0) { return ""; }
            if (number < 3 || (kind == NounKind.Plural && number < 5))
            {
                switch (kind)
                {
                    case NounKind.Male: return new[] { "один", "два" }[number - 1];
                    case NounKind.Female: return new[] { "одна", "две" }[number - 1];
                    case NounKind.Middle: return new[] { "одно", "два" }[number - 1];
                    case NounKind.Plural: return new[] { "одни", "двое", "трое", "четверо" }[number - 1];
                    default: throw new InvalidOperationException("Invalid Kind");
                }
            }
            return new[] { "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" }[number - 3];
        }

        /// <summary>
        /// Получить наименование сотни для значения класса
        /// </summary>
        private static string GetHundred(int number) => Hundreds[number / 100];

        private static Noun[] GetNumberNouns()
        {
            return new[] {
                new Noun("тысяча", "тысячи", "тысяч", NounKind.Female),
                new Noun("миллион", "миллиона", "миллионов"),
                new Noun("миллиард", "миллиарда", "миллиардов"),
                new Noun("триллион", "триллиона", "триллионов"),
                new Noun("квадриллион", "квадриллиона", "квадриллионов"),
                new Noun("квинтиллион", "квинтиллиона", "квинтиллионов"),
                new Noun("секстиллион", "секстиллиона", "секстиллионов"),
                new Noun("септиллион", "септиллиона", "септиллионов"),
                new Noun("октиллион", "октиллиона", "октиллионов"),
                new Noun("нониллион", "нониллиона", "нониллионов"),
                new Noun("дециллион", "дециллиона", "дециллионов"),
                new Noun("ундециллион", "ундециллиона", "ундециллионов"),
                new Noun("дуодециллион", "дуодециллиона", "дуодециллионов"),
                new Noun("тредециллион", "тредециллиона", "тредециллионов"),
                new Noun("квиндециллион", "квиндециллиона", "квиндециллионов"),
                new Noun("сексдециллион", "сексдециллионa", "сексдециллион"),
                new Noun("септдециллион", "септдециллиона", "септдециллионов"),
                new Noun("октодециллион", "октодециллионa", "октодециллионов"),
                new Noun("новемдециллион", "октодециллионa", "октодециллионов"),
                new Noun("вигинтиллион", "вигинтиллиона", "вигинтиллионов"),
                new Noun("унвигинтиллион", "унвигинтиллионa", "унвигинтиллионов"),
                new Noun("дуовигинтиллион", "дуовигинтиллионa", "дуовигинтиллионов"),
                new Noun("тревигинтиллион", "тревигинтиллионa", "тревигинтиллионов"),
                new Noun("кваттуорвигинтиллион", "кваттуорвигинтиллионa", "кваттуорвигинтиллионов"),
                new Noun("квинвигинтиллион", "квинвигинтиллионa", "квинвигинтиллионов"),
                new Noun("сексвигинтиллион", "сексвигинтиллионa", "сексвигинтиллионов"),
                new Noun("септенвигинтиллион", "септенвигинтиллионa", "септенвигинтиллионов"),
                new Noun("октовигинтиллион", "октовигинтиллионa", "октовигинтиллионов"),
                new Noun("новемвигинтиллион", "новемвигинтиллионa", "новемвигинтиллионов"),
                new Noun("тригинтиллион", "тригинтиллионa", "тригинтиллионов"),
                new Noun("унтригинтиллион", "унтригинтиллионa", "унтригинтиллионов"),
                new Noun("дуотригинтиллион", "дуотригинтиллионa", "дуотригинтиллионов"),
                new Noun("третригинтиллион", "третригинтиллионa", "третригинтиллионов"),
                new Noun("кваттуортригинтиллион", "кваттуортригинтиллионa", "кваттуортригинтиллионов"),
                new Noun("квинтригинтиллион", "квинтригинтиллионa", "квинтригинтиллионов"),
                new Noun("секстригинтиллион", "секстригинтиллионa", "секстригинтиллионов"),
                new Noun("септентригинтиллион", "септентригинтиллионa", "септентригинтиллионов"),
                new Noun("октотригинтиллион", "октотригинтиллионa", "октотригинтиллионов"),
                new Noun("новемтригинтиллион", "новемтригинтиллионa", "новемтригинтиллионов"),
                new Noun("квадрагинтиллион", "квадрагинтиллионa", "квадрагинтиллионов")
            };
            // Нужно больше числительных
        }

        private static void InsertClass(StringBuilder SB, int number, NounKind kind)
        {
            if (number == 0) { return; }
            string Class = number % 100 < 20
                ? $"{GetHundred(number)} {GetFraction20(number % 20, kind)}"
                : $"{GetHundred(number)} {GetDozen(number)} {GetFraction20(number % 10, kind)}";
            SB.Insert(0, Class.Trim(' '));
        }
    }
}