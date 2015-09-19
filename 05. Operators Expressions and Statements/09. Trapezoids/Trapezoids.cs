using System;

class Trapezoids
{
    static void Main()
    {
        string inputA;
        int a;

        string inputB;
        int b;

        string inputH;
        int h;

        do  
        {
            Console.Write("Enter a value for a: ");
            inputA = Console.ReadLine();

        } while (!int.TryParse(inputA, out a));

        do  
        {
            Console.Write("Enter a value for b: ");
            inputB = Console.ReadLine();

        } while (!int.TryParse(inputB, out b));

        do  
        {
            Console.Write("Enter a value for h: ");
            inputH = Console.ReadLine();

        } while (!int.TryParse(inputH, out h));

        Console.WriteLine("\na = {0}; b = {1}; h = {2}; area = {3}\n", a, b, h, ((a + b)/2)*h );
    }
}

