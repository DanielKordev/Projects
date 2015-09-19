using System;
using System.Collections.Generic; 
using System.Linq; 

class FourDigitNumber
{
    static int GetDigit(int number, int digit)
    {
        return (number / (int)Math.Pow(10, digit - 1)) % 10;
    }

    static void Main()
    {
        List<int> workString = new List<int>();
        List<int> digitString = new List<int>();

        string input;
        int num;

        do  
        {
            Console.Write("\t\t\t   Number: ");
            input = Console.ReadLine();

        } while ((!int.TryParse(input, out num)) || (input.Length != 4) || num < 1000);

        for (int i = 1; i <= 4; i++)
        {
            int digitValue = GetDigit(num, i); 

            workString.Add(digitValue);
            digitString.Add(digitValue);
        }

        digitString.Reverse();

        int sumOfDigits = digitString.Sum();

        string reversed = string.Join("", workString.ToArray());

        workString.Reverse(1, 3);
        string lastDigitInFront = string.Join("", workString.ToArray());

        digitString.Reverse(1, 2); 
        string secondAndThirdDigitsExchanged = string.Join("", digitString.ToArray());

        Console.WriteLine("\t\t    Sum of digits: {0}\n\t\t\t Reversed: {1}\n\t      Last digit in front: {2}\nSecond and third digits exchanged: {3}"
            , sumOfDigits, reversed, lastDigitInFront, secondAndThirdDigitsExchanged);
    }
}