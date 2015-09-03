using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine("First variable _{0}_ and second variable _{1}_", nullInt, nullDouble);
        Console.WriteLine(nullDouble + null);
        Console.WriteLine(nullInt + 12);
        Console.WriteLine("nullInt = _{0}_", nullInt + 10);
    }
}
