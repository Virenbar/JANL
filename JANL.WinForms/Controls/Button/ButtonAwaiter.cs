using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Класс ожидания нажатия на кнопку
    /// </summary>
    public struct ButtonAwaiter : INotifyCompletion, IEquatable<ButtonAwaiter>
    {
        private readonly Button _button;
        private Action _continuation;

        /// <summary>
        /// Создаёт класс ожидания нажатия на кнопку
        /// </summary>
        /// <param name="button">Кнопка</param>
        public ButtonAwaiter(Button button)
        {
            _button = button;
            _continuation = null;
        }

        /// <summary>
        /// Завершено ли ожидание
        /// </summary>
        public bool IsCompleted => false;

        /// <summary>
        /// Указывает, равен ли текущий объект другому объекту того же типа
        /// </summary>
        /// <param name="other">Объект, который требуется сравнить с данным объектом</param>
        public bool Equals(ButtonAwaiter other)
        {
            return _button == other._button
                && _continuation == other._continuation;
        }

        /// <summary>
        /// Результат ожидания
        /// </summary>
        public Button GetResult() => _button;

        /// <summary>
        /// Планирует действие продолжения, которое вызывается, когда завершается экземпляр
        /// </summary>
        /// <param name="continuation">Действие, вызываемое по завершении операции</param>
        public void OnCompleted(Action continuation)
        {
            _continuation = continuation;
            _button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _button.Click -= Button_Click;
            _continuation();
        }
    }
}