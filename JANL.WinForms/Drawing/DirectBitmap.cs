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
        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        protected GCHandle BitsHandle { get; private set; }

        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        public Color GetPixel(int x, int y) => Color.FromArgb(Bits[GetIndex(x, y)]);

        public void SetPixel(int x, int y, Color color) => Bits[GetIndex(x, y)] = color.ToArgb();

        private int GetIndex(int x, int y) => x + (y * Width);

        #region Properties

        public Bitmap Bitmap { get; private set; }
        public int[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        #endregion Properties

        #region Disposing

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

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