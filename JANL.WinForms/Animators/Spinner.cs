using System;
using System.Collections.Generic;

namespace JANL.Animators
{
    /// <summary>
    /// Спиннер
    /// </summary>
    public abstract partial class Spinner
    {
        /// <summary>
        /// Кадры
        /// </summary>
        public abstract IReadOnlyList<string> Frames { get; }

        /// <summary>
        /// Интервал между кадрами
        /// </summary>
        public abstract TimeSpan Interval { get; }
    }
}