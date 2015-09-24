using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double biggerNumber = a;
        double smallerNumber = b;

        if (b > biggerNumber)
        {
            biggerNumber = b;
            smallerNumber = a;
        }

        Console.Write("\n{0}  {1}\n", smallerNumber, biggerNumber);
    }
}