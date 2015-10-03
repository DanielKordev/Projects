using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        long number = 0;
        long power = 1;

        Console.Write("Please enter a hexadecimal integer number: ");
        string hex = Console.ReadLine();

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int symbol;

            switch (hex[i])
            {
                case 'A': symbol = 10;
                    break;
                case 'B': symbol = 11;
                    break;
                case 'C': symbol = 12;
                    break;
                case 'D': symbol = 13;
                    break;
                case 'E': symbol = 14;
                    break;
                case 'F': symbol = 15;
                    break;
                default: symbol = hex[i] - '0';
                    break;
            }

            number += symbol * power;
            power *= 16;
        }

        Console.WriteLine("\nThe string you entered is the binary representation of {0}\n", number);
    }
}