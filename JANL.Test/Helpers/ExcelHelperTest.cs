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
            var Target = new List<string>(new[] { "A", "B", "C", "D" });
            var Result = ExcelMiniHelper.LetterRange("A", "D");
            Assert.AreEqual(Target, Result);
        }

        [Test]
        public void ToLetter_1()
        {
            var Target = "A";
            var Result = ExcelMiniHelper.ToLetter(1);
            Assert.AreEqual(Target, Result);
        }

        [Test]
        public void ToLetter_2()
        {
            var Target = "AA";
            var Result = ExcelMiniHelper.ToLetter(27);
            Assert.AreEqual(Target, Result);
        }

        [Test]
        public void ToLetter_3()
        {
            var Target = "A1";
            var Result = ExcelMiniHelper.ToLetter(1, 1);
            Assert.AreEqual(Target, Result);
        }

        [Test]
        public void ToNumber_1()
        {
            var Target = 1;
            var Result = ExcelMiniHelper.ToNumber("A");
            Assert.AreEqual(Target, Result);
        }

        [Test]
        public void ToNumber_2()
        {
            var Target = 27;
            var Result = ExcelMiniHelper.ToNumber("AA");
            Assert.AreEqual(Target, Result);
        }
    }
}