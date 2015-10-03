using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Please, enter a value for n, so that (0 <= n <= 100): ");
            n = int.Parse(Console.ReadLine());

        } while (!(0 <= n && n <= 100));

        BigInteger quotient = 1;  
        BigInteger factorialNPlus1 = 1; 

        for (int i = n + 1; i <= 2*n; i++)
        {
            quotient *= i;
        }

        for (int j = 1; j <= (n + 1); j++)
        {
            factorialNPlus1 *= j;
        }

        Console.WriteLine("\nn! / (k! * (n-k)!) = {0}\n", quotient / factorialNPlus1);
    }
}

