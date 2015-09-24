using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double one = 0;
        double two = 0;
        double three = 0;

        if (a > one)
        {
            one = a;

            if (b > c)
            {
                two = b;
                three = c; ;
            }
            else
            {
                two = c;
                three = b;
            }
        }
        if (b > one)
        {
            one = b;

            if (a > c)
            {
                two = a;
                three = c; ;
            }
            else
            {
                two = c;
                three = a;
            }
        }
        if (c > one)
        {
            one = c;

            if (a > b)
            {
                two = a;
                three = b; ;
            }
            else
            {
                two = b;
                three = a;
            }
        }
        Console.WriteLine("\n{0}  {1}  {2}\n", one, two, three);
    }
}