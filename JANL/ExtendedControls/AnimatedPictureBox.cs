using JANL.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.ExtendedControls
{
    public class AnimatedPictureBox : PictureBox
    {
        private IAnimator _animator;
        private Image _frame;
        private Image _image;

        public AnimatedPictureBox() : base() { }

        public IAnimator Animator
        {
            get => _animator;
            set
            {
                if (_animator == value) { return; }
                if (_animator is IAnimator) { _animator.CurrentImageChanged -= Animator_CurrentImageChanged; }
                _animator = value;
                if (_animator is IAnimator)
                {
                    _animator.CurrentImageChanged += Animator_CurrentImageChanged;
                    if (_animator.SourceImage is null) { _animator.SourceImage = _image; }
                }
            }
        }

        [Bindable(true), Category("Appearance"), Description("Отображаемое изображение")]
        public new Image Image
        {
            get => _image;
            set
            {
                if (_image == value) { return; }
                _image = value;
                base.Image = _image;
                if (Animator != null) { Animator.SourceImage = _image; }
            }
        }

        public void StartAnimation() => Animator?.StartAnimation();

        public void StopAnimation() => Animator?.StopAnimation();

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            SizeMode = (_image.Width > Width || _image.Height > Height) ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            base.OnBackgroundImageChanged(e);
        }

        private void Animator_CurrentImageChanged(object sender, EventArgs e)
        {
            base.Image = _animator.CurrentImage;
            _frame?.Dispose();
            _frame = _animator.CurrentImage;
        }
    }
}