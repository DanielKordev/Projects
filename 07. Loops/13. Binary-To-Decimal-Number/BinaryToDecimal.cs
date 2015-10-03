using System;

class BinaryToDecimal
{
    static void Main()
    {
        long number = 0;
        long power = 1;

        Console.Write("Please enter a binary integer number: ");
        string num = Console.ReadLine();
        
        for (int i = num.Length - 1; i >= 0 ; i--)
        {            
            int digit = num[i] - '0'; 

            if (digit == 1) 
            {
                number += digit * power;
            }

            power *= 2;
        }

        Console.WriteLine("\nThe string you entered is the binary representation of {0}\n", number);
    }
}

