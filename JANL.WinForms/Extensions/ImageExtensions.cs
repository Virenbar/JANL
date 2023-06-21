using JANL.Helpers;
using System.Drawing;

namespace JANL.Extensions
{
    public static class ImageExtensions
    {
        public static void DestroyIcon(this Icon icon) => ImageHelper.DestroyIcon(icon);

        public static Icon ToIcon(this Bitmap bitmap) => ImageHelper.ToIcon(bitmap);

        public static Icon ToIcon(this Image image) => ImageHelper.ToIcon(image);
    }
}