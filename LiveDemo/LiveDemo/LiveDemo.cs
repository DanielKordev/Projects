using System;

namespace LiveDemo
{
    class LiveDemo
    {
        static void Main()
        {
            // Problem 1.	Practice Integer Numbers
            sbyte numbers = -100;
            byte numbers1 = 128;
            short numbers2 = -3540;
            ushort numbers3 = 64876;
            uint numbers4 = 2147483648;
            long numbers5 = -1141583228;
            long numbers6 = -1223372036854775808;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", numbers, numbers1, numbers2, numbers3, numbers4, numbers5, numbers6);
            
            // Problem 2.	Practice Floating Point Numbers
            decimal decimalPI = 3.141592653589793238m;
            double doublePI = 1.60217657;
            decimal decimalPI1 = 7.8184261974584555216535342341m;
            Console.WriteLine("{0}\n{1}\n{2}", decimalPI, doublePI, decimalPI1);

            // Problem 3.	Practice Characters and Strings
            string symbol = "Software University";
            Console.WriteLine(symbol);

        }
    }
}
