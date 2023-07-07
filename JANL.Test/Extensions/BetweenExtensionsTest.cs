using JANL.Extensions;
using NUnit.Framework;
using System.Numerics;

namespace JANL.Test.Extensions
{
    internal class BetweenExtensionsTest
    {
        [Test]
        public void TestAll()
        {
            // Integer
            Assert.IsTrue(2.IsBetween(1, 3));
            Assert.IsFalse(0.IsBetween(1, 3));
            Assert.IsFalse(4.IsBetween(1, 3));
            Assert.IsTrue(2.IsBetween(3, 1));
            Assert.IsFalse(0.IsBetween(3, 1));
            Assert.IsFalse(4.IsBetween(3, 1));
            // BigInteger
            Assert.IsTrue(new BigInteger(2).IsBetween(1, 3));
            Assert.IsFalse(new BigInteger(0).IsBetween(1, 3));
            Assert.IsFalse(new BigInteger(4).IsBetween(1, 3));
            Assert.IsTrue(new BigInteger(2).IsBetween(3, 1));
            Assert.IsFalse(new BigInteger(0).IsBetween(3, 1));
            Assert.IsFalse(new BigInteger(4).IsBetween(3, 1));
        }

        [Test]
        public void TestGeneric()
        {
            Assert.IsTrue(2.IsBetween<int>(1, 3));
            Assert.IsFalse(0.IsBetween<int>(1, 3));
            Assert.IsFalse(4.IsBetween<int>(1, 3));

            Assert.IsTrue(2.IsBetween<int>(3, 1));
            Assert.IsFalse(0.IsBetween<int>(3, 1));
            Assert.IsFalse(4.IsBetween<int>(3, 1));

            Assert.IsTrue(2.IsBetween<int>(2, 2));
            Assert.IsFalse(0.IsBetween<int>(2, 2));
            Assert.IsFalse(4.IsBetween<int>(2, 2));
        }
    }
}