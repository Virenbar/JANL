using JANL.Helpers;
using NUnit.Framework;
using System.Drawing;

namespace JANL.Test.Helpers
{
    internal class ColorHelperTest
    {
        [Test]
        public void ColorToHEX_1()
        {
            var target = "#FFFFFF";
            var color = Color.White;
            var result = ColorHelper.ColorToHEX(color);
            Assert.That(result, Is.EqualTo(target));
        }

        [Test]
        public void ColorToHEX_2()
        {
            var target = "#007000";
            var color = Color.FromArgb(0, 112, 0);
            var result = ColorHelper.ColorToHEX(color);
            Assert.That(result, Is.EqualTo(target));
        }

        [Test]
        public void HSLToColor_1()
        {
            var target = "#FFFFFF";
            var color = ColorHelper.HSLToColor(0, 0, 1);
            var result = ColorHelper.ColorToHEX(color);
            Assert.That(result, Is.EqualTo(target));
        }

        [Test]
        public void HSLToColor_2()
        {
            var target = "#007000";
            var color = ColorHelper.HSLToColor(120, 1, 0.22);
            var result = ColorHelper.ColorToHEX(color);
            Assert.That(result, Is.EqualTo(target));
        }
    }
}