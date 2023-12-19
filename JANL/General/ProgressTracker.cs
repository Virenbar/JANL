using JANL.Extensions;
using JANL.Generic;
using System;
using System.Diagnostics;
using System.Linq;

namespace JANL
{
    public class ProgressTracker : Progress<int>
    {
        private readonly FixedQueue<TimeSpan> DeltaTime;
        private readonly Stopwatch TotalTime = new Stopwatch();
        private TimeSpan LastReport = new TimeSpan();

        public ProgressTracker(int total, int limit)
        {
            Maximum = total;
            DeltaTime = new FixedQueue<TimeSpan>(limit);
        }

        public ProgressTracker(int total) : this(total, 10) { }

        public ProgressTracker() : this(100, 10) { }

        public void Incriment() => OnReport(1);

        public void Incriment(int value) => OnReport(value);

        public void Reset()
        {
            Value = 0;
            TotalTime.Reset();
            TimeAverage = TimeSpan.Zero;
            DeltaTime.Clear();
            TimeRemaining = TimeSpan.Zero;
        }

        public void Start()
        {
            TotalTime.Restart();
        }

        public void Stop()
        {
            TotalTime.Stop();
        }

        protected override void OnReport(int value)
        {
            Value += value;
            if (Value >= Maximum)
            {
                Value = Maximum;
                TimeRemaining = TimeSpan.Zero;
            }
            else
            {
                DeltaTime.Enqueue(new TimeSpan((TotalTime.Elapsed - LastReport).Ticks / value));
                long Average = (long)DeltaTime.Average(T => T.Ticks);
                TimeAverage = new TimeSpan(Average);
                long old = TimeRemaining.Ticks;
                long n = Average * (Maximum - Value);

                long d = (long)(old * Smoothness + n * (1 - Smoothness));

                TimeRemaining = new TimeSpan(d);
            }
            LastReport = TotalTime.Elapsed;
            base.OnReport(value);
        }

        #region Properties
        private float _smoothness = 0.8F;
        public int Maximum { get; set; }
        public float Percent => Maximum == 0 ? 0 : Math.Min((float)Value / Maximum * 100, 100);

        public int QueueLimit
        {
            get => DeltaTime.Limit;
            set => DeltaTime.Limit = value;
        }

        public float Smoothness
        {
            get => _smoothness;
            set => _smoothness = value.Clamp(0, 1);
        }

        public TimeSpan TimeAverage { get; private set; }
        public TimeSpan TimeElapsed => TotalTime.Elapsed;
        public TimeSpan TimeRemaining { get; private set; }
        public int Value { get; private set; }
        #endregion Properties
    }
}