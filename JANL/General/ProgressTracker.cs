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
        private TimeSpan LastIncriment = new TimeSpan();

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
                DeltaTime.Enqueue(TotalTime.Elapsed - LastIncriment);
                long Average = (long)DeltaTime.Average(T => T.Ticks);
                TimeAverage = new TimeSpan(Average);
                TimeRemaining = new TimeSpan(Average * (Maximum - Value));
            }
            LastIncriment = TotalTime.Elapsed;
            base.OnReport(value);
        }

        #region Properties

        public int Maximum { get; set; }
        public float Percent => Maximum == 0 ? 0 : Math.Min((float)Value / Maximum * 100, 100);

        public int QueueLimit
        {
            get => DeltaTime.Limit;
            set => DeltaTime.Limit = value;
        }

        public TimeSpan TimeAverage { get; private set; }
        public TimeSpan TimeElapsed => TotalTime.Elapsed;
        public TimeSpan TimeRemaining { get; private set; }
        public int Value { get; private set; }
        #endregion Properties
    }
}