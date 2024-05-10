using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the collections
        List<int> list = new List<int> { 1, 10, -30, 10, -5 };
        Stack<int> stack = new Stack<int>(new[] { 1, 10, -30, 10, -5 });
        Queue<int> queue = new Queue<int>(new[] { 1, 10, -30, 10, -5 });
        HashSet<int> hashSet = new HashSet<int> { 1, 10, -30, 10, -5 };

        // Print each collection using a separate foreach loop
        PrintList(list);
        PrintStack(stack);
        PrintQueue(queue);
        PrintHashSet(hashSet);
    }

    static void PrintList(List<int> list)
    {
        Console.Write("List: ");
        foreach (int i in list)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }

    static void PrintStack(Stack<int> stack)
    {
        Console.Write("Stack: ");
        foreach (int i in stack)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }

    static void PrintQueue(Queue<int> queue)
    {
        Console.Write("Queue: ");
        foreach (int i in queue)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }

    static void PrintHashSet(HashSet<int> hashSet)
    {
        Console.Write("HashSet: ");
        foreach (int i in hashSet)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }
}
