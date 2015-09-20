using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;
        float number;

        string intro = @"This program gets two numbers from the console 
and prints the greater of them.";

        Console.WriteLine(intro);

        List<float> numbers = new List<float>();

        for (int i = 1; i < 3; i++)
        {
            do 
            {
                Console.Write("\nPlease, enter number {0}: ", i);
                input = Console.ReadLine().Replace(",", ".");

            } while (!float.TryParse(input, out number));

            numbers.Add(number); 
        }

        Console.WriteLine("\nThe greater number is {0}\n", numbers.Max());
    }
}

