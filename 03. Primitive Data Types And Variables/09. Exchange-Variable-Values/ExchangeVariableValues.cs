using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine("Before: \na = {0} \nb = {1}\n\n", a, b);
        a ^= b ^= a; 
        b ^= a;
        Console.WriteLine("After: \na = {0} \nb = {1}\n\n", a, b);
        Console.ReadLine();
    }
}


