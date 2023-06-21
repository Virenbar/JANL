using System;
using System.Drawing;
using System.Runtime.InteropServices;

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
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool DestroyIcon(IntPtr handle);

        /// <summary>
        /// Создает иконку из изображения
        /// </summary>
        public static Icon ToIcon(Image image)
        {
            if (image is Bitmap B) { return ToIcon(B); }

            using (var bitmap = new Bitmap(image))
            {
                var ptr = bitmap.GetHicon();
                return Icon.FromHandle(bitmap.GetHicon());
            }
        }

        /// <summary>
        /// Создает иконку из изображения
        /// </summary>
        public static Icon ToIcon(Bitmap bitmap) => Icon.FromHandle(bitmap.GetHicon());
    }
}