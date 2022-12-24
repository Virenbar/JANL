using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace JANL.Animators
{
    public class UnionAnimator : Collection<IAnimator>, IAnimator
    {
        public UnionAnimator() : base() { }

        public UnionAnimator(IList<IAnimator> list) : base(list) { }

        public void ResetAnimation()
        {
            foreach (var item in Items) { item.ResetAnimation(); }
        }

        public void StartAnimation()
        {
            foreach (var item in Items) { item.StartAnimation(); }
        }

        public void StopAnimation()
        {
            foreach (var item in Items) { item.StopAnimation(); }
        }

        protected override void ClearItems()
        {
            foreach (var item in this)
            {
                item.CurrentImageChanged -= OnCurrentImageChanged;
            }
            base.ClearItems();
        }

        protected override void InsertItem(int index, IAnimator item)
        {
            base.InsertItem(index, item);
            this[index].CurrentImageChanged += OnCurrentImageChanged;
        }

        protected override void RemoveItem(int index)
        {
            this[index].CurrentImageChanged -= OnCurrentImageChanged;
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, IAnimator item)
        {
            this[index].CurrentImageChanged -= OnCurrentImageChanged;
            base.SetItem(index, item);
            this[index].CurrentImageChanged += OnCurrentImageChanged;
        }

        #region Properties
        public Image CurrentImage => throw new NotImplementedException();

        public int Duration
        {
            get => Items.FirstOrDefault().Duration;
            set
            {
                foreach (var item in Items) { item.Duration = value; }
            }
        }

        public int Framerate
        {
            get => Items.FirstOrDefault().Framerate;
            set
            {
                foreach (var item in Items) { item.Framerate = value; }
            }
        }

        public int Height => Items.Max(I => I.Height);

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

        protected void OnCurrentImageChanged(object sender, EventArgs e)
        {
            CurrentImageChanged?.Invoke(sender, e);
        }

        public event EventHandler CurrentImageChanged;

        #endregion Events
    }
}