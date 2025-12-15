using JANL.Exceptions;
using JANL.Extensions;
using System;
using System.Numerics;
using System.Text;

namespace JANL.Text.Converters
{
    public static class NumberConverter
    {
        private const int MAX_CLASS = 1000;
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
            if (BigInteger.Log10(N) / 3 > MAX_CLASS + 2) { return N.ToString("E"); }

            var SB = new StringBuilder();
            InsertClass(SB, (int)(N % 1000), kind);
            if (N > 999)
            {
                var ClassIndex = 0;
                N /= 1000;
                while (N != 0)
                {
                    var Noun = GenerateNoun(ClassIndex);
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

        private static Noun CreateNoun(string name) => new Noun(name, $"{name}а", $"{name}ов");

        private static Noun GenerateNoun(int big)
        {
            switch (big)
            {
                case 0: return new Noun("тысяча", "тысячи", "тысяч", NounKind.Female);
                case 1: return CreateNoun("миллион");
                case 2: return CreateNoun("миллиард");
                case 3: return CreateNoun("триллион");
                case 4: return CreateNoun("квадриллион");
                case 5: return CreateNoun("квинтиллион");
                case 6: return CreateNoun("секстиллион");
                case 7: return CreateNoun("септиллион");
                case 8: return CreateNoun("октиллион");
                case 9: return CreateNoun("нониллион");
                case 1000: return CreateNoun("миллиниллион");
            }
            var pre = "";
            var N1 = big / 100 % 10;
            var N2 = big / 10 % 10;
            var N3 = big / 1 % 10;

            switch (N3)
            {
                case 1: pre = "ун"; break;
                case 2: pre = "дуо"; break;
                case 3:
                    pre = "тре";
                    if (N2 == 0)
                    {
                        if (N1 == 1 || (N1 > 2 && N1 < 6)) { pre += "с"; }
                    }
                    else if (N2 > 1 && N2 < 6) { pre += "с"; }
                    break;

                case 4: pre = "кваттуор"; break;
                case 5: pre = "квин"; break;
                case 6:
                    pre = "се";
                    if (N2 == 0)
                    {
                        if (N1 > 2 && N1 < 6) { pre += "с"; }
                        if (N1 == 1 || N1 == 8) { pre += "кс"; }
                    }
                    else if (N2 > 1 && N2 < 6) { pre += "с"; }
                    else if (N2 == 8) { pre += "кс"; }
                    break;

                case 7:
                    pre = "септе";
                    if (N2 == 0)
                    {
                        if (N1 == 8) { pre += "м"; }
                        else if (N1 < 8) { pre += "н"; }
                    }
                    else if (N2 == 8 || N2 == 2) { pre += "м"; }
                    else if (N2 < 8) { pre += "н"; }
                    break;

                case 8: pre = "окто"; break;
                case 9:
                    pre = "нове";
                    if (N2 == 0)
                    {
                        if (N1 == 8) { pre += "м"; }
                        else if (N1 < 8) { pre += "н"; }
                    }
                    else if (N2 == 8 || N2 == 2) { pre += "м"; }
                    else if (N2 < 8) { pre += "н"; }
                    break;
            }

            switch (N2)
            {
                case 1: pre += "деци"; break;
                case 2: pre += "вигинти"; break;
                case 3: pre += "тригинта"; break;
                case 4: pre += "квадрагинта"; break;
                case 5: pre += "квинквагинта"; break;
                case 6: pre += "сексагинта"; break;
                case 7: pre += "септуагинта"; break;
                case 8: pre += "октогинта"; break;
                case 9: pre += "нонагинта"; break;
            }

            switch (N1)
            {
                case 1: pre += "санти"; break;
                case 2: pre += "дуценти"; break;
                case 3: pre += "треценти"; break;
                case 4: pre += "квадрингенти"; break;
                case 5: pre += "квингенти"; break;
                case 6: pre += "сесценти"; break;
                case 7: pre += "септингенти"; break;
                case 8: pre += "октингенти"; break;
                case 9: pre += "нонгенти"; break;
            }

            return pre.EndsWith("a") ? CreateNoun($"{pre.Remove(pre.Length - 1)}иллион") : CreateNoun($"{pre}ллион");
        }

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