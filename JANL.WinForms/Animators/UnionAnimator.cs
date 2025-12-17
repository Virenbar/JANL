using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace JANL.Animators
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    public class UnionAnimator : ObservableObject, IAnimator

    {
        public UnionAnimator()
        {
            Items = new AnimatorCollection();
        }

        public UnionAnimator(IList<IAnimator> list)
        {
            Items = new AnimatorCollection(list);
        }

        public IAnimator this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }

        public void Add(IAnimator item) => Items.Add(item);

        public void Clear() => Items.Clear();

        public void Remove(IAnimator item) => Items.Remove(item);

        public void ResetAnimation() => Items.ResetAnimation();

        public void StartAnimation() => Items.StartAnimation();

        public void StopAnimation() => Items.StopAnimation();

        #region Properties
        public Image CurrentImage => throw new NotImplementedException();

        public int Duration
        {
            get => Items.Duration;
            set
            {
                Items.Duration = value;
                NotifyPropertyChanged();
            }
        }

        public bool Enabled => Items.Enabled;

        public int Framerate
        {
            get => Items.Framerate;
            set
            {
                Items.Framerate = value;
                NotifyPropertyChanged();
            }
        }

        public int Height => Items.Height;

        [Obsolete("Use Enable")]
        public bool IsAnimated => Items.Enabled;

        public AnimatorCollection Items { get; }

        public Image SourceImage
        {
            get => Items.SourceImage;
            set => Items.SourceImage = value;
        }

        public int Width => Items.Width;

        #endregion Properties

        #region Events

        protected void OnCurrentImageChanged() => CurrentImageChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Никогда не вызывается
        /// </summary>
        public event EventHandler CurrentImageChanged;

        #endregion Events
    }
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
}