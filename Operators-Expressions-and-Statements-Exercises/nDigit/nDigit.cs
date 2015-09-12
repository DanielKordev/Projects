using System;

namespace nDigit
{
    class nDigit
    {
        static void Main()
        {
            int number = 2174;
            int n = 3;
            int tensPower = (int)(Math.Pow(10, n - 1));
            int divResul = (number / tensPower);
            int nDigit = divResul % (10);
            Console.WriteLine(nDigit);

            int number1 = 169;
            int n1 = 2;
            int tensPower1 = (int)(Math.Pow(10, n1 - 1));
            int divResul1 = (number1 / tensPower1);
            int nDigit1 = divResul1 % (10);
            Console.WriteLine(nDigit1);

            int number2 = 46;
            int n2 = 4;
            int tensPower2 = (int)(Math.Pow(10, n2 - 1));
            int divResul2 = (number2 / tensPower2);
            int nDigit2 = divResul2 % (10);
            if (nDigit2 < 1)
            {
                Console.WriteLine('-');
            }

        }
    }
}
