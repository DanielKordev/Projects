using System;

class FactorialSum
{
    static void Main()
    {
        Console.Write("Please, enter a value for the int n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("\nPlease, enter a value for the int x: ");
        int x = int.Parse(Console.ReadLine());

        decimal factorialN = 1;
        decimal NPowerOfX = 1;
        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            NPowerOfX *= x;
            sum += factorialN / NPowerOfX;
        }
        Console.WriteLine("\nSum = {0:F5}\n", sum);        
    }
}

