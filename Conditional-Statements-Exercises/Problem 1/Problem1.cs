using System;

namespace Problem1
{
    class Problem1
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double biggerNumber = 0;

            if (a > biggerNumber)
            {
                biggerNumber = a;
            }
            if (b > biggerNumber)
            {
                biggerNumber = b;
            }
            if (c > biggerNumber)
            {
                biggerNumber = c;
            }

            Console.WriteLine("\n{0}\n", biggerNumber);
        }
    }
}
