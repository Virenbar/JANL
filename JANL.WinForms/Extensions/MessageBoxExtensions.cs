using JANL.Forms;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Environment;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для вызова <see cref="MessageBox"/>
    /// </summary>
    public static class MessageBoxExtensions
    {
        private static string DefaultHeader => UIDefaults.Header;

        /// <summary>
        /// Отображает вопрос с Да Нет
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст вопроса</param>
        public static DialogResult AskYesNo(this Control owner, string text) => MessageBox.Show(owner, text, DefaultHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Отображает вопрос с Да Нет (В основном потоке)
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст вопроса</param>
        [Obsolete("WIP")]
        public static DialogResult InvokeAskYesNo(this Control owner, string text)
        {
            Func<DialogResult> x = () => owner.AskYesNo(text);
            return (DialogResult)owner.Invoke(x);
        }

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст ошибки</param>
        public static void ShowError(this Control owner, string text) => ShowMessage(owner, text, DefaultHeader, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст ошибки</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowError(this Control owner, string text, string header) => ShowMessage(owner, text, header, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку, имя метода и стёк вызова
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="ex">Объект ошибки</param>
        /// <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
        public static void ShowError(this Control owner, Exception ex, [CallerMemberName] string prefix = null)
        {
            MessageBox.Show(owner, $"{prefix}: {ex.Message}{NewLine}StackTrace:{NewLine}{ex.StackTrace}", DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отображает ExceptionBox
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="ex">Объект ошибки</param>
        public static void ShowException(this Control owner, Exception ex)
        {
            var F = new ExceptionBox(ex);
            F.ShowDialog(owner);
        }

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст сообщения</param>
        public static void ShowInfo(this Control owner, string text) => ShowMessage(owner, text, DefaultHeader, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст сообщения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowInfo(this Control owner, string text, string header) => ShowMessage(owner, text, header, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        /// <param name="icon">Icon</param>
        public static void ShowMessage(this Control owner, string text, string header, MessageBoxIcon icon) => MessageBox.Show(owner, text, header, MessageBoxButtons.OK, icon);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст предупреждения</param>
        public static void ShowWarning(this Control owner, string text) => ShowMessage(owner, text, DefaultHeader, MessageBoxIcon.Exclamation);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="owner">Родитель</param>
        /// <param name="text">Текст предупреждения</param>
        /// <param name="header">Заголовок окна</param>
        public static void ShowWarning(this Control owner, string text, string header) => ShowMessage(owner, text, header, MessageBoxIcon.Exclamation);
    }
}