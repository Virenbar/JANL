using JANL.Forms;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Environment;

namespace JANL
{
    public static class Msgs
    {
        private static string DefaultHeader => Defaults.Header;

        /// <summary>
        /// Отображает вопрос с Да Нет
        /// </summary>
        /// <param name="Text">Текст вопроса</param>
        public static DialogResult AskYesNo(string Text) => MessageBox.Show(Text, DefaultHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="Text">Текст ошибки</param>
        public static void ShowError(string Text) => ShowMessage(Text, DefaultHeader, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку
        /// </summary>
        /// <param name="Text">Текст ошибки</param>
        /// <param name="Header">Заголовок окна</param>
        public static void ShowError(string Text, string Header) => ShowMessage(Text, Header, MessageBoxIcon.Error);

        /// <summary>
        /// Отображает ошибку, имя метода и стёк вызова
        /// </summary>
        /// <param name="ex">Объект ошибки</param>
        /// <param name="prefix">Префикс сообщения (По умолчанию имя метода)</param>
        public static void ShowError(Exception ex, [CallerMemberName()] string prefix = null)
        {
            MessageBox.Show($"{prefix}: {ex.Message}{NewLine}StackTrace:{NewLine}{ex.StackTrace}", DefaultHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отображает ExceptionBox
        /// </summary>
        /// <param name="ex">Объект ошибки</param>
        public static void ShowException(Exception ex)
        {
            var F = new ExceptionBox(ex);
            F.ShowDialog();
        }

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="Text">Текст сообщения</param>
        public static void ShowInfo(string Text) => ShowMessage(Text, DefaultHeader, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает сообщение
        /// </summary>
        /// <param name="Text">Текст сообщения</param>
        /// <param name="Header">Заголовок окна</param>
        public static void ShowInfo(string Text, string Header) => ShowMessage(Text, Header, MessageBoxIcon.Information);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="Text">Текст предупреждения</param>
        /// <param name="Header">Заголовок окна</param>
        /// <param name="MBI">Icon</param>
        public static void ShowMessage(string Text, string Header, MessageBoxIcon MBI) => MessageBox.Show(Text, Header, MessageBoxButtons.OK, MBI);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="Text">Текст предупреждения</param>
        public static void ShowWarning(string Text) => ShowMessage(Text, DefaultHeader, MessageBoxIcon.Exclamation);

        /// <summary>
        /// Отображает предупреждение
        /// </summary>
        /// <param name="Text">Текст предупреждения</param>
        /// <param name="Header">Заголовок окна</param>
        public static void ShowWarning(string Text, string Header) => ShowMessage(Text, Header, MessageBoxIcon.Exclamation);
    }
}