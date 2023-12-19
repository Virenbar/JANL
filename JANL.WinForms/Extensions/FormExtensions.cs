using JANL.Forms;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Environment;

namespace JANL.Extensions
{
    public static class FormExtensions
    {
        private static string DefaultHeader => UIDefaults.Header;

        /// <summary>
        /// Отображает вопрос с Да Нет
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст вопроса</param>
        public static DialogResult AskYesNo(this Form form, string text) => MessageBox.Show(form, text, DefaultHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст ошибки</param>
        public static void ShowError(this Form form, string text) => ShowMessage(form, text, DefaultHeader, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст ошибки</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowError(this Form form, string text, string header) => ShowMessage(form, text, header, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку, имя метода и стёк вызова
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="ex">Объект ошибки</param>
        /// <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
        public static void ShowError(this Form form, Exception ex, [CallerMemberName] string prefix = null)
        {
            MessageBox.Show(form, $"{prefix}: {ex.Message}{NewLine}StackTrace:{NewLine}{ex.StackTrace}", DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отображает ExceptionBox
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="ex">Объект ошибки</param>
        public static void ShowException(this Form form, Exception ex)
        {
            var F = new ExceptionBox(ex);
            F.ShowDialog(form);
        }

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст сообщения</param>
        public static void ShowInfo(this Form form, string text) => ShowMessage(form, text, DefaultHeader, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст сообщения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowInfo(this Form form, string text, string header) => ShowMessage(form, text, header, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        /// <param name="icon">Icon</param>
        public static void ShowMessage(this Form form, string text, string header, MessageBoxIcon icon) => MessageBox.Show(form, text, header, MessageBoxButtons.OK, icon);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст предупреждения</param>
        public static void ShowWarning(this Form form, string text) => ShowMessage(form, text, DefaultHeader, MessageBoxIcon.Exclamation);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="form">Родительская форма</param>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowWarning(this Form form, string text, string header) => ShowMessage(form, text, header, MessageBoxIcon.Exclamation);
    }
}