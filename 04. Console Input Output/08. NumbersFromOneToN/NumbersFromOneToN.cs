using System;

class NumbersFromOneToN
{
    static void Main()
    {
        string intro =
@"This program  reads an integer number n 
from the console and prints all the numbers 
in the interval [1..n], each on a single line.";
        Console.WriteLine(intro);

        string input;
        int n;

        do 
        {
            Console.Write("\nPlease, enter a value for n: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out n));

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0,4}", i);
        }

        for (int i = 1; i >= n; i--)
        {
            Console.Write("{0,4}", i);
        }
        Console.WriteLine();
    }
}

