using JANL.Properties;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace JANL
{
    public static class UIDefaults
    {
        /// <summary>
        /// Цвет текста для UI элементов
        /// </summary>
        public static Color BackColor => Settings.Default.BackColor;

        public static CultureInfo Culture { get; set; } = new CultureInfo("ru-RU");

        /// <summary>
        /// Шрифт для UI элементов
        /// </summary>
        public static Font Font => Settings.Default.Font;

        /// <summary>
        /// Цвет заднего фона для UI элементов
        /// </summary>
        public static Color ForeColor => Settings.Default.ForeColor;

        /// <summary>
        /// Заголовок окон
        /// </summary>
        public static string Header { get; set; } = Application.ProductName;

        public static InputLanguage Language => InputLanguage.FromCulture(Culture);
        public static class Icons
        {
            public static Icon Cancel { get; set; }
            public static Icon OK { get; set; }
        }
    }
}