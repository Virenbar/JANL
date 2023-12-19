using JANL.Helpers;
using NUnit.Framework;
using System.Collections.Generic;

namespace JANL.Test.Helpers
{
    internal class ExcelHelperTest
    {
        [Test]
        public void LetterRange_1()
        {
            var target = new List<string>(new[] { "A", "B", "C", "D" });
            var result = ExcelMiniHelper.LetterRange("A", "D");
            Assert.AreEqual(target, result);
        }

        [Test]
        public void ToLetter_1()
        {
            var target = "A";
            var result = ExcelMiniHelper.ToLetter(1);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void ToLetter_2()
        {
            var target = "AA";
            var result = ExcelMiniHelper.ToLetter(27);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void ToLetter_3()
        {
            var target = "A1";
            var result = ExcelMiniHelper.ToLetter(1, 1);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void ToNumber_1()
        {
            var target = 1;
            var result = ExcelMiniHelper.ToNumber("A");
            Assert.AreEqual(target, result);
        }

        [Test]
        public void ToNumber_2()
        {
            var target = 27;
            var result = ExcelMiniHelper.ToNumber("AA");
            Assert.AreEqual(target, result);
        }
    }
}