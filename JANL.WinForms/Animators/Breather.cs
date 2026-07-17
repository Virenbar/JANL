using System;
using System.Drawing;

namespace JANL.Animators
{
    /// <summary>
    /// Класс анимации дыхания
    /// </summary>
    public sealed class Breather : BaseAnimator
    {
        private bool down;
        private float scale = 1;
        private float scaleStep;

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public Breather()
        {
            UpdateScaleStep();
        }

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public Breather(Image image) : this() { SourceImage = image; }

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public Breather(Image image, float minimalScale) : this(image) { MinimalScale = minimalScale; }

        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public Breather(float minimalScale) : this() { MinimalScale = minimalScale; }

        /// <summary>
        /// Сброс состояния анимации
        /// </summary>
        public override void ResetAnimation()
        {
            scale = 1;
            base.ResetAnimation();
        }

        /// <summary>
        /// Вызывается перед созданием нового кадра
        /// </summary>
        protected override void BeforeTransform()
        {
            scale += scaleStep * (down ? -1 : 1);
            scale = Math.Min(Math.Max(_minScale, scale), 1);
            if (scale <= _minScale || scale >= 1) { down = !down; }
            base.BeforeTransform();
        }

        /// <summary>
        /// Создает новый кадр
        /// </summary>
        /// <param name="SourceImage">Исходный кадр</param>
        /// <param name="CurrentImage">Текущий кадр</param>
        /// <returns>Новый кадр</returns>
        protected override Image Transform(Image SourceImage, Image CurrentImage)
        {
            Image B = new Bitmap(Width, Height);
            using (Graphics G = Graphics.FromImage(B))
            {
                // Перемещение в центр пространства
                G.TranslateTransform((float)Width / 2, (float)Height / 2);
                // Масштабирование пространства
                G.ScaleTransform(scale, scale);
                // Перемещение в начало исходного изображения
                G.TranslateTransform(-(float)SourceImage.Width / 2, -(float)SourceImage.Height / 2);
                // Рисование исходного изображения
                G.DrawImage(SourceImage, new Point(0, 0));
            }
            return B;
        }

        private void UpdateScaleStep()
        {
            var diff = 1 - _minScale;
            scaleStep = diff / ((float)Duration / Delay);
        }

        #region Properties
        private float _minScale = 0.5f;

        /// <summary>
        /// Минимальный размер изображения
        /// </summary>
        public float MinimalScale
        {
            get => _minScale;
            set
            {
                if (_minScale == value) { return; }
                _minScale = value;
                UpdateScaleStep();
            }
        }

        #endregion Properties

        #region Events

        /// <summary>
        /// Private
        /// </summary>
        protected sealed override void OnDurationChanged(EventArgs e)
        {
            UpdateScaleStep();
            base.OnDurationChanged(e);
        }

        /// <summary>
        /// Private
        /// </summary>
        protected override void OnFramerateChanged(EventArgs e)
        {
            UpdateScaleStep();
            base.OnFramerateChanged(e);
        }

        #endregion Events
    }
}