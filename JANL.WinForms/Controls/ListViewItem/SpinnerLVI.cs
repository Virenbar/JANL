using System;
using System.Windows.Forms;
using JANL.Animators;

namespace JANL.Controls
{
    /// <summary>
    /// Представляет спиннер в <see cref="ListView"/>
    /// </summary>
    public class SpinnerLVI : ListViewItem
    {
        private readonly SpinnerAnimator animator;

        /// <summary>
        ///
        /// </summary>
        /// <param name="spinner"></param>
        public SpinnerLVI(Spinner spinner)
        {
            Tag = spinner;
            Text = spinner.GetType().Name;
            SubItems.Add(spinner.Frames[0]);
            animator = new SpinnerAnimator(spinner);
            animator.FrameChanged += Animator_FrameChanged;
        }

        /// <summary>
        /// Спиннер
        /// </summary>
        public new Spinner Tag { get; set; }

        /// <summary>
        /// Запускает анимацию
        /// </summary>
        public void Start() => animator.Start();

        /// <summary>
        /// Останавливает анимацию
        /// </summary>
        public void Stop() => animator.Stop(true);

        private void Animator_FrameChanged(object sender, EventArgs e)
        {
            SubItems[1].Text = animator.Frame;
        }
    }
}