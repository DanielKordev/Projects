using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        int n;
        int k;
        do
        {
            Console.Write("Please, enter a value for n, so that (1 < k < n < 100): ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nPlease, enter a value for k, so that (1 < k < n < 100): ");
            k = int.Parse(Console.ReadLine());

        } while (!(1 < k && k < n && n < 100));

        BigInteger quotient = 1;  
        BigInteger factorialNMinusK = 1; 

        for (int i = k + 1; i <= n; i++)
        {
            quotient *= i;
        }

        for (int j = 1; j <= (n - k); j++)
        {
            factorialNMinusK *= j;
        }

        Console.WriteLine("\nn! / (k! * (n-k)!) = {0}\n", quotient / factorialNMinusK);
    }
}

