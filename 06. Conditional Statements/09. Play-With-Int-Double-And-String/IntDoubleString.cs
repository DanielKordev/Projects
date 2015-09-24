using System;

class IntDoubleString
{
    static void Main()
    {
        Console.Write("1 --> int\n2 --> double\n3 --> string\nPlease choose a type: ");
        byte choice;

        try
        {
            choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter a type int number: ");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n{0}\n", ++integer);
                    break;
                case 2:
                    Console.Write("Please enter a type double number: ");
                    double floatingPoint = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n{0}\n", ++floatingPoint);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("\n{0}*\n", str);
                    break;
                default:
                    Console.WriteLine("Try again with 1, 2 or 3.");
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Try again with 1, 2 or 3.");
        }      
    }
}