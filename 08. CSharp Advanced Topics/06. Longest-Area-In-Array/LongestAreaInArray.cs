using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main()
    {
        List<string> sequence = new List<string>();
        Console.Write("Please enter an int value for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter {0} strings, each on a separate line:", n);
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        sequence = LongestSequence(array);
        Console.WriteLine("\nOutput\n{0}", sequence.Count);
        for (int k = 0; k < sequence.Count; k++)
        {
            Console.WriteLine(sequence[k]);
        }
    }

    private static List<string> LongestSequence(string[] array)
    {
        List<string> longestSequence = new List<string>();
        string str = array[0];
        int count = 1;
        int bestCount = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;

                if (count > bestCount)
                {
                    bestCount = count;
                    str = array[i];
                }
            }

            else
            {
                count = 1;
            }
        }

        for (int j = 0; j < bestCount; j++)
        {
            longestSequence.Add(str);
        }
        
        return longestSequence;
    }
}

