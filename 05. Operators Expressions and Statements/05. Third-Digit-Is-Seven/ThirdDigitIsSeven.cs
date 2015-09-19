using System;

class ThirdDigitSeven
{
    static int GetDigit(int number, int digit)
    {
        return (number / (int)Math.Pow(10, digit - 1)) % 10;
    }

    static void Main()

    {
        string input;
        int num;

        do  
        {
            Console.Write("Enter a type int number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        Console.WriteLine("\n{0}\t{1}\n", num, GetDigit(num, 3) == 7 ? true : false);
    }
}


