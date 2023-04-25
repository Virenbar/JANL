using JANL.Forms;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Environment;

namespace JANL
{
    /// <summary>
    /// Message box wrapper
    /// </summary>
    public static class Msgs
    {
        private static string DefaultHeader => UIDefaults.Header;

        /// <summary>
        /// Отображает вопрос с Да Нет
        /// </summary>
        /// <param name="text">Текст вопроса</param>
        public static DialogResult AskYesNo(string text) => MessageBox.Show(text, DefaultHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="text">Текст ошибки</param>
        public static void ShowError(string text) => ShowMessage(text, DefaultHeader, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="text">Текст ошибки</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowError(string text, string header) => ShowMessage(text, header, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку, имя метода и стёк вызова
        /// </summary>
        /// <param name="exception">Объект ошибки</param>
        /// <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
        public static void ShowError(Exception exception, [CallerMemberName] string prefix = null)
        {
            MessageBox.Show($"{prefix}: {exception.Message}{NewLine}StackTrace:{NewLine}{exception.StackTrace}", DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отображает ExceptionBox
        /// </summary>
        /// <param name="exception">Объект ошибки</param>
        public static void ShowException(Exception exception)
        {
            var F = new ExceptionBox(exception);
            F.ShowDialog();
        }

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        public static void ShowInfo(string text) => ShowMessage(text, DefaultHeader, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowInfo(string text, string header) => ShowMessage(text, header, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        /// <param name="icon">Icon</param>
        public static void ShowMessage(string text, string header, MessageBoxIcon icon) => MessageBox.Show(text, header, MessageBoxButtons.OK, icon);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="text">Текст предупреждения</param>
        public static void ShowWarning(string text) => ShowMessage(text, DefaultHeader, MessageBoxIcon.Exclamation);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowWarning(string text, string header) => ShowMessage(text, header, MessageBoxIcon.Exclamation);
    }
}