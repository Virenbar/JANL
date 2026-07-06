using System;
using System.Drawing;
using JANL.Drawing;

namespace JANL.Colors
{
    /// <summary>
    /// Status colors palette
    /// </summary>
    /// <remarks>
    /// https://www.astrouxds.com/patterns/status-system/
    /// </remarks>
    [Obsolete(@"Use JANL.Drawing.AstroColor")]
    public struct Status
    {
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public static Color Critical => AstroColor.Dark.Critical;
        public static Color Serious => AstroColor.Dark.Serious;
        public static Color Caution => AstroColor.Dark.Caution;
        public static Color Normal => AstroColor.Dark.Normal;
        public static Color Standby => AstroColor.Dark.Standby;
        public static Color Off => AstroColor.Dark.Off;
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    }
}