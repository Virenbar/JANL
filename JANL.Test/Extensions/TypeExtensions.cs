using JANL.Extensions;
using NUnit.Framework;
using System;

namespace JANL.Test.Extensions
{
    internal class TypeExtensionsTest
    {
        [Test]
        public void PickRandom()
        {
            var E = new int[] { 1, 2, 3 };
            var R = E.PickRandom();
            Assert.Contains(R, E);
        }

        [Test]
        public void LastDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.LastDay();
            Assert.AreEqual(new DateTime(1994, 11, 30), L);
        }

        [Test]
        public void FirstDay()
        {
            var D = new DateTime(1994, 11, 21);
            var L = D.FirstDay();
            Assert.AreEqual(new DateTime(1994, 11, 1), L);
        }
    }
}