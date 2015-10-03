using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter a positive integer number n (1 <= n <= 20): ");
            n = int.Parse(Console.ReadLine());
        } while (!(1 <= n && n <= 20));
        
        for (int row = 0; row < n; row++) 
        {
            for (int column = 0; column < n; column++) 
            {
                Console.Write("{0, 3}", ((row +1 ) + column));
            }
            Console.WriteLine();
        }
    }
}

