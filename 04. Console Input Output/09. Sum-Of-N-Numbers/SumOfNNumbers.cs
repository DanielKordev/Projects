using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("\nPlease, enter a value for array length: ");
        int length = int.Parse(Console.ReadLine());

        double[] nums = new double[length];

        for (int i = 0; i < length; i++)
        {
                Console.Write("\nPlease, enter number {0}: ", i + 1);
                nums[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe Max of these {0} numbers is {1}\n", length, nums.Max());
        Console.WriteLine("\nThe Min of these {0} numbers is {1}\n", length, nums.Min());
        Console.WriteLine("\nThe sum of these {0} numbers is {1}\n", length, nums.Sum());
        Console.WriteLine("\nThe average of these {0} numbers is {1}\n", length, nums.Average());
    }
}

