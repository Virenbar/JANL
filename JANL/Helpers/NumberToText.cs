using System;
using System.Numerics;
using System.Text;

namespace JANL.Helpers
{
    public static partial class StringHelper
    {
        private const int MaxClass = 40;

        public static string NumberToText(BigInteger Value, Noun Noun) => $"{NumberToText(Value, Noun.Kind)} {CaseForNumber((int)(Value % 1000), Noun)}";

        /// <summary>Перевод целого числа в строку</summary>
        /// <param name="Value">Число</param>
        /// <returns>Возвращает строковую запись числа</returns>
        public static string NumberToText(BigInteger Value, Kind Kind)
        {
            if (Value.IsZero) { return "Ноль"; }
            var Minus = Value.Sign < 0;
            var N = BigInteger.Abs(Value);
            if (BigInteger.Log10(N) / 3 > MaxClass) { return N.ToString("E"); }

            var SB = new StringBuilder();
            InsertClass(SB, (int)(N % 1000), Kind);
            if (N > 999)
            {
                var ClassIndex = 0;
                var NumberNouns = GetNumberNouns();
                N /= 1000;
                while (N != 0)
                {
                    var Noun = NumberNouns[ClassIndex];
                    var Part = (int)(N % 1000);
                    ClassIndex += 1;
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
        /// <param name="Summa">Сумма</param>
        /// <returns>Сумма текстом</returns>
        public static string RubToText(decimal Summa)
        {
            int kop = (int)((Summa % 1) * 100);
            return $"{NumberToText(new BigInteger(Summa), Kind.Male)} {CaseForNumber((int)(Math.Truncate(Summa) % 1000), "рубль", "рубля", "рублей")} {kop} {CaseForNumber(kop, "копейка", "копейки", "копеек")}";
        }

        /// <summary>
        /// Выбор правильного падежного окончания существительного
        /// </summary>
        /// <param name="Value">Число</param>
        /// <param name="one">Форма существительного в единственном числе</param>
        /// <param name="two">Форма существительного от двух до четырёх</param>
        /// <param name="five">Форма существительного от пяти и больше</param>
        /// <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
        private static string CaseForNumber(int Value, string One, string Two, string Five)
        {
            int t = Value % 100 > 20 ? Value % 10 : Value % 20;
            switch (t)
            {
                case 1:
                    return One;

                case object _ when 2 <= t && t <= 4:
                    return Two;

                default:
                    return Five;
            }
        }

        /// <summary>
        /// Выбор правильного падежного окончания существительного
        /// </summary>
        /// <param name="Value">Число</param>
        /// <param name="Noun">Формы существительного</param>
        /// <returns>Возвращает существительное с падежным окончанием, которое соответствует числу</returns>
        private static string CaseForNumber(int Value, Noun Noun) => CaseForNumber(Value, Noun.One, Noun.Two, Noun.Five);

        private static string GetFraction20(int Value, Kind Kind)
        {
            if (Value == 0) { return ""; }
            if (Value < 3)
            {
                string[] F = { };
                switch (Kind)
                {
                    case Kind.Male:
                        {
                            F = new[] { "один", "два" };
                            break;
                        }

                    case Kind.Female:
                        {
                            F = new[] { "одна", "две" };
                            break;
                        }

                    case Kind.Middle:
                        {
                            F = new[] { "одно", "два" };
                            break;
                        }
                    default:
                        throw new InvalidOperationException("Invalid Kind");
                }
                return F[Value - 1];
            }
            return new[] { "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" }[Value - 3];
        }

        /// <summary>
        /// Получить наименование сотни для значения класса
        /// </summary>
        private static string GetHundred(int Value)
        {
            return new[] { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" }[Value / 100];
        }

        private static Noun[] GetNumberNouns()
        {
            return new[] {
                new Noun("тысяча", "тысячи", "тысяч", Kind.Female),
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
                new Noun("квадрагинтиллион", "квадрагинтиллионa", "квадрагинтиллионов") };
        }

        /// <summary>
        /// Получить наименование десятка для значения класса
        /// </summary>
        private static string GetTen(int Value)
        {
            return new[] { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" }[(Value % 100) / 10];
        }

        private static void InsertClass(StringBuilder SB, int Value, Kind Kind)
        {
            if (Value == 0) { return; }

            string C;
            if (Value % 100 < 20)
            {
                C = GetHundred(Value) + " " + GetFraction20(Value % 20, Kind);
            }
            else
            {
                C = GetHundred(Value) + " " + GetTen(Value) + " " + GetFraction20(Value % 10, Kind);
            }
            SB.Insert(0, C.Trim(' '));
        }

        /// <summary>
        /// Существительное
        /// </summary>
        public struct Noun
        {
            public Noun(string One, string Two, string Five, Kind Kind) : this()
            {
                this.One = One;
                this.Two = Two;
                this.Five = Five;
                this.Kind = Kind;
            }

            public Noun(string One, string Two, string Five) : this(One, Two, Five, Kind.Male) { }

            public string Five { get; set; }
            public Kind Kind { get; set; }
            public string One { get; set; }
            public string Two { get; set; }
        }

        /// <summary>
        /// Род
        /// </summary>
        public enum Kind
        {
            /// <summary>
            /// Мужской род
            /// </summary>
            Male,

            /// <summary>
            /// Женский род
            /// </summary>
            Female,

            /// <summary>
            /// Средний род
            /// </summary>
            Middle
        }
    }
}