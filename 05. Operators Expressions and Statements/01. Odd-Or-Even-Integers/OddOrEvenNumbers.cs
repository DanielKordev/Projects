using System;

class OddOrEvenNumbers
{
    static void Main()
    {
        string input;
        int num;

        do  
        {
            Console.Write("Enter a type int number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        Console.WriteLine("\n{0}\t{1}\n",num, (num%2 != 0));
    }
}


