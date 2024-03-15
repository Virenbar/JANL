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
            Assert.That(2.IsBetween(1, 3), Is.True);
            Assert.That(2.IsBetween(1, 3), Is.True);
            Assert.That(0.IsBetween(1, 3), Is.False);
            Assert.That(4.IsBetween(1, 3), Is.False);
            Assert.That(2.IsBetween(3, 1), Is.True);
            Assert.That(0.IsBetween(3, 1), Is.False);
            Assert.That(4.IsBetween(3, 1), Is.False);
            // BigInteger
            Assert.That(new BigInteger(2).IsBetween(1, 3), Is.True);
            Assert.That(new BigInteger(0).IsBetween(1, 3), Is.False);
            Assert.That(new BigInteger(4).IsBetween(1, 3), Is.False);
            Assert.That(new BigInteger(2).IsBetween(3, 1), Is.True);
            Assert.That(new BigInteger(0).IsBetween(3, 1), Is.False);
            Assert.That(new BigInteger(4).IsBetween(3, 1), Is.False);
        }

        [Test]
        public void TestGeneric()
        {
            Assert.That(2.IsBetween<int>(1, 3), Is.True);
            Assert.That(0.IsBetween<int>(1, 3), Is.False);
            Assert.That(4.IsBetween<int>(1, 3), Is.False);

            Assert.That(2.IsBetween<int>(3, 1), Is.True);
            Assert.That(0.IsBetween<int>(3, 1), Is.False);
            Assert.That(4.IsBetween<int>(3, 1), Is.False);

            Assert.That(2.IsBetween<int>(2, 2), Is.True);
            Assert.That(0.IsBetween<int>(2, 2), Is.False);
            Assert.That(4.IsBetween<int>(2, 2), Is.False);
        }
    }
}