using System;

namespace JANL.Text
{
    /// <summary>
    /// Существительное
    /// </summary>
    public struct Noun : IEquatable<Noun>
    {
        /// <summary>
        /// Создает новое существительное указанного рода
        /// </summary>
        /// <param name="one">1</param>
        /// <param name="few">2-4</param>
        /// <param name="many">0 и 5+</param>
        /// <param name="kind">Род</param>
        public Noun(string one, string few, string many, NounKind kind) : this()
        {
            One = one;
            Few = few;
            Many = many;
            Kind = kind;
        }

        /// <summary>
        /// Создает новое существительное мужского рода
        /// </summary>
        /// <param name="one">1</param>
        /// <param name="few">2-4</param>
        /// <param name="many">0 и 5+</param>
        public Noun(string one, string few, string many) : this(one, few, many, NounKind.Male) { }

        public string Few { get; set; }
        public NounKind Kind { get; set; }
        public string Many { get; set; }
        public string One { get; set; }

        public bool Equals(Noun other)
        {
            return One == other.One
                && Few == other.Few
                && Many == other.Many
                && Kind == other.Kind;
        }

        public override string ToString() => One;
    }
}