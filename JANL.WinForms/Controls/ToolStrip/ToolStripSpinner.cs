using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using JANL.Animators;
using JANL.Designers;

namespace JANL.Controls
{
    /// <summary>
    /// Элемент отображения спиннера на <see cref="StatusStrip"/>
    /// </summary>
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripSpinner : ToolStripLabel
    {

        private readonly SpinnerAnimator animator;

        /// <summary>
        /// Создает элемент отображения спиннера
        /// </summary>
        public ToolStripSpinner()
        {
            Text = "-";

            animator = new SpinnerAnimator();
            animator.FrameChanged += Animator_FrameChanged;

            Spinner = Spinner.Predefined.Default;
        }

        /// <summary>
        /// Запускает анимацию спиннера
        /// </summary>
        public void Start() => animator.Start();

        /// <summary>
        /// Останавливает анимацию спиннера
        /// </summary>
        public void Stop()
        {
            animator.Stop(true);
            base.Text = Text;
        }

        private void Animator_FrameChanged(object sender, EventArgs e)
        {
            base.Text = animator.Frame;
        }

        #region Properties

        /// <summary>
        /// Спиннер
        /// </summary>
        //  [Browsable(false)]
        //  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Editor(typeof(SpinnerEditor), typeof(System.Drawing.Design.UITypeEditor)), DefaultValue(typeof(DefaultSpinner), "")]
        public Spinner Spinner
        {
            get => animator.Spinner;
            set
            {
                if (animator.Spinner == value) { return; }
                animator.Spinner = value;

            }
        }

        /// <summary>
        /// Текст
        /// </summary>
        [DefaultValue("-")]
        protected new string Text { get; set; }

        #endregion Properties
    }
}