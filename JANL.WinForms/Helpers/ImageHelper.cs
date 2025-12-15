using System;
using System.Drawing;

namespace JANL.Helpers
{
    public static class ImageHelper
    {
        /// <summary>
        /// Уничтожить иконку (Только для иконок из <see cref="ToIcon"/>)
        /// </summary>
        public static void DestroyIcon(Icon icon)
        {
            DestroyIcon(icon.Handle);
            icon.Dispose();
        }

        /// <summary>
        /// Уничтожить иконку (Только для иконок из <see cref="ToIcon"/>)
        /// </summary>
        public static bool DestroyIcon(IntPtr handle) => NativeMethods.DestroyIcon(handle);

        /// <summary>
        /// Создать иконку из изображения
        /// </summary>
        public static Icon ToIcon(Image image)
        {
            if (image is Bitmap B) { return ToIcon(B); }

            using (var bitmap = new Bitmap(image))
            {
                return ToIcon(bitmap);
            }
        }

        /// <summary>
        /// Создать иконку из изображения
        /// </summary>
        public static Icon ToIcon(Bitmap bitmap) => Icon.FromHandle(bitmap.GetHicon());
    }
}