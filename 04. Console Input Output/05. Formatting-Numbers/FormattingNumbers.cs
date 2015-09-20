using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string intro = @"This program reads one type int, 
and two type float numbers from the console,
then prints them in 4 virtual columns.";
        Console.WriteLine(intro);

        string inputInt;
        int integer;

        do 
        {
        Console.Write("Please enter first number a: ");
        integer = int.Parse(Console.ReadLine());

        } while (!(0 <= integer && integer <= 500));

        string inputFloat;
        float floatNumber;

        List<float> floats = new List<float>();

        for (int i = 1; i < 3; i++)
        {
            do 
            {
                Console.Write("\nPlease, enter float number {0}: ", i);
                inputFloat = Console.ReadLine().Replace(",", ".");

            } while (!float.TryParse(inputFloat, out floatNumber));

            floats.Add(floatNumber); 
        }

        string separator = new string('-', 45);
        Console.WriteLine("\n{0}", separator);
        Console.WriteLine("|   Hex    |  Binary  | Float 1  | Float 2  |");
        Console.WriteLine(separator);
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", integer, Convert.ToString(integer, 2).PadLeft(10, '0'), floats[0], floats[1]);
        Console.WriteLine("{0}\n", separator);
    }
}

