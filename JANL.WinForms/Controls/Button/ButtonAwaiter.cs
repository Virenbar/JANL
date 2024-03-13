using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace JANL.Controls
{
    public struct ButtonAwaiter : INotifyCompletion
    {
        private readonly Button _button;
        private Action _continuation;

        public ButtonAwaiter(Button button)
        {
            _button = button;
            _continuation = null;
        }

        public bool IsCompleted => false;

        public Button GetResult() => _button;

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