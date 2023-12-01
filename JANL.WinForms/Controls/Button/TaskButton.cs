using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.Controls
{
    [DefaultEvent(nameof(Click))]
    public class TaskButton : Button
    {
        private CancellationTokenSource CTS;

        public TaskButton()
        {
            TextCancel = "Cancel";
        }

        protected override void OnClick(EventArgs e)
        {
            if (CTS is null)
            {
                base.Text = TextCancel;
                base.Image = ImageCancel;

                var Arguments = new ClickEventArgs();
                CTS = Arguments.CTS;
                OnClick(Arguments);
                _ = TryRunTask(Arguments.Task);
            }
            else
            {
                Enabled = false;
                CTS.Cancel();
                OnCancel(EventArgs.Empty);
            }
        }

        private async Task TryRunTask(Task task)
        {
            try
            {
                if (task is null) { return; }
                await task;
            }
            catch (TaskCanceledException) { /* NOOP */ }
            finally
            {
                CTS?.Dispose();
                CTS = null;

                base.Text = Text;
                base.Image = Image;
                Enabled = true;
            }
        }

        #region Properties

        #region Designer

        private Image _image;
        private string _text;

        [Browsable(true), Category("Appearance")]
        public new Image Image
        {
            get => _image;
            set
            {
                _image = value;
                if (base.Image is null) { base.Image = value; }
                if (ImageCancel is null) { ImageCancel = value; }
            }
        }

        [Browsable(true), Category("Appearance")]
        public Image ImageCancel { get; set; }

        [Browsable(true), Category("Appearance"), DefaultValue("")]
        public new string Text
        {
            get => _text;
            set
            {
                _text = value;
                base.Text = value;
                if (string.IsNullOrEmpty(TextCancel)) { TextCancel = value; }
            }
        }

        [Browsable(true), Category("Appearance"), DefaultValue("Cancel")]
        public string TextCancel { get; set; }

        #endregion Designer

        #endregion Properties

        #region Events

        /// <summary>
        /// Вызывает событие <see cref="Cancel"/>
        /// </summary>
        protected void OnCancel(EventArgs e) => Cancel?.Invoke(this, e);

        /// <summary>
        /// Вызывает событие <see cref="Click"/>
        /// </summary>
        /// <param name="e"></param>
        protected void OnClick(ClickEventArgs e) => Click?.Invoke(this, e);

        public class ClickEventArgs : EventArgs
        {
            /// <summary>
            /// Токен отмены, получает сигнал отмены при отмене пользователем.
            /// </summary>
            public CancellationTokenSource CTS { get; } = new CancellationTokenSource();

            /// <summary>
            /// Task
            /// </summary>
            public Task Task { get; set; }
        }

        /// <summary>
        /// Происходит при отмене пользователем
        /// </summary>
        [Browsable(true), Category("TaskButton")]
        public event EventHandler Cancel;

        /// <summary>
        /// Происходит при нажатии кнопки
        /// </summary>
        [Browsable(true), Category("TaskButton")]
        public new event EventHandler<ClickEventArgs> Click;

        #endregion Events

        #region Disposing

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            CTS?.Dispose();
        }

        #endregion Disposing
    }
}