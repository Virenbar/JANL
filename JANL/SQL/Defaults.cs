namespace JANL.SQL
{
	public static class Defaults
	{
		/// <summary>
		/// Соединение по умолчанию
		/// </summary>
		public static string DefaultConnection { get; set; }

		/// <summary>
		/// Время ожидания выполнения команды (в секундах) по умолчанию.
		/// По умолчанию используется значение 30 секунд.
		/// </summary>
		public static int DefaultTimeout { get; set; } = 30;
	}
}