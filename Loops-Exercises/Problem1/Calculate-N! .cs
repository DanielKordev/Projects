using System;

namespace Problem1
{
    class Calculate_N 
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;                
            }
            Console.WriteLine(factorial);
        }
    }
}
