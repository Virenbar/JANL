using System;
using System.Drawing;

namespace JANL.Animators
{
    public sealed class Rotator : BaseAnimator
    {
        /// <summary>
        /// Максимальный угол
        /// </summary>
        private const int MAX_ANGLE = 360;

        /// <summary>
        /// Минимальный угол
        /// </summary>
        private const int MIN_ANGLE = 0;

        /// <summary>
        /// Синус угла в 45°
        /// <para>
        /// SIN45 = Math.Sin(45 * Math.PI / 180)
        /// </para>
        /// </summary>
        private const double SIN45 = 0.70710678118654757;

        private float angle;
        private float angleStep;

        public Rotator()
        {
            UpdateAngleStep();
        }

        public Rotator(Image image) : this() { SourceImage = image; }

        public Rotator(Image image, int duration) : base(image, duration) { }

        public Rotator(int duration) : base(duration) { }

        public override void ResetAnimation()
        {
            angle = MIN_ANGLE;
            base.ResetAnimation();
        }

        protected override void BeforeTransform()
        {
            angle += (short)Direction * angleStep;
            angle %= MAX_ANGLE;
            base.BeforeTransform();
        }

        protected override Image Transform(Image SourceImage, Image CurrentImage)
        {
            Image B = new Bitmap(Width, Height);
            using (Graphics G = Graphics.FromImage(B))
            {
                // Перемещение в центр пространства
                G.TranslateTransform((float)Width / 2, (float)Height / 2);
                // Поворот пространства
                G.RotateTransform(angle);
                // Перемещение в начало исходного изображения
                G.TranslateTransform(-(float)SourceImage.Width / 2, -(float)SourceImage.Height / 2);
                // Рисование исходного изображения
                G.DrawImage(SourceImage, new Point(0, 0));
            }
            return B;
        }

        private void UpdateAngleStep() => angleStep = MAX_ANGLE / ((float)Duration / Delay);

        public enum DirectionType : short
        {
            Clockwise = 1,
            Counterclockwise = -1
        }

        #region Properties
        public DirectionType Direction { get; set; } = DirectionType.Clockwise;

        public override int Height => (int)Math.Ceiling((base.Height + base.Width) * SIN45);

        public override int Width => (int)Math.Ceiling((base.Width + base.Height) * SIN45);

        #endregion Properties

        #region Events

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

        #endregion Events
    }
}