
using System;

class RandomNumbers
{
    static void Main()
    {
        int n, min, max;
        Console.Write("n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        min = int.Parse(Console.ReadLine());

        do 
        {
            Console.Write("max: ");
            max = int.Parse(Console.ReadLine());
        } while (min == max);

        Console.Write("\nrandom numbers: \n");

        Random rand = new Random(); 
        for (int i = 0; i < n; i++)
        {                       
            Console.Write("{0} ", rand.Next(min, max + 1)); 
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

