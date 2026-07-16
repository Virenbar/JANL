using System;
using System.Windows.Forms;

namespace JANL.Animators
{
    /// <summary>
    /// Класс для анимации спиннера
    /// </summary>
    public class SpinnerAnimator
    {
        private readonly Timer timer = new Timer { Interval = 100 };
        private int index;

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public SpinnerAnimator()
        {
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Создаёт новый экземпляр с указанным спиннером
        /// </summary>
        /// <param name="spinner">Cпиннер</param>
        public SpinnerAnimator(Spinner spinner) : this()
        {
            Spinner = spinner;
        }

        /// <summary>
        /// Сбрасывает анимацию
        /// </summary>
        public void Reset()
        {
            index = 0;
            UpdateFrame();
        }

        /// <summary>
        /// Запускает анимацию
        /// </summary>
        public void Start()
        {
            timer.Interval = Spinner.Interval.Milliseconds;
            timer.Start();
        }

        /// <summary>
        /// Останавливает анимацию
        /// </summary>
        public void Stop() => Stop(false);

        /// <summary>
        /// Останавливает анимацию
        /// </summary>
        /// <param name="reset">Сбросить анимацию</param>
        public void Stop(bool reset)
        {

            timer.Stop();
            if (reset) { Reset(); }
        }

        private void Timer_Tick(object sender, EventArgs e) => UpdateFrame();

        private void UpdateFrame()
        {
            var frame = Spinner.Frames[index];
            index = (index + 1) % Spinner.Frames.Count;
            Frame = frame;
            OnFrameChanged(new EventArgs());
        }

        #region Properties
        private Spinner _spinner;

        /// <summary>
        /// Текущий кадр
        /// </summary>
        public string Frame { get; private set; }

        /// <summary>
        /// Спиннер
        /// </summary>
        public Spinner Spinner
        {
            get => _spinner;
            set
            {
                if (_spinner == value) { return; }
                _spinner = value;
                Reset();
            }
        }

        #endregion Properties

        #region Events

        /// <summary>
        /// Вызывает <see cref="FrameChanged"/>
        /// </summary>
        /// <param name="args"></param>
        protected void OnFrameChanged(EventArgs args) => FrameChanged?.Invoke(this, args);

        /// <summary>
        /// Происходит при смене кадра
        /// </summary>
        public event EventHandler FrameChanged;

        #endregion Events
    }
}