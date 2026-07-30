using System;
using System.Numerics;
using System.Text;
using JANL.Exceptions;
using JANL.Extensions;

namespace JANL.Text.Converters
{
    /// <summary>
    /// Класс для перевода чисел в пропись
    /// </summary>
    public static partial class NumberConverter
    {
        private const int MAX_CLASS = 1000;

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="noun">Существительное</param>
        /// <returns>Возвращает строковую запись числа и существительного</returns>
        public static string NumberToText(BigInteger number, Noun noun) => $"{NumberToText(number, noun.Kind)} {CaseForNumber((int)(number % 1000), noun)}";

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Возвращает строковую запись числа</returns>
        public static string NumberToText(BigInteger number) => NumberToText(number, NounKind.Male);

        /// <summary>
        /// Перевод целого числа в строку
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="kind">Род существительного</param>
        /// <returns>Возвращает строковую запись числа</returns>
        public static string NumberToText(BigInteger number, NounKind kind)
        {
            // Проверка на ноль
            if (number.IsZero) { return "ноль"; }
            // Проверка на возможность преобразования
            if (BigInteger.Log10(number) / 3 > MAX_CLASS + 2) { return number.ToString("E"); }
            // Проверка на сочетаемость
            // https://orfogrammka.ru/грамматика/синтаксическая_несочетаемость_в_числительных/
            if (kind == NounKind.Plural && number > 20 && (number % 10).IsBetween(2, 4)) { throw new SyntacticIncongruityException(); }

            var minus = number.Sign < 0;
            var N = BigInteger.Abs(number);

            var SB = new StringBuilder();
            InsertClass(SB, (int)(N % 1000), kind);
            if (N > 999)
            {
                var classIndex = 0;
                N /= 1000;
                while (N != 0)
                {
                    var classNoun = GenerateNoun(classIndex);
                    var classPart = (int)(N % 1000);
                    classIndex++;
                    N /= 1000;

                    if (classPart == 0) { continue; }
                    SB.Insert(0, " " + CaseForNumber(classPart, classNoun) + " ");
                    InsertClass(SB, classPart, classNoun.Kind);
                }
            }

            if (minus) { SB.Insert(0, "минус "); }
            return SB.ToString().Trim(' ');
        }

        /// <summary>
        /// Выбор правильного падежного окончания существительного
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="noun">Существительное</param>
        /// <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
        private static string CaseForNumber(int number, Noun noun)
        {
            int digit = number % 100 > 20 ? number % 10 : number % 20;
            switch (digit)
            {
                case 1:
                    return noun.One;

                case object _ when 2 <= digit && digit <= 4:
                    return noun.Few;

                default:
                    return noun.Many;
            }
        }

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
        /// Получить наименование для числа меньше 20
        /// </summary>
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
            return new[] {
                "три",
                "четыре",
                "пять",
                "шесть",
                "семь",
                "восемь",
                "девять",
                "десять",
                "одиннадцать",
                "двенадцать",
                "тринадцать",
                "четырнадцать",
                "пятнадцать",
                "шестнадцать",
                "семнадцать",
                "восемнадцать",
                "девятнадцать"
            }[number - 3];
        }

        /// <summary>
        /// Получить наименование сотни для значения класса
        /// </summary>
        private static string GetHundred(int number)
        {
            return new[] {
                "",
                "сто",
                "двести",
                "триста",
                "четыреста",
                "пятьсот",
                "шестьсот",
                "семьсот",
                "восемьсот",
                "девятьсот"
            }[number / 100];
        }

        /// <summary>
        /// Получить наименование десятка для значения класса
        /// </summary>
        private static string GetTen(int number)
        {
            return new[] {
                "",
                "десять",
                "двадцать",
                "тридцать",
                "сорок",
                "пятьдесят",
                "шестьдесят",
                "семьдесят",
                "восемьдесят",
                "девяносто"
            }[number % 100 / 10];
        }

        private static void InsertClass(StringBuilder SB, int number, NounKind kind)
        {
            if (number == 0) { return; }
            string Class = number % 100 < 20
                ? $"{GetHundred(number)} {GetFraction20(number % 20, kind)}"
                : $"{GetHundred(number)} {GetTen(number)} {GetFraction20(number % 10, kind)}";
            SB.Insert(0, Class.Trim(' '));
        }
    }
}