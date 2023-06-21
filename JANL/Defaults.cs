namespace JANL
{
    public static class Defaults
    {
        /// <summary>
        /// Соединение по умолчанию
        /// </summary>
        public static string Connection { get; set; }

        /// <summary>
        /// Формат времени
        /// </summary>
        public static string TimeFormat { get; set; } = "hh:mm:ss";

        /// <summary>
        /// Время ожидания выполнения команды (в секундах) по умолчанию.
        /// По умолчанию используется значение 30 секунд.
        /// </summary>
        public static int Timeout { get; set; } = 30;

        /// <summary>
        /// Формат промежутка времени
        /// </summary>
        public static string TimespanFormat { get; set; } = "d.hh:mm:ss";
    }
}