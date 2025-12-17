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

        /// <summary>
        /// Несколько (2-4)
        /// </summary>
        public string Few { get; set; }

        /// <summary>
        /// Род существительного
        /// </summary>
        public NounKind Kind { get; set; }

        /// <summary>
        /// Много (0 и 5+)
        /// </summary>
        public string Many { get; set; }

        /// <summary>
        /// Одно (1)
        /// </summary>
        public string One { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="other"></param>
        public bool Equals(Noun other)
        {
            return One == other.One
                && Few == other.Few
                && Many == other.Many
                && Kind == other.Kind;
        }

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => One;
    }
}