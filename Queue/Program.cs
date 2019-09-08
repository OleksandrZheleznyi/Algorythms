using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> instance1 = new Queue<int>();
            PriorityQueue<int, string> priorityQueue = new PriorityQueue<int, string>();
            //insert(ключ, значение) — добавляет пару(ключ, значение) в хранилище;
            //extract_maximum() — возвращает пару(ключ, значение)
            //с максимальным значением ключа, удаляя её из хранилища.
            priorityQueue.Insert(1, "first");
            priorityQueue.Insert(5, "fifth");
            priorityQueue.Insert(3, "third");
            priorityQueue.Insert(2, "second");
            priorityQueue.Insert(4, "fourth");
            priorityQueue.Insert(1, "first");

            priorityQueue.Show();

            Console.WriteLine(priorityQueue.Count);

            Console.WriteLine(priorityQueue.ExtractMaximum());

            priorityQueue.DequeueMax();

            priorityQueue.Show();

            Console.WriteLine(priorityQueue.Count);

            Console.WriteLine(priorityQueue.ExtractMaximum());

            priorityQueue.DequeueMax();

            priorityQueue.Show();

            Console.WriteLine(priorityQueue.Count);

            Console.ReadLine();
        }
    }
}
