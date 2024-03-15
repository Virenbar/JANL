using JANL.Generic;
using NUnit.Framework;

namespace JANL.Test.Generic
{
    internal class FixedQueueTest
    {
        private const int Limit = 5;
        private FixedQueue<int> Queue;

        [Test]
        public void Dequeue()
        {
            for (int i = 0; i < Limit + 5; i++) { Queue.Enqueue(0); }
            Queue.Dequeue();
            Assert.That(Limit - 1, Is.EqualTo(Queue.Count));
        }

        [Test]
        public void Enqueue()
        {
            for (int i = 0; i < Limit + 5; i++) { Queue.Enqueue(0); }
            Assert.That(Limit, Is.EqualTo(Queue.Count));
        }

        [SetUp]
        public void Setup()
        {
            Queue = new FixedQueue<int>(Limit);
        }
    }
}