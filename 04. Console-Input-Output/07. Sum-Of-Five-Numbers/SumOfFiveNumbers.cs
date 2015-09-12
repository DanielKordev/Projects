using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;

        string intro = @"This program enters 5 numbers (given in a single line, 
separated by a space), calculates and prints their sum.";
        Console.WriteLine(intro);

        float sum = 0f;

        Console.Write("\nPlease, enter 5 numbers in a signle line \nseparated by a space: ");

        input = Console.ReadLine(); 
        string[] numStr = input.Split(' '); 

        for (int i = 0; i < numStr.Length; i++)
			{
			    sum += float.Parse(numStr[i]);
			}
        
        Console.WriteLine("\nThe sum of numbers {0} is {1}\n", string.
            Join(", ", numStr), sum);
    }
}


