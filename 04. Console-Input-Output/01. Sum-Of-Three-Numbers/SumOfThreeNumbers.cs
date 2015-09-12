using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;
        float number;

        string intro = @"This program invites you to enter three real numbers, 
reads the three numbers from the console, and prints their sum.";
        Console.WriteLine(intro);

        List<float> numbers = new List<float>();

        for (int i = 1; i < 4; i++)
        {
            do 
            {
                Console.Write("\nPlease, enter number {0}: ", i);
                input = Console.ReadLine().Replace(",", ".");
                 
            } while (!float.TryParse(input, out number));

            numbers.Add(number); 
        }

        Console.WriteLine("\nYou have entered the numbers {0}\nTheir sum is {1}\n", string.
            Join(", ", numbers.ToArray()), numbers.Sum());
    }
}

