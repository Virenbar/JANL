using System;
using System.Drawing;

namespace JANL.Animators
{
    public class Breather : BaseAnimator
    {
        private float _scale = 1;
        private float _scaleStep;
        private bool down = false;
        private float _minScale = 0.5f;

        public Breather() : this(0.5f) { }

        public Breather(float minimalScale) : base() { MinimalScale = minimalScale; }

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

        public override void ResetAnimation()
        {
            _scale = 1;
            base.ResetAnimation();
        }

        private void UpdateScaleStep()
        {
            var diff = 1 - _minScale;
            _scaleStep = diff / ((float)Duration / Delay);
        }

        protected override Image Transform(Image SourceImage, Image CurrentImage)
        {
            _scale += _scaleStep * (down ? -1 : 1);
            _scale = Math.Min(Math.Max(_minScale, _scale), 1);
            if (_scale == _minScale || _scale == 1) { down = !down; }

            Image B = new Bitmap(Width, Height);
            using (Graphics G = Graphics.FromImage(B))
            {
                G.TranslateTransform((float)Width / 2, (float)Height / 2);
                G.ScaleTransform(_scale, _scale);

                G.TranslateTransform(-(float)SourceImage.Width / 2, -(float)SourceImage.Height / 2);
                G.DrawImage(SourceImage, new Point(0, 0));
            }
            return B;
        }

        #region Properties

        public float MinimalScale
        {
            get => _minScale;
            set
            {
                _minScale = value;
                UpdateScaleStep();
            }
        }

        #endregion Properties
    }
}