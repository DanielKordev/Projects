using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class QuadraticEquation
{

    #region SolveQuadratic(double a, double b, double c)

    public static void SolveQuadratic(double a, double b, double c)
    {
        double discriminant = (b * b) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("\nThere are no real roots\n");
        }
        else
        {
            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ? "\nOne real root {0}\n" : "\nTwo real roots: {0} and {1}\n", x1, x2);
        }
    }
    #endregion

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string intro = @"The quadratic equation is a second order of polynomial equation
in a single variable: x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
Please, enter the values for a, b, and c.";
        Console.WriteLine(intro);

        string input;
        double number;

        double[] numbers = new double[3];

        for (int i = 0; i < 3; i++)
        {
            do 
            {
                Console.Write("\nPlease, enter value {0}: ", i + 1);
                input = Console.ReadLine().Replace(",", ".");

            } while (!double.TryParse(input, out number));

            numbers[i] = number; 
        }

        SolveQuadratic(numbers[0], numbers[1], numbers[2]);
    }
}

