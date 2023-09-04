using System;

namespace JANL
{
    /// <summary>
    /// Структура для использования в <see cref="Progress{T}"/>
    /// </summary>
    public struct TaskProgress : IEquatable<TaskProgress>
    {
        #region ctor

        /// <summary>
        /// Задает числовой прогресс
        /// </summary>
        public TaskProgress(int Value, int Max) : this()
        {
            this.Value = Value;
            this.Max = Max;
            Percent = Value / (double)Max * 100;
            HasValue = true;
        }

        /// <summary>
        /// Задает процент
        /// </summary>
        public TaskProgress(int Percent) : this()
        {
            this.Percent = Percent;
            Value = Percent;
            Max = 100;
            HasValue = true;
        }

        /// <summary>
        /// Задает строковый и числовой прогресс
        /// </summary>
        public TaskProgress(string Status, int Value, int Max) : this(Value, Max)
        {
            this.Status = Status;
            HasStatus = true;
        }

        /// <summary>
        /// Задает строковый прогресс и процент
        /// </summary>
        public TaskProgress(string Status, int Percent) : this(Percent)
        {
            this.Status = Status;
            HasStatus = true;
        }

        /// <summary>
        /// Задает строковый прогресс
        /// </summary>
        public TaskProgress(string Status) : this()
        {
            this.Status = Status;
            HasStatus = true;
        }

        #endregion ctor

        #region Properties

        /// <summary>
        /// <see cref="Value"/>/<see cref="Max"/>
        /// </summary>
        public string Count => $"{Value}/{Max}";

        /// <summary>
        /// Есть ли значение у Status
        /// </summary>
        public bool HasStatus { get; }

        /// <summary>
        /// Есть ли значения у Value, Max и Percent
        /// </summary>
        public bool HasValue { get; }

        /// <summary>
        /// Максимальное значение
        /// </summary>
        public int Max { get; }

        /// <summary>
        /// Процент в формате 100.00
        /// </summary>
        public double Percent { get; }

        /// <summary>
        /// Строковый статус
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Текущие значение
        /// </summary>
        public int Value { get; }

        public bool Equals(TaskProgress other) => Value == other.Value && Max == other.Max && Status == other.Status;

        #endregion Properties
    }
}