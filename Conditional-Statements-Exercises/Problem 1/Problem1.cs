using System;

namespace Problem1
{
    class Problem1
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggerNumber = a;
            if (b > biggerNumber)
            {
                biggerNumber = b;
            }

            if (c > biggerNumber)
            {
                biggerNumber = c;
            }

            Console.WriteLine("{0}", biggerNumber);
        }
    }
}
