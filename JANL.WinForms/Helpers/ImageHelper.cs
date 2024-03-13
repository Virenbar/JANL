using System;
using System.Drawing;

namespace JANL.Helpers
{
    public static class ImageHelper
    {
        /// <summary>
        /// Уничтожить иконку
        /// </summary>
        public static void DestroyIcon(Icon icon)
        {
            icon.Dispose();
            DestroyIcon(icon.Handle);
        }

        /// <summary>
        /// Уничтожить иконку
        /// </summary>
        public static bool DestroyIcon(IntPtr handle) => NativeMethods.DestroyIcon(handle);

        /// <summary>
        /// Создает иконку из изображения
        /// </summary>
        public static Icon ToIcon(Image image)
        {
            if (image is Bitmap B) { return ToIcon(B); }

            using (var bitmap = new Bitmap(image))
            {
                return Icon.FromHandle(bitmap.GetHicon());
            }
        }

        /// <summary>
        /// Создает иконку из изображения
        /// </summary>
        public static Icon ToIcon(Bitmap bitmap) => Icon.FromHandle(bitmap.GetHicon());
    }
}