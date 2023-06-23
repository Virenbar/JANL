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

        protected BaseAnimator()
        {
            UpdateDelay();
            Timer.Tick += Timer_Tick;
        }

        protected BaseAnimator(Image image) : this() { SourceImage = image; }

        protected BaseAnimator(Image image, int duration) : this(image) { Duration = duration; }

        protected BaseAnimator(Image image, int duration, int framerate) : this(image, framerate) { Framerate = framerate; }

        protected BaseAnimator(int duration) : this(null, duration) { }

        protected BaseAnimator(int duration, int framerate) : this(null, duration, framerate) { }

        /// <summary>
        /// Сброс состояния анимации
        /// <para>
        /// Создает новый кадр без вызова <see cref="BeforeTransform"/> и <see cref="AfterTransform"/>
        /// </para>
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
            if (SourceImage is null || Enabled) { return; }
            Timer.Interval = Delay;
            Timer.Start();
        }

        /// <summary>
        /// Остановка анимации
        /// </summary>
        public void StopAnimation() => StopAnimation(false);

        /// <summary>
        /// Остановка анимации
        /// </summary>
        /// <param name="reset">Сбросить состояние анимации</param>
        public void StopAnimation(bool reset)
        {
            Timer.Stop();
            if (reset) { ResetAnimation(); }
        }

        /// <summary>
        /// Вызывается после созданием нового кадра
        /// </summary>
        protected virtual void AfterTransform() { }

        /// <summary>
        /// Вызывается перед созданием нового кадра
        /// </summary>
        protected virtual void BeforeTransform() { }

        /// <summary>
        /// Создает новый кадр
        /// </summary>
        /// <param name="SourceImage"></param>
        /// <param name="CurrentImage"></param>
        /// <returns>Новый кадр</returns>
        protected abstract Image Transform(Image SourceImage, Image CurrentImage);

        private void Animate()
        {
            Stopwatch.Restart();
            BeforeTransform();
            CurrentImage = Transform(SourceImage, CurrentImage);
            AfterTransform();
            OnCurrentImageChanged(EventArgs.Empty);
            Stopwatch.Stop();
            Timer.Interval = Math.Max(Delay - (int)Stopwatch.ElapsedMilliseconds, 10);
        }

        private void Timer_Tick(object sender, EventArgs e) => Animate();

        private void UpdateDelay() => Delay = 1000 / Framerate;

        #region Properties
        private int _duration = 5 * 1000;
        private int _framerate = 30;

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
        /// Активна ли анимация
        /// </summary>
        public bool Enabled => Timer.Enabled;

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
                UpdateDelay();
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
        [Obsolete("Use Enabled")]
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