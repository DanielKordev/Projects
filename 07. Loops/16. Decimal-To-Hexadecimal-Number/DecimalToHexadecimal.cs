using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long num = long.Parse(Console.ReadLine());

        string hex = string.Empty; 
        if (num == 0)
        {
            Console.WriteLine("\nThe hexadecimal representation of the number you entered is: {0}\n", num.ToString());
        }

        else
        {   
            while (num > 0)
	            {
                    string hexSymbol = "0"; 
                    long remainder = num % 16;

		                switch (remainder)
                        {   
                            case 10: hexSymbol = "A";
                                break;
                            case 11: hexSymbol = "B";
                                break;
                            case 12: hexSymbol = "C";
                                break;
                            case 13: hexSymbol = "D";
                                break;
                            case 14: hexSymbol = "E";
                                break;
                            case 15: hexSymbol = "F";
                                break;
                            default: hexSymbol = remainder.ToString();
                                break;
                        }
                        hex += hexSymbol; 
                        num /= 16;
	                }

            var temp = hex.ToCharArray();
            Array.Reverse(temp);
            hex = new String(temp); 

            Console.WriteLine("\nThe hexadecimal representation of the number you entered is: {0}\n", hex);
	    }
    }
}