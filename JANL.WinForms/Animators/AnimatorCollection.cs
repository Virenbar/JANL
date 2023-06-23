using JANL.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace JANL.Animators
{
    public class AnimatorCollection : Collection<IAnimator>
    {
        public AnimatorCollection() : base() { }

        public AnimatorCollection(IList<IAnimator> list) : base(list) { }

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

        #region Properties

        public int Duration
        {
            get => Items.FirstOrDefault().Duration;
            set
            {
                foreach (var item in Items) { item.Duration = value; }
            }
        }

        public bool Enabled => Items.Any(I => I.Enabled);

        public int Framerate
        {
            get => Items.FirstOrDefault().Framerate;
            set
            {
                foreach (var item in Items) { item.Framerate = value; }
            }
        }

        public int Height => Items.Max(I => I.Height);

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
    }
}