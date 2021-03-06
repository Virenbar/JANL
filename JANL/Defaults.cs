using JANL.Properties;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace JANL
{
    public static class Defaults
    {
        /// <summary>
        /// Цвет текста для UI элементов
        /// </summary>
        public static Color BackColor => Settings.Default.BackColor;

        /// <summary>
        /// Соединение по умолчанию
        /// </summary>
        public static string Connection { get; set; }

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

        /// <summary>
        /// Время ожидания выполнения команды (в секундах) по умолчанию.
        /// По умолчанию используется значение 30 секунд.
        /// </summary>
        public static int Timeout { get; set; } = 30;

        public static class Icons

        {
            public static Icon Cancel { get; set; }
            public static Icon OK { get; set; }
        }
    }
}