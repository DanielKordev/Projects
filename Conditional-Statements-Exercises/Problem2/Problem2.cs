using System;

namespace Problem2
{
    class Problem2
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            
            if (a * b * c > 0)
            {
                Console.WriteLine("Positive");
            }
            if (a * b * c < 0)
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
