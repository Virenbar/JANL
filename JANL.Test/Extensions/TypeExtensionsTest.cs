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
            Assert.AreEqual(0, 0.Clamp(-10, 10));
        }

        [Test]
        public void Clamp_2()
        {
            Assert.AreEqual(10, 100.Clamp(-10, 10));
        }

        [Test]
        public void Clamp_3()
        {
            Assert.AreEqual(-10, -100.Clamp(-10, 10));
        }

        [Test]
        public void FirstDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.FirstDay();
            Assert.AreEqual(new DateTime(1994, 11, 1), L);
        }

        [Test]
        public void LastDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.LastDay();
            Assert.AreEqual(new DateTime(1994, 11, 30), L);
        }

        [Test]
        public void PickRandom_1()
        {
            var E = new[] { 1, 2, 3 };
            var R = E.PickRandom();
            Assert.Contains(R, E);
        }

        [Test]
        public void PickRandom_2()
        {
            var E = new List<int> { 1, 2, 3 };
            var R = E.PickRandom(true);
            Assert.False(E.Contains(R));
        }
    }
}