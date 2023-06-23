using System;
using System.Drawing;

namespace JANL.Animators
{
    public class Breather : BaseAnimator
    {
        private bool down;
        private float scale = 1;
        private float scaleStep;

        public Breather()
        {
            UpdateScaleStep();
        }

        public Breather(Image image) : this() { SourceImage = image; }

        public Breather(Image image, float minimalScale) : this(image) { MinimalScale = minimalScale; }

        public Breather(float minimalScale) : this() { MinimalScale = minimalScale; }

        public override void ResetAnimation()
        {
            scale = 1;
            base.ResetAnimation();
        }

        protected override void BeforeTransform()
        {
            scale += scaleStep * (down ? -1 : 1);
            scale = Math.Min(Math.Max(_minScale, scale), 1);
            if (scale <= _minScale || scale >= 1) { down = !down; }
            base.BeforeTransform();
        }

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

        protected override void OnDurationChanged(EventArgs e)
        {
            UpdateScaleStep();
            base.OnDurationChanged(e);
        }

        protected override void OnFramerateChanged(EventArgs e)
        {
            UpdateScaleStep();
            base.OnFramerateChanged(e);
        }

        #endregion Events
    }
}