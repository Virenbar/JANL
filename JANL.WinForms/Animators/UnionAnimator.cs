using JANL.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace JANL.Animators
{
    public class UnionAnimator : IAnimator
    {
        public List<IAnimator> Items { get; set; }
        public Image CurrentImage => throw new NotImplementedException();

        public int Duration
        {
            get => Items.FirstOrDefault().Duration;
            set { foreach (var item in Items) { item.Duration = value; } }
        }

        public int Framerate
        {
            get => Items.FirstOrDefault().Framerate;
            set { foreach (var item in Items) { item.Framerate = value; } }
        }

        public int Height => Items.Max(I => I.Height);

        public bool IsAnimated => Items.Any(I => I.IsAnimated);

        public Image SourceImage
        {
            get => Items.FirstOrDefault().SourceImage;
            set { foreach (var item in Items) { item.SourceImage = value; } }
        }

        public int Width => Items.Max(I => I.Width);

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

        public event EventHandler CurrentImageChanged;
    }
}