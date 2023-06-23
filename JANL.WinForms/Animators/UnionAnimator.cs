using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace JANL.Animators
{
    public sealed class UnionAnimator : ObservableObject, IAnimator
    {
        private readonly AnimatorCollection Items;

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
            get => Items.FirstOrDefault().Duration;
            set
            {
                foreach (var item in Items) { item.Duration = value; }
                NotifyPropertyChanged();
            }
        }

        public bool Enabled => Items.Any(I => I.Enabled);

        public int Framerate
        {
            get => Items.FirstOrDefault().Framerate;
            set
            {
                foreach (var item in Items) { item.Framerate = value; }
                NotifyPropertyChanged();
            }
        }

        public int Height => Items.Max(I => I.Height);

        [Obsolete("Use Enable")]
        public bool IsAnimated => Items.Any(I => I.IsAnimated);

        public Image SourceImage
        {
            get => Items.FirstOrDefault().SourceImage;
            set
            {
                foreach (var item in Items) { item.SourceImage = value; }
            }
        }

        public int Width => Items.Max(I => I.Width);

        #endregion Properties

        #region Events

        /// <summary>
        /// Никогда не вызывается
        /// </summary>
        [Obsolete("Никогда не вызывается")]
        public event EventHandler CurrentImageChanged;

        #endregion Events
    }
}