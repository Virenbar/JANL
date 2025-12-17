using JANL.Helpers;
using System.Drawing;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="Image"/>
    /// </summary>
    public static class ImageExtensions
    {
        /// <summary>
        /// Уничтожить иконку (Только для иконок из <see cref="ToIcon(Image)"/>)
        /// </summary>
        public static void DestroyIcon(this Icon icon) => ImageHelper.DestroyIcon(icon);

        /// <summary>
        /// Создать иконку из изображения
        /// </summary>
        public static Icon ToIcon(this Bitmap bitmap) => ImageHelper.ToIcon(bitmap);

        /// <summary>
        /// Создать иконку из изображения
        /// </summary>
        public static Icon ToIcon(this Image image) => ImageHelper.ToIcon(image);
    }
}