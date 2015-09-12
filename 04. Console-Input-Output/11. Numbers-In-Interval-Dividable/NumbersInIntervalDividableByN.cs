using System;
using System.Collections.Generic;
using System.Linq;

class NumbersInIntervalDividableByN
{
    static void Main()
    {
        string intro =
@"This program reads two positive integer numbers 
and prints how many numbers p exist between them such 
that the reminder of the division by 5 is 0.";

        Console.WriteLine(intro);

        string inputA;
        int a;

        string inputB;
        int b;

        do
        {
            Console.Write("\nPlease, enter a value for a: ");
            inputA = Console.ReadLine();

        } while (!int.TryParse(inputA, out a) || a < 0);

                do
        {
            Console.Write("\nPlease, enter a value for b: ");
            inputB = Console.ReadLine();

        } while (!int.TryParse(inputB, out b) || b < 0);

        List<int> nums = new List<int>();

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                nums.Add(i);
            }
        }

        Console.WriteLine("\nBetween {0} and {1} there are {2} members of the 5x sequence:\n{3}\n", a, b, nums.Count, string.Join(", ", nums));
    }
}


