using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        string inputV;
        int v;

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

        do
        {
            Console.Write("Enter a bit value v (0 or 1): ");
            inputV = Console.ReadLine();

        } while (!int.TryParse(inputV, out v));

        int mask = 1 << p;
        string binary1 = Convert.ToString(n, 2).PadLeft(16, '0');
        string first1 = binary1.Substring(0, 8);
        string second1 = binary1.Substring(8);

        string binary2;
        string first2;
        string second2;
        int temp;
        if (v == 1)
        {
            temp = n;
            n = n | mask;

            binary2 = Convert.ToString(n, 2).PadLeft(16, '0');
            first2 = binary2.Substring(0, 8);
            second2 = binary2.Substring(8);
            Console.WriteLine("\nn 	binary representation  p  v  binary result        result\n{0, -8}{1, -9}{2, -14}{3, -3}{4, -3}{5, -9}{6, -12}{7}\n",
                temp, first1, second1, p, v, first2, second2, n);
        }

        if (v == 0)
        {
            temp = n;
            n = n | mask;
            n = n ^ mask;

            binary2 = Convert.ToString(n, 2).PadLeft(16, '0');
            first2 = binary2.Substring(0, 8);
            second2 = binary2.Substring(8);
            Console.WriteLine("\nn 	binary representation  p  v  binary result        result\n{0, -8}{1, -9}{2, -14}{3, -3}{4, -3}{5, -9}{6, -12}{7}\n",
                temp, first1, second1, p, v, first2, second2, n);
        }
    }
}