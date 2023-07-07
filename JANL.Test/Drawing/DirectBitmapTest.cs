using JANL.Drawing;
using NUnit.Framework;
using System.Drawing;

namespace JANL.Test.Drawing
{
    internal class DirectBitmapTest
    {
        private readonly Color White = Color.White;
        private DirectBitmap Bitmap;

        [SetUp]
        public void Setup()
        {
            Bitmap = new DirectBitmap(8, 8);
        }

        [TearDown]
        public void TearDown()
        {
            Bitmap.Dispose();
        }

        [Test]
        public void TestGetSet()
        {
            Bitmap.SetPixel(0, 0, White);
            Assert.AreEqual(White.ToArgb(), Bitmap.GetPixel(0, 0).ToArgb());
        }

        [Test]
        public void TestThis()
        {
            Bitmap[1, 1] = White;
            Assert.AreEqual(White.ToArgb(), Bitmap[1, 1].ToArgb());
        }
    }
}