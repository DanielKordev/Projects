using System;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("Please, enter an integer number: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("\nPlease, enter a value for number {0}: ", i + 1);
            nums[i] = int.Parse(Console.ReadLine());
        }

        string sequence = String.Join(", ", nums);

        Console.WriteLine("\nNumbers: {0} \nMin = {1} \nMax = {2} \nSum: {3} \nAverage = {4:F2}", sequence, nums.
            Min(), nums.Max(), nums.Sum(), nums.Average());

        Console.WriteLine();
    }
}

