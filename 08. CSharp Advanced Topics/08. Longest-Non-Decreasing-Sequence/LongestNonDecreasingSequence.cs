using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSequence
{
    static int[] arr;
    static int[] maxSubset = new int[1];

    static void Main()
    {
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        List<int> subset = new List<int>(); 
        MakeSubset(0, subset);

        Console.WriteLine("Longest increasing sequence is:");
        for (int i = 0; i < maxSubset.Length; i++)
        {
            Console.Write("{0,3}", maxSubset[i]);
        }
        Console.WriteLine();
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Count > 1 && subset[subset.Count - 2] > subset[subset.Count - 1]) 
            return; 
        if (subset.Count >= maxSubset.Length)
        {
            maxSubset = new int[subset.Count]; 
            subset.CopyTo(maxSubset);

        }
        for (int i = index; i < arr.Length; i++) 
        {
            subset.Add(arr[i]); 

            MakeSubset(i + 1, subset);
            subset.RemoveAt(subset.Count - 1); 

        }
    }
}

