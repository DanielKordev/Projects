using System;
using System.Collections.Generic;

class ComparingFloats
{
    static void Main()
    {
        List<double> floatsOne = new List<double> { 5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
        List<double> floatsTwo = new List<double> { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };
        for (int i = 0; i <= 5; i++)
        {
            bool equal = Math.Abs(floatsOne[i] - floatsTwo[i]) < 0.000001;
            Console.WriteLine("The numbers \t{0} \tand \t{1} \tare equal: \t{2}.", floatsOne[i].ToString("0.00000000"), floatsTwo[i].ToString("0.00000000"), equal ? "True" : "False");
        }
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}
