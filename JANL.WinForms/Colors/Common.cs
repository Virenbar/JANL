using System.Drawing;

namespace JANL.Colors
{
    /// <summary>
    /// Часто используемые цвета
    /// </summary>
    public struct Common
    {
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public static Color White => Color.White;
        public static Color Red => Color.MistyRose;
        public static Color Yellow => Color.LightYellow;
        public static Color Green => Color.LightGreen;
        public static Color Bad => Color.MistyRose;
        public static Color Unknown => Color.LightYellow;
        public static Color Good => Color.LightGreen;
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    }
}