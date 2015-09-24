using System;

class CheckForAPlayCard
{
    static void Main()
    {
        byte number;
        bool number2;
        char letter;
        bool letter2;
        
        do
        {
            string symbol = Console.ReadLine();
            letter2 = char.TryParse(symbol, out letter);
            number2 = byte.TryParse(symbol, out number);
        } while (!number2 && (!letter2 || char.IsLower(letter)));

        if (number2)
        {
            switch (number)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
        else if (letter2)
        {
            switch (letter)
            {
                case 'J':
                case 'Q':
                case 'K':
                case 'A':
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}