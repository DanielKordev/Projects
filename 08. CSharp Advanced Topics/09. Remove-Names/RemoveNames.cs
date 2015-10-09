using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Please, enter first list of names: ");
        List<string> names1 = Console.ReadLine().Split(' ').ToList();
        Console.WriteLine("Please, enter second list of names: ");
        List<string> names2 = Console.ReadLine().Split(' ').ToList();

        for (int i = 0; i < names2.Count; i++)
        {
            if (names1.Contains(names2[i]))
            {
                names1.RemoveAll(item => item == names2[i]);
            }
        } 

        Console.WriteLine();
        Console.WriteLine(string.Join(" ", names1));
        Console.WriteLine();
    }
}

