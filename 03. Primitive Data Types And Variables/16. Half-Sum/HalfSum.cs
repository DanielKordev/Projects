using System;
using System.Linq;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[2 * n];
        for (int i = 0; i < 2 * n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] subset1 = numbers.Take(n).ToArray();
        int[] subset2 = numbers.Skip(n).Take(n).ToArray();
        int sum1 = subset1.Sum();
        int sum2 = subset2.Sum();
        if (sum1 == sum2)
        {
            Console.WriteLine();
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}


