using System.Drawing;

namespace JANL.Colors
{
    /// <summary>
    /// Status colors palette
    /// </summary>
    /// <remarks>
    /// https://www.astrouxds.com/patterns/status-system/
    /// </remarks>
    public struct Status
    {
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public static Color Critical => Color.FromArgb(255, 56, 56);
        public static Color Serious => Color.FromArgb(255, 179, 2);
        public static Color Caution => Color.FromArgb(252, 232, 58);
        public static Color Normal => Color.FromArgb(86, 240, 0);
        public static Color Standby => Color.FromArgb(45, 204, 255);
        public static Color Off => Color.FromArgb(158, 167, 173);
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    }
}