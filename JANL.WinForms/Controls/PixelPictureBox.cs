using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JANL.Controls
{
    public class PixelPictureBox : PictureBox
    {
        public PixelPictureBox()
        {
            InterpolationMode = InterpolationMode.NearestNeighbor;
            PixelOffsetMode = PixelOffsetMode.Half;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.PixelOffsetMode = PixelOffsetMode;
            e.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(e);
        }

        #region Properties

        /// <summary>
        /// Interpolation mode
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(InterpolationMode.NearestNeighbor)]
        public InterpolationMode InterpolationMode { get; set; }

        /// <summary>
        /// Pixel offset mode
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(PixelOffsetMode.Half)]
        public PixelOffsetMode PixelOffsetMode { get; set; }

        #endregion Properties
    }
}