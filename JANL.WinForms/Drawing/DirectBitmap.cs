using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace JANL.Drawing
{
    /// <summary>
    /// Bitmap with pinned memory
    /// </summary>
    /// <remarks>
    /// https://stackoverflow.com/a/34801225/9530839
    /// </remarks>
    public class DirectBitmap : IDisposable
    {
        /// <summary>
        /// Creates new <see cref="DirectBitmap"/>
        /// </summary>
        /// <param name="width">Width of bitmap</param>
        /// <param name="height">Height of bitmap</param>
        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        /// <summary>
        /// Memory handle
        /// </summary>
        protected GCHandle BitsHandle { get; private set; }

        /// <summary>
        /// Access to color of pixel
        /// </summary>
        /// <param name="x">X of pixel</param>
        /// <param name="y">Y of pixel</param>
        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        /// <summary>
        /// Get color of pixel
        /// </summary>
        /// <param name="x">X of pixel</param>
        /// <param name="y">Y of pixel</param>
        /// <returns>Color of pixel</returns>
        public Color GetPixel(int x, int y) => Color.FromArgb(Bits[GetIndex(x, y)]);

        /// <summary>
        /// Set color of pixel
        /// </summary>
        /// <param name="x">X of pixel</param>
        /// <param name="y">Y of pixel</param>
        /// <param name="color">Color to set</param>
        public void SetPixel(int x, int y, Color color) => Bits[GetIndex(x, y)] = color.ToArgb();

        private int GetIndex(int x, int y) => x + (y * Width);

        #region Properties

        /// <summary>
        /// Internal bitmap
        /// </summary>
        public Bitmap Bitmap { get; private set; }

        /// <summary>
        /// Bits of bitmap
        /// </summary>
        public int[] Bits { get; private set; }

        /// <summary>
        /// Height of bitmap
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Width of bitmap
        /// </summary>
        public int Width { get; private set; }

        #endregion Properties

        #region Disposing

        /// <summary>
        ///
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            BitsHandle.Free();
            if (disposing)
            {
                Bitmap.Dispose();
            }
        }

        #endregion Disposing
    }
}