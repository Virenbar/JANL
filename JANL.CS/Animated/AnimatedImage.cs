using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.Animators
{
	public abstract class AnimatedImage
	{
		protected int Delay;
		protected int Framerate;

		private readonly Control Parent;
		private bool Animated;

		public AnimatedImage(Control Parent) : this(Parent, new Bitmap(16, 16)) { }

		public AnimatedImage(Control Parent, Image Image)
		{
			Framerate = 30;
			Delay = 1000 / Framerate;
			this.Parent = Parent;
			this.Parent.Paint += Parent_Paint;
			this.Image = Image;
			Size = Image.Size;
		}

		public abstract void ResetAnimation();

		public virtual void SetFramerate(int Framerate)

		{
			Delay = 1000 / Framerate;
			this.Framerate = Framerate;
		}

		public void StartAnimation()
		{
			if (Animated) { return; }
			Animated = true;
			_ = AnimationLoop();
		}

		public void StopAnimation() => Animated = false;

		protected abstract void PaintFrame(Graphics G);

		protected abstract void PrepareFrame();

		private async Task AnimationLoop()
		{
			while (Animated)
			{
				await Task.Delay(Delay);
				PrepareFrame();
				//Region R = new Region(new Rectangle(Parent.Width / 2, 0, Parent.Width, Parent.Height));
				//Parent.SetBounds(Parent.Left, Parent.Top, Parent.Width, Parent.Height, BoundsSpecified.None);
				//Parent.Invalidate(R, true);
				OnFramePrepared();
			}
		}

		public void Paint(Graphics G) => PaintFrame(G);

		private void Parent_Paint(object sender, PaintEventArgs e)
		{
			//PaintFrame(e.Graphics);
		}

		#region Properties
		protected int Height => Parent.Height;
		public Image Image { get; set; }
		protected int Width => Parent.Width;
		public Size Size { get; protected set; }

		public Rectangle Bounds => new Rectangle(Position, Size);
		public Point Position { get; set; }

		#endregion Properties

		#region Events

		protected void OnFramePrepared() => FramePrepared?.Invoke(this, EventArgs.Empty);

		public event EventHandler FramePrepared;

		#endregion Events
	}
}