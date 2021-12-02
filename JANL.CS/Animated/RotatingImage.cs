using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.Animators
{
	public class RotatingImage : AnimatedImage
	{
		private float Angle;
		private float AngleStep;
		private int Duration;
		private const int Total = 360;

		public RotatingImage(Control Parent, Image Image) : this(Parent, Image, 5 * 1000) { }

		public RotatingImage(Control Parent, Image Image, int Duration) : base(Parent, Image)
		{
			Angle = 0;
			SetDuration(Duration);
			Direction = DirectionType.Clockwise;
			Size = new Size((int)Math.Ceiling(Image.Width * 1.707), (int)Math.Ceiling(Image.Height * 1.707));
		}

		public DirectionType Direction { get; set; }

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

		protected override void PaintFrame(Graphics G)
		{
			G.TranslateTransform((float)Width / 2, (float)Height / 2);
			G.RotateTransform(Angle);

			//G.TranslateTransform(-(float)Width / 2, -(float)Height / 2);

			G.TranslateTransform(-(float)Image.Width / 2, -(float)Image.Height / 2);

			G.DrawImage(Image, new Point(0, 0));
		}

		protected override void PrepareFrame()
		{
			Angle = (Angle + (int)Direction * AngleStep) % Total;
		}

		public enum DirectionType : int
		{
			Clockwise = 1,
			Counterclockwise = -1
		}
	}
}