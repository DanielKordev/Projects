using System;

class MultiplicationSign
{
    static void Main()
    {
        
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double i = 0;
        Console.Write("\nResult: ");

        if (a == 0 || b == 0 || c == 0)
        {
            Console.Write("0\n\n");
        }

        else
        {
            if (a < 0)
            {
                i++;
            }
            if (b < 0)
            {
                i++;
            }
            if (c < 0)
            {
                i++;
            }
            if (i%2 == 0)
            {
                Console.Write("+\n\n");
            }
            else
            {
                Console.Write("-\n\n");
            }
        }
    }
}