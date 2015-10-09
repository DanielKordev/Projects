using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Please, enter first list of numbers in one line, separated by a space: ");
        List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine("Please, enter second list of numbers in one line, separated by a space: ");
        List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> result = list1.Union(list2).ToList();
        result.Sort();
        Console.WriteLine("\nOutput: ");
        Console.WriteLine("{0}\n", string.Join(" ", result));
    }
}

