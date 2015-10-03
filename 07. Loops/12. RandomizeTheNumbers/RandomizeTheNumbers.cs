using System;

class RandomizeTheNumbers
{
    public static void MixArray(int[] array)
    {
        int index, temp;
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            index = rand.Next(array.Length);

            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
    
    static void Main()
    {
        Console.Write("Please, enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("\n{0} sequential numbers in the range 1...{0}: ", n);

        int[] nums = new int[n]; 
        for (int i = 0; i < n; i++)
        {
            nums[i] = i+1; 
        }

        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }

        Console.Write("\n\nRandomized array: ");
        MixArray(nums);

        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

