using System.Collections;
using System.Collections.Generic;

namespace LinkedLists
{
    internal class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;

        public int Count
        {
            get;
            private set;
        }

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            InsertNode(node);

            return node;
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            InsertNode(node);
        }

        private void InsertNode(LinkedListNode<T> newNode)
        {
            LinkedListNode<T> temp = head;

            head = newNode;

            head.Next = temp;

            if (Count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                head = node;
            }
            else
            {
                tail.Next = node;

                node.Previous = tail;
            }

            tail = node;

            Count++;
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public void AddAfter(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            node.Next.Previous = newNode;
            newNode.Next = node.Next;

            node.Next = newNode;
            newNode.Previous = node;

            Count++;
        }

        public void Remove()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //2
        public void RemoveNextFive()
        {
            LinkedListNode<T> current = head;

            for (int i = 1; current != null; i++)
            {
                if (i % 5 == 0)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                }
                current = current.Next;
            }
        }
    }
}
