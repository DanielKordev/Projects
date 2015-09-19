using System;
using System.Collections.Generic;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        string input;
        int num;

#region 

        List<int> notPrime = new List<int>();

        for (int x = 2; x < 100; x++)
        {
            for (int y = x * 2; y < 100; y = y + x)
            {
                if (!notPrime.Contains(y))
                {
                    notPrime.Add(y);
                }
            }
        }

#endregion
        
        do 
        {
            Console.Write("Enter a number between 0 and 100: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num) || num < 0 || num > 100);

        Console.Write((notPrime.Contains(num))? "True\n" : "False\n" );
    }
}

