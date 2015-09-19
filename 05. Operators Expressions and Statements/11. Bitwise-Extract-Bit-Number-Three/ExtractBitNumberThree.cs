using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        string input;
        int num = 0;

        do  
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        int mask = 1;

        string binary = Convert.ToString(num, 2).PadLeft(16, '0');
        string first = binary.Substring(0, 8);
        string second = binary.Substring(8);

        Console.WriteLine("\nn 	    binary representation 	bit #3\n{0, -12}{1, -9}{2, -19}{3}\n", num, first, second, ((num >> 3) & mask));
    }
}