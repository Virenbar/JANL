using System.Collections.Generic;

namespace JANL.Generic
{
    /// <summary>
    /// Очередь фиксированного размера
    /// </summary>
    /// <typeparam name="T">Тип очереди</typeparam>
    public class FixedQueue<T> : Queue<T>
    {
        /// <summary>
        /// Создает новый экземпляр очереди
        /// </summary>
        /// <param name="limit">Размер очереди</param>
        public FixedQueue(int limit) : base(limit) { _limit = limit; }

        /// <summary>
        /// Добавляет элемент в конец очереди
        /// </summary>
        /// <param name="item">Элемент</param>
        public new void Enqueue(T item)
        {
            Truncate();
            base.Enqueue(item);
        }

        private void Truncate()
        {
            while (Count >= Limit) { Dequeue(); }
        }

        #region Properties
        private int _limit;

        /// <summary>
        /// Размер очереди
        /// </summary>
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