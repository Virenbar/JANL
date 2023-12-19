using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Кнопка с возможность отмены задачи.
    /// При повторном нажатии происходит отмена.
    /// При завершении или отмене необходимо вызвать <see cref="CancelableButton.ResetButton()"/>
    /// </summary>
    public class CancelableButton : Button
    {
        private CancellationTokenSource CTS;
        private Image DefaultImage;
        private string DefaultText;

        public CancelableButton()
        {
            TextCancel = "Отменить";
            TextCanceled = "Отмена";
        }

        #region Properties

        #region Designer

        [Browsable(true)]
        [Category("Appearance")]
        public Image ImageCancel { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        public Image ImageCanceled { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("Отменить")]
        public string TextCancel { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("Отмена")]
        public string TextCanceled { get; set; }

        #endregion Designer

        [Browsable(false)]
        public bool IsCanceled { get; private set; }

        [Browsable(false)]
        public bool IsPressed { get; private set; }

        #endregion Properties

        /// <summary>
        /// Сброс состояния кнопки
        /// </summary>
        public void ResetButton()
        {
            if (!IsPressed) { return; }
            SetDefault();
        }

        protected override void OnClick(EventArgs e)
        {
            if (!IsPressed)
            {
                SetPressed();
                OnRun(new RunEventArgs { CTS = CTS });
            }
            else if (!IsCanceled)
            {
                SetCanceled();
                OnCancel(EventArgs.Empty);
            }
            base.OnClick(e);
        }

        private void SetCanceled()
        {
            IsCanceled = true;
            Text = TextCanceled;
            Image = ImageCanceled;
            Enabled = false;
            CTS.Cancel();
        }

        private void SetDefault()
        {
            IsPressed = false;
            IsCanceled = false;
            Text = DefaultText;
            Image = DefaultImage;
            Enabled = true;
            CTS = null;
        }

        private void SetPressed()
        {
            IsPressed = true;
            DefaultText = Text;
            DefaultImage = Image;
            Text = TextCancel;
            Image = ImageCancel;
            CTS = new CancellationTokenSource();
        }

        #region Events

        /// <summary>
        /// Вызывает событие <see cref="Cancel"/>
        /// </summary>
        protected void OnCancel(EventArgs e) => Cancel?.Invoke(this, e);

        /// <summary>
        /// Вызывает событие <see cref="Run"/>
        /// </summary>
        protected void OnRun(RunEventArgs e) => Run?.Invoke(this, e);

        /// <summary>
        ///
        /// </summary>
        public class RunEventArgs : EventArgs
        {
            /// <summary>
            /// Токен отмены, получает сигнал отмены при отмене пользователем.
            /// </summary>
            public CancellationTokenSource CTS { get; set; }
        }

        /// <summary>
        /// Происходит при отмене пользователем
        /// </summary>
        [Browsable(true), Category("Action")]
        public event EventHandler Cancel;

        /// <summary>
        /// Происходит при запуске пользователем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Объект класса <see cref="RunEventArgs"/>, содержащий данные события.</param>
        [Browsable(true), Category("Action")]
        public event EventHandler<RunEventArgs> Run;

        #endregion Events

        protected override void Dispose(bool disposing)
        {
            CTS?.Dispose();
            base.Dispose(disposing);
        }
    }
}