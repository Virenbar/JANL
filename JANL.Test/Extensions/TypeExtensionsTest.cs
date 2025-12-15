using JANL.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace JANL.Test.Extensions
{
    internal class TypeExtensionsTest
    {
        [Test]
        public void Clamp_1()
        {
            Assert.That(0.Clamp(-10, 10), Is.EqualTo(0));
        }

        [Test]
        public void Clamp_2()
        {
            Assert.That(100.Clamp(-10, 10), Is.EqualTo(10));
        }

        [Test]
        public void Clamp_3()
        {
            Assert.That(-100.Clamp(-10, 10), Is.EqualTo(-10));
        }

        [Test]
        public void FirstMonthDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.FirstDay();
            Assert.That(L, Is.EqualTo(new DateTime(1994, 11, 1)));
        }

        [Test]
        public void FirstYearDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.FirstYearDay();
            Assert.That(L, Is.EqualTo(new DateTime(1994, 1, 1)));
        }

        [Test]
        public void LastMonthDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.LastDay();
            Assert.That(L, Is.EqualTo(new DateTime(1994, 11, 30)));
        }

        [Test]
        public void LastYearDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.LastYearDay();
            Assert.That(L, Is.EqualTo(new DateTime(1994, 12, 31)));
        }

        [Test]
        public void PickRandom_1()
        {
            var E = new[] { 1, 2, 3 };
            var R = E.PickRandom();
            Assert.That(E, Contains.Item(R));
        }

        [Test]
        public void PickRandom_2()
        {
            var E = new List<int> { 1, 2, 3 };
            var R = E.PickRandom(true);
            Assert.That(E, Is.Not.Contains(R));
        }
    }
}