using System;
using System.Drawing;

namespace JANL.Animators
{
    public class Rotator : BaseAnimator
    {
        private const double SIN45 = 0.70710678118654757;//SIN45 = Math.Sin(45 * Math.PI / 180);
        private const int TOTAL = 360;
        private float _angle;
        private float AngleStep;

        public Rotator() : base() { }

        public Rotator(int duration) : base(30, duration) { }

        public Rotator(int duration, Image image) : base(30, duration, image) { }

        public override void ResetAnimation()
        {
            _angle = 0;
            base.ResetAnimation();
        }

        protected override Image Transform(Image SourceImage, Image CurrentImage)
        {
            _angle = (_angle + (int)Direction * AngleStep) % TOTAL;
            Image B = /*CurrentImage ??*/ new Bitmap(Width, Height);

            using (Graphics G = Graphics.FromImage(B))
            {
                G.TranslateTransform((float)Width / 2, (float)Height / 2);
                G.RotateTransform(_angle);
                G.TranslateTransform(-(float)SourceImage.Width / 2, -(float)SourceImage.Height / 2);
                G.DrawImage(SourceImage, new Point(0, 0));
            }

            return B;
        }

        private void UpdateAngleStep() => AngleStep = TOTAL / ((float)Duration / Delay);

        public enum DirectionType : int
        {
            Clockwise = 1,
            Counterclockwise = -1
        }

        protected override void OnDurationChanged(EventArgs e)
        {
            UpdateAngleStep();
            base.OnDurationChanged(e);
        }

        protected override void OnFramerateChanged(EventArgs e)
        {
            UpdateAngleStep();
            base.OnFramerateChanged(e);
        }

        #region Properties
        public DirectionType Direction { get; set; } = DirectionType.Clockwise;

        public override int Height => (int)Math.Ceiling((base.Height + base.Width) * SIN45);

        public override int Width => (int)Math.Ceiling((base.Width + base.Height) * SIN45);

        #endregion Properties
    }
}