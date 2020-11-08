using System;
namespace BSTProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree Problem!");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            Console.WriteLine("Binary Search Tree: ");
            binarySearchTree.Display();
        }
    }
}
