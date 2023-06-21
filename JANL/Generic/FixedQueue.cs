using System.Collections.Generic;

namespace JANL.Generic
{
    public class FixedQueue<T> : Queue<T>
    {
        private readonly int Limit;

        public FixedQueue(int limit) : base(limit) { Limit = limit; }

        public new void Enqueue(T Item)
        {
            while (Count >= Limit) { Dequeue(); }
            base.Enqueue(Item);
        }
    }
}