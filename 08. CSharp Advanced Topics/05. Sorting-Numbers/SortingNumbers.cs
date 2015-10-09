using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Please enter an int value for n: ");
        int n = int.Parse(Console.ReadLine());      

        Console.WriteLine("Please, enter {0} numbers, each on a separate line:", n);
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        array = SelectionSort(array);
        Console.WriteLine("\nOutput:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
    }

    private static int[] SelectionSort(int[] array)
    {
        List<int> tempList = array.ToList();
        int[] sorted = new int[array.Length]; 

        int i = 0;
        while (tempList.Count != 0)
        {
            tempList.Min(); 
            sorted[i] = tempList.Min();
            tempList.Remove(tempList.Min()); 
            i++;
            
        }
        return sorted;
    }
}

