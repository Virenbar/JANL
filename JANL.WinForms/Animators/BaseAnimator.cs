using JANL.Interfaces;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Animators
{
    public abstract class BaseAnimator : ObservableObject, IAnimator
    {
        private readonly Stopwatch Stopwatch = new Stopwatch();
        private readonly Timer Timer = new Timer();
        private int _duration;
        private int _framerate;

        protected BaseAnimator(int framerate, int duration)
        {
            Framerate = framerate;
            Duration = duration;
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) => Animate();

        protected BaseAnimator(int framerate, int duration, Image image) : this(framerate, duration) { SourceImage = image; }

        protected BaseAnimator() : this(30, 5 * 1000) { }

        protected BaseAnimator(Image image) : this() { SourceImage = image; }

        /// <summary>
        /// Сброс состояния анимации
        /// </summary>
        public virtual void ResetAnimation()
        {
            CurrentImage = Transform(SourceImage, CurrentImage);
            OnCurrentImageChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Запуск анимации
        /// </summary>
        public void StartAnimation()
        {
            if (SourceImage is null || IsAnimated) { return; }
            Timer.Interval = Delay;
            Timer.Start();
        }

        /// <summary>
        /// Остановка анимации
        /// </summary>
        public void StopAnimation() => Timer.Stop();

        protected abstract Image Transform(Image SourceImage, Image CurrentImage);

        private void Animate()
        {
            Stopwatch.Restart();
            CurrentImage = Transform(SourceImage, CurrentImage);
            OnCurrentImageChanged(EventArgs.Empty);
            Stopwatch.Stop();
            Timer.Interval = Math.Max(Delay - (int)Stopwatch.ElapsedMilliseconds, 10);
        }

        #region Properties

        /// <summary>
        /// Текущий кадр
        /// </summary>
        public Image CurrentImage { get; protected set; }

        /// <summary>
        /// Длительность анимации
        /// </summary>
        public virtual int Duration
        {
            get => _duration;
            set
            {
                if (_duration == value) { return; }
                _duration = value;
                NotifyPropertyChanged();
                OnDurationChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Частота кадров
        /// </summary>
        public virtual int Framerate
        {
            get => _framerate;
            set
            {
                if (_framerate == value) { return; }
                _framerate = value;
                Delay = 1000 / _framerate;
                NotifyPropertyChanged();
                OnFramerateChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Высота текущего кадра
        /// </summary>
        public virtual int Height => SourceImage.Height;

        /// <summary>
        /// Активна ли анимация
        /// </summary>
        public bool IsAnimated => Timer.Enabled;

        /// <summary>
        /// Исходное изображение
        /// </summary>
        public Image SourceImage { get; set; }

        /// <summary>
        /// Ширина текущего кадра
        /// </summary>
        public virtual int Width => SourceImage.Width;

        /// <summary>
        /// Задержка между кадрами (мс)
        /// </summary>
        protected int Delay { get; private set; }

        #endregion Properties

        #region Events

        protected virtual void OnCurrentImageChanged(EventArgs e) => CurrentImageChanged?.Invoke(this, e);

        protected virtual void OnDurationChanged(EventArgs e) => DurationChanged?.Invoke(this, e);

        protected virtual void OnFramerateChanged(EventArgs e) => FramerateChanged?.Invoke(this, e);

        public event EventHandler CurrentImageChanged;

        public event EventHandler DurationChanged;

        public event EventHandler FramerateChanged;

        #endregion Events
    }
}