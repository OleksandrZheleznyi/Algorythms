using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(0);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            list.AddFirst(7);

            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine("Count of list items - {0}", list.Count);

            list.AddAfter(list.Find(5), 10);
            list.AddAfter(list.Find(10), 11);
            list.AddAfter(list.Find(11), 12);

            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine("Count of list items - {0}", list.Count);

            list.RemoveNextFive();

            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine("Count of list items - {0}", list.Count);

            list.AddFirst(8);
            list.AddFirst(8);

            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine("Count of list items - {0}", list.Count);

            list.Remove();

            Console.WriteLine("Count of list items - {0}", list.Count);

            Console.ReadLine();

            //3
            //T(n) = (n + 1)^2 - O(n^2)
            //4
            //20 * n^2 + 10 - O(n^2)
            //500 * n - O(n)
            //but if n < 5 (20 * n^2 + 10) better than (500 * n)
        }
    }
}
