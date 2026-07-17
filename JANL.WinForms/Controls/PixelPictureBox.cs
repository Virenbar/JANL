using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// <see cref="PictureBox"/> без сглаживания
    /// </summary>
    public sealed class PixelPictureBox : PictureBox
    {
        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public PixelPictureBox()
        {
            InterpolationMode = InterpolationMode.NearestNeighbor;
            PixelOffsetMode = PixelOffsetMode.Half;
        }

        /// <summary>
        /// Private
        /// </summary>
        /// <param name="e"></param>
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