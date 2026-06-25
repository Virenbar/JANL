using System;
using System.Diagnostics;
using System.Linq;
using JANL.Extensions;
using JANL.Generic;

namespace JANL
{
    /// <summary>
    /// Класс для расчёта прогресса
    /// </summary>
    public class ProgressTracker : Progress<int>, IProgress<int>
    {
        private readonly FixedQueue<TimeSpan> DeltaTime;
        private readonly Stopwatch TotalTime = new Stopwatch();
        private TimeSpan LastReport = new TimeSpan();

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        /// <param name="total">Максимум</param>
        /// <param name="limit">Лимит очереди</param>
        public ProgressTracker(int total, int limit)
        {
            Maximum = total;
            DeltaTime = new FixedQueue<TimeSpan>(limit);
        }

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        /// <param name="total"></param>
        public ProgressTracker(int total) : this(total, 10) { }

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public ProgressTracker() : this(100, 10) { }

        /// <summary>
        /// Увеличивает значение на 1
        /// </summary>
        public void Incriment() => OnReport(Value + 1);

        /// <summary>
        /// Увеличивает значение на указанное значение
        /// </summary>
        /// <param name="inc">Значение</param>
        public void Incriment(int inc) => OnReport(Value + inc);

        /// <summary>
        /// Сбрасывает состояние
        /// </summary>
        public void Reset()
        {
            Value = 0;
            TotalTime.Reset();
            DeltaTime.Clear();
            TimeAverage = TimeSpan.Zero;
            TimeRemaining = TimeSpan.Zero;
            LastReport = TimeSpan.Zero;
        }

        /// <summary>
        /// Запускает измерение времени выполнения
        /// </summary>
        public void Start() => TotalTime.Restart();

        /// <summary>
        /// Останавливает измерение времени выполнения
        /// </summary>
        public void Stop() => TotalTime.Stop();

        /// <summary>
        /// Сообщает об изменении хода выполнения.
        /// </summary>
        /// <param name="value">Значение обновленного хода выполнения.</param>
        protected override void OnReport(int value)
        {
            var delta = Math.Abs(value - Value);
            Value = Math.Min(value, Maximum);
            if (Value == Maximum)
            {
                TimeRemaining = TimeSpan.Zero;
            }
            else if (delta > 0)
            {
                DeltaTime.Enqueue(new TimeSpan((TotalTime.Elapsed - LastReport).Ticks / delta));
                long Average = (long)DeltaTime.Average(T => T.Ticks);
                TimeAverage = new TimeSpan(Average);
                long oldTicks = TimeRemaining.Ticks;
                long newTicks = Average * (Maximum - Value);
                TimeRemaining = new TimeSpan((long)(oldTicks * Smoothness + newTicks * (1 - Smoothness)));
            }
#if DEBUG
            Console.WriteLine($"{delta}{TimeAverage}{TimeRemaining}");
#endif
            LastReport = TotalTime.Elapsed;
            base.OnReport(value);
        }

        #region Properties
        private float _smoothness = 0.8F;

        /// <summary>
        /// Максимальное значение
        /// </summary>
        public int Maximum { get; set; }

        /// <summary>
        /// Процент
        /// </summary>
        public float Percent => Maximum == 0 ? 0 : Math.Min((float)Value / Maximum * 100, 100);

        /// <summary>
        /// Лимит очереди
        /// </summary>
        public int QueueLimit
        {
            get => DeltaTime.Limit;
            set => DeltaTime.Limit = value;
        }

        /// <summary>
        /// Плавность изменения оставшегося времени
        /// </summary>
        public float Smoothness
        {
            get => _smoothness;
            set => _smoothness = value.Clamp(0, 1);
        }

        /// <summary>
        /// Среднее время
        /// </summary>
        public TimeSpan TimeAverage { get; private set; }

        /// <summary>
        /// Пройденное время
        /// </summary>
        public TimeSpan TimeElapsed => TotalTime.Elapsed;

        /// <summary>
        /// Оставшегося времени
        /// </summary>
        public TimeSpan TimeRemaining { get; private set; }

        /// <summary>
        /// Текущее значение
        /// </summary>
        public int Value { get; private set; }

        #endregion Properties
    }
}