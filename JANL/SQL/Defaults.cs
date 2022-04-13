namespace JANL.SQL
{
    public static class Defaults
    {
        /// <summary>
        /// Соединение по умолчанию
        /// </summary>
        public static string DefaultConnection
        {
            get => JANL.Defaults.Connection;
            set => JANL.Defaults.Connection = value;
        }

        /// <summary>
        /// Время ожидания выполнения команды (в секундах) по умолчанию.
        /// По умолчанию используется значение 30 секунд.
        /// </summary>
        public static int DefaultTimeout
        {
            get => JANL.Defaults.Timeout;
            set => JANL.Defaults.Timeout = value;
        }
    }
}