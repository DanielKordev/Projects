using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                index++;
                if (index % step == 1 || (step == 1 ))
                {
                    int mask = 1 << bitIndex;
                    num = num ^ mask;

                }
            }
            Console.WriteLine("___");
            Console.WriteLine(num);
            Console.WriteLine();
        }
    }
}

