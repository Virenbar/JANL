namespace JANL
{
    public static class Defaults
    {
        /// <summary>
        /// Соединение по умолчанию
        /// </summary>
        public static string Connection { get; set; }

        /// <summary>
        /// Время ожидания выполнения команды (в секундах) по умолчанию.
        /// По умолчанию используется значение 30 секунд.
        /// </summary>
        public static int Timeout { get; set; } = 30;
    }
}