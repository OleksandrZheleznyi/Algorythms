using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.Add(4);
            binaryTree.Add(2);
            binaryTree.Add(1);
            binaryTree.Add(3);
            binaryTree.Add(5);
            binaryTree.Add(7);
            binaryTree.Add(6);
            binaryTree.Add(8);

            Console.WriteLine("PreOrder");
            binaryTree.ShowPreOrder(binaryTree.Head);//4, 2, 1, 3, 5, 7, 6, 8
            Console.WriteLine();

            Console.WriteLine("PostOrder");
            binaryTree.ShowPostOrder(binaryTree.Head);//1, 3, 2, 6, 8, 7, 5, 4- ?
            Console.WriteLine();

            Console.WriteLine("InOrder");
            binaryTree.ShowInOrder(binaryTree.Head);//1, 2, 3, 4, 5, 6, 7, 8
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
