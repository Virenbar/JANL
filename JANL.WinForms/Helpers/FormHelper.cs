using System.Linq;
using System.Windows.Forms;

namespace JANL.Helpers
{
    public static class FormHelper
    {
        /// <summary>
        /// Проверяет есть ли экземпляр формы типа <typeparamref name="T"/>, с возможность её активации
        /// </summary>
        /// <typeparam name="T">Тип формы</typeparam>
        /// <param name="Activate">Активировать ли форму</param>
        /// <returns></returns>
        public static bool IsOpen<T>(bool Activate) where T : Form
        {
            var Form = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (Activate && Form != null) { Form.Activate(); }
            return Form != null;
        }

        /// <summary>
        /// Пытается активировать экземпляр формы типа <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Тип формы</typeparam>
        /// <returns>Была ли активирована форма</returns>
        public static bool TryActivate<T>() where T : Form
        {
            var Form = Application.OpenForms.OfType<T>().FirstOrDefault();
            Form?.Activate();
            return Form != null;
        }
    }
}