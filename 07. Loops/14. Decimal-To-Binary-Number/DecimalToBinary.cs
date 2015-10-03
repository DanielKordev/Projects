using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        List<byte> digits = new List<byte>();
        byte digit;

        Console.Write("Please enter an integer number: ");
        long num = long.Parse(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("\nThe binary representation of the number you entered is: {0}\n", num.ToString());
        }

        else 
        {
            while (num > 0)
            {
                digit = (byte)(num % 2);
                digits.Add(digit);
                num /= 2;
            }

            digits.Reverse();
            string binary = string.Join("", digits.ToArray());

            Console.WriteLine("\nThe binary representation of the number you entered is: {0}\n", binary);
        }
    }
}