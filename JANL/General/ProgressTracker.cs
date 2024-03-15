using JANL.Extensions;
using JANL.Generic;
using System;
using System.Diagnostics;
using System.Linq;

namespace JANL
{
    public class ProgressTracker : Progress<int>, IProgress<int>
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

        public void Incriment() => OnReport(Value + 1);

        public void Incriment(int inc) => OnReport(Value + inc);

        public void Reset()
        {
            Value = 0;
            TotalTime.Reset();
            DeltaTime.Clear();
            TimeAverage = TimeSpan.Zero;
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
            var delta = value - Value;
            Value = Math.Min(value, Maximum);
            if (Value >= Maximum)
            {
                TimeRemaining = TimeSpan.Zero;
            }
            else
            {
                DeltaTime.Enqueue(new TimeSpan((TotalTime.Elapsed - LastReport).Ticks / delta));
                long Average = (long)DeltaTime.Average(T => T.Ticks);
                long oldTicks = TimeRemaining.Ticks;
                long newTicks = Average * (Maximum - Value);
                TimeAverage = new TimeSpan(Average);
                TimeRemaining = new TimeSpan((long)(oldTicks * Smoothness + newTicks * (1 - Smoothness)));
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