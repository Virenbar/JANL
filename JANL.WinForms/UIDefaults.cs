using JANL.Properties;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace JANL
{
    /// <summary>
    /// Default values for Forms
    /// </summary>
    public static class UIDefaults
    {
        /// <summary>
        /// Цвет текста для UI элементов
        /// </summary>
        public static Color BackColor => Settings.Default.BackColor;

        /// <summary>
        /// Default Culture
        /// </summary>
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

        /// <summary>
        /// Default Language
        /// </summary>
        public static InputLanguage Language => InputLanguage.FromCulture(Culture);

        /// <summary>
        /// Icon Overrides
        /// </summary>
        public static class Icons
        {
            /// <summary>
            /// Cancel button
            /// </summary>
            public static Icon Cancel { get; set; }

            /// <summary>
            /// OK button
            /// </summary>
            public static Icon OK { get; set; }
        }
    }
}