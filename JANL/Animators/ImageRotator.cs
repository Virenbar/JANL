using System.Drawing;

namespace JANL.Animators
{
    internal class ImageRotator : ImageAnimator
    {
        private const int Total = 360;
        private float Angle;
        private float AngleStep;

        public ImageRotator(Image Image) : this(Image, 5 * 1000) { }

        public ImageRotator(Image Image, int Duration) : base(Image)
        {
            Angle = 0;
            SetDuration(Duration);
            Direction = DirectionType.Clockwise;
        }

        public DirectionType Direction { get; set; }
        public int Duration { get; private set; }

        public override void ResetAnimation() { Angle = 0; }

        public void SetDuration(int Duration)
        {
            this.Duration = Duration;
            AngleStep = Total / ((float)Duration / Delay);
        }

        public override void SetFramerate(int Framerate)
        {
            base.SetFramerate(Framerate);
            SetDuration(Duration);
        }

        protected override Bitmap Transform(Image SourceImage)
        {
            Angle = (Angle + (int)Direction * AngleStep) % Total;
            Bitmap B = new Bitmap(Width, Height);
            using (Graphics G = Graphics.FromImage(B))
            {
                G.TranslateTransform((float)Width / 2, (float)Height / 2);
                G.RotateTransform(Angle);
                G.TranslateTransform(-(float)Width / 2, -(float)Height / 2);
                G.DrawImage(SourceImage, new Point(0, 0));
            }
            return B;
        }

        public enum DirectionType : int
        {
            Clockwise = 1,
            Counterclockwise = -1
        }
    }
}