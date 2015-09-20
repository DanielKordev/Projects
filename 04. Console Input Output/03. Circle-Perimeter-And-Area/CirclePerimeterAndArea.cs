using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        string intro =
@"This program reads the radius r of a circle 
and prints its perimeter and area.";
        Console.WriteLine(intro);

        string input;
        float r;

        do 
        {
            Console.Write("\nPlease, enter a value for r: ");
            input = Console.ReadLine().Replace(",", "."); 

        } while (!float.TryParse(input, out r));

        Console.WriteLine("\nCircle with radius r = {0:F2}\nPerimeter {1:F2}; Area {2:F2}\n", r, 2 * Math.PI * r, Math.PI * Math.Pow(r, 2));
    }
}

