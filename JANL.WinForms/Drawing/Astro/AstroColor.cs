using System.Drawing;

namespace JANL.Drawing
{
    /// <summary>
    /// Status colors palette
    /// </summary>
    /// <remarks>
    /// https://www.astrouxds.com/patterns/status-system/
    /// </remarks>
    public static class AstroColor
    {
        /// <summary>
        /// Получить цвет статуса для тёмной темы
        /// </summary>
        /// <param name="status">Статус</param>
        public static Color GetDark(AstroStatus status)
        {
            switch (status)
            {
                case AstroStatus.Off: return Dark.Off;
                case AstroStatus.Standby: return Dark.Standby;
                case AstroStatus.Normal: return Dark.Normal;
                case AstroStatus.Caution: return Dark.Caution;
                case AstroStatus.Serious: return Dark.Serious;
                case AstroStatus.Critical: return Dark.Critical;
                default: return Dark.Off;
            }
        }

        /// <summary>
        /// Получить цвет статуса для светлой темы
        /// </summary>
        /// <param name="status">Статус</param>
        public static Color GetLight(AstroStatus status)
        {
            switch (status)
            {
                case AstroStatus.Off: return Light.Off;
                case AstroStatus.Standby: return Light.Standby;
                case AstroStatus.Normal: return Light.Normal;
                case AstroStatus.Caution: return Light.Caution;
                case AstroStatus.Serious: return Light.Serious;
                case AstroStatus.Critical: return Light.Critical;
                default: return Light.Off;
            }
        }

        /// <summary>
        /// Получить цвет границы статуса для светлой темы
        /// </summary>
        /// <param name="status">Статус</param>
        public static Color GetLightBorder(AstroStatus status)
        {
            switch (status)
            {
                case AstroStatus.Off: return LightBorder.Off;
                case AstroStatus.Standby: return LightBorder.Standby;
                case AstroStatus.Normal: return LightBorder.Normal;
                case AstroStatus.Caution: return LightBorder.Caution;
                case AstroStatus.Serious: return LightBorder.Serious;
                case AstroStatus.Critical: return LightBorder.Critical;
                default: return LightBorder.Off;
            }
        }

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public static class Dark
        {
            public static Color Critical => Color.FromArgb(255, 56, 56);
            public static Color Serious => Color.FromArgb(255, 179, 2);
            public static Color Caution => Color.FromArgb(252, 232, 58);
            public static Color Normal => Color.FromArgb(86, 240, 0);
            public static Color Standby => Color.FromArgb(45, 204, 255);
            public static Color Off => Color.FromArgb(158, 167, 173);
        }

        public static class Light
        {
            public static Color Critical => Color.FromArgb(255, 42, 4);
            public static Color Serious => Color.FromArgb(255, 175, 61);
            public static Color Caution => Color.FromArgb(250, 216, 0);
            public static Color Normal => Color.FromArgb(0, 226, 0);
            public static Color Standby => Color.FromArgb(45, 204, 255);
            public static Color Off => Color.FromArgb(123, 128, 137);
        }

        public static class LightBorder
        {
            public static Color Critical => Color.FromArgb(102, 17, 2);
            public static Color Serious => Color.FromArgb(102, 70, 24);
            public static Color Caution => Color.FromArgb(100, 86, 0);
            public static Color Normal => Color.FromArgb(0, 90, 0);
            public static Color Standby => Color.FromArgb(40, 87, 102);
            public static Color Off => Color.FromArgb(60, 62, 66);
        }
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    }
}