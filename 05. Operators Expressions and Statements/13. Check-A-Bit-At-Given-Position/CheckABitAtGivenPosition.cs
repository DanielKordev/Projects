using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        do 
        {
            Console.Write("Enter a value for n: ");
            inputN = Console.ReadLine();

        } while (!int.TryParse(inputN, out n));

        do  
        {
            Console.Write("Enter a value for p: ");
            inputP = Console.ReadLine();

        } while (!int.TryParse(inputP, out p));

        int mask = 1 << p;
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        string first = binary.Substring(0, 8);
        string second = binary.Substring(8);

        Console.WriteLine("\nn 	binary representation 	p  bit @ p == 1\n{0, -8}{1, -9}{2, -15}{3, -3}{4}\n", n, first, second, p, ((mask & n) == mask));
    }
}