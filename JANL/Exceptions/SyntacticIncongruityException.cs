using System;

namespace JANL.Exceptions
{
    /// <summary>
    /// https://orfogrammka.ru/грамматика/синтаксическая_несочетаемость_в_числительных/
    /// </summary>
    public class SyntacticIncongruityException : Exception
    {
        private const string MESSAGE = "Синтаксическая несочетаемость числительного и существительного";

        internal SyntacticIncongruityException() : base(MESSAGE) { }
    }
}