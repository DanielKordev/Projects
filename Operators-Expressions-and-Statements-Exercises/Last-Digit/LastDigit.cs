using System;

namespace LastDigit
{
    class LastDigit
    {
        static void Main()
        {
            double n = 21;            
            double lastDigit = n %(10);
            Console.WriteLine(lastDigit);

            double n1 = 139;
            double lastDigit1 = n1 % (10);
            Console.WriteLine(lastDigit1);

            double n2 = 4;
            double lastDigit2 = n2 % (10);
            Console.WriteLine(lastDigit2);
        }
    }
}
