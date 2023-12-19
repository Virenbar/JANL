using JANL.Exceptions;
using JANL.Helpers;
using JANL.Text;
using NUnit.Framework;

namespace JANL.Test.Helpers
{
    internal class StringHelperTest
    {
        private readonly static Noun Day = new Noun("сутки", "суток", "суток", NounKind.Plural);

        [Test]
        public void NumberToText_1()
        {
            var target = "одна тысяча триста тридцать семь";
            var result = StringHelper.NumberToText(1337);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void NumberToText_2()
        {
            var target = "двести две тысячи сто один";
            var result = StringHelper.NumberToText(202101);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void NumberToText_3()
        {
            var target = "двое суток";
            var result = StringHelper.NumberToText(2, Day);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void NumberToText_4()
        {
            void Result() { StringHelper.NumberToText(22, Day); }
            Assert.Throws<SyntacticIncongruityException>(Result);
        }

        [Test]
        public void RubleToText_1()
        {
            var target = "одна тысяча триста тридцать семь рублей 0 копеек";
            var result = StringHelper.RubleToText(1337m);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void RubleToText_2()
        {
            var target = "двести две тысячи сто один рубль 55 копеек";
            var result = StringHelper.RubleToText(202101.55m);
            Assert.AreEqual(target, result);
        }
    }
}