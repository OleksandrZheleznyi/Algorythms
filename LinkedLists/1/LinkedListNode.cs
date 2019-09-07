namespace LinkedLists
{
    internal class LinkedListNode<T>
    {
        public LinkedListNode(T item)
        {
            Value = item;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next
        {
            get;
            internal set;
        }

        public LinkedListNode<T> Previous
        {
            get;
            internal set;
        }
    }
}
