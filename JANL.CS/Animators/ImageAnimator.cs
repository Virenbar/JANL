﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace JANL.Animators
{
	public abstract class ImageAnimator
	{
		protected int Delay;
		protected int Framerate;
		private readonly Image SourceImage;
		private bool Animated;

		public ImageAnimator(Image Image)
		{
			Framerate = 30;
			Delay = 1000 / Framerate;
			SourceImage = Image;
			this.Image = new Bitmap(Image);
		}

		[DllImport("user32.dll")]
		public extern static bool DestroyIcon(IntPtr handle);

		public abstract void ResetAnimation();

		public virtual void SetFramerate(int Framerate)
		{
			Delay = 1000 / Framerate;
			this.Framerate = Framerate;
		}

		public void StartAnimation()
		{
			Animated = true;
			_ = AnimationLoop();
		}

		public void StopAnimation() => Animated = false;

		protected abstract Bitmap Transform(Image SourceImage);

		private void Animate()
		{
			Thread.Sleep(Delay);
			var f = Transform(SourceImage);
			Image = f;
		}

		private async Task AnimationLoop()
		{
			while (Animated)
			{
				//await Task.Delay(Delay);
				//var f = await Task.Run(() => Transform(SourceImage));
				//Image = f;
				await Task.Run(Animate);
				OnImageChanged();
			}
		}

		#region Properties
		protected int Height => SourceImage.Height;
		public Bitmap Image { get; private set; }
		protected int Width => SourceImage.Width;
		#endregion Properties

		#region Events

		protected void OnImageChanged() => ImageChanged?.Invoke(this, EventArgs.Empty);

		public event EventHandler ImageChanged;

		#endregion Events
	}
}