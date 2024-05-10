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

}
