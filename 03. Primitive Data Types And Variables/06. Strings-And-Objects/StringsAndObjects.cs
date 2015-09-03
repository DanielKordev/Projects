using System;

class StringsAndObjects
{
    static void Main()
    {
        string hi = "Hello";
        string name = "World!";
        object concatenation = string.Concat(hi, " ", name);

        string greating = (string)concatenation;
        Console.WriteLine(greating);
        Console.ReadLine();
    }
}
