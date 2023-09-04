using System.Collections.Generic;

namespace JANL.Generic
{
    public class FixedQueue<T> : Queue<T>
    {
        public FixedQueue(int limit) : base(limit) { _limit = limit; }

        public new void Enqueue(T Item)
        {
            Truncate();
            base.Enqueue(Item);
        }

        private void Truncate()
        {
            while (Count >= Limit) { Dequeue(); }
        }

        #region Properties
        private int _limit;

        public int Limit
        {
            get => _limit;
            set
            {
                if (value == _limit) { return; }
                _limit = value;
                Truncate();
            }
        }

        #endregion Properties
    }
}