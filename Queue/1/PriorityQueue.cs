using System;
using System.Collections.Generic;

namespace Queue
{
    internal class PriorityQueue<TKey, TValue> where TKey : struct 
    {
        private LinkedList<KeyValuePair<TKey, TValue>> _items;
  
        public int Count
        {
            get { return _items.Count; }
        }

        public PriorityQueue()
        {
            _items = new LinkedList<KeyValuePair<TKey, TValue>>();
        }

        public void Insert(TKey key, TValue value)
        {
            _items.AddLast(new KeyValuePair<TKey, TValue>(key, value));
        }

        public KeyValuePair<TKey, TValue> ExtractMaximum()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }

            return FindMaxKey();
        }

        private KeyValuePair<TKey, TValue> FindMaxKey()
        {
            var maxKey = _items.First.Value.Key;
            var maxValue = _items.First.Value.Value;

            var index = _items.First.Next;

            while (index != null)
            {
                if (Convert.ToInt32(maxKey) < Convert.ToInt32(index.Value.Key))
                {
                    maxKey = index.Value.Key;
                    maxValue = index.Value.Value;
                }

                index = index.Next;
            }

            return new KeyValuePair<TKey, TValue>(maxKey, maxValue);
        }

        public void DequeueMax()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }

            _items.Remove(FindMaxKey());
        }

        public void Show()
        {
            var index = _items.First;

            while (index != null)
            {
                Console.WriteLine("{0} - {1}", index.Value.Key, index.Value.Value);
                index = index.Next;
            }
        }
    }
}
