using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JANL.Properties;
using JANL.Animators;

namespace JANL

{
	public partial class UC_Loader : UserControl
	{
		private int _Opacity = 100;
		private int alpha = 0;

		private AnimatedImage Animation;

		public UC_Loader()
		{
			InitializeComponent();
			//DoubleBuffered = true;
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.Opaque, true);
			//BackColor = Color.Transparent;
			//BackColor = Color.Black;
			BackColor = Color.FromArgb(255, Color.Black);
			//Opacity = 10;

			PB_Image.Visible = false;
		}

		public int Opacity
		{
			get => _Opacity;
			set
			{
				_Opacity = Math.Max(0, Math.Min(100, value));
				alpha = _Opacity * 255 / 100;
				if (Parent != null) { Parent.Invalidate(Bounds, true); }
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | 0x20;
				return cp;
			}
		}

		protected override void OnBackColorChanged(EventArgs e)
		{
			if (Parent != null) { Parent.Invalidate(Bounds, true); }
			base.OnBackColorChanged(e);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			PP(e.Graphics);
			//base.OnPaintBackground(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			PP(e.Graphics);
			Animation.Paint(e.Graphics);
			base.OnPaint(e);
		}

		private void PP(Graphics G)
		{
			//G.Clear(BackColor);

			//var t = e.ClipRectangle;
			//Rectangle Bounds = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle Bounds = DisplayRectangle;
			//Color frmColor = Parent.BackColor;
			using (var SB = new SolidBrush(Color.FromArgb(alpha, BackColor)))
			{
				if (BackColor != Color.Transparent)
				{
					G.FillRectangle(SB, Bounds);
				}
			}
			//g.Dispose();
			G.DrawImage(Resources.partner64, ClientSize.Width / 2, ClientSize.Height / 2);
		}

		protected override void OnParentBackColorChanged(EventArgs e)
		{
			Invalidate();
			base.OnParentBackColorChanged(e);
		}

		private void UC_Loader_Resize(object sender, EventArgs e)
		{
			PB_Image.Left = (ClientSize.Width - PB_Image.Width) / 2;
			PB_Image.Top = (ClientSize.Height - PB_Image.Height) / 2;
		}

		private void UC_Loader_Load(object sender, EventArgs e)
		{
			Animation = new RotatingImage(this, Resources.partner64);
			Animation.SetFramerate(15);
			Animation.StartAnimation();
			Animation.FramePrepared += Animation_FramePrepared;
		}

		private void Animation_FramePrepared(object sender, EventArgs e)
		{
			Rectangle B = Bounds;
			SetBounds(Left, Top, 0, 0, BoundsSpecified.All);

			SetBounds(Left, Top, B.Width, B.Height, BoundsSpecified.All);

			//SetBoundsCore(Left, Top, Width, Height, BoundsSpecified.None);
			//Invalidate();
		}
	}
}