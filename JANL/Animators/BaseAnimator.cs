using JANL.Interfaces;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace JANL.Animators
{
    public abstract class BaseAnimator : ObservableObject, IAnimator
    {
        private readonly Stopwatch Stopwatch = new Stopwatch();
        private int _duration;
        private int _framerate;
        private Task AnimationTask;

        protected BaseAnimator(int framerate, int duration)
        {
            Framerate = framerate;
            Duration = duration;
        }

        protected BaseAnimator(int framerate, int duration, Image image) : this(framerate, duration) { SourceImage = image; }

        protected BaseAnimator() : this(30, 5 * 1000) { }

        protected BaseAnimator(Image image) : this() { SourceImage = image; }

        [DllImport("user32.dll")]
        public extern static bool DestroyIcon(IntPtr handle);

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
            IsAnimated = true;
            AnimationTask = AnimationLoop();
        }

        /// <summary>
        /// Остановка анимации
        /// </summary>
        public void StopAnimation() => IsAnimated = false;

        protected abstract Image Transform(Image SourceImage, Image CurrentImage);

        private void Animate()
        {
            Stopwatch.Restart();
            CurrentImage = Transform(SourceImage, CurrentImage);
            Stopwatch.Stop();
            Thread.Sleep(Math.Max(Delay - (int)Stopwatch.ElapsedMilliseconds, 0));
        }

        private async Task AnimationLoop()
        {
            await Task.Delay(Delay);
            //var t = new doubleanimation()
            while (IsAnimated)
            {
                //await Task.Run(Animate).ConfigureAwait(false);
                await Task.Run(() =>
                {
                    Stopwatch.Restart();
                    CurrentImage = Transform(SourceImage, CurrentImage);
                    Stopwatch.Stop();
                    //Thread.Sleep(Math.Max(Delay - (int)Stopwatch.ElapsedMilliseconds, 0));
                }).ConfigureAwait(false);
                OnCurrentImageChanged(EventArgs.Empty);
                await Task.Delay(Math.Max(Delay - (int)Stopwatch.ElapsedMilliseconds, 0));
            }
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
        public bool IsAnimated { get; private set; }

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